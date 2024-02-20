using System;
using System.Threading;
using Robot21;
using Robot21.MyRobotLibrary;

class Program
{


    
        static void Main(string[] args)
        {
            Robot robot1 = new Robot("Робот Валера", 200, 199);
            Robot robot2 = new Robot("Робот Сережа", 200, 199);
            Robot robot3 = new Robot("Робот Антон", 200, 199);

            Thread moveThread1 = new Thread(() =>
            {
                for (int i = 0; i < 3; i++)
                {
                    lock (robot1)
                    {
                        robot1.Move();
                        robot1.GetInfo();
                    }
                    Thread.Sleep(1000);
                }
            });

            Thread moveThread2 = new Thread(() =>
            {
                for (int i = 0; i < 3; i++)
                {
                    lock (robot2)
                    {
                        robot2.Move();
                        robot2.GetInfo();
                    }
                    Thread.Sleep(1000);
                }
            });

            Thread moveThread3 = new Thread(() =>
            {
                for (int i = 0; i <= 3; i++)
                {
                    lock (robot3)
                    {
                        robot3.Move();
                        robot3.GetInfo();
                    }
                    Thread.Sleep(1000);
                }
            });

            moveThread1.Start();
            moveThread2.Start();
            moveThread3.Start();

            moveThread1.Join();
            moveThread2.Join();
            moveThread3.Join();

            Console.ReadKey();
        }
    }


