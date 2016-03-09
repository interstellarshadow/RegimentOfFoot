namespace RegimentOfFoot
{
    internal class Date
    {
        private int year, month, day;
        private DateRules dateRules;
    }

    internal class DateRules
    {
        private class LeapMonth
        {
        }

        private class LeapDay
        {
        }

        int startYear;
        int numMonths;
        int[] daysPerMonth;
        LeapDay leapDay;
        LeapMonth leapMonth;
    }
}