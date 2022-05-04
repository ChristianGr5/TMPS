using System;
namespace Strategy
{
    public class JsonSerializerStrategy : ISerializeStrategy
    {
        public void Serialize()
        {
            Console.WriteLine("Serializing to Json");
        }
    }
}
