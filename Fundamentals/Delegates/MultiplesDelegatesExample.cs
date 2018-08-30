using System;

namespace Fundamentals.Delegates
{
    public class MultiplesDelegatesExample
    {
        public static void Start()
        {
            Lines.BeginDelegateExample();

            Book book = new Book();

            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged2;

            // book.NameChanged = null -> ITS A BIG PROBLEM!!!! CAN BE SOLVE BY EVENTS !!!!

            book.Name = "Allan";
            book.Name = "Egidio";

            Lines.EndLine();
        }

        private static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"Book changing name from {existingName} to {newName}");
        }
        private static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine($"****");
        }
    }
}
