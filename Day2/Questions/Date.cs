using System;

namespace Questions;

public class Date
{
    int day, month, year;

    public Date(int d, int m, int y)
    {
        day = d;
        month = m;
        year = y;
    }

    bool IsLeapYear()
    {
        if (year % 400 == 0)
            return true;
        else if (year % 100 == 0)
            return false;
        else if (year % 4 == 0)
            return true;
        else
            return false;
    }

    public bool IsValidDate()
    {
        if (year <= 0)
            return false;

        if (month < 1 || month > 12)
            return false;

        if (month == 1 || month == 3 || month == 5 || month == 7 ||
            month == 8 || month == 10 || month == 12)
        {
            if (day >= 1 && day <= 31)
                return true;
            else
                return false;
        }
        else if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            if (day >= 1 && day <= 30)
                return true;
            else
                return false;
        }
        else if (month == 2)
        {
            if (IsLeapYear())
            {
                if (day >= 1 && day <= 29)
                    return true;
                else
                    return false;
            }
            else
            {
                if (day >= 1 && day <= 28)
                    return true;
                else
                    return false;
            }
        }

        return false;
    }
}
