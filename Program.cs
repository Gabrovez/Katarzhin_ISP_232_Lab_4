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
            /*string[] results = { "win", "loss", "win", "win", "loss" };
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
            Console.WriteLine($"{ws} победы и {ls} поражения");*/
            //Задание 7
            /*int[] points = { 15, 20, 25, 30, 10 };
            int sum = 0;
            for (int i = 0; i < points.Length; i++)
            {
                sum += points[i];
            }
            double average = (double)sum / points.Length;
            Console.WriteLine($"Среднее количество очков: {average}");*/
            //Задание 8
            /*string[] inv = { "Меч", "Ласточка", "Бомба", "Зелье Гром", "Ласточка" };
        
            for (int i = 0; i < inv.Length; i++)
            {
                if (inv[i] == "Ласточка")
                {
                    inv[i] = "Кошка";
                }
            }
            Console.WriteLine("[" + string.Join(", ", inv) + "]");*/
            //Задание 9
            /*string[] companions = ["Garrus", "Tali", "Mordin", "Grunt", "Jack"];
            string[] roles = ["Лидер команды", "Техник", "Биотик", "Солдат", "Поддержка"];
            for (int i = 0; i < companions.Length; i++)
            {
                Console.WriteLine($"{roles[i]}: {companions[i]}");
            }*/
            //Шаг 5. Массивы
            //int[] numbs;
            //int[] nums = new int[4];
            //int[] nums2 = new int[4] { 1, 2, 3, 5 };
            //int[] nums3 = new int[] { 1, 2, 3, 5 };
            //int[] nums4 = new[] { 1, 2, 3, 5 };
            //int[] nums5 = { 1, 2, 3, 5 };
            //int[] nums = [1, 2, 3, 5];
            //int i = 0;
            //while (i < nums.Length)
            //{
            //    Console.WriteLine(nums[i]);
            //    i++;
            //}
            //int[] nums1 = [0, 1, 2, 3, 4, 5];
            //int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };
            //object[] student = new object[] { "Иван", "Игорь", 4, 4.6, 'с' };
            //student[4] = 4;
            //dynamic[] student2 = new dynamic[] { "Иван", "Игорь", 4, 4.6, 'с' };
            //student2[4] = 4;
            //Console.WriteLine(student[4].GetType());
            //Console.WriteLine(student2[4].GetType());
            // Шаг 6. Задачи с массивами
            /*int[] numbs = [-1, -2, -3, 4, 5, -6, 0, 43, 56, -34, 12, 45, -102, 76, -45, 96, -4, -3, 5, 76, -6, -8, 2, 0, 5, -9];
            int res = 0;
            foreach (int number in numbs)
            {
                if (number > 0)
                    res++;
            }
            Console.WriteLine($"Число элементов больше нуля: {res}");*/
            //int[] numbers = [-1, -2, -3, 4, 5, -6, 0, 43, 56, -34, 12, 45, -102, 76, -45, 96, -4, -3, 5, 76, -6, -8, 2, 0, 5, -9];
            //int n = numbers.Length;
            //int k = n / 2; 
            //int temp;
            //for (int i = 0; i < k; i++)
            //{
            //    temp = numbers[i];
            //    numbers[i] = numbers[n - 1 - i];
            //    numbers[n - 1 - i] = temp;
            //}
            //foreach (int i in numbers)
            //{
            //    Console.Write($"{i} \t");
            //}
            /*int[] nums = [54, 7, -41, 2, 4, 2, 89, 33, -5, 12];
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            Console.WriteLine("Вывод отсортированного массива ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }*/
            /*List<string> student = ["Иван", "Игорь", "Аллександр"];
            var yourStudent = new List<string>(student);*/
            /* List<string> student = new(10);*/
            List<string> student = ["Билли", "Петр", "Степан"];
            string firstStudent = student[0];
            Console.WriteLine(firstStudent);
            student[0] = "Богдан";
            Console.WriteLine(student[0]);
            Console.WriteLine(student.Count);
        }
    }
}
