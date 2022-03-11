using System;
using System.Collections.Generic;

namespace BracketExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            const char BracketLeft = '(';
            const char BracketRight = ')';

            string userInput = Console.ReadLine();
            char[] charArray = userInput.ToCharArray();
            int maximumDepth = 0;
            bool isCorrect = true;

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] != BracketLeft && charArray[i] != BracketRight)
                {
                    isCorrect = false;
                }
            }

            if (isCorrect)
            {
                int tempMaximumLeftDepth = 0;
                int tempMaximumRightDepth = 0;

                for (int i = 0; i < charArray.Length; i++)
                {
                    switch (charArray[i])
                    {
                        case BracketLeft:
                            tempMaximumLeftDepth++;
                            tempMaximumRightDepth = 0;

                            if (tempMaximumLeftDepth > maximumDepth)
                            {
                                maximumDepth = tempMaximumLeftDepth;
                            }
                            break;
                        case BracketRight:
                            tempMaximumRightDepth++;
                            tempMaximumLeftDepth = 0;

                            if (tempMaximumRightDepth > maximumDepth)
                            {
                                maximumDepth = tempMaximumRightDepth;
                            }
                            break;
                    }
                }

                Console.WriteLine($"Максимальная глубина - {maximumDepth}");
            }
            else
            {
                Console.WriteLine("Строка не корректна");
            }

        }
    }
}