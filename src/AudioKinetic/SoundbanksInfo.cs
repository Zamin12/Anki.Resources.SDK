﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Anki.AudioKinetic.XML
{

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class File {
    
    private string shortNameField;
    
    private string pathField;
    
    private uint prefetchSizeField;
    
    private uint idField;
    
    private string languageField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ShortName {
        get {
            return this.shortNameField;
        }
        set {
            this.shortNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Path {
        get {
            return this.pathField;
        }
        set {
            this.pathField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public uint PrefetchSize {
        get {
            return this.prefetchSizeField;
        }
        set {
            this.prefetchSizeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Language {
        get {
            return this.languageField;
        }
        set {
            this.languageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SoundBanksInfo {
    
    private string dialogueEventsField;
    
    private string mediaFilesNotInAnyBankField;
    
    private SoundBanksInfoRootPaths[] rootPathsField;
    
    private File[] streamedFilesField;
    
    private SoundBanksInfoSoundBanksSoundBank[] soundBanksField;
    
    private string platformField;
    
    private string basePlatformField;
    
    private string schemaVersionField;
    
    private string soundbankVersionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DialogueEvents {
        get {
            return this.dialogueEventsField;
        }
        set {
            this.dialogueEventsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string MediaFilesNotInAnyBank {
        get {
            return this.mediaFilesNotInAnyBankField;
        }
        set {
            this.mediaFilesNotInAnyBankField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RootPaths", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SoundBanksInfoRootPaths[] RootPaths {
        get {
            return this.rootPathsField;
        }
        set {
            this.rootPathsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("File", typeof(File), IsNullable=false)]
    public File[] StreamedFiles {
        get {
            return this.streamedFilesField;
        }
        set {
            this.streamedFilesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("SoundBank", typeof(SoundBanksInfoSoundBanksSoundBank), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public SoundBanksInfoSoundBanksSoundBank[] SoundBanks {
        get {
            return this.soundBanksField;
        }
        set {
            this.soundBanksField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Platform {
        get {
            return this.platformField;
        }
        set {
            this.platformField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string BasePlatform {
        get {
            return this.basePlatformField;
        }
        set {
            this.basePlatformField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SchemaVersion {
        get {
            return this.schemaVersionField;
        }
        set {
            this.schemaVersionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SoundbankVersion {
        get {
            return this.soundbankVersionField;
        }
        set {
            this.soundbankVersionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SoundBanksInfoRootPaths {
    
    private string projectRootField;
    
    private string sourceFilesRootField;
    
    private string soundBanksRootField;
    
    private string externalSourcesInputFileField;
    
    private string externalSourcesOutputRootField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ProjectRoot {
        get {
            return this.projectRootField;
        }
        set {
            this.projectRootField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SourceFilesRoot {
        get {
            return this.sourceFilesRootField;
        }
        set {
            this.sourceFilesRootField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SoundBanksRoot {
        get {
            return this.soundBanksRootField;
        }
        set {
            this.soundBanksRootField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ExternalSourcesInputFile {
        get {
            return this.externalSourcesInputFileField;
        }
        set {
            this.externalSourcesInputFileField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ExternalSourcesOutputRoot {
        get {
            return this.externalSourcesOutputRootField;
        }
        set {
            this.externalSourcesOutputRootField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SoundBanksInfoSoundBanksSoundBank {
    
    private string objectPathField;
    
    private string shortNameField;
    
    private string pathField;
    
    private SoundBanksInfoSoundBanksSoundBankIncludedEventsEvent[] includedEventsField;
    
    private File[] referencedStreamedFilesField;
    
    private File[] includedMemoryFilesField;
    
    private string idField;
    
    private string languageField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ObjectPath {
        get {
            return this.objectPathField;
        }
        set {
            this.objectPathField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ShortName {
        get {
            return this.shortNameField;
        }
        set {
            this.shortNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Path {
        get {
            return this.pathField;
        }
        set {
            this.pathField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Event", typeof(SoundBanksInfoSoundBanksSoundBankIncludedEventsEvent), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public SoundBanksInfoSoundBanksSoundBankIncludedEventsEvent[] IncludedEvents {
        get {
            return this.includedEventsField;
        }
        set {
            this.includedEventsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("File", typeof(File), IsNullable=false)]
    public File[] ReferencedStreamedFiles {
        get {
            return this.referencedStreamedFilesField;
        }
        set {
            this.referencedStreamedFilesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("File", typeof(File), IsNullable=false)]
    public File[] IncludedMemoryFiles {
        get {
            return this.includedMemoryFilesField;
        }
        set {
            this.includedMemoryFilesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Language {
        get {
            return this.languageField;
        }
        set {
            this.languageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SoundBanksInfoSoundBanksSoundBankIncludedEventsEvent {
    
    private string idField;
    
    private string nameField;
    
    private string objectPathField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ObjectPath {
        get {
            return this.objectPathField;
        }
        set {
            this.objectPathField = value;
        }
    }
}
}
