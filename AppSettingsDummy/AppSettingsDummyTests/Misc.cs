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
    public class Misc
    {
        [Test]
        public void SerializepersonTest()
        {
            var johan = new XmlPerson { Name = "JohanXml", Age = 34};
            Console.WriteLine(johan.GetType().AssemblyQualifiedName);
            var sb = new StringBuilder();
            var serializer = new XmlSerializer(johan.GetType());
            using (var writer = new XmlTextWriter(new StringWriter(sb)))
            {
                serializer.Serialize(writer, johan);
                Console.Write(sb);
            }
        }

        [Test]
        public void ConvertPersonTest()
        {
            var johan = new ConverterPerson ( "JohanXml",  34 );
            Console.WriteLine(johan.GetType().AssemblyQualifiedName);
            var convertTo = new PersonConverter().ConvertTo(null, null, johan, null);
            Console.WriteLine((string)convertTo);
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
