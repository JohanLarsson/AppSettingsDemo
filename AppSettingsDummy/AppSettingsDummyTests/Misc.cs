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
            DumpXml(johan);
        }


        [Test]
        public void SerializeListOfPersonsTest()
        {
            var persons = new Persons
                {
                    new XmlPerson {Name = "JohanXml", Age = 34},
                    new XmlPerson {Name = "Travis", Age = 34},
                    new XmlPerson {Name = "Drch", Age = 34}
                };
            DumpXml(persons);
        }
        
        private static void DumpXml<T>(T item)
        {
            Console.WriteLine(item.GetType().FullName);
            Console.WriteLine();
            var sb = new StringBuilder();
            var serializer = new XmlSerializer(item.GetType());
            using (var writer = new XmlTextWriter(new StringWriter(sb)))
            {
                serializer.Serialize(writer, item);
                Console.Write(sb);
            }
            Console.WriteLine();
        }

        [Test]
        public void ConvertPersonTest()
        {
            var johan = new ConverterPerson ( "JohanConvert",  34 );
            Console.WriteLine(johan.GetType().FullName);
            var convertTo = new PersonConverter().ConvertTo(null, null, johan, null);
            Console.WriteLine((string)convertTo);
        }

        [Test, Explicit]
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
