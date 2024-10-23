
using OOP.Patterns_of_behavior.Responsibility_chain.Interfaces;
using OOP.Patterns_of_behavior.Responsibility_chain.Objects;

namespace OOP.Patterns_of_behavior.Responsibility_chain.Handlers
{
    internal class SFPPaymentHandler : Handler
    {
        public override void handlePayment(Payment payment)
        {
            if (payment.getType() is SFPPayment)
            {
                Console.WriteLine("осуществлена оплата по СБП");
            }
            else
            {
                nextHandler.handlePayment(payment);
            }
        }

        public override void setNextHandler(Handler nextHandler)
        {
            this.nextHandler = nextHandler;
        }
    }
}
