using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SerializeContext context = new SerializeContext(new XmlSerializerStrategy());
            context.Serialize();
        }
    }
}
