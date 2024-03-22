namespace calculator_for_translation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите направление перевода:");
            Console.WriteLine("1. Из десятичной в двоичную");
            Console.WriteLine("2. Из двоичной в десятичную");
            Console.WriteLine("3. Из десятичной в шестнадцатеричную");
            Console.WriteLine("4. Из шестнадцатеричной в десятичную");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DecimalToBinary();
                    break;
                case 2:
                    BinaryToDecimal();
                    break;
                case 3:
                    DecimalToHexadecimal();
                    break;
                case 4:
                    HexadecimalToDecimal();
                    break;
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }
        }

        static void DecimalToBinary()
        {
            Console.WriteLine("Введите десятичное число:");
            int decimalNum = int.Parse(Console.ReadLine());

            string binaryNum = Convert.ToString(decimalNum, 2);

            Console.WriteLine("Результат перевода: " + binaryNum);
        }

        static void BinaryToDecimal()
        {
            Console.WriteLine("Введите двоичное число:");
            string binaryNum = Console.ReadLine();

            int decimalNum = Convert.ToInt32(binaryNum, 2);

            Console.WriteLine("Результат перевода: " + decimalNum);
        }

        static void DecimalToHexadecimal()
        {
            Console.WriteLine("Введите десятичное число:");
            int decimalNum = int.Parse(Console.ReadLine());

            string hexadecimalNum = Convert.ToString(decimalNum, 16);

            Console.WriteLine("Результат перевода: " + hexadecimalNum);
        }

        static void HexadecimalToDecimal()
        {
            Console.WriteLine("Введите шестнадцатеричное число:");
            string hexadecimalNum = Console.ReadLine();

            int decimalNum = Convert.ToInt32(hexadecimalNum, 16);

            Console.WriteLine("Результат перевода: " + decimalNum);
        }
    }
}
