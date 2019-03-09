using System;
using System.Windows.Media.Imaging;

namespace GuessThePattern.Model.Map
{
    public class Images
    {
        public static readonly BitmapImage AbstractFactory = new BitmapImage(new Uri(DefaultPath("AbstractFactory"), UriKind.Absolute));
        public static readonly BitmapImage Adapter = new BitmapImage(new Uri(DefaultPath("Adapter"), UriKind.Absolute));
        public static readonly BitmapImage Builder = new BitmapImage(new Uri(DefaultPath("Builder"), UriKind.Absolute));
        public static readonly BitmapImage Command = new BitmapImage(new Uri(DefaultPath("Command"), UriKind.Absolute));
        public static readonly BitmapImage Decorator = new BitmapImage(new Uri(DefaultPath("Decorator"), UriKind.Absolute));
        public static readonly BitmapImage FactoryMethod = new BitmapImage(new Uri(DefaultPath("FactoryMethod"), UriKind.Absolute));
        public static readonly BitmapImage Iterator = new BitmapImage(new Uri(DefaultPath("Iterator"), UriKind.Absolute));
        public static readonly BitmapImage Prototype = new BitmapImage(new Uri(DefaultPath("Prototype"), UriKind.Absolute));
        public static readonly BitmapImage Strategy = new BitmapImage(new Uri(DefaultPath("Strategy"), UriKind.Absolute));
        static string DefaultPath(string name)
        {
            return $"C:/Users/Konver/source/repos/GuessThePattern/GuessThePattern/Model/Map/Images/{name}.png";
        }
    }
}
