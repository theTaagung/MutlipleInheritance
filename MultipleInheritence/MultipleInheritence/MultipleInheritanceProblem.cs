using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritence.Problem
{
    class SuperParent
    {
        public virtual void MethodA()
        {
            Console.WriteLine("MethodA from Super Parent called");
        }
        public virtual void MethodB()
        {
            Console.WriteLine("MethodB from Supre Parent called");
        }
    }
    class ParentA:SuperParent
    {
        public override void MethodA()
        {
            Console.WriteLine("MethodA from ParentA called");
        }
        public override void MethodB()
        {
            Console.WriteLine("MethodB from ParentA called");
        }
    }

    class ParentB:SuperParent
    {
        public override void MethodA()
        {
            Console.WriteLine("MethodA from ParentB called");
        }
        public override void MethodB()
        {
            Console.WriteLine("MethodA from ParentB called");
        }
    }

    class Child : ParentA//, ParentB
    {
        
    }
}
