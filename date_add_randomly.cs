  static void Main(string[] args)
        {
            string[] dates = {"10-Jan-2023 08:25:44 AM", "11-Jan-2023 01:40:39 PM", "13-Jan-2023 09:18:38 AM", "09-Jan-2023 09:52:37 AM", "09-Jan-2023 09:01:11 AM", "09-Jan-2023 11:01:14 AM", "09-Jan-2023 11:54:12 AM", "10-Jan-2023 01:27:52 PM", "13-Jan-2023 04:27:02 AM", "09-Jan-2023 11:46:04 PM", "10-Jan-2023 01:03:44 AM", "10-Jan-2023 06:00:51 AM", "10-Jan-2023 01:59:43 PM", "11-Jan-2023 04:00:43 AM", "11-Jan-2023 04:00:51 AM", "11-Jan-2023 05:00:52 AM", "09-Jan-2023 12:31:04 PM", "15-Jan-2023 03:31:59 AM", "15-Jan-2023 03:55:34 AM", "17-Jan-2023 08:26:59 AM", "17-Jan-2023 08:26:59 AM", "10-Jan-2023 08:47:14 AM", "13-Jan-2023 03:00:11 PM", "12-Jan-2023 09:24:31 PM", "17-Jan-2023 07:30:37 AM", "10-Jan-2023 11:26:21 AM", "09-Jan-2023 12:18:47 PM", "15-Jan-2023 05:20:12 AM", "17-Jan-2023 11:56:43 PM", "12-Jan-2023 04:45:23 AM", "09-Jan-2023 03:55:58 PM", "17-Jan-2023 02:15:39 PM", "09-Jan-2023 08:06:10 AM", "17-Jan-2023 08:16:53 AM", "17-Jan-2023 11:10:12 AM", "17-Jan-2023 11:21:25 AM", "17-Jan-2023 11:36:43 AM", "17-Jan-2023 08:30:53 PM", "13-Jan-2023 09:50:09 PM" };
            Random rand = new Random();
            for (int i = 0; i < dates.Length; i++)
            {
                DateTime originalDate = DateTime.ParseExact(dates[i], "dd-MMM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                int minutesToAdd = rand.Next(30, 241);  // generates a random number between 30 and 240
                DateTime newDate = originalDate.AddMinutes(minutesToAdd);
                dates[i] = newDate.ToString("dd-MMM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                Console.WriteLine(dates[i]);
            }
            Console.ReadLine();
        }
