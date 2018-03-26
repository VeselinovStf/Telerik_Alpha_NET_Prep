using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneINfo
{
    public class Call
    {
        private DateTime dateOfCall;
        private int duration;

        public Call(DateTime dateOfCall, int duration)
        {
            this.dateOfCall = dateOfCall;

            if (duration < 0)
            {
                throw new ArgumentException("Call duration must be more the 0 seconds");
            }
            else
            {
                this.duration = duration;
            }
            
        }

        public DateTime DateOfCall { get => dateOfCall;  }
        public int Duration { get => duration; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("--Call history--");
            result.AppendLine($"Date of Call: {dateOfCall.ToString()}");
            result.AppendLine($"Durration: {duration} seconds");

            return result.ToString();
        }
    }
}
