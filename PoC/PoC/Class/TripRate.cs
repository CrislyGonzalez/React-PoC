using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoC.Class
{
    public class TripRate
    {
		static string[] week = new string[5] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

		public static bool isNY(string state)
		{
			if (state.Equals("New York"))
			{
				return true;
			}
			else { return false; }
		}

		public static bool IsNightSurcharge(string StartHour, string FinalHour)
		{
			DateTime Start = Convert.ToDateTime(StartHour);
			DateTime Finish = Convert.ToDateTime(FinalHour);

			if (((Start.Hour >= 20 && Start.Hour <= 24) || (Start.Hour >= 0 && Start.Hour <= 6)) && ((Start.Hour >= 20 && Start.Hour <= 24) || (Finish.Hour >= 0 && Finish.Hour <= 6)))
			{
				return true;
			}

			return false;

		}

		public static bool isTripOnWeek(string startDay)
		{
			DateTime day = Convert.ToDateTime(startDay);

			for (int i = 0; i < week.Length; i++)
			{

				if (week[i] == day.DayOfWeek.ToString())
				{
					return true;
				}
			}

			return false;
		}

		public static bool isPeakHour(string StartHour, string FinalHour)
		{

			DateTime Start = Convert.ToDateTime(StartHour);
			DateTime Finish = Convert.ToDateTime(FinalHour);
			bool tripOnWeek = isTripOnWeek(StartHour);

			if ((Start.Hour >= 16 && Start.Hour < 20) && (Finish.Hour >= 16 && Finish.Hour < 20) && tripOnWeek)
			{
				return true;
			}

			return false;
		}

		public static void startTrip(string StartHour, string FinalHour, string state)
		{
			double rate = 3;
			bool RateState = isNY(state);

			bool NightSurcharge = IsNightSurcharge(StartHour, FinalHour);
			bool PeakHour = isPeakHour(StartHour, FinalHour);


			if (NightSurcharge)
			{
				rate += 0.5;

				Console.WriteLine("NightSurcharge");
			}

			if (PeakHour)
			{
				rate += 1;

				Console.WriteLine("Peakhour");
			}

			if (RateState)
			{
				rate += 0.5;

				Console.WriteLine("l will go to NY");
			}

			Console.WriteLine("Rate:" + rate);

			Console.ReadKey();
		}
	}
}
