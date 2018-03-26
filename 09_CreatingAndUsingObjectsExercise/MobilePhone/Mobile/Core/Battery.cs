using System;
using System.Text;

namespace MobilePhone.Mobile
{
    public class Battery
    {
        private string model;

        private int hourseIdle;
        private int hoursTalk;

        private BatteryTypes batteryType;

        public Battery()
        {
            this.model = null;
            this.hourseIdle = 0;
            this.hoursTalk = 0;
            this.batteryType = 0;
        }

        public Battery(string model)
            : this()
        {
            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("The battery model must be a valid string");
            }

            this.model = model;
        }

        public Battery(string model, int hourseIdle)
            : this(model)
        {
            ValidateBatteryValues(hourseIdle);

            this.hourseIdle = hourseIdle;
        }

        public Battery(string model, int hourseIdle, int hoursTalk)
            : this(model, hourseIdle)
        {
            ValidateBatteryValues(hoursTalk);

            this.hoursTalk = hoursTalk;
        }

        public Battery(string model, int hourseIdle, int hoursTalk, BatteryTypes batteryType)
            : this(model, hourseIdle, hoursTalk)
        {
            this.batteryType = batteryType;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public int HourseIdle
        {
            get
            {
                return this.hourseIdle;
            }
        }

        public int HourseTalk
        {
            get
            {
                return this.hoursTalk;
            }
        }

        public BatteryTypes BatteryTypes
        {
            get
            {
                return this.batteryType;
            }
        }

        public void AddTalkTime(int value)
        {
            ValidateBatteryValues(value);

            this.hoursTalk += value;
        }

        private void ValidateBatteryValues(int hourseIdle)
        {
            if (hourseIdle < 0)
            {
                throw new ArgumentException("Battery parameters can't be less then 0");
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"--Battery specifications--");
            result.AppendLine($"--Model : {this.Model}");
            result.AppendLine($"--Hourse Idle : {this.HourseIdle}");
            result.AppendLine($"--Hourse Talk : {this.HourseTalk}");
            result.AppendLine($"--Battery Type : {this.BatteryTypes}");

            return result.ToString();
        }
    }
}