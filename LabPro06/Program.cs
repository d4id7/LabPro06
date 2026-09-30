class Program {
    static void Main() {
        // PrintHeader();
        // PrintHeader();
        // System.Console.WriteLine("Основная часть программы");
        // PrintFooter();


        // PrintStudentCard("Иванов Иван", "ИСП-221", 2);
        // PrintStudentCard("Смирнова Анна", "ИСП-222", 2);


        // PrintPurchase("Ноутбук", 65000, true);
        // PrintPurchase("Мышь", 1200, false);


        // int sum = Add(15, 27);
        // System.Console.WriteLine($"Сумма: {sum}");

        // double area = CalculateRectangleArea(3.5, 4.2);
        // System.Console.WriteLine($"Площадь прямоугольника: {area}");

        // bool isAdult = IsAdult(20);
        // System.Console.WriteLine($"Совершеннолетний: {isAdult}");

        // System.Console.WriteLine();
        // System.Console.WriteLine($"5 + 10 = {Add(5, 10)}");
        // System.Console.WriteLine($"Площадь 2х2 больше площади 1х5: {CalculateRectangleArea(2, 2) > CalculateRectangleArea(1, 5)}");


        // System.Console.WriteLine(Add(2, 3));
        // System.Console.WriteLine(Add(2.5, 3.5));
        // System.Console.WriteLine(Add(2, 3, 4));


        // System.Console.WriteLine();
        // System.Console.WriteLine("Методы вызывают методы");
        // PrintNumberInfo(7);
        // PrintNumberInfo(10);
        // PrintNumberInfo(15);

        // System.Console.WriteLine();
        // System.Console.WriteLine("Методы + цикл");
        // for (int i = 1; i <= 5; i++) {
        //     PrintNumberInfo(i);
        // }


        System.Console.WriteLine("Задание 1. Конвертер единиц");
        Console.Write("Введите длину (в метрах): ");
        double meters = double.Parse(Console.ReadLine()!);
        Console.Write("Введите температуру (в градусах Цельсия): ");
        double celsius = double.Parse(Console.ReadLine()!);

        System.Console.WriteLine();
        System.Console.WriteLine($"{meters} м = {MetersToFeet(meters)} ft");
        System.Console.WriteLine($"{celsius}°C = {CelsiusToFahrenheit(celsius)}°F");
    }

    // void PrintHeader() {
    //     System.Console.WriteLine("^\\_^");
    //     System.Console.WriteLine("Лабораторная работа №6");
    //     System.Console.WriteLine("0\\_0");
    // }

    // void PrintFooter() {
    //     System.Console.WriteLine(">\\_<");
    //     System.Console.WriteLine("  Конец программы");
    //     System.Console.WriteLine("X\\_X");
    // }


    // void PrintStudentCard(string name, string group, int course) {
    //     System.Console.WriteLine($"Студент: {name}, группа {group}, курс {course}");
    // }


    // void PrintPurchase(string itemName, double price, bool hasDiscount) {
    //     string discountLabel = hasDiscount ? " (со скидкой)" : "";
    //     System.Console.WriteLine($"{itemName}: {price} руб.{discountLabel}");
    // }


    // int Add(int a, int b) {
    //     return a + b;
    // }

    // double CalculateRectangleArea(double width, double height) {
    //     return width * height;
    // }

    // bool IsAdult(int age) {
    //     return age >= 18;
    // }


    // static int Add(int a, int b) {
    //     return a + b;
    // }

    // static double Add(double a, double b) {
    //     return a + b;
    // }

    // static int Add(int a, int b, int c) {
    //     return a + b + c;
    // }


    // static bool isEven(int number) {
    //     return number % 2 == 0;
    // }

    // static void PrintNumberInfo(int number) {
    //     string parity = isEven(number) ? "чётное" : "нечётное";
    //     System.Console.WriteLine($"{number} - {parity} число");
    // }


    static double MetersToFeet(double meters) {
        return meters * 3.28084;
    }

    static double CelsiusToFahrenheit(double celsius) {
        return (celsius * 9 / 5) + 32;
    }
}
