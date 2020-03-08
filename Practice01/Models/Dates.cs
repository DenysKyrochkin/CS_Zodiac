using System;
namespace Practice01.Models
{
    public class Dates
    {
        static DateTime today  = DateTime.Today;

        public static int GetAge(DateTime birthDate)
        {
            return today.Year - birthDate.Year - 1 +
                ((today.Month > birthDate.Month || today.Month == birthDate.Month && today.Day >= birthDate.Day) ? 1 : 0);
        }

        public static bool Birthday(DateTime date)
        {
            if (today.Month == date.Month && today.Day == date.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

    
