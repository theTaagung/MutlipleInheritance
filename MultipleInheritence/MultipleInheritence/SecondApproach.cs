using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritence.SecondApproach
{
    class ParentA
    {
        public void MethodA()
        {
            Console.WriteLine("MethodA from ParentA called");
        }
        public void MethodB()
        {
            Console.WriteLine("MethodB from ParentA called");
        }
    }

    class ParentB : IParentB
    {
        public void MethodA()
        {
            Console.WriteLine("MethodA from ParentB called");
        }
        public void MethodB()
        {
            Console.WriteLine("MethodB from ParentB called");
        }
    }

    interface IParentB
    {
        void MethodA();
        void MethodB();
    }

    class Child : ParentA, IParentB
    {
        ParentB objParentB = new ParentB();
        
        public void ParentBMethodA()
        {
            objParentB.MethodA();
        }

        public void ParentBMethodB()
        {
            objParentB.MethodB();
        }
    }

}
