using System.Reflection.Emit;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            double v;

            while (n != 0)
            {
                v = double.Parse(Console.ReadLine());
                if (v < norma)
                {
                    milk += glass / 1000.0;
                }
                n--;
            }
                // end

                return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            while (n != 0)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if (x > 0 && y > 0)
                {
                    first++;
                }
                if (x < 0 && y > 0)
                {
                    second++;
                }
                if (x < 0 && y < 0)
                {
                    third++;
                }
                if (x > 0 && y < 0)
                {
                    fourth++;
                }

                n--;
            }
                // end

                return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            while (n != 0)
            {
                int q = int.Parse(Console.ReadLine());
                int w = int.Parse(Console.ReadLine());
                int e = int.Parse(Console.ReadLine());
                int r = int.Parse(Console.ReadLine());
                if (q == 2 || w == 2 || e == 2 || r == 2 || q == 3 || w == 3 || e == 3 || r == 3)
                {
                    count--;
                }
                n--;
            }
                // end

                return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {

            int taskTime = 10;
            int serias = 0;

            while (time < 1440)
            {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;
                }
                else
                {
                    int seriasTime = int.Parse(Console.ReadLine());
                    time += seriasTime;
                    serias++;
                }
            }


            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {
            switch (number)
            {
                case 1 or 3:
                    power += 10;
                    intellect -= 5;
                    if (intellect < 0)
                        intellect = 0;
                    break;
                case 2:
                    agility += 5;
                    power -= 5;
                    intellect -= 5;
                    if (power < 0)
                        power = 0;
                    if (intellect < 0)
                        intellect = 0;
                    break;
                case 4:
                    agility += 15;
                    power -= 10;
                    intellect -= 10;
                    if (power < 0)
                        power = 0;
                    if (intellect < 0)
                        intellect = 0;
                    break;
                case 5:
                    intellect += 7;
                    power -= 5;
                    if (power < 0)
                        power = 0;
                    break; 
            }
        }
    }
}
