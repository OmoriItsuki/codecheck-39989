using System;

public class MainApp
{
    static public void Main (string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
           string output = String.Format("argv[{0}]: {1}", i, args[i]);
           string s = Console.ReadLine();
           Console.WriteLine("Hello " + s);
        }
    }
}
