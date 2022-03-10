using ExercisesOOP_S2W6.InClass;
using ExercisesOOP_S2W6.Question1;
using ExercisesOOP_S2W6.Question2;
using ExercisesOOP_S2W6.Question3;
using System;

namespace ExercisesOOP_S2W6
{

    class Program {      
        static void Main(string[] args)
        {
            Console.WriteLine("Exercises S2W6");
            Console.WriteLine("Question .1");
            Console.WriteLine("Question .2");
            Console.WriteLine("Question .3");
            Console.Write("Choose a question: ");
            int menuOpt = Convert.ToInt32(Console.ReadLine());
            switch (menuOpt)
            {
                case 1:
                    Square[] squares = new Square[10];
                    for (int i = 0; i < 10; i++)
                    {
                        squares[i] = new Square(i + 1);
                        Console.WriteLine($"Side: {squares[i].Side} | Area: {squares[i].Area}");
                    }
                    break;
                case 2:
                    TaxPayer[] payers = new TaxPayer[10];
                    for (int i = 0; i < payers.Length; i++)
                    {
                        payers[i] = new TaxPayer();
                        Console.WriteLine("Enter payer #{0} SSN", i + 1);
                        payers[i].SocialSecNumber = Console.ReadLine();
                        Console.WriteLine("Enter payer #{0} yearly income", i + 1);
                        payers[i].YearlyGrossIncome = double.Parse(Console.ReadLine());
                    }

                    for (int i = 0; i < payers.Length; i++)
                    {
                        Console.WriteLine($"Tax Payer #{i + 1}, SSN = {payers[i].SocialSecNumber}, Income = {payers[i].YearlyGrossIncome}, Tax Owed = {payers[i].TaxOwed}");
                    }
                    break;
                case 3:
                    Job j1 = new Job("wash windows", 5, 15);
                    Console.WriteLine("{0}, {1}, {2}, {3}", j1.JobDesc, j1.TimeToComplete, j1.HourlyRate, j1.TotalFee);
                    
                    Job j2 = new Job("take out trash", 2, 12.50);
                    Console.WriteLine("{0}, {1}, {2}, {3}", j2.JobDesc, j2.TimeToComplete, j2.HourlyRate, j2.TotalFee);

                    Job j3 = j1 + j2;
                    Console.WriteLine("{0}, {1}, {2}, {3}", j3.JobDesc, j3.TimeToComplete, j3.HourlyRate, j3.TotalFee);
                    break;
            }
        }
    }
}
