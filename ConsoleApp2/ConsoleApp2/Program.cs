using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== برنامه جمع دو عدد ===");

        // دریافت عدد اول
        Console.Write("عدد اول را وارد کنید: ");
        string input1 = Console.ReadLine();

        // دریافت عدد دوم
        Console.Write("عدد دوم را وارد کنید: ");
        string input2 = Console.ReadLine();

        // تبدیل ورودی‌ها به عدد و کنترل خطا
        if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
        {
            double sum = number1 + number2;
            Console.WriteLine($"\nنتیجه جمع {number1} و {number2} برابر است با: {sum:N2}");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n⚠️ خطا: لطفاً فقط عدد وارد کنید (از کاراکترهای غیرعددی استفاده نکنید).");
            Console.ResetColor();
        }

        Console.WriteLine("\nبرای خروج کلیدی را فشار دهید...");
        Console.ReadKey();
    }
}
