using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritence.SecondApproach
{
    class ParentA
    {
        public void MethodX()
        {
            Console.WriteLine("MethodX from ParentA called");
        }
        public void MethodY()
        {
            Console.WriteLine("MethodY from ParentA called");
        }
        public void MethodZ()
        {
            Console.WriteLine("MethodZ from ParentA called");
        }
    }

    class ParentB : IParentB
    {
        public void MethodA()
        {
            Console.WriteLine("MethodA from ParentB called");
        }
      
    }

    interface IParentB
    {
        void MethodA();
      
    }

    class Child : ParentA, IParentB
    {
        ParentB objParentB = new ParentB();
        public void MethodA()
        {
            objParentB.MethodA();
        }
    }

}
