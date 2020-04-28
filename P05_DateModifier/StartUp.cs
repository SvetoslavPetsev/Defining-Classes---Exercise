namespace DefiningClasses
{
    using System;
    using System.Linq;

    public class StartUp
    {

        public static void Main(string[] args)
        {
            DateTime[] time = new DateTime[2];

            for (int i = 0; i < 2; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int day = input[0];
                int month = input[1];
                int year = input[2];
                DateTime date = new DateTime(day,month,year);
                time[i] = date;
            }

            DateModifier modifier = new DateModifier(time[0], time[1]);
            int dayes = Math.Abs(modifier.GetDayes());
            Console.WriteLine(dayes);

        }
    }
}
