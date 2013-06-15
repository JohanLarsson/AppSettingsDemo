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

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", Name, Age);
        }
    }
}