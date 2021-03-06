﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class RPN
    {
        static private bool IsDelimeter(char c)
        {
            if ((" =".IndexOf(c) != -1))
                return true;
            return false;
        }
        static private bool IsOperator(char с)
        {
            if (("+-/*".IndexOf(с) != -1))
                return true;
            return false;
        }
        static private byte GetPriority(char s)
        {
            switch (s)
            {
                case '+': return 2;
                case '-': return 3;
                case '*': return 4;
                case '/': return 4;
                default: return 6;
            }
        }
        static public int Calculate(string input)
        {
            string output = GetExpression(input);
            int result = Counting(output);
            return result;
        }
        static private string GetExpression(string input)
        {
            string output = string.Empty;
            Stack<char> operStack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {

                if (IsDelimeter(input[i]))
                    continue;
                if (Char.IsDigit(input[i]))
                {

                    while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                    {
                        output += input[i];
                        i++;

                        if (i == input.Length) break;
                    }
                    output += " ";
                    i--;
                }

                if (IsOperator(input[i]))
                {
                    if (operStack.Count > 0)
                        if (GetPriority(input[i]) <= GetPriority(operStack.Peek()))
                            output += operStack.Pop().ToString() + " ";
                    operStack.Push(char.Parse(input[i].ToString()));
                }
            }


            while (operStack.Count > 0)
                output += operStack.Pop() + " ";
            return output;
        }
        static private int Counting(string input)
        {
            int result = 0;
            Stack<int> temp = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {

                if (Char.IsDigit(input[i]))
                {
                    string a = string.Empty;

                    while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                    {
                        a += input[i];
                        i++;
                        if (i == input.Length) break;
                    }
                    temp.Push(int.Parse(a));
                    i--;
                }
                else if (IsOperator(input[i]))
                {

                    int a = temp.Pop();
                    int b = temp.Pop();

                    switch (input[i])
                    {
                        case '+': result = b + a; break;
                        case '-': result = b - a; break;
                        case '*': result = b * a; break;
                        case '/': result = b / a; break;
                    }
                    temp.Push(result);
                }
            }
            return temp.Peek();
        }
    }
}
