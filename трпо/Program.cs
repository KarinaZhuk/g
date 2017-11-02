using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace трпо
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("text.txt"))
            {
                
                    string a = sr.ReadToEnd();
                    Match match = Regex.Match(a, @"\d\d[.]\d\d[.]\d\d\d\d");
                    if (match.Success)
                    {
                        using (StreamWriter sn = new StreamWriter("text1.txt"))
                        {
                        sn.WriteLine(match.Captures[0].Value);
                        }
                    }
                    
                }
            }
        }
    }

