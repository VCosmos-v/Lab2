internal class Program
{
    public static void Main(string[] args)
    {
        Program menu = new Program();
        menu.Menu();
    }

    private void PrintMenu()
    {
        Console.WriteLine("\n1. 3 Точки");
        Console.WriteLine("2. Линии");
        Console.WriteLine("3. Студенты");
        Console.WriteLine("4. Изменение Точки и Линии");
        Console.WriteLine("5. Длина линии");
        Console.WriteLine("0. Выход");
    }

    private void Menu()
    {
        Validator validator = new Validator();
        Program menu = new Program();
        int num = -1;
        while (num != 0)
        {
            PrintMenu();
            num = validator.ReadIntInterval("Выберите пункт:", 0, 5);
            switch (num)
            {
                case 1:
                    {
                        Point[] points = new Point[3];
                        for (int i = 0; i < points.Length; i++)
                        {
                            Console.WriteLine($"\n{i + 1} Точка");
                            int x = validator.ReadInt("Введите x: ");
                            int y = validator.ReadInt("Введите y: ");
                            points[i] = new Point(x, y);
                        }
                        Console.WriteLine("Точки: ");
                        for (int i = 0; i < points.Length; i++)
                        {
                            Console.WriteLine(points[i]);
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\nПервые три линии:");
                        Line line1 = new Line(new Point(1, 3), new Point(23, 8));
                        Console.WriteLine(line1);
                        Line line2 = new Line(new Point(5, 10), new Point(25, 10));
                        Console.WriteLine(line2);
                        Line line3 = new Line(line1, line2);
                        Console.WriteLine(line3);

                        Console.WriteLine("\nИзменения начала и конца линий:");
                        line1.Start.X = 5;
                        line1.Start.Y = 4;
                        line2.End.X = 7;
                        line2.End.Y = 9;
                        Console.WriteLine(line1);
                        Console.WriteLine(line2);
                        Console.WriteLine(line3);

                        Console.WriteLine("\nИзменения начала 1-ой линии без изменения 3-ей:");
                        line1.ChangeStart(new Point(100, 100));
                        Console.WriteLine(line1);
                        Console.WriteLine(line3);
                        break;
                    }
                case 3:
                    {
                        Student Vasya = new Student("Vasya", new int[3] { 3, 4, 5 });
                        Student Petya = new Student("Petya", Vasya.Grades);
                        Console.WriteLine(Vasya);
                        Console.WriteLine(Petya);
                        Petya.Grades[0] = 5;
                        Console.WriteLine("\nПосле изменения оценки Пети: ");
                        Console.WriteLine(Vasya);
                        Console.WriteLine(Petya);

                        int[] grade = new int[Vasya.Grades.Length];
                        for (int i = 0; i < grade.Length; i++)
                        {
                            grade[i] = Vasya.Grades[i];
                        }
                        Student Andrey = new Student("Andrey", grade);
                        Vasya.Grades[0] = 2;
                        Console.WriteLine("\nОценки Васи и Андрея: ");
                        Console.WriteLine(Vasya);
                        Console.WriteLine(Andrey);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("\nТочки:");
                        Point point1 = new Point(3, 5);
                        Console.WriteLine(point1);
                        Point point2 = new Point(25, 6);
                        Console.WriteLine(point2);
                        Point point3 = new Point(7, 8);
                        Console.WriteLine(point3);

                        Console.WriteLine("\nЛинии:");
                        Line line1 = new Line(1, 3, 23, 8);
                        Console.WriteLine(line1);
                        Line line2 = new Line(5, 10, 25, 10);
                        Console.WriteLine(line2);
                        Line line3 = new Line(line1, line2);
                        Console.WriteLine(line3);
                        break;
                    }
                case 5:
                    {
                        Line line = new Line(1, 1, 10, 15);
                        Console.WriteLine(line);
                        Console.WriteLine($"Длина = {line.Distance()}");
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
