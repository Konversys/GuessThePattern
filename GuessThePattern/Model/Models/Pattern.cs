using System.Windows.Media.Imaging;

namespace GuessThePattern.Model.Models
{
    public class Pattern
    {
        public Pattern(Name name, string title, string code, BitmapImage uml, Type type)
        {
            Name = name;
            Title = title;
            Code = code;
            UML = uml;
            Type = type;
        }

        public Name Name { get; private set; }
        public string Title { get; private set; }
        public string Code { get; private set; }
        public BitmapImage UML { get; private set; }
        public Type Type { get; private set; }
    }
}
