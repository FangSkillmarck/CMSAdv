using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Web;

namespace AlloyTraining.Business.Channels.PdfChannel
{
    public class PdfChannel : DisplayChannel
    {
        public override string ChannelName
        {
            get { return "PDF"; }
        }

        public override bool IsActive(HttpContextBase context)
        {
            if (context == null)
            {
                return false;
            }
            return context.Request.QueryString["pdf"] != null;
        }
    }
}