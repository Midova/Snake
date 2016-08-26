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
				p.Draw();			
		}

		/// <summary>
		/// проверка на пересечение точек
		/// </summary>
		/// <param name="figure">фигура для пересечения</param>
		/// <returns> true -если точки совпадают</returns>
		internal bool IsHit(Figure figure)
		{
			foreach (var p in pList)
			{
				//пересикается ли фигура с точкой
				if (figure.IsHit(p))
					return true;
			}
			return false;
		}

		/// <summary>
		/// пересикается ли фигура с точкой
		/// </summary>
		/// <param name="point">точка (координаты)</param>
		/// <returns>true - если координаты совпадают</returns>
		private bool IsHit(Point point)
		{
			foreach (var p in pList)
			{
				if (p.IsHit(point))
					return true;
			}
			return false;
		}
	}
}
