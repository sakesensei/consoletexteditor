using System;
using Editor;

namespace consoletexteditor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Init.Display();

			Page _page = new Page(0);

			for (int i = 1; i < Init.WIDTH-2; i++)
			{
				Console.SetCursorPosition(i, 1);
				Console.Write('%');
			}

			Console.WriteLine(_page.Line[0]);

			Console.ReadLine();
        }
    }
}
