using System.Configuration;

namespace AppSettingsDummy
{
    /// <summary>
    /// http://www.blackwasp.co.uk/CustomAppSettings.aspx
    /// </summary>
    [SettingsSerializeAs(SettingsSerializeAs.Xml)]
    public class XmlPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}