using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        void Handle(Product product);
    }

    public abstract class Handler : IHandler
    {
        private IHandler Next { get; set; }
        public virtual void Handle(Product product)
        {
            Next?.Handle(product);
        }

        public IHandler SetNext(IHandler handler)
        {
            Next = handler;
            return Next;
        }
    }
}
