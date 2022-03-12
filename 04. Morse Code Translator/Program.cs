using System;
using System.Linq;
using System.Text;

namespace _04._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] morse = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < morse.Length; i++)
            {
                sb.Append(MorseToString(morse[i]));
            }
            Console.WriteLine(sb.ToString());
            static string MorseToString(string morse)
            {
                switch(morse)
                {
                    case ".-":
                        return "A";
                    case "-...":
                        return "B";
                    case "-.-.":
                        return "C";
                    case "-..":
                        return "D";
                    case ".":
                        return "E";
                    case "..-.":
                        return "F";
                    case "--.":
                        return "G";
                    case "....":
                        return "H";
                    case "..":
                        return "I";
                    case ".---":
                        return "J";
                    case "-.-":
                        return "K";
                    case ".-..":
                        return "L";
                    case "--":
                        return "M";
                    case "-.":
                        return "N";
                    case "---":
                        return "O";
                    case ".--.":
                        return "P";
                    case "--.-":
                        return "Q";
                    case ".-.":
                        return "R";
                    case "...":
                        return "S";
                    case "-":
                        return "T";
                    case "..-":
                        return "U";
                    case "...-":
                        return "V";
                    case ".--":
                        return "W";
                    case "-..-":
                        return "X";
                    case "-.--":
                        return "Y";
                    case "--..":
                        return "Z";
                    default:
                        return " ";
                }
            }
        }
    }
}
