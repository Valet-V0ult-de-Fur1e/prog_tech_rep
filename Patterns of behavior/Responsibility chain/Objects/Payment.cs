namespace OOP.Patterns_of_behavior.Responsibility_chain.Objects
{
    internal class Payment
    {
        private PaymentType _type;
        public Payment(PaymentType type)
        {
            _type = type;
        }
        public PaymentType getType() { return _type; }
    }
}
