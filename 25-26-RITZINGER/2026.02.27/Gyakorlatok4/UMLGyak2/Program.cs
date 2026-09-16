namespace UMLGyak2
{

    public class MyTime
    {
        private int hour = 0;
        private int minute = 0;
        private int second = 0;

        // ------------------------------- //

        public MyTime()
        {

        }

        public MyTime(int hour, int minute, int second)
        {

            //validate hour
            if (hour >= 0 && hour < 30)
            {
                this.hour = hour;
            }
            else
            {
                throw new ArgumentException("Invalid Hour value");
            }

            //validate minute
            if (minute >= 0 && minute < 60)
            {
                this.minute = minute;
            }
            else
            {
                throw new ArgumentException("Invalid Minute value");
            }

            //validate second
            if (second >= 0 && second < 60)
            {
                this.second = second;
            }
            else
            {
                throw new ArgumentException("Invalid Second value");
            }


            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public void setTime(int hour, int minute, int second)
        {
            //validate hour
            if (hour >= 0 && hour < 30)
            {
                this.hour = hour;
            }
            else
            {
                throw new ArgumentException("Invalid Hour value");
            }
            //validate minute
            if (minute >= 0 && minute < 60)
            {
                this.minute = minute;
            }
            else
            {
                throw new ArgumentException("Invalid Minute value");
            }
            //validate second
            if (second >= 0 && second < 60)
            {
                this.second = second;
            }
            else
            {
                throw new ArgumentException("Invalid Second value");
            }

            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public int getHour()
        {
            return this.hour;

        }

        public int getMinute()
        {
            return this.minute;
        }

        public int getSecond()
        {
            return this.second;
        }

        public void setHour(int hour)
        {
            this.hour = hour;
        }

        public void setMinute(int minute)
        {
            this.minute = minute;
        }

        public void setSecend(int secend)
        {
            this.second = secend;
        }

        public override string ToString()
        {
            string strHour;
            string strMinute;
            string strSecond;
            //adjunk hozzá egy vezető 0 karaktert
            if (this.hour >= 0 && this.hour < 10)
                strHour = "0" + this.hour;
            else
                strHour = "" + this.hour;

            if(this.minute >= 0 && this.minute < 10)
            {
                strMinute = "0" + this.minute;
            }
            else
                strMinute = "" + this.minute;

            if(this.second >= 0 && this.second < 10)
            {
                strSecond = "0" + this.second;
            }
            else
                strSecond = "" + this.second;

            return strHour + " : " + strMinute + " : " + strSecond;
        }

        public MyTime nextSecound()
        {
            MyTime retTime = new MyTime();
            retTime.setSecend(this.second + 1);
            return retTime;
        }

        public MyTime nextHour()
        {
            MyTime retTime = new MyTime();
            retTime.setHour (this.hour+1);
            return retTime;
        }

        public MyTime nextMinute()
        {
            MyTime retTime = new MyTime();
            retTime.setMinute(this.minute+1);
            return retTime;
        }

        public MyTime previosSecound()
        {
            MyTime retTime = new MyTime();
            retTime.setSecend(this.second - 1);
            return retTime;
        }

        public MyTime previosHour()
        {
            MyTime retTime = new MyTime();
            retTime.setHour(this.hour - 1);
            return retTime;
        }

        public MyTime previosMinute()
        {
            MyTime retTime = new MyTime();
            retTime.setMinute(this.minute - 1);
            return retTime;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyTime time1 = new MyTime();
            time1.setTime(22, 0, 59);
            MyTime time2 = new MyTime(02,23,33);

            Console.WriteLine("Az első idő érték: " + time1);
            Console.WriteLine("A második idő érték " + time2);
            
        }
    }
}
