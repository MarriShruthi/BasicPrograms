using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramDemo
{
    class ReplaceString
    {
        public static void ReadInput()
        {
            string template = "Hello <<UserName>>, How are you?";
            Console.WriteLine("please enter your name");
            string userInput = Console.ReadLine();
            ReplaceWord(template, userInput);
        }
        private static void ReplaceWord(string template, string userInput)
        {
            string result = template.Replace("<<UserName>>", userInput);
            Console.WriteLine("After done replace " + result);
        }
    }
}
