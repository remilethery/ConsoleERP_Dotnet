using Evaluation.Interface;
using System;

namespace Evaluation
{
    internal class UserEntry
    {
        internal static string GetAnswerString()
        {
            string myAnswer;
            Display.EntryQuestionString();
            myAnswer = Console.ReadLine();
            return myAnswer;
        }

        internal static int GetAnswerInt()
        {
            int myAnswer;
            do { Display.EntryQuestionInt(); }
            while (!int.TryParse(Console.ReadLine(), out myAnswer));
            return myAnswer;
        }

        internal static decimal GetAnswerDecimal()
        {
            decimal myAnswer;
            do { Display.EntryQuestionInt(); }
            while (!decimal.TryParse(Console.ReadLine(), out myAnswer));
            return myAnswer;

        }

        internal static uint GetAnswerUINT()
        {
            uint myAnswer;
            do { Display.EntryQuestionInt(); }
            while (!uint.TryParse(Console.ReadLine(), out myAnswer));
            return myAnswer;
        }
    }
}