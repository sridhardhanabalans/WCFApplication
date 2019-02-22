using Assignment1_Section1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;


namespace ServiceHost.Models
{
    public class SayHelloProxy: ClientBase<ISayHello>, ISayHello
    {
        public string DoWork(string name)
        {
            return base.Channel.DoWork(name);
        }
    }
}