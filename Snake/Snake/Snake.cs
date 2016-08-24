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
		private Direction _direction;
		
		/// <summary>
		/// Отрисовка змейки
		/// </summary>
		/// <param name="tail">точка хвоста</param>
		/// <param name="lenght">длинна змейки</param>
		/// <param name="direction">направление змейки</param>
		public Snake( Point tail, int length, Direction direction)
		{
			_direction = direction;

			pList = new List<Point>();
			for (int i = 0; i < length; i++)
			{
				Point p = new Point(tail);
				p.Move(i, direction);
				pList.Add(p);
			}
		}

		internal void Move()
		{
			Point tail = pList.First();
			pList.Remove(tail);
			Point head = GetNextPoint();
			pList.Add(head);

			tail.Clear();
			head.Draw();
		}

		public Point GetNextPoint()
		{
			Point head = pList.Last();
			Point nextPoint = new Point(head);
			nextPoint.Move(1, _direction);
			return nextPoint;
		}
	}
}
