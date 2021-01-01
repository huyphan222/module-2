using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorNextday
{
    public class NextDayCalculator
    {

        public string NextDay(int day, int month, int year)
        {
            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    if(day < 30 )
                    {
                        return $"{day + 1}/{month}/{year}";
                    }
                    else if(day == 30)
                    {
                        return $"1/{month + 1}/{year}";
                    }
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    if(day < 31)
                    {
                        return $"{day + 1}/{month}/{year}";
                    }
                    else if (day == 31)
                    {
                        return $"1/{month + 1}/{year}";
                    }
                    break;
                case 2:
                    if(IsLeapYear(year))
                    {
                        if (day == 29)
                        {
                            return $"1/3/{year}";
                        }
                        else if (day < 29)
                        {
                            return $"{day + 1}/{month}/{year}";
                        }
                    }
                    else
                    {
                        if (day == 28)
                        {
                            return $"1/3/{year}";
                        }
                        else if (day < 28)
                        {
                            return $"{day + 1}/{month}/{year}";
                        }

                    }
                    break;
                case 12:
                    if(day < 31)
                    {
                        return $"{day + 1}/{month}/{year}";
                    }
                    else if (day == 31)
                    {
                        return $"1/1/{year + 1}";
                    }
                    break;
            }
            return "ga`";
        }

       

        public bool IsLeapYear(int year)
        {

            bool isDivisibleBy4 = year % 4 == 0;
            if(isDivisibleBy4)
            {
                bool isDivisibleBy100 = year % 100 == 0;
                if(isDivisibleBy100)
                {
                    bool isDivisibleBy400 = year % 400 == 0;
                    if(isDivisibleBy400)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;           
            }
        }



    }
}
