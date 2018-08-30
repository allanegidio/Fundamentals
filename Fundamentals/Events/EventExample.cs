using System;

namespace Fundamentals.Events
{
    public class EventExample
    {
        public static void Start()
        {
            Lines.BeginEventExample();

            Book book = new Book();

            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged;
            book.NameChanged -= OnNameChanged;

            book.Name = "Allan";
            book.Name = "Egidio";

            Lines.EndLine();
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Book changing name from {args.ExistingName} to {args.NewName}");
        }
    }
}
