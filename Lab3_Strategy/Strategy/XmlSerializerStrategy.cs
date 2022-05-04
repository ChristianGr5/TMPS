using System;
namespace Strategy
{
    public class XmlSerializerStrategy : ISerializeStrategy
    {
        public void Serialize()
        {
            Console.WriteLine("Serializing to Xml");
        }
    }
}
