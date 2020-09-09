/*4. Подсчитать, сколько раз каждое слово
встречается в заданном тексте. Результат записать
в коллекцию Dictionary<TKey, TValue>.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_04
{
    class CountWords
    {
        private static Dictionary<string, int> text;
        public CountWords()
        {
            text = new Dictionary<string, int>();
        }
        public void AddWord(string word)
        {
            if (text.ContainsKey(word))
            {
                text[word] += 1;
            }
            else
            {
                text.Add(word, 1);
            }
        }
        public void PrintStats()
        {
            foreach (var word in text)
            {
                WriteLine("Слово - {0}, встречается - {1} раз.", word.Key, word.Value);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = { ' ', ',', '.', '!', '?' };
            string text = "Язык С# 6.0 представляет собой пятое крупное обновление флагманского языка программирования от Microsoft, которое превращает С# в язык с невероятной гибкостью и широтой применения. С одной стороны, он предлагает высокоуровневые абстракции, такие как выражения запросов и асинхронные продолжения, в то время как с другой обеспечивает  изкоуровневую эффективность через конструкции вроде специальных типов значений и дополнительное использование указателей. Эта книга предоставляет такие знания в сжатой и унифицированной форме, не утомляя беспорядочными и длинными введениями. Подобно трем предшествующим изданиям, книга организована вокруг концепций и сценариев использования, что делает ее пригодной как для последовательного чтения, так и для просмотра в произвольном порядке.";
            string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            CountWords textObject = new CountWords();
            foreach (string item in words)
            {
                textObject.AddWord(item);
            }
            textObject.PrintStats();
            ReadKey();
        }
    }
}
