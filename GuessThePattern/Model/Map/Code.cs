using System.IO;

namespace GuessThePattern.Model.Map
{
    public class Code
    {
        public static readonly string AbstractFactory = ReadFile("AbstractFactory");
        public static readonly string Adapter = ReadFile("Adapter");
        public static readonly string Builder = ReadFile("Builder");
        public static readonly string Command = ReadFile("Command");
        public static readonly string Decorator = ReadFile("Decorator");
        public static readonly string FactoryMethod = ReadFile("FactoryMethod");
        public static readonly string Iterator = ReadFile("Iterator");
        public static readonly string Prototype = ReadFile("Prototype");
        public static readonly string Strategy = ReadFile("Strategy");

        static string ReadFile(string pattern, string path = @"D:\ASTU\8s\ВиТПО\L3\GuessThePattern\GuessThePattern\Model\Map\Codes.txt")
        {
            string data = null;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                data = sr.ReadToEnd();
            }
            string[] codes = data.Split('%');
            for (int i = 0; i < codes.Length; i++)
            {
                if (codes[i] == pattern)
                {
                    return codes[i + 1];
                }
            }
            return null;
        }
    }
}
