using OOP.Patterns_of_behavior.Responsibility_chain.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Patterns_of_behavior.Responsibility_chain.Interfaces
{
    internal abstract class Handler
    {
        private protected Handler nextHandler;
        public abstract void handlePayment(Payment payment);
        public abstract void setNextHandler(Handler nextHandler);
    }
}
