using System;

namespace MultipleInheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("First Approach");
            FirstApproach.Child objChild = new FirstApproach.Child();
            objChild.ParentWrapperAMethodA();
            objChild.ParentWrapperBMethodB();

            Console.WriteLine("Second Approach");
            SecondApproach.Child objChild2 = new SecondApproach.Child();
            objChild2.MethodA();
            objChild2.ParentBMethodB();

            Console.ReadLine();
        }
    }

   

 }

