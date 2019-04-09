using System;
using ValidatorGuard.CustomExceptions;

namespace ValidatorGuard
{
    public static class Validator
    {
        public static void IsIntegerBiggerThanZero(int value)
        {
            if (value <= 0)
            {
                throw new LessThenZeroValueException("Value can't be 0 or less then zero !");
            }
        }

        public static void IsIntegerBiggerThanZero(int? value)
        {
            if (value <= 0)
            {
                throw new LessThenZeroValueException("Value can't be 0 or less then zero !");
            }
        }

        public static void IsStringNotNullOrWhiteSpace(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new StringIsNullOrWhiteSpaceException("String can't be null or white space");
            }
        }

        public static void IsDecimalBiggerThanZero(decimal value)
        {
            if (value <= 0)
            {
                throw new LessThenZeroValueException("Value can't be 0 or less then zero !");
            }
        }

        public static void IsDateNotBiggerThanCorrent(DateTime date)
        {
            if (date.Year <= DateTime.Now.Year)
            {
                throw new DateTimeIsOldException("Date can't be before today's date !");
            }
        }

        public static void IsObjectNull(object obj)
        {
            if (obj == null)
            {
                throw new ObjectNullException("Object can't be null !");
            }
        }
    }
}
