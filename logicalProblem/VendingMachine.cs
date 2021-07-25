using System;
using System.Collections.Generic;
using System.Text;

namespace logicalProblem
{
    class VendingMachine
    {
        int moneyValue,noteNumber;
        int[] notes;
        public VendingMachine(int number)
        {
            this.moneyValue = number;
            this.noteNumber = 0;
            this.notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
        }
        public void MoneyNotes()
        {
            for(int i = 0; i < notes.Length && moneyValue>0; i++)
            {
                if (moneyValue / notes[i] > 0)
                {
                    noteNumber += moneyValue / notes[i];
                    moneyValue %= notes[i];
                }
            }
            Console.WriteLine("Number of notes: " + noteNumber);
        }
    }
}
