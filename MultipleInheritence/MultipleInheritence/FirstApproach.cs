using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritence.FirstApproach
{
    #region First Approach
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

    class ParentB
    {
        public void MethodA()
        {
            Console.WriteLine("MethodA from ParentB called");
        }
        public void MethodB()
        {
            Console.WriteLine("MethodA from ParentB called");
        }
    }

    class ParentWrapper
    {
        ParentA objA = new ParentA();
        ParentB objB = new ParentB();
        public void ParentWrapperAMethodA()
        {
            objA.MethodA();
        }
        public void ParentWrapperAMethodB()
        {
            objA.MethodB();
        }
        public void ParentWrapperBMethodA()
        {
            objB.MethodA();
        }
        public void ParentWrapperBMethodB()
        {
            objB.MethodB();
        }
    }

    class Child : ParentWrapper
    {

    }
    #endregion
}
