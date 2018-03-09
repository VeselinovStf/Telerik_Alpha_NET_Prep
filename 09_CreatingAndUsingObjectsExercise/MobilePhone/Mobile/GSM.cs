using System;
using System.Text;

namespace MobilePhone.Mobile
{
    public class GSM
    {
        private string model;
        private string manufacturer;

        private decimal price;
        private string owner;

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
        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            ChechPrice(price);

            this.price = price;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price)
        {
            CheckIfOwnerIsValidString(owner);

            this.owner = owner;
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

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat($"GSM model : {this.Model} , manufacturer : {this.Manufacturer}");

            return result.ToString();
        }
    }
}