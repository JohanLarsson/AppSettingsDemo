using System.Configuration;

namespace AppSettingsDummy
{
    [SettingsSerializeAs(SettingsSerializeAs.Xml)]
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
    }
}