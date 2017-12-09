using System;
using OpenTK;

namespace BlankWindow
{
    sealed class Program : GameWindow
    {
        [STAThread]
        static void Main()
        {
            var program = new Program();
            program.Run();
        }
    }
}
