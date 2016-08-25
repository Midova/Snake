using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class VerticalLine : Figure
	{	
		/// <summary>
		/// Создание вертикальной линии
		/// </summary>
		/// <param name="x">коррдината х линии</param>
		/// <param name="yTop">координата у начала</param>
		/// <param name="yDeep">координата у конца</param>
		/// <param name="sym"> символ</param>
		public VerticalLine(int x, int yTop, int yDeep, char sym)
		{
			pList = new List<Point>();

			for (int y = yTop; y <= yDeep; y++)
			{
				Point p = new Point(x, y, sym);
				pList.Add(p);
			}
		}		
	}
}
