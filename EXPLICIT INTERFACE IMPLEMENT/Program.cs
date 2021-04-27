using System;

namespace EXPLICIT_INTERFACE_IMPLEMENT
{
interface I1
    {
        void Method();
    }
interface I2
    {
        void Method();
    }
    class Program :   I1 , I2
    {// ACCESS MODIFIERS ARE NOT ALLOWED ON EXPLICITY IMPLEMENTED INTERFACE MEMBERS      change 1 is not use access modifier
        void I1.Method()    //I1 now the explicity implement interface    change 2 that I1.interface-method
        {
            Console.WriteLine("i1 interface method");
        }// IF WE WANT TO DEFAULT CALL METHODS USE PUBLIC KEYWORD
        void I2.Method()
        {
            Console.WriteLine("i2 interface method");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            ((I2)p).Method();  // TYPE CAST OPERATOR Important to use the type cast operator ((I1)REFERENCE)
            ((I1)p).Method();
        
        
        }

    }
}
