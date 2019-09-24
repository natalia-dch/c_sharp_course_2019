using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: 
*/

namespace Task_01
{
    class Program
    {
        public static bool RectangleInflate(int x, int y, ref int height, ref int width)
        {
            // проверяем корректность переданных значений
            if (height <= 0 || width <= 0) return false;
            height++;
            width++;
            return true;
        }

        public static bool RectangleDeflate(int x, int y, ref int height, ref int width)
        {
            // проверяем корректность переданных значений
            if (height <= 1 || width <= 1) return false;
            height--;
            width--;
            return true;
        }

        public static bool RectangleNormalize(int x, int y, ref int height, ref int width)
        {
            // проверяем корректность переданных значений
            if (height == width) return false;
            height = height > width ? width : height;
            width = width > height ? height : width;
            return true;
        }

        static void isOk(int x, int y, ref int height, ref int width) {
            if (!RectangleInflate(x, y, ref height, ref width))
            {
                Console.WriteLine("Неверные параметры прямоугольника!");
                return;
            }
            Console.WriteLine("Преобразование успешно произведено:");
            Console.WriteLine("({0},{1}) h={2} w={3}", x, y, height, width);
        }
        static void Main(string[] args)
        {   //var-s
            int x = 0, y = 0;
            int height = 5, width = 7;
            isOk(x, y, ref height, ref width);
            int xWrong = 1, yWrong = 1;
            isOk(xWrong, yWrong, ref height, ref width);
            int heightWrong = -5, widthWrong = 7;
            isOk(x, y, ref heightWrong, ref widthWrong);
            // тест метода для неверных данных
        }
    }
}
