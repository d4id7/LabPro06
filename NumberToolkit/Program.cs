class NumberToolkit {
    static void Main() {
        System.Console.WriteLine("Набор утилит для чисел");

        Console.Write("Введите первое число: ");
        string input1 = Console.ReadLine()!;
        Console.Write("Введите второе число: ");
        string input2 = Console.ReadLine()!;
        Console.Write("Введите третье число: ");
        string input3 = Console.ReadLine()!;

        bool isRight1 = int.TryParse(input1, out int number1);
        bool isRight2 = int.TryParse(input2, out int number2);
        bool isRight3 = int.TryParse(input3, out int number3);

        System.Console.WriteLine();
        if (isRight1 && isRight2 && isRight3) {
            System.Console.WriteLine($"{number1} простое: {IsPrime(number1)}");
            System.Console.WriteLine($"{number2} простое: {IsPrime(number2)}");
            System.Console.WriteLine($"{number3} простое: {IsPrime(number3)}");

            System.Console.WriteLine();
            System.Console.WriteLine($"Максимум из трёх чисел: {FindMax(number1, number2, number3)}");
            System.Console.WriteLine($"Максимум из первых двух: {FindMax(number1, number2)}");

            System.Console.WriteLine();
            System.Console.WriteLine($"Среднее арифметическое: {CalculateAverage(number1, number2, number3)}");
        }
        else {
            System.Console.WriteLine("Некорректный ввод");
        }
    }

    static bool IsPrime(int number) {
        for (int i = 2; i < number; i++) {
            if (number % i == 0) return false;
        }
        return true;
    }

    static int FindMax(int a, int b) {
        int max;
        if (a > b) {
            max = a;
        }
        else {
            max = b;
        }
        return max;
    }

    static int FindMax(int a, int b, int c) {
        int max = FindMax(a, b);
        if (max > c) {
            return max;
        }
        return c;
    }

    static double CalculateAverage(int a, int b, int c) {
        return ((double)a + b + c) / 3;
    }
}