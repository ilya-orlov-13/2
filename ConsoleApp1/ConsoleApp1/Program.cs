using ConsoleApp1;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.WriteLine("\nвыберите задание");
            Console.WriteLine("1. Задание 1");
            Console.WriteLine("2. Задание 2");
            Console.WriteLine("3. Задание 3");
            Console.WriteLine("4. Задание 4");
            Console.WriteLine("5. Задание 5");
            Console.WriteLine("0. Выход из программы");

            int choice = ConsoleValidator.ReadValidatedInt("", 0, 5);

            switch (choice)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 0:
                    continueRunning = false;
                    break;
            }

            if (continueRunning && choice != 0)
            {
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    static void Task1()
    {
        Console.WriteLine("\n1.1");

        double x1 = ConsoleValidator.ReadValidatedDouble("Введите координату X для точки 1: ", -1000, 1000, true);
        double y1 = ConsoleValidator.ReadValidatedDouble("Введите координату Y для точки 1: ", -1000, 1000, true);
        var point1 = new Point(x1, y1);

        double x2 = ConsoleValidator.ReadValidatedDouble("Введите координату X для точки 2: ", -1000, 1000, true);
        double y2 = ConsoleValidator.ReadValidatedDouble("Введите координату Y для точки 2: ", -1000, 1000, true);
        var point2 = new Point(x2, y2);

        double x3 = ConsoleValidator.ReadValidatedDouble("Введите координату X для точки 3: ", -1000, 1000, true);
        double y3 = ConsoleValidator.ReadValidatedDouble("Введите координату Y для точки 3: ", -1000, 1000, true);
        var point3 = new Point(x3, y3);

        Console.WriteLine($"Точка 1: {point1}");
        Console.WriteLine($"Точка 2: {point2}");
        Console.WriteLine($"Точка 3: {point3}");
    }

    static void Task2()
    {
        Console.WriteLine("\n2.1");
        Console.WriteLine("Линия 1:");
        double line1x1 = ConsoleValidator.ReadValidatedDouble("Начало линии 1 - X: ", -1000, 1000, true);
        double line1y1 = ConsoleValidator.ReadValidatedDouble("Начало линии 1 - Y: ", -1000, 1000, true);
        double line1x2 = ConsoleValidator.ReadValidatedDouble("Конец линии 1 - X: ", -1000, 1000, true);
        double line1y2 = ConsoleValidator.ReadValidatedDouble("Конец линии 1 - Y: ", -1000, 1000, true);

        Console.WriteLine("Линия 2:");
        double line2y = ConsoleValidator.ReadValidatedDouble("Высота линии 2: ", -1000, 1000, true);
        double line2x1 = ConsoleValidator.ReadValidatedDouble("Начало линии 2 - X: ", -1000, 1000, true);
        double line2x2 = ConsoleValidator.ReadValidatedDouble("Конец линии 2 - X: ", -1000, 1000, true);

        var line1 = new Line(new Point(line1x1, line1y1), new Point(line1x2, line1y2));
        var line2 = new Line(new Point(line2x1, line2y), new Point(line2x2, line2y));
        var line3 = new Line(line1.Start, line2.End);

        Console.WriteLine($"Линия 1: {line1}");
        Console.WriteLine($"Линия 2: {line2}");
        Console.WriteLine($"Линия 3: {line3}");

        Console.WriteLine("\nИзменение координат");
        bool changeLines = ConsoleValidator.ReadValidatedBoolean("Хотите изменить координаты линий 1 и 2?: ");

        if (changeLines)
        {
            double newLine1x1 = ConsoleValidator.ReadValidatedDouble("начало линии 1 - X: ", -1000, 1000, true);
            double newLine1y1 = ConsoleValidator.ReadValidatedDouble("начало линии 1 - Y: ", -1000, 1000, true);
            line1.Start = new Point(newLine1x1, newLine1y1);

            double newLine2x2 = ConsoleValidator.ReadValidatedDouble("конец линии 2 - X: ", -1000, 1000, true);
            double newLine2y2 = ConsoleValidator.ReadValidatedDouble("конец линии 2 - Y: ", -1000, 1000, true);
            line2.End = new Point(newLine2x2, newLine2y2);

            line3 = new Line(line1.Start, line2.End);

            Console.WriteLine($"Линия 1: {line1}");
            Console.WriteLine($"Линия 2: {line2}");
            Console.WriteLine($"Линия 3: {line3}");
        }
    }

    static void Task3()
    {
        Console.WriteLine("\n3.1");
        string studentName = ConsoleValidator.ReadValidatedString("Введите имя студента: ", 1, 50);

        int[] grades = ReadGradesFromConsole();

        var student1 = new Student(studentName, grades);

        string studentName2 = ConsoleValidator.ReadValidatedString("Введите имя 2-го студента: ", 1, 50);

        var student2 = new Student(studentName2, (int[])grades.Clone());
        if (grades.Length > 0)
        {
            student2.Grades[0] = 5;
        }

        string studentName3 = ConsoleValidator.ReadValidatedString("Введите имя 3-го студента: ", 1, 50);

        var student3 = new Student(studentName3, grades.ToArray());

        Console.WriteLine($"{student1}");
        Console.WriteLine($"{student2}");
        Console.WriteLine($"{student3}");
    }

    static void Task4()
    {
        Console.WriteLine("\n4.1");

        var point1 = ConsoleValidator.ReadValidatedPoint("Введите координаты точки 1: ");
        Console.WriteLine($"{point1}");

        var point2 = ConsoleValidator.ReadValidatedPoint("Введите координаты точки 2: ");
        Console.WriteLine($"{point2}");

        var point3 = ConsoleValidator.ReadValidatedPoint("Введите координаты точки 3: ");
        Console.WriteLine($"{point3}");

        Console.WriteLine("\n4.7");

        string studentName = ConsoleValidator.ReadValidatedString("Введите имя студента: ", 1, 50);
        int[] grades = ReadGradesFromConsole();
        var student1 = new Student(studentName, grades);

        string studentName2 = ConsoleValidator.ReadValidatedString("Введите имя 2-го студента: ", 1, 50);
        var student2 = new Student(studentName2);

        Console.WriteLine(student1);
        Console.WriteLine(student2);
    }

    static void Task5()
    {
        Console.WriteLine("\n5.6");

        string studentName = ConsoleValidator.ReadValidatedString("Введите имя студента: ", 1, 50);
        int[] grades = ReadGradesFromConsole();
        var student1 = new Student(studentName, grades);

        string studentName2 = ConsoleValidator.ReadValidatedString("Введите имя 2-го студента: ", 1, 50);
        int[] grades2 = ReadGradesFromConsole();
        var student2 = new Student(studentName2, grades2);

        Console.WriteLine($"{student1.Name}: Средний балл = {student1.AverageGrade:F2}, " + (student1.IsExcellent ? "отличник" : "не отличник"));
        Console.WriteLine($"{student2.Name}: Средний балл = {student2.AverageGrade:F2}, " + (student2.IsExcellent ? "отличник" : "не отличник"));
    }

    static int[] ReadGradesFromConsole()
    {
        while (true)
        {
            try
            {
                Console.Write("Введите оценки через пробел (1-5): ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    return new int[0];
                }

                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var grades = new List<int>();

                foreach (string part in parts)
                {
                    if (int.TryParse(part, out int grade) && grade >= 1 && grade <= 5)
                    {
                        grades.Add(grade);
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка: '{part}' не является допустимой оценкой (1-5). Попробуйте снова.");
                        throw new FormatException();
                    }
                }

                return grades.ToArray();
            }
            catch (FormatException)
            {
                Console.WriteLine("Пожалуйста, введите только числа от 1 до 5, разделенные пробелами.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}. Попробуйте снова.");
            }
        }
    }
}