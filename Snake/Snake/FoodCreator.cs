using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class FoodCreator
	{
		/// <summary>
		/// ширина карты
		/// </summary>
		int _mapWidht;

		/// <summary>
		/// высота карты
		/// </summary>
		int _mapHeight;

		/// <summary>
		/// символ еды
		/// </summary>
		char _sym;

		Random random = new Random();

		/// <summary>
		/// запускаем создатель еды
		/// </summary>
		/// <param name="mapWidth">ширина карты</param>
		/// <param name="mapHeight">высота карты</param>
		/// <param name="sym">символ еды</param>
		public FoodCreator(int mapWidth, int mapHeight, char sym)
		{
			_mapHeight = mapHeight;
			_mapWidht = mapWidth;
			_sym = sym;
		}

		/// <summary>
		/// Создаем еду. Генерируем случайные координаты в границах поля
		/// </summary>
		/// <returns>случайная точка с едой</returns>
		public Point CreaterFood()
		{
			int x = random.Next(2, _mapWidht - 2);
			int y = random.Next(2, _mapHeight - 2);
			return new Point(x, y, _sym);
		}
	}
}
