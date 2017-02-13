﻿using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRWebApp.Repository
{
    public class DevTestHub : Hub
    {
        public static void Show()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<DevTestHub>();
            context.Clients.All.displayStatus();
        }
    }
}