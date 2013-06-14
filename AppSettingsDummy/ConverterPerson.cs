using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace AppSettingsDummy
{
    [TypeConverter(typeof(PersonConverter))]
    [SettingsSerializeAs(SettingsSerializeAs.String)]
    public class ConverterPerson
    {
        public ConverterPerson(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
    }
}
