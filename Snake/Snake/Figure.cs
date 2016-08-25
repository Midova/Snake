using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Figure
	{
		/// <summary>
		/// фигура- список точек
		/// </summary>
		protected List<Point> pList;

		/// <summary>
		/// отрисовка фигуры
		/// </summary>
		public void Draw()
		{

			foreach (Point p in pList)
			{
				p.Draw();
			}
		}
	}
}
