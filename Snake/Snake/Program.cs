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

			//создаем рамку из преград
			Walls walls = new Walls(80, 25);
			walls.Drow();
			
			//Отрисовка точки
			Point p = new Point(4, 5, '*');
			//создаем змейку и отрисовываем ее
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Draw();

			//запускаем создатель еды в границах нашей карты
			FoodCreator foodCreator = new FoodCreator(80, 25, '$');
			
			//создаем еду и отрисовываем ее
			Point food = foodCreator.CreaterFood();
			food.Draw();


			while (true)
			{
				//столкнулась ли змейка с преградой или с собственным хвостом
				if (walls.IsHit(snake) || snake.IsHitTail())
					break;
				
				//ест ли змейка еду (встретилась ли с едой)
				if (snake.Eat(food))
				{
					//появляется новая еда
					food = foodCreator.CreaterFood();
					food.Draw();
				}
				else
					//продолжаем движение дальше
					snake.Move();

				Thread.Sleep(100);

				//нажата ли кнопка
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					//змейка меняет напраление
					snake.HandleKey(key.Key);
				}
			}
			WriteGameOver();
			Console.ReadLine();
		}

		static void WriteGameOver()
		{
			int xOffset = 25;
			int yOffset = 8;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.SetCursorPosition(xOffset, yOffset++);
			WriteText("============================", xOffset, yOffset++);
			WriteText("И Г Р А    О К О Н Ч Е Н А", xOffset + 1, yOffset++);					
			WriteText("============================", xOffset, yOffset++);
		}

		static void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}

	}
}
