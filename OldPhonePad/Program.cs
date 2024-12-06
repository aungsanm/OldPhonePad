using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(OldKeypadPhone.OldPadPhone("33#"));
        Console.WriteLine(OldKeypadPhone.OldPadPhone("227*#"));
        Console.WriteLine(OldKeypadPhone.OldPadPhone("4433555 555666#"));
        Console.WriteLine(OldKeypadPhone.OldPadPhone("8 88777444666* 664#"));

        string input = Console.ReadLine();

        string result = OldKeypadPhone.OldPadPhone(input);
    }
}