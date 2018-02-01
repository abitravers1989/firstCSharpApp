using System;
using System.Collections.Generic;
using System.Text;

namespace YagoSession1Practice
{
    class Questionaire
    {
       // public string Answer { get; private set; }

        public string Question { get; private set; }

        public Questionaire(string question)
        {
            this.Question = question;
        }

        public void AskQuestion()
        {
            Console.WriteLine("Your Question is:" + question)
        }
    }
}


