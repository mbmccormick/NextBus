using NextBus.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NextBus
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // initialize data source
            CityBusDataSource dataSource = new CityBusDataSource();

            // fetch current stop
            CityBusStop currentStop;
            if (Request.QueryString["stop"] != null)
                currentStop = dataSource.Stops().SingleOrDefault(z => z.ID == Request.QueryString["stop"].ToUpper());
            else
                currentStop = dataSource.Stops().SingleOrDefault(z => z.ID == "BUS271");

            this.Page.Title = "NextBus - " + currentStop.Name;

            this.lblStopName.Text = currentStop.Name;

            this.lstStopTimes.DataSource = dataSource.StopTimes(currentStop);
            this.lstStopTimes.DataBind();
        }
    }
}