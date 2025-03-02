﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwedishLanguageProgram
{
    internal class Printer
    {
        private ConsoleColor defaultTextColor = ConsoleColor.White;

        public void Reset()
        {
            Console.ForegroundColor = defaultTextColor;
        }

        public void PrintPageTitle(string title)
        {
            Console.Clear();
            Console.ForegroundColor = defaultTextColor;
            Console.WriteLine($"===== {title.ToUpper()} =====");
        }

        public void PrintChapterTitle(string chapterName)
        {
            PrintContinueConfirmation();
            Console.Clear();
            Console.ForegroundColor = defaultTextColor;
            Console.WriteLine($"===== KAPITEL {chapterName} =====");
        }

        public void PrintProblemSetTitle(string problemSetTitle)
        {
            PrintContinueConfirmation();
            Console.Clear();
            Console.ForegroundColor = defaultTextColor;
            Console.WriteLine($"[Uppgift {problemSetTitle}]");
        }

        public void PrintWordList(List<string> wordList)
        {
            PrintContinueConfirmation();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < wordList.Count; i++)
            {
                if (i != 0 && i % 5 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write($"{String.Format("{0,-15}", wordList[i])}\t");
            }
            Console.WriteLine();
        }

        public void PrintQuestion(string question)
        {
            Console.ForegroundColor = defaultTextColor;
            Console.Write($"\n{question}     ");
        }

        public void PrintProblemSetSummary(int correct, int total)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nSammanfattning: {correct} / {total}.");
        }

        public void PrintCorrectAnswer(string answer)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PrintAnswer(answer);
        }

        public void PrintIncorrectAnswer(string answer)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            PrintAnswer(answer);
        }

        public void PrintAnswer(string answer)
        {
            Console.WriteLine($"{answer}");
        }

        public void PrintWarning(string warning)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(warning);
        }

        public void PrintInfo(string info)
        {
            Console.ForegroundColor = defaultTextColor;
            Console.WriteLine(info);
        }

        public void PrintContinueConfirmation()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nTryck ENTER för att fortsätta.\n");
            Console.ReadLine();
        }
    }
}
