using System;
using Editor;

namespace consoletexteditor
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			char s = '☭';
			int num = 0;

			Clear.All(s);

			Console.Clear();

			Page _page = new Page(0);

			//Init.Display();
			//Console.WriteLine(_page.Line[0]);
			_page.Line[num] = Console.ReadLine();

		}
	}
}
