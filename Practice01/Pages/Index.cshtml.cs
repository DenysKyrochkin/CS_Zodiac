using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practice01.Models;

namespace Practice01.Pages
{
    public class IndexModel : PageModel
    {
        public string Header { get; set; }
        public string Information { get; set; }
        DateTime today = DateTime.Today;

        public void OnGet()
        {
            Header = "Input date of your birtday!";
        }
        public void OnPost(DateTime date)
        {
            var years = Dates.GetAge(date);

            if (years < 0)
            {
                Header = "Hello, man from the future!";
                Information = $"Please, input correct date. (before {today.ToShortDateString()})";
            }

            else if (years > 135)
            {
                Header = "Hello, man from the afterlife!";
                Information = $"Please, input correct date. (after {today.Year - 135} year)";
            }

            else
            {
                Header = $"You are {years} years old.";

                if (Dates.Birthday(date))
                {
                    Header += " Happy birthday!";
                }

                Information = $"In western system your zodiac is {Zodiac.ZodiacWestern(date.Day, date.Month)} ";

                Information += $" and in chinese system your zodiac is {Zodiac.ZodiacChinese(date.Year)}.";
            }


        }
    }

}
