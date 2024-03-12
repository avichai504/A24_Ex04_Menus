using Ex04.Menus.Delegates;
using System;

namespace Ex04.Menus.Test.Tests
{
    public class DelegateMenuTest
    {
        public void Show()
        {
            Menu mainMenu = new Menu("Delegate Test Menu");
            MenuItem dateTimeMenuItem = new MenuItem("Show Date/Time");
            dateTimeMenuItem.OnSelected += ShowDateOrTime;

            MenuItem versionAndDigitsMenuItem = new MenuItem("Version and Digits");
            versionAndDigitsMenuItem.OnSelected += ShowVersionAndDigits;

            mainMenu.AddMenuItem(dateTimeMenuItem);
            mainMenu.AddMenuItem(versionAndDigitsMenuItem);

            mainMenu.Show();
        }

        private void ShowDateOrTime()
        {
            Console.WriteLine("Choose an option:\n1. Show Date\n2. Show Time");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
                    break;
                case "2":
                    Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        private void ShowVersionAndDigits()
        {
            Console.WriteLine("Choose an option:\n1. Show Version\n2. Count Digits in a Number");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Version: 1.0");
                    break;
                case "2":
                    Console.WriteLine("Enter a number:");
                    string number = Console.ReadLine();
                    int digitCount = number.Length; // Simplified; doesn't account for decimal points or negatives
                    Console.WriteLine($"The number {number} has {digitCount} digits.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
