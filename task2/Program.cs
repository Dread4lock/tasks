using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string trimmed = text.Trim();
            string[] words = trimmed.Split(' ');
            string wordWithMaxLength = "";
            for (int i = 0; i < words.Length; i++) 
                if (words[i].Length > wordWithMaxLength.Length)
                {
                    wordWithMaxLength = words[i];
                }
            int maxLenght = wordWithMaxLength.Length;
            string symbol = "_";
            for (int i = 0; i < words.Length; i++)
            {
                int diff = maxLenght - words[i].Length;
                for (int j = 0; j < diff; j++)
                {
                    words[i] = symbol + words[i];
                }
            }
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            string dot = ".";
            string[] DotArr = new string[10];
            DotArr[0] = dot;
            DotArr[1] = dot + dot;
            DotArr[2] = dot + dot + dot;
            DotArr[3] = dot + dot + dot + dot;
            DotArr[4] = dot + dot + dot + dot + dot;
            DotArr[5] = dot + dot + dot + dot + dot + dot;
            DotArr[6] = dot + dot + dot + dot + dot + dot + dot;
            DotArr[7] = dot + dot + dot + dot + dot + dot + dot + dot;
            DotArr[8] = dot + dot + dot + dot + dot + dot + dot + dot + dot;
            DotArr[9] = dot + dot + dot + dot + dot + dot + dot + dot + dot + dot;

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                    {
                        if (pairs.ContainsKey(words[i]))
                        {
                            if (pairs[words[i]] == DotArr[0])//2 points
                            {
                                pairs[words[i]] = DotArr[1];
                                break;
                            }
                            if (pairs[words[i]] == DotArr[1])//3
                            {
                                pairs[words[i]] = DotArr[2];
                                break;
                            }
                            if (pairs[words[i]] == DotArr[2])//4
                            {
                                pairs[words[i]] = DotArr[3];
                                break;
                            }
                            if (pairs[words[i]] == DotArr[3])//5
                            {
                                pairs[words[i]] = DotArr[4];
                                break;
                            }
                            if (pairs[words[i]] == DotArr[4])//5
                            {
                                pairs[words[i]] = DotArr[5];
                                break;
                            }
                            if (pairs[words[i]] == DotArr[5])//6
                            {
                                pairs[words[i]] = DotArr[6];
                                break;
                            }
                            if (pairs[words[i]] == DotArr[6])//7
                            {
                                pairs[words[i]] = DotArr[7];
                                break;
                            }
                            if (pairs[words[i]] == DotArr[7])//8
                            {
                                pairs[words[i]] = DotArr[8];
                                break;
                            }
                            if (pairs[words[i]] == DotArr[8])//9
                            {
                                pairs[words[i]] = DotArr[9];
                                break;
                            }
                            if (pairs[words[i]] == DotArr[9])//10
                            {

                            }
                        }
                        else
                        {
                            pairs.Add(words[i], DotArr[0]);//1
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                PrintDesc(i);
            }
            void PrintDesc(int count)
            {
                foreach (var item in pairs)
                {
                    if (item.Value == DotArr[count])
                    {
                        Console.WriteLine(item.Key + " " + item.Value);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
