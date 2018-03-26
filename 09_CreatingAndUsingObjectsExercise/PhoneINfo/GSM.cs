using System.Text;

namespace PhoneINfo
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;

        public static GSM IPhone4S = new GSM(
           "IPhone4S",
           "Apple",
           1000M,
           "Pesho",
           new Battery(
               "IBatt",100,0,BatteryType.Li_Ion
               ),
           new Display(
               10,23455
               ));

        public string Model { get => model;  }
        public string Manufacturer { get => manufacturer; }
        public decimal Price { get => price;  }
        public string Owner { get => owner; }
        public Battery Battery { get => battery; }
        public Display Display { get => display;  }

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = 0;
            this.owner = null;
            this.battery = null;
            this.display = null;
          
        }

        public GSM(
            string model,
            string manufacturer,
            decimal price
            )
            :this(model,manufacturer)
        {
            this.price = price;
        }

        public GSM(
            string model,
            string manufacturer,
            decimal price,
            string owner
            )
            : this(model, manufacturer,price)
        {
            this.owner = owner;
        }

        public GSM(
           string model,
           string manufacturer,
           decimal price,
           string owner,
           Battery battery
           )
           : this(model, manufacturer, price, owner)
        {
            this.battery = battery;
        }

        public GSM(
           string model,
           string manufacturer,
           decimal price,
           string owner,
           Battery battery,
           Display display
           )
           : this(model, manufacturer, price, owner,battery)
        {
            this.display = display;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("-----------------");
            result.AppendLine($"GSM Info");
            result.AppendLine($"Model : {this.Model}");
            result.AppendLine($"Manufacturer {this.Manufacturer}");
            result.AppendLine($"Price {this.Price}");
            result.AppendLine($"Owner {this.Owner}");
            result.AppendLine(this.Battery.ToString());
            result.AppendLine(this.Display.ToString());
            result.AppendLine("-----------------");
            
            return result.ToString();
        }


    }
}
