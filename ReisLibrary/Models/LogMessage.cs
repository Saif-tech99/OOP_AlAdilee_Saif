using System;

namespace ReisLibrary.Models
{
    public class LogMessage
    {
        private string Boodschap { get; set; }
        private int ID { get; set; }

        public int GenerrerID()
        {
            Random random = new Random();
            int Id = random.Next(10000, 99999);
            this.ID = Id;
            return ID;
        }

        public LogMessage(string boodschap)
        {
             boodschap = "this is your ID number : ";
            this.Boodschap = boodschap;
            this.ID = GenerrerID();
        }
    }
}
