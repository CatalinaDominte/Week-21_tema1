using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Goat
    {
        public static string Latin(string s)
        {
            string[] integer = {"1","2","3","4","5","6","7","8","9"};
            foreach (var item in integer)
            {
                if (s.Contains(item))
                {
                    throw new FormatException("integer values are not supported");
                }
            }
           
            var words = s.Split(' ');
            StringBuilder sb = new StringBuilder();
            int count = 0;
            foreach (string w in words)
            {
                count++;
                
                if (
                    w[0] == 'a' || w[0] == 'e' || w[0] == 'i' || w[0] == 'o' || w[0] == 'u' ||
                    w[0] == 'A' || w[0] == 'E' || w[0] == 'I' || w[0] == 'O' || w[0] == 'U'
                  )
                {
                    sb.Append(w);
                }
                else
                {
                    for (int i = 1; i < w.Length; i++)
                    {
                        sb.Append(w[i]);
                    }
                    
                    sb.Append(w[0]);
                }
                sb.Append("ma");

                for (int i = 0; i < count; i++)
                    sb.Append('a');
                if (count < words.Length)
                    sb.Append(' ');
            }

            return sb.ToString();
        }
    }
}
