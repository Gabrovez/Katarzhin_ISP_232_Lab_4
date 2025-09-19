namespace Katarzhin_ISP_232_Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = [-1, -2, -3, 4, 5, -6, 0,
                43, 56, -34, 12, 45, -102, 76, -45, 96, 
                -4, -3, 5, 76, -6, -8, 2, 0, 5, -9];
            int res = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    res++;
            }
            Console.WriteLine($"Число элементов больше нуля: {res}");*/
            /*int[] numbers = [-1, -2, -3, 4, 5, -6, 0,
                43, 56, -34, 12, 45, -102, 76, -45, 96, 
                -4, -3, 5, 76, -6, -8, 2, 0, 5, -9];
            int res = 0;
            int index = 0;
            while (index < numbers.Length)
            {
                if (numbers[index] > 0)
                    res++;
                index++;
            }
            Console.WriteLine($"Число элементов больше нуля: {res}");*/
            //Задание 1
            /*Console.WriteLine("Введите элементы массива через пробел: ");
            string[] mas = Console.ReadLine().Split(' ');
            Console.WriteLine("Введенный массив:");
            foreach (string it in mas)
            {
                Console.Write(it + " ");
            }*/
            //Задание 2
            /*int[] scores = { 10, 20, 15, 30, 25 };
            int res = 0;
            foreach (int poin in scores)
            {
                res += poin;
            }
            Console.WriteLine($"Общее количество очков: {res}");*/
            //Задание 3
            /*int[] nums = { 1, 3, 7, 2, 5 };
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            Console.WriteLine($"Максимальный элемент: {max}");*/
            //Задание 4
            /*int[] numbers = { 1, 2, 3, 4, 5 };
            int et = 0;
            int ot = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    et++;
                }
                else
                {
                    ot++;
                }
            }
            Console.WriteLine($"{et} четных и {ot} нечетных");*/
            //Задание 5
            /*int[] times = [ 120, 95, 110, 105, 100 ];
            int minTime = times[0];
            for (int i = 1; i < times.Length; i++)
            {
                if (times[i] < minTime)
                {
                    minTime = times[i];
                }
            }
            Console.WriteLine($"Самое быстрое время: {minTime} секунд");*/
            //Задание 6
            string[] results = { "win", "loss", "win", "win", "loss" };
            int ws = 0;
            int ls = 0;
            for (int i = 0; i < results.Length; i++)
            {
                if (results[i] == "win")
                {
                    ws++;
                }
                else if (results[i] == "loss")
                {
                    ls++;
                }
            }
            Console.WriteLine($"{ws} победы и {ls} поражения");
        }
    }
}
