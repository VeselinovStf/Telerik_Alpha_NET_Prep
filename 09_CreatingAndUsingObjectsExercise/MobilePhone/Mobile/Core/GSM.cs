using MobilePhone.Mobile.Actions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone.Mobile
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private static GSM iPhoneS;

        private List<Call> calls;

        public GSM(string model, string manufacturer)
        {
            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException($"You entered Model [{model}] but it must be a valid model name, not space or nothing!");
            }

            if (string.IsNullOrWhiteSpace(manufacturer))
            {
                throw new ArgumentException($"You entered Manufacturer [{manufacturer}] but it must be a valid manufacturer name, not space or nothing!");
            }

            this.model = model;
            this.manufacturer = manufacturer;
            this.price = 0;
            this.owner = null;
            this.battery = null;
            this.display = null;
            this.calls = new List<Call>();
        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            ChechPrice(price);

            this.price = price;
        }

        public GSM(string model, string manufacturer, string owner)
            : this(model, manufacturer)
        {
            CheckIfOwnerIsValidString(owner);

            this.owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price)
        {
            CheckIfOwnerIsValidString(owner);

            this.owner = owner;
        }

        public GSM(
            string model,
            string manufacturer,
            decimal price,
            string owner,
            Battery battery,
            Display display
            )
            : this(model, manufacturer, price, owner)
        {
            this.battery = battery;
            this.display = display;
        }

        static GSM()
        {
            iPhoneS = new GSM(
                "IPhoneS", "Apple", 1000M, "Pesho",
                new Battery("AppleBattery", 100, 24),
                new Display(20, 10));
        }

        public static GSM IPhoneS
        {
            get
            {
                return iPhoneS;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                ChechPrice(value);

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                CheckIfOwnerIsValidString(value);

                this.owner = value;
            }
        }

        public string Battery
        {
            get
            {
                return this.battery.ToString();
            }
        }

        public string Display
        {
            get
            {
                return this.display.ToString();
            }
        }

        public static void ChechPrice(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Price can't be bollow 0");
            }
        }

        public static void CheckIfOwnerIsValidString(string owner)
        {
            if (string.IsNullOrWhiteSpace(owner))
            {
                throw new ArgumentException($"You entered Owner [{owner}] but it must be a valid manufacturer name, not space or nothing!");
            }
        }

        public void AddCall(string phoneNumber, int duration)
        {
            Call singleCall = new Call(phoneNumber, duration);
            this.calls.Add(singleCall);
        }

        public void ViewCallHistory()
        {
            if (this.calls.Count > 0)
            {
                StringBuilder result = new StringBuilder();

                result.AppendLine("--Call History--");
                result.AppendLine("--Phone Number--Duration -- Date of Call");
                foreach (var call in this.calls)
                {
                    result.AppendLine($"----{call.PhoneNumber} -- {call.Duration} -- {call.Date.Date}");
                }

                Console.WriteLine(result.ToString());
            }
            else
            {
                Console.WriteLine("\nNo call history\n");
            }
        }

        public void DeleteCall(DateTime callToDelete)
        {
            int removedCalls;

            if (this.calls.Count > 0)
            {
                removedCalls = this.calls.RemoveAll(
                    delegate (Call c)
                    {
                        return c.Date == callToDelete;
                    });

                if (removedCalls > 0)
                {
                    Console.WriteLine("{0} calls removed", removedCalls);
                }
                else
                {
                    Console.WriteLine("Call not found");
                }
            }
            else
            {
                Console.WriteLine("\nNo call History\n");
            }
        }

        public void DeleteCall(string callToDelete)
        {
            int removedCalls;

            if (this.calls.Count > 0)
            {
                removedCalls = this.calls.RemoveAll(
                    delegate (Call c)
                    {
                        return c.PhoneNumber == callToDelete;
                    });

                if (removedCalls > 0)
                {
                    Console.WriteLine("{0} calls removed", removedCalls);
                }
                else
                {
                    Console.WriteLine("Call not found");
                }
            }
            else
            {
                Console.WriteLine("\nNo call History\n");
            }
        }

        public decimal CalculatePrice(decimal price)
        {
            decimal totalPrice = 0M;

            foreach (var call in calls)
            {
                totalPrice += call.Duration;
            }

            totalPrice = totalPrice / 60 * price;

            return totalPrice;
        }

        public void ClearCallHistory()
        {
            this.calls.Clear();

            Console.WriteLine("\nAll call history is cleared\n");
        }

        public decimal CalculateCallPrice(decimal priceForMinute)
        {
            int totalSecondsCalls = 0;

            foreach (var call in calls)
            {
                totalSecondsCalls += call.Duration;
            }

            decimal totalPrice = totalSecondsCalls * priceForMinute;

            return totalPrice;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"GSM INFO\n\r");
            result.AppendLine($"--Model : {this.Model}");
            result.AppendLine($"--Manufacturer : {this.Manufacturer}");
            result.AppendLine($"--Price : {this.Price}");
            result.AppendLine($"--Owner : {this.Owner}\n\r");
            result.AppendLine(this.Battery);
            result.AppendLine(this.Display);

            return result.ToString();
        }
    }
}