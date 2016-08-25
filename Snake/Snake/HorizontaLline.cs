using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class HorizontaLline : Figure
	{
		/// <summary>
		/// созадние горизонтальной линии
		/// </summary>
		/// <param name="xLeft">координата х начала</param>
		/// <param name="xRight">координата х конца</param>
		/// <param name="y"> координата у</param>
		/// <param name="sym">симол</param>
		public HorizontaLline(int xLeft, int xRight, int y, char sym)
		{
			pList = new List<Point>();

			for (int x = xLeft; x <= xRight; x++)
			{
				Point p = new Point(x, y, sym);
				pList.Add(p);
			}
		}
	}
}
