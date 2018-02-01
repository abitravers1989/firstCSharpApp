using System;

namespace YagoSession1Practice
{
    class Program
    {
      public static void Main (string [] args)
        {
            Animal first = new Animal("cat", "poopie");
            var second = new Animal("dog");

            first.DescribeMe();
            second.DescribeMe();
            
            Questionaire firstq = new Questionaire("How are you?");

            firstq.AskQuestion();
            string answerInput = Console.ReadLine();

           firstq.OutputAnswer(answerInput);

            Console.ReadLine();
        }
    }
}
