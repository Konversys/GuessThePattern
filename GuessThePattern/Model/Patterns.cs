using GuessThePattern.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessThePattern.Model.Map;
using Type = GuessThePattern.Model.Models.Type;

namespace GuessThePattern.Model
{
    class Patterns
    {
        public List<Pattern> patterns;
        static Random random;

        public Patterns()
        {
            random = new Random();
            InitDefault();
        }

        public void InitDefault()
        {
            patterns = new List<Pattern>();
            patterns.Add(new Pattern(Name.AbstractFactory, "Абстрактная фабрика", Code.AbstractFactory, Images.AbstractFactory, Type.Порождающий));
            patterns.Add(new Pattern(Name.Adapter, "Адаптер", Code.Adapter, Images.Adapter, Type.Структурный));
            patterns.Add(new Pattern(Name.Builder, "Строитель", Code.Builder, Images.Builder, Type.Порождающий));
            patterns.Add(new Pattern(Name.Command, "Команда", Code.Command, Images.Command, Type.Порождающий));
            patterns.Add(new Pattern(Name.Decorator, "Декоратор", Code.Decorator, Images.Decorator, Type.Структурный));
            patterns.Add(new Pattern(Name.FactoryMethod, "Фабричный метод", Code.FactoryMethod, Images.FactoryMethod, Type.Порождающий));
            patterns.Add(new Pattern(Name.Iterator, "Итератор", Code.Iterator, Images.Iterator, Type.Поведенческий));
            patterns.Add(new Pattern(Name.Prototype, "Прототип", Code.Prototype, Images.Prototype, Type.Структурный));
            patterns.Add(new Pattern(Name.Strategy, "Стратегия", Code.Strategy, Images.Strategy, Type.Поведенческий));
        }

        public List<Pattern> GetPatterns()
        {
            return patterns;
        }

        public Pattern GetPattern(Name name)
        {
            return patterns.Where(x => x.Name == name).ToList().First();
        }

        public Pattern[] GetRandom(int count = 4)
        {
            List<Pattern> list = patterns.ToArray().ToList();
            List<Pattern> result = new List<Pattern>();
            while (result.Count < count)
            {
                int index = random.Next(list.Count);
                result.Add(list.ElementAt(index));
                list.RemoveAt(index);
            }
            return result.ToArray();
        }
    }
}
