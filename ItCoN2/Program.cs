using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItCoN2
{
    internal class Program
    {
        static string[] MySplit(string str, char[] separators, bool withEmpty = false) // withEmpty указатель нужно ли выводить пустые строчки
        {
            var list = new List<string>();
            int start = -1, end = 0;
            string substr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (!separators.Contains(str[i]))
                    continue;
                end = i;
                substr = str.Substring(start + 1, end - start - 1);
                if (!withEmpty)
                {
                    // если опция без пустых строк то не копируем если строка пустая
                    if (!string.IsNullOrWhiteSpace(substr))
                        list.Add(substr);
                }
                else
                {
                    list.Add(substr);
                }

                start = end;
            }
            substr = str.Substring(end + 1, str.Length - end - 1);
            if (!withEmpty)
            {
                // если опция без пустых строк то не копируем если строка пустая
                if (!string.IsNullOrWhiteSpace(substr))
                    list.Add(substr);
            }
            else
            {
                list.Add(substr);
            }

            return list.ToArray();
        }
        static void Main(string[] args)
        {
            // в тз не указано что нужно написать вызовы к функции
        }
    }
}
