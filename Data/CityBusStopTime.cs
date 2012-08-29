using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBus.Data
{
    public class CityBusStopTime
    {
        public string RouteNumber
        {
            get;
            set;
        }
        
        public string RouteName
        {
            get;
            set;
        }

        public DateTime ArrivalTime
        {
            get;
            set;
        }

        public string FriendlyArrivalTime
        {
            get
            {
                int minutes = Convert.ToInt32((ArrivalTime - DateTime.UtcNow.AddHours(-5)).TotalMinutes);

                if (minutes < 0)
                    return "";
                else if (minutes == 0)
                    return "Boarding";
                else if (minutes == 1)
                    return "1 min";
                else if (minutes > 15)
                    return ArrivalTime.ToString("h:mm tt");
                else
                    return Convert.ToInt32((ArrivalTime - DateTime.UtcNow.AddHours(-5)).TotalMinutes) + " mins";
            }
        }

        public string CssClass
        {
            get
            {
                int minutes = Convert.ToInt32((ArrivalTime - DateTime.UtcNow.AddHours(-5)).TotalMinutes);

                if (minutes < 0)
                    return "white";
                else if (minutes <= 5)
                    return "red";
                else if (minutes <= 15)
                    return "yellow";
                else
                    return "white";
            }
        }
    }
}
