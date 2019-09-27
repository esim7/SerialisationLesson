using System;
using System.Xml.Serialization;

namespace SerialisationLesson
{
    //[Serializable]
    public class Book
    {
        //[NonSerialized]
        //private Guid id = Guid.NewGuid();
        //public Guid Id
        //{
        //    get 
        //    {
        //        return id;
        //    }
        //    set 
        //    {
        //        id = value;
        //    }

        //}
        [XmlIgnore]
        public Guid Id { get; set; } = Guid.NewGuid();
        [XmlElement("FIO")]
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

    }
}
