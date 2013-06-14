using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using AppSettingsDummy;
using NUnit.Framework;

namespace AppSettingsDummyTests
{
    public class Class1
    {
        [Test]
        public void SerializepersonTest()
        {
            var andreas = new Employee { Name = "Andreas", Position = "Top" };
            var sb = new StringBuilder();
            var serializer = new XmlSerializer(andreas.GetType());
            using (var writer = new XmlTextWriter(new StringWriter(sb)))
            {
                serializer.Serialize(writer, andreas);
                Console.Write(sb);
            }
        }

        [Test]
        public void SerializeDictionaryTest()
        {
            var dictionary = new Dictionary<string,string>
                {
                    {"Johan","Toan"}
                };
            var sb = new StringBuilder();
            var serializer = new XmlSerializer(dictionary.GetType());
            using (var writer = new XmlTextWriter(new StringWriter(sb)))
            {
                serializer.Serialize(writer, dictionary);
                Console.Write(sb);
            }
        }
    }
}
