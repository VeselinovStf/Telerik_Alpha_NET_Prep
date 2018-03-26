using System;

namespace MobilePhone.Mobile.Actions
{
    public class Call
    {
        private string phoneNumber;
        private int duration;
        private DateTime date;

        public Call(string phoneNumber, int duration)
        {
            this.phoneNumber = phoneNumber;
            this.duration = duration;
            this.date = DateTime.Now;
        }

        public string PhoneNumber { get => phoneNumber; }
        public int Duration { get => duration; }
        public DateTime Date { get => date; }
    }
}