/*
* Name: Nogaye Gueye
* email:  gueyene @mail.uc.edu
* Assignment Number: Final Project
* Due Date:  12/10/2024
* Course #/Section: IS3050
* Semester / Year: Fall 2024
* Brief Description of the assignment: Final project, which will contain multiple leet code 
* solutions. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalproject_cooperatingcrows
{
    public class gueyene
    {
        Console.WriteLine("Enter a string of parentheses:");
        string input = Console.ReadLine();

        Solution solution = new Solution();
        int result = solution.LongestValidParentheses(input);

        Console.WriteLine($"The length of the longest valid parentheses substring is: {result}");
    }
}

public class Solution
{
    public int LongestValidParentheses(string s)
    {
        Stack<int> st = new Stack<int>();
        st.Push(-1);
        int maxLen = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                st.Push(i);
            }
            else
            {
                st.Pop();
                if (st.Count == 0)
                {
                    st.Push(i);
                }
                else
                {
                    maxLen = Math.Max(maxLen, i - st.Peek());
                }
            }
        }

        return maxLen;
    }
}
}