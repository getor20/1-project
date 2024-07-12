namespace _1_project
{
    internal class Program
    {
        static int food = 20;
        static int water = 10;
        static int tree = 40;
        static int[] resources = new int[3];

        static void Main(string[] args)
        {
            Resources();
        }

        static void Resources()
        {
            resources[0] = food;
            resources[1] = water;
            resources[2] = tree;
            Console.WriteLine($"Еда: {resources[0]}");
            Console.WriteLine($"Вода: {resources[1]}");
            Console.WriteLine($"Дерево: {resources[2]}");


            while (true)
            {
                Console.WriteLine("\nВидите действие: 1-увилечение/уменьшение еды, 2-увилечение/уменьшение вода, 3-увилечение/уменьшение дерива. \nЧтобы выйти 0");
                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Видите действие: 1-увилечение еды, 2-уменьшение еды.\nЧтобы выйти 0");
                        var choicefood = Convert.ToInt32(Console.ReadLine());

                        switch (choicefood)
                        {
                            case 1:
                                Console.WriteLine("Ведите количество добовления еды:");
                                var foodplus = Convert.ToInt32(Console.ReadLine());
                                 
                                if (100 < (resources[0] += foodplus))
                                {
                                    
                                    resources[0] = 100;
                                    Console.WriteLine($"\nКоличество еды: {resources[0]}");
                                    Console.WriteLine("МАКСИМАЛЬНОЕ ЗНАЧЕНИЕ ЕДЫ 100");
                                }
                                else
                                {
                                    Console.WriteLine($"\nКоличество еды: {resources[0]}");
                                    resources[0] += foodplus;
                                    
                                }

                                
                                break;
                            case 2:
                                Console.WriteLine("Ведите количество уменьшение еды:");
                                var foodminus = Convert.ToInt32(Console.ReadLine());

                                if (0 > (resources[0] -= foodminus))
                                {

                                    resources[0] = 0;
                                    Console.WriteLine($"\nКоличество еды: {resources[0]}");
                                    Console.WriteLine("МИНИМАЛЬНОЕ ЗНАЧЕНИЕ ЕДЫ 0");
                                }
                                else
                                {
                                    Console.WriteLine($"\nКоличество еды: {resources[0]}");
                                    resources[0] -= foodminus;

                                }


                                break;
                            case 0:
                                return;
                            default:
                                Console.WriteLine("Неверно");
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Видите действие: 1-увилечение воды, 2-уменьшение воды.\nЧтобы выйти 0");
                        var choicewater = Convert.ToInt32(Console.ReadLine());

                        switch (choicewater)
                        {
                            case 1:
                                Console.WriteLine("Ведите количество добовления воды:");
                                var waterplus = Convert.ToInt32(Console.ReadLine());

                                if (100 < (resources[1] += waterplus))
                                {

                                    resources[1] = 100;
                                    Console.WriteLine($"\nКоличество воды: {resources[1]}");
                                    Console.WriteLine("МАКСИМАЛЬНОЕ ЗНАЧЕНИЕ ВОДЫ 100");
                                }
                                else
                                {
                                    Console.WriteLine($"\nКоличество воды: {resources[1]}");
                                    resources[1] += waterplus;

                                }


                                break;
                            case 2:
                                Console.WriteLine("Ведите количество уменьшение воды:");
                                var waterminus = Convert.ToInt32(Console.ReadLine());

                                if (0 > (resources[1] -= waterminus))
                                {

                                    resources[1] = 0;
                                    Console.WriteLine($"\nКоличество воды: {resources[1]}");
                                    Console.WriteLine("МИНИМАЛЬНОЕ ЗНАЧЕНИЕ ВОДЫ 0");
                                }
                                else
                                {
                                    Console.WriteLine($"\nКоличество воды: {resources[1]}");
                                    resources[1] -= waterminus;

                                }


                                break;
                            case 0:
                                return;
                            default:
                                Console.WriteLine("Неверно");
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Видите действие: 1-увилечение дерева, 2-уменьшение дерева.\nЧтобы выйти 0");
                        var choicetree = Convert.ToInt32(Console.ReadLine());

                        switch (choicetree)
                        {
                            case 1:
                                Console.WriteLine("Ведите количество добовления дерева:");
                                var treeplus = Convert.ToInt32(Console.ReadLine());

                                if (100 < (resources[2] += treeplus))
                                {

                                    resources[2] = 100;
                                    Console.WriteLine($"\nКоличество дерева: {resources[2]}");
                                    Console.WriteLine("МАКСИМАЛЬНОЕ ЗНАЧЕНИЕ ДЕРЕВА 100");
                                }
                                else
                                {
                                    Console.WriteLine($"\nКоличество дерева: {resources[2]}");
                                    resources[2] += treeplus;

                                }


                                break;
                            case 2:
                                Console.WriteLine("Ведите количество уменьшение дерева:");
                                var treeminus = Convert.ToInt32(Console.ReadLine());

                                if (0 > (resources[2] -= treeminus))
                                {

                                    resources[2] = 0;
                                    Console.WriteLine($"\nКоличество дерева: {resources[2]}");
                                    Console.WriteLine("МИНИМАЛЬНОЕ ЗНАЧЕНИЕ ДЕРЕВА 0");
                                }
                                else
                                {
                                    Console.WriteLine($"\nКоличество дерева: {resources[2]}");
                                    resources[2] -= treeminus;
                                    

                                }


                                break;
                            case 0:
                                return;
                            default:
                                Console.WriteLine("Неверно");
                                break;
                        }
                        break;
                    case 0:
                        return;

                    default:
                        Console.WriteLine("Неверно");
                        break;

                }
            }
        }

    }

}
