using OOP.Patterns_of_behavior.Responsibility_chain.Handlers;
using OOP.Patterns_of_behavior.Responsibility_chain.Interfaces;
using OOP.Patterns_of_behavior.Responsibility_chain.Objects;
using OOP.Patterns_of_behavior.Responsibility_chain.Objects.PaymentsTypes;
using OOP.Patterns_of_behavior.Strategy.Objects.Engines;
using OOP.Patterns_of_behavior.Strategy.Strategies;

namespace OOP.Patterns_of_behavior.Strategy
{
    internal class TesterPatternsOfBehavior
    {
        public static void testStrategyPattern()
        {
            ElectricMotor electricMotor = new("em_vh_1", 180);
            ServoDrive servoDrive = new("sd_lr_90_1", 0);

            Context context = new Context();
            context.setStrategy(new ServoDriveControllerStrategy());
            context.engineMove(servoDrive, 45);

            context.setStrategy(new ElectricMotorControllerStrategy());
            context.engineMove(electricMotor, 90);
        }
        public static void testResponsibilityChainPattern() 
        {
            Handler handlerSFP = new SFPPaymentHandler();
            Handler handlerBetweenBanks = new BetweenBanksPaymentHandler();
            Handler handlerInsideBank = new InsideBankPaymentHandler();

            handlerSFP.setNextHandler(handlerBetweenBanks);
            handlerBetweenBanks.setNextHandler(handlerInsideBank);

            Payment paymentSFP = new Payment(new SFPPayment());
            Payment paymentBB = new Payment(new BetweenBanksPayment());
            Payment paymentIB = new Payment(new InsideBankPayment());

            handlerSFP.handlePayment(paymentSFP);
            handlerBetweenBanks.handlePayment(paymentBB);
            handlerInsideBank.handlePayment(paymentIB);
        }
    }
}
