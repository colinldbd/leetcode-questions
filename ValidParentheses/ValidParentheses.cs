using System.Reflection.Metadata.Ecma335;

namespace ValidParentheses
{
    internal class ValidParentheses
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool IsValid(string s)
        {
            Stack<char> chars = new Stack<char>();

            foreach (char c in s)
            {
                if (c == ')')
                {
                    if (chars.Count == 0) return false;
                    if (chars.Pop() != '(')
                    {
                        return false;
                    }
                }
                else if (c == ']')
                {
                    if (chars.Count == 0) return false;
                    if (chars.Pop() != '[')
                    {
                        return false;
                    }
                }
                else if (c == '}')
                {
                    if (chars.Count == 0) return false;
                    if (chars.Pop() != '{')
                    {
                        return false;
                    }
                }
                else
                {
                    chars.Push(c);
                }
            }
            if (chars.Count != 0)
            {
                return false;
            }

            return true;
        }
    }
}
