class Program {
    static void Main() {
        System.Console.WriteLine("Валидатор с вложенными методами");
        Console.Write("Введите пароль: ");
        string password = Console.ReadLine()!;

        System.Console.WriteLine($"Пароль подходит: {IsPasswordValid(password)}");

    }

    static bool HasMinLength(string password, int minLength) {
        return password.Length >= minLength;
    }

    static bool HasDigit(string password) {
        foreach (char letter in password) {
            if (char.IsDigit(letter)) {
                return true;
            }
        }
        return false;
    }

    static bool HasUpperCase(string password) {
        foreach (char letter in password) {
            if (char.IsUpper(letter)) {
                return true;
            }
        }
        return false;
    }

    static bool IsPasswordValid(string password) {
        System.Console.WriteLine($"Пароль не короче 8 символов: {HasMinLength(password, 8)}");
        System.Console.WriteLine($"Пароль содержит хотя бы одну цифру: {HasDigit(password)}");
        System.Console.WriteLine($"Пароль содержит хотя бы одну заглавную букву: {HasUpperCase(password)}");

        if (HasMinLength(password, 8) && HasDigit(password) && HasUpperCase(password)) {
            return true;
        }
        return false;
    }
}