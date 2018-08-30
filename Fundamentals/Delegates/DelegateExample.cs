using System;

namespace Fundamentals.Delegates
{
    public static class DelegateExample
    {
        public static void Start()
        {
            Lines.BeginDelegateExample();

            Book book = new Book();

            book.NameChanged = OnNameChanged;
            book.Name = "Allan";

            Lines.EndLine();
        }

        private static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"Book changing name from {existingName} to {newName}");
        }
    }
}
