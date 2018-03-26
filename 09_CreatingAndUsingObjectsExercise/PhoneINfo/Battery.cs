using System.Text;

namespace PhoneINfo
{
    public class Battery
    {
        private string model;
        private int idleTime;
        private int hourseTalk;
        private BatteryType batteryType;

        public int HourseTalk { get => hourseTalk; }
        public int IdleTime { get => idleTime;}
        public string Model { get => model; }
        public BatteryType BatteryType { get => batteryType;}

        public Battery()
        {
            this.model = null;
            this.idleTime = 0;
            this.hourseTalk = 0;
            this.batteryType = 0;
        }

        public Battery(string model)
            : this()
        {
            this.model = model;
        }

        public Battery(string model, int idleTime)
            :this(model)
        {
            this.idleTime = idleTime;
        }

        public Battery(string model, int idleTime, int hourseTalk)
            : this(model, idleTime)
        {
            this.hourseTalk = hourseTalk;
        }

        public Battery(string model, int idleTime, int hourseTalk, BatteryType batteryType)
           : this(model, idleTime,hourseTalk)
        {
            this.batteryType = batteryType;
        }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("-----------------");
            result.AppendLine($"\tBattery Info");
            result.AppendLine($"Model : {this.Model}");
            result.AppendLine($"Idle Time {this.IdleTime}");
            result.AppendLine($"Hourse Talk {this.HourseTalk}");
            result.AppendLine($"Battery Type {this.BatteryType}");
            result.AppendLine("-----------------");

            return result.ToString();
        }
    }
}