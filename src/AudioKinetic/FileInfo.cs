﻿// Copyright © 2020 Randall Maas. All rights reserved.
// See LICENSE file in the project root for full license information.  

namespace Anki.AudioKinetic
{
/// <summary>
/// This is information on the sound files within a sound bank
/// </summary>
public class FileInfo
{
    /// <summary>
    /// The name of the sound bank that it is part of
    /// </summary>
    public string SoundBankName {get;internal set; }

    /// <summary>
    /// This is the stream id for the file.
    /// </summary>
    public uint ID {get;internal set; }

    /// <summary>
    /// This is the name of the source file
    /// </summary>
    /// <remarks>This is left from the audio editing workspace</remarks>
    public string ShortName {get;internal set; }

    /// <summary>
    /// This is a path within the workspace to the audio file
    /// </summary>
    /// <remarks>This is left from the audio editing workspace</remarks>
    public string Path {get;internal set; }

    /// <summary>
    /// The offset to where the WEM sound file can be found within the
    /// soundbank file.
    /// </summary>
    public uint Offset {get;internal set; }

    /// <summary>
    /// The size of the sound file segment within the soundbank file
    /// </summary>
    public uint Size {get;internal set; }

    /// <summary>
    /// If non-zero, the file should be prefetched so that there is no latency.
    /// The number of bytes to prefetch from the soundbank before heading out the external file?
    /// </summary>
    public uint PrefetchSize {get;internal set; }
}

}
