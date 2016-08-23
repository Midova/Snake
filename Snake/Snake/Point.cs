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

		public void Draw()
		{
			Console.SetCursorPosition(CoordinateX, CoordinateY);
			Console.Write(Symbol);
		}
	}
}
