using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;



namespace SerialisationLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book
                {
                    Name = "Poema",
                    Author = "Pushkin",
                    Price = 1000
                },
                new Book
                {
                    Name = "Stihi",
                    Author = "tolstoy",
                    Price = 1200
                },

            };
            //
            //var serializer = new XmlSerializer(typeof(List<Book>));//books.gettype

            //using (var stream = File.CreateText("1.xml"))
            //{
            //    serializer.Serialize(stream, books);
            //}

            //using (var stream = File.OpenRead("1.xml"))
            //{
            //    var result = serializer.Deserialize(stream) as List<Book>;
            //}


            //сериализация c помощью библиотеки Newtonsoft.Json;
            string json = JsonConvert.SerializeObject(books);

            var result = JsonConvert.DeserializeObject<List<Book>>(json);

        }
    }
}
