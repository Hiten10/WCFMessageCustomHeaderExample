using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web;

namespace WCF.MessageHeaders.Service
{
    public class ServiceMessageInspector : System.ServiceModel.Dispatcher.IDispatchMessageInspector
    {
        public object AfterReceiveRequest(ref Message request, IClientChannel channel, InstanceContext instanceContext)
        {
            if (request.Headers.FindHeader("SubscriptionID", "") == -1)
            {
                throw new FaultException("Subscription not found. Access Denied.");
            }

            //Utility.SubscriptionID = request.Headers.GetHeader<string>("SubscriptionID", "");
            Service1.CorrelationID = request.Headers.GetHeader<string>("SubscriptionID", ""); ;
            return instanceContext;
        }

        public void BeforeSendReply(ref Message reply, object correlationState)
        {
            
        }
    }
}