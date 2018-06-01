using System;

public class MainApp
{
    static public void Main (string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            string s = Console.ReadLine();
            Console.WriteLine("Hello " + s);
        }
    }
}
