
using Microsoft.Win32;
using System;

class Program
{
    static void Main()
    {
        var subKeyNames = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");

        Console.WriteLine(subKeyNames);
        string[] valueNames = subKeyNames.GetValueNames();
        foreach (var item in valueNames)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}