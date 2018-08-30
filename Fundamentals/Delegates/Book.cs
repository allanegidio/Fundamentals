namespace Fundamentals.Delegates
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
                    NameChanged(_name, value);

                _name = value;
            }
        }

        public NameChangedDelegate NameChanged;

        public Book()
        {
            _name = "Empty";
        }
    }
}
