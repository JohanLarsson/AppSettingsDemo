﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppSettingsDummy.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Johan,34")]
        public global::AppSettingsDummy.ConverterPerson JohanConvert {
            get {
                return ((global::AppSettingsDummy.ConverterPerson)(this["JohanConvert"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Dummy string")]
        public string DummyString {
            get {
                return ((string)(this["DummyString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"
                    <XmlPerson xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
                        <Name>JohanXml</Name>
                        <Age>34</Age>
                    </XmlPerson>
                ")]
        public global::AppSettingsDummy.XmlPerson JohanXml {
            get {
                return ((global::AppSettingsDummy.XmlPerson)(this["JohanXml"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?><ArrayOfXmlPerson xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""><XmlPerson><Name>JohanXml</Name><Age>34</Age></XmlPerson><XmlPerson><Name>Travis</Name><Age>34</Age></XmlPerson><XmlPerson><Name>Drch</Name><Age>34</Age></XmlPerson></ArrayOfXmlPerson>")]
        public global::AppSettingsDummy.ListOfPersons ListOfPersons {
            get {
                return ((global::AppSettingsDummy.ListOfPersons)(this["ListOfPersons"]));
            }
        }
    }
}
