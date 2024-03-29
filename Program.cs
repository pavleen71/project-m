using Microsoft.Win32.SafeHandles;
using System.Runtime.CompilerServices;

namespace inteface
{
    internal class Program
    {
        public interface ione
        {
            void One();//all interfaces are public 
        }
        public interface itwo
        {
            void Two();//all interfaces are public 
        }
        public interface i: ione,itwo
        {
           //all interfaces are public 
        }
        public class OaT : i
        {
            public void One()
            {
                Console.WriteLine("One .. ");
            }
            public void Two()
            {
                Console.WriteLine("Two .. ");
            }
        }
        static void Main(string[] args)
        {
          i one= new OaT();
            one.One();
            one.Two();
        }
    }
}