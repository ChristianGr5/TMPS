using System;

namespace Builder
{
    class SpendingsBuilder
    {

        private readonly SpendingsInfo _spendingsInfo = new SpendingsInfo();

        public SpendingsBuilder From(string from)
        {
            _spendingsInfo.From = from;
            return this;
        }

        public SpendingsBuilder To(string to)
        {
            _spendingsInfo.To = to;
            return this;
        }

        public SpendingsBuilder Amount(string amount)
        {
            _spendingsInfo.Amount = amount;
            return this;
        }

        public SpendingsBuilder About(string about)
        {
            _spendingsInfo.About = about;
            return this;
        }

        public SpendingsInfo Build()
        {
            if (_spendingsInfo.Amount == "0")
                throw new InvalidCastException("Error!");
            return _spendingsInfo;
        }
    }
}
