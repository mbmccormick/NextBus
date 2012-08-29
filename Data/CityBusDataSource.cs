using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;

namespace NextBus.Data
{
    public class CityBusDataSource
    {
        public ObservableCollection<CityBusStop> Stops()
        {
            ObservableCollection<CityBusStop> stops = new ObservableCollection<CityBusStop>();

            string line;
            StringReader reader = new StringReader(GTFS.Stops);

            while ((line = reader.ReadLine()) != null)
            {
                string[] fields = line.Split("\",\"".ToCharArray());

                CityBusStop stop = new CityBusStop();
                stop.ID = fields[1];
                stop.Name = fields[3];

                stops.Add(stop);
            }

            return stops;
        }

        public ObservableCollection<CityBusStopTime> StopTimes(CityBusStop stop)
        {
            WebClient client = new WebClient();
            string response = client.DownloadString(new System.Uri("http://myride.gocitybus.com/widget/Default1.aspx?pt=30&code=" + stop.ID));
            
            ObservableCollection<CityBusStopTime> stopTimes = new ObservableCollection<CityBusStopTime>();

            string line;
            StringReader reader = new StringReader(response);

            for (int i = 0; i < 5; i++) // skip ahead 5 lines
                reader.ReadLine();

            while ((line = reader.ReadLine()) != null)
            {
                string routeName = line.Replace("<RouteName>", "").Replace("</RouteName>", "").Trim();

                line = reader.ReadLine();
                string timeTillArrival = line.Replace("<TimeTillArrival>", "").Replace("</TimeTillArrival>", "").Trim();

                CityBusStopTime stopTime = new CityBusStopTime();
                stopTime.RouteNumber = routeName.Split(' ')[0].Trim();
                stopTime.RouteName = routeName.Replace(stopTime.RouteNumber, "").Trim();

                if (stopTime.RouteNumber.Length > 3)
                    stopTime.RouteNumber = stopTime.RouteNumber.Substring(0, 3);

                stopTime.RouteNumber = stopTime.RouteNumber.ToUpper();

                if (timeTillArrival == "DUE")
                {
                    stopTime.ArrivalTime = DateTime.UtcNow.AddHours(-5);
                }
                else
                {
                    stopTime.ArrivalTime = DateTime.UtcNow.AddHours(-5).AddMinutes(Convert.ToInt32(timeTillArrival.Replace("min", "")));
                }

                stopTimes.Add(stopTime);

                for (int i = 0; i < 2; i++) // skip ahead 2 lines
                    reader.ReadLine();
            }

            return stopTimes;
        }
    }
}
