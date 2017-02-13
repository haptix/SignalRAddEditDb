using Microsoft.AspNet.SignalR;
using SignalRWebApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SignalRWebApp.Repository
{
    public class DevTestRepo
    {
        public IEnumerable<DevTestModel> GetData()
        {

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(@"SELECT *  FROM [dbo].[DevTest]", connection))
                {
                    // Make sure the command object does not already have
                    // a notification object associated with it.
                    command.Notification = null;

                    SqlDependency dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    using (var reader = command.ExecuteReader())
                        return reader.Cast<IDataRecord>()
                            .Select(x => new DevTestModel()
                            {
                                ID = x.GetInt32(0),
                                CampaignName = x.GetString(1),
                                Date = x.GetDateTime(2),
                                Clicks = x.GetInt32(3),
                                Impressions = x.GetInt32(4),
                                AffiliateName = x.GetString(5)
                            }).ToList();



                }
            }
        }
        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            DevTestHub.Show();
        }
    }
}