using System;
namespace Strategy
{
    public class SerializeContext
    {
        private ISerializeStrategy serialize;
        public SerializeContext(ISerializeStrategy serialize)
        {
            this.serialize = serialize;
        }
        public void Serialize()
        {
            this.serialize.Serialize();
        }
    }
}
