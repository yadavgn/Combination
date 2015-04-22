using System;

namespace Brick.MSTestRunner
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var facade = new Facade();

            if (!facade.ValidateArgs(args))
                return;

            facade.RunTests(args[0]);
        }
    }
}
