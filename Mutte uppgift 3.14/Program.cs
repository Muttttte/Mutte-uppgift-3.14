using System;

//Uppgift 3.14

public class Program
{
    public static void Main()
    {

        Console.WriteLine("har du gått ut gymnasiet? j/n ");
        string svar = Console.ReadLine().ToLower();
        Console.WriteLine("Hur gammal är du");
        int ålder = int.Parse(Console.ReadLine());
        if (svar == "j" && ålder <= 22 && ålder >= 19)
        {
            Console.WriteLine("vi vill gärna anställa dig  ");
        }

        else
        {
            Console.WriteLine("Vi letar tyvärr efter annan personal just nu. ");
        }




    }
}