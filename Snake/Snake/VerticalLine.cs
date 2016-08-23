using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class VerticalLine
	{
		List<Point> pList;

		public VerticalLine(int x, int yTop, int yDeep, char sym)
		{
			pList = new List<Point>();

			for (int y = yTop; y <= yDeep; y++)
			{
				Point p = new Point(x, y, sym);
				pList.Add(p);
			}
		}

		public void Draw()
		{
			foreach (Point p in pList)
			{
				p.Draw();
			}
		}
	}
}
