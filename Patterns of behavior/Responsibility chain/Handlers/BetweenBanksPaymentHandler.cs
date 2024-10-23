using OOP.Patterns_of_behavior.Responsibility_chain.Interfaces;
using OOP.Patterns_of_behavior.Responsibility_chain.Objects;
using OOP.Patterns_of_behavior.Responsibility_chain.Objects.PaymentsTypes;

namespace OOP.Patterns_of_behavior.Responsibility_chain.Handlers
{
    internal class BetweenBanksPaymentHandler : Handler
    {
        public override void handlePayment(Payment payment)
        {
            if (payment.getType() is BetweenBanksPayment)
            {
                Console.WriteLine("осуществлена оплата по между банковской системе");
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
