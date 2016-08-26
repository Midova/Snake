using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Walls
	{
		/// <summary>
		/// список преград
		/// </summary>
		List<Figure> wallList;

		/// <summary>
		/// создаем список проеград
		/// </summary>
		/// <param name="mapWidth">ширина карты</param>
		/// <param name="mapHeight">длинна карты</param>
		public Walls(int mapWidth, int mapHeight)
		{
			wallList = new List<Figure>();
			
			//Отрисовка рамочки
			HorizontaLline upLine = new HorizontaLline(0, mapWidth-2, 0, '+');
			HorizontaLline downLine = new HorizontaLline(0, mapWidth-2, mapHeight-1, '+');
			VerticalLine leftLine = new VerticalLine(0, 0, mapHeight-1, '+');
			VerticalLine rightLine = new VerticalLine(mapWidth-2, 0, mapHeight-1, '+');

			wallList.Add(upLine);
			wallList.Add(downLine);
			wallList.Add(leftLine);
			wallList.Add(rightLine);
		}

		/// <summary>
		/// Столкнулись ли фигуры
		/// </summary>
		/// <param name="figure">любая фигура</param>
		/// <returns>true - если координаты совпадают</returns>
		internal bool IsHit(Figure figure)
		{
			foreach (var wall in wallList)
			{
				if (wall.IsHit(figure))
					return true;
			}
			return false;
		}

		/// <summary>
		/// свой метод отрисовки. Пробигаемся по всем фигурам и вызываем их метод отрисовки
		/// </summary>
		public void Drow()
		{
			foreach (var wall in wallList)
				wall.Draw();			
		}
	}
}
