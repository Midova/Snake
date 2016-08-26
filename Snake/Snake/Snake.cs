using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Snake : Figure
	{
		//направление змейки
		private Direction direction;
		
		/// <summary>
		/// Создание змейки
		/// </summary>
		/// <param name="tail">точка хвоста</param>
		/// <param name="lenght">длинна змейки</param>
		/// <param name="_direction">направление змейки</param>
		public Snake( Point tail, int length, Direction _direction)
		{
			direction = _direction;

			pList = new List<Point>();
			for (int i = 0; i < length; i++)
			{
				Point p = new Point(tail);
				p.Move(i, _direction);
				pList.Add(p);
			}
		}

		/// <summary>
		/// Сдвиг змейки (дорисовываем точку "голова", стираем точку "хвост")
		/// </summary>
		internal void Move()
		{
			Point tail = pList.First();
			pList.Remove(tail);
			Point head = GetNextPoint();
			pList.Add(head);

			tail.Clear();
			head.Draw();
		}

		/// <summary>
		/// столкнулась ли змейка со своим хвостом
		/// </summary>
		/// <returns>да- если координаты совпадают</returns>
		internal bool IsHitTail()
		{
			//получаем координаты головы
			var head = pList.Last();

			//делаем перебор по всему телу
			for (int i = 0; i < pList.Count -2; i++)
			{
				if (head.IsHit(pList[i]))
					return true;
			}
			return false;
		}

		/// <summary>
		/// съела ли змейка еду на этом ходу
		/// </summary>
		/// <param name="food">точка "еда"</param>
		/// <returns>да- если съела</returns>
		internal bool Eat(Point food)
		{
			//будущая голова- где будет голова в следующий момент времени
			Point head = GetNextPoint();
			//если координаты головы и еды совпадают
			if (head.IsHit(food))
			{
				//змейка удлиняется, меняем точку еда
				food.Symbol = head.Symbol;
				pList.Add(food);
				return true;
			}
			else
				return false;
		}

		/// <summary>
		/// Возвращает следующую точку
		/// </summary>
		/// <returns>возвращает следующую точку( координаты)</returns>
		public Point GetNextPoint()
		{
			Point head = pList.Last();
			Point nextPoint = new Point(head);
			nextPoint.Move(1, direction);
			return nextPoint;
		}

		/// <summary>
		/// реакция на нажатие клавиши- змейка меняет направление
		/// </summary>
		/// <param name="key">направление движения змейки</param>
		public void HandleKey(ConsoleKey key)
		{
			if (key == ConsoleKey.LeftArrow)
				direction = Direction.LEFT;
			if (key == ConsoleKey.RightArrow)
				direction = Direction.RIGHT;
			if (key == ConsoleKey.UpArrow)
				direction = Direction.UP;
			if (key == ConsoleKey.DownArrow)
				direction = Direction.DOWN;
		}
	}
}
