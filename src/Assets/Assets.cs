﻿// Copyright © 2020 Randall Maas. All rights reserved.
// See LICENSE file in the project root for full license information.  
using Resource = Anki.Resources.SDK.Properties.Resources;
using RCM;
using System;
using System.Collections.Generic;
using System.IO;
using Anki.AudioKinetic;
using System.Text.Json;

namespace Anki.Resources.SDK
{
/// <summary>
/// The type of assets folder
/// </summary>
public enum AssetsType
{
    /// <summary>
    /// Cozmo-style assets
    /// </summary>
    Cozmo,

    /// <summary>
    /// Vector-style assets
    /// </summary>
    Vector
};

/// <summary>
/// This is a class to access the resources in the Cozmo_Resources folder for Vector
/// (And maybe some of Cozmo)
/// </summary>
/// <example>
/// <code>
///    var assets = new Assets(... some path to Vector resources ..);
///    var audioAssets = assets.AudioAssets;
/// </code>
/// </example>
public partial class Assets: IDisposable
{
    /// <summary>
    /// The configuration 
    /// </summary>
    static readonly AssetsConfig config;

    /// <summary>
    /// This loads the configuration 
    /// </summary>
    static Assets()
    {
        // Load the JSON files
        // The JSON parsing options
        var JSONOptions = new JsonSerializerOptions
            {
                ReadCommentHandling = JsonCommentHandling.Skip,
                AllowTrailingCommas = true,
                IgnoreNullValues    = true
            };
        // Get the text file
        var text = Resource.ResourceManager.GetString("assets.json");
        // Get the dictionary
        config = JsonSerializer.Deserialize<AssetsConfig>(text, JSONOptions);

        // Get the text file
        text = Resource.ResourceManager.GetString("condition.json");

        // Get the dictionary
        conditionSchema = JsonSerializer.Deserialize<ConditionSchema>(text, JSONOptions);

        // Get the text file
        text = Resource.ResourceManager.GetString("behavior.json");
        behaviorSchema = JsonSerializer.Deserialize<BehaviorSchema>(text, JSONOptions);
    }


    /// <summary>
    /// The type of assets folder
    /// </summary>
    public readonly AssetsType AssetsType;

    /// <summary>
    /// The path to the Cozmo resources
    /// </summary>
    readonly string cozmoResourcesPath;

    /// <summary>
    /// One of: de-DE   en-US   fr-FR
    /// Future: ja-JA
    /// </summary>
    internal string Locale = "en-US";

    /// <summary>
    /// This is the constructor for a wrapper around the Vector Resources folder
    /// </summary>
    /// <param name="basePath">The path to the root of the Vector file system</param>
    public Assets(string basePath)
    {
        // Load the platform configuration with the patchs to the other parts
        // Note: this is not present in Cozmo
        var path = Path.Combine(basePath, "anki/etc/config/platform_config.json");

        // Try the Vector first
        if (File.Exists(path))
        {
            // Mark it as a Vector style assets folder
            AssetsType=AssetsType.Vector;

            displayWidth = VectorDisplayWidth;
            displayHeight= VectorDisplayHeight;

            // Get the text for the file
            var text = System.IO.File.ReadAllText(path);

            // Get it in a convenient form
            var JSONOptions = new JsonSerializerOptions
            {
                ReadCommentHandling = JsonCommentHandling.Skip,
                AllowTrailingCommas = true,
                IgnoreNullValues    = true
            };
            var config = JsonSerializer.Deserialize<Platform_config>(text, JSONOptions);

            // Construct the cozmoResources patch
            cozmoResourcesPath = Path.Combine(basePath, config.DataPlatformResourcesPath.Substring(1));

        }
        else
        {
            // Mark it as a Cozmo style assets folder
            AssetsType=AssetsType.Cozmo;

            displayWidth = CozmoDisplayWidth;
            displayHeight= CozmoDisplayHeight;

            // Construct the cozmoResources patch
            cozmoResourcesPath = Path.Combine(basePath, "assets/cozmo_resources");
        }

        // Load the manifest of features
        LoadFeatures(Path.Combine(cozmoResourcesPath, "config"));
        LoadCozmoResources();
    }

    // Flag: Has Dispose already been called?
    bool disposed = false;

    /// <summary>
    /// Public implementation of Dispose pattern callable by consumers.
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Protected implementation of Dispose pattern.
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
        if (disposed || !disposing)
            return;

#if false
            cubeLightsCache.Dispose();
            backpackLightsCache.Dispose();
            localizedTTSCache.Dispose();
            imageMapCache.Dispose();
            imageLayoutCache.Dispose();
            animationGroupCache.Dispose();
            animationBinCache.Dispose();
#endif
        if (null != audioAssets)
            audioAssets.Dispose();

        disposed = true;
    }

    /// <summary>
    /// Load the "Cozmo" resources
    /// </summary>
    void LoadCozmoResources()
    {
        // Load the animation manifest
        LoadAnimationManifest(Path.Combine(cozmoResourcesPath, "assets"));

        // Load the trigger maps
        LoadCladToFileMaps();

        // Load the mood configuration
        LoadMoods        (Path.Combine(cozmoResourcesPath, "config/engine"));
        LoadEmotionEvents(Path.Combine(cozmoResourcesPath, "config/engine/emotionevents"));

        if (AssetsType.Vector == AssetsType)
        {
            // Load the behavior manager
            LoadBehaviors    (Path.Combine(cozmoResourcesPath, "config/engine/behaviorComponent"));
        }

        // Load the intents maps
        LoadIntents();

#if false
        // Load the sound files
        // todo
        // Load the text to speech
        Path.Combine(cozmoResourcesPath, "config/engine/tts_config.json");
        // locale de-DE   en-US   fr-FR
        // module : BehaviorStrings 	BlackJackStrings 	FaceEnrollmentStrings
        //Path.Combine(basePath, "LocalizedStrings", locale, module);
#endif
    }

    /// <summary>
    /// The cached audio assets for the resource 
    /// </summary>
    AudioAssets audioAssets;

    /// <summary>
    /// This provides the audio assets wrapper
    /// </summary>
    public AudioAssets AudioAssets
    {
        get
        {
            // Look up the audio assets, if it hasn't already been opened
            if (null == audioAssets)
                 audioAssets= new AudioAssets(Path.Combine(cozmoResourcesPath,"sound"));
            // Increment the reference count and return it
            return audioAssets.Retain();
        }
    }
}
}



