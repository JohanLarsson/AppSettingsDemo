using System.Configuration;

namespace AppSettingsDummy
{
    [SettingsSerializeAs(SettingsSerializeAs.Xml)]
    public class XmlPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}