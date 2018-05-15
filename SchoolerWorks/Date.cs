namespace SchoolerWorks
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(string date)
        {
            char[] delimiterChars = { '/', '-', '.', ' ' };
            string[] parts = date.Split(delimiterChars);
            day = int.Parse(parts[0]);
            month = int.Parse(parts[1]);
            year = int.Parse(parts[2]);

        }

        public override string ToString()
        {
            return ((day < 10) ? "0" + day : day.ToString()) + "-" +((month < 10) ? "0" + month : month.ToString()) + "-" +year;
        }

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        

    }
}