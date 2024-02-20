using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot21
{
    using System;

    namespace MyRobotLibrary
    {

        public class Robot
        {
            private string name;
            private (int, int) position;

            public (int, int) Position
            {
                get { return position; }
                set { position = value; }
            }

            public Robot(string name, int x, int y)
            {
                this.name = name;
                position = (x, y);
            }

            public void Move()
            {
                Random random = new Random();
                int direction = random.Next(0, 4);

                switch (direction)
                {
                    case 0:
                        Console.WriteLine("Робот движется вперед");
                        position.Item2++;
                        break;
                    case 1:
                        Console.WriteLine("Робот движется назад");
                        position.Item2--;
                        break;
                    case 2:
                        Console.WriteLine("Робот поворачивает налево");
                        position.Item1--;
                        break;
                    case 3:
                        Console.WriteLine("Робот поворачивает направо");
                        position.Item1++;
                        break;
                    default:
                        Console.WriteLine("Некорректное направление");
                        break;
                }
            }

            public void GetInfo()
            {
                Console.WriteLine("Имя робота: " + name);
                Console.WriteLine("Текущая позиция: (" + position.Item1 + ", " + position.Item2 + ")");
            }
        }
    }
}
    
    