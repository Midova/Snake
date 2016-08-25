using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Point
	{
		public int CoordinateX;
		public int CoordinateY;
		public char Symbol;

		public Point()
		{
		}

		public Point( int _x, int _y, char _sym)
		{
			CoordinateX = _x;
			CoordinateY = _y;
			Symbol = _sym;
		}

		public Point(Point p)
		{
			CoordinateX = p.CoordinateX;
			CoordinateY = p.CoordinateY;
			Symbol = p.Symbol;
		}


		/// <summary>
		/// сдвигает точку на растояние offset, в напралении direction
		/// </summary>
		/// <param name="offset">расстояние сдвига</param>
		/// <param name="direction">направление сдвига</param>
		public void Move(int offset, Direction direction)
		{
			if (direction == Direction.RIGHT)
				CoordinateX = CoordinateX + offset;
			if (direction == Direction.LEFT)
				CoordinateX = CoordinateX - offset;
			if (direction == Direction.UP)
				CoordinateY = CoordinateY - offset;
			if (direction == Direction.DOWN)
				CoordinateY = CoordinateY + offset;
		}

		/// <summary>
		/// стираем точку
		/// </summary>
		public void Clear()
		{
			Symbol = ' ';
			Draw();
		}

		/// <summary>
		/// отрисовываем точку
		/// </summary>
		public void Draw()
		{
			Console.SetCursorPosition(CoordinateX, CoordinateY);
			Console.Write(Symbol);
		}

		/// <summary>
		/// сравнение координат этой точки с точкой в скобках
		/// </summary>
		/// <param name="p"> точка для сравнения </param>
		/// <returns> да-если совпадают </returns>
		public bool IsHit(Point p)
		{
			return p.CoordinateX == this.CoordinateX && p.CoordinateY == this.CoordinateY;
		}
	}
}
