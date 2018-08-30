namespace Fundamentals.Events
{
    public class Book
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;

                    NameChanged(this, args);
                }
                    

                _name = value;
            }
        }

        public event NameChangedEvent NameChanged;

        public Book()
        {
            _name = "Empty";
        }
    }
}
