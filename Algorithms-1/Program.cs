using System;
using System.Text;

namespace Algorithms
{
    class Program
    {

        static String ReverseEachWord(String input) {
            if (string.IsNullOrEmpty(input)) {
                return input;
            }
           
            StringBuilder output = new StringBuilder();
            String[] arr = input.Split(" ");
            for (int i = 0; i < arr.Length; i++) {
                output.Append(Reverse(arr[i]));
                if (i != arr.Length - 1) {
                    output.Append(" ");
                }
            }

            return output.ToString();
        }

        static String Reverse(String input) {
            if (string.IsNullOrEmpty(input)) {
                return input;
            }

            else{
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
            }
        }

        static void Main(string[] args) {
            Console.WriteLine(ReverseEachWord("Taylor is a great worker"));
            Console.WriteLine(ReverseEachWord(null));
            Console.WriteLine(ReverseEachWord("racer racecar madam"));
            Console.WriteLine(ReverseEachWord("what can I do today"));
            Console.WriteLine(ReverseEachWord(" "));
        }
    }
}