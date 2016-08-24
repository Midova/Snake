using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.SetWindowSize(80,25);
			Console.SetBufferSize(80, 25);

			//Отрисовка рамочки
			HorizontaLline upLine = new HorizontaLline(0, 78, 0, '+');
			HorizontaLline downLine = new HorizontaLline(0,78,24,'+');
			VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
			VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');
			upLine.Draw();
			downLine.Draw();
			leftLine.Draw();
			rightLine.Draw();

			//Отрисовка точки
			Point p = new Point(4, 5, '*');

			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Draw();

			while (true)
			{
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}

				Thread.Sleep(100);
				snake.Move();
			}



		}
	}
}
