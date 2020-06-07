using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace WCF.MessageHeader.Client
{
    class MessageInspector : System.ServiceModel.Dispatcher.IClientMessageInspector
    {
        public static string CorrelationID { get; set; }
        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            var messageHeader = new MessageHeader<string>(CorrelationID);
            var untypedMessageHeader = messageHeader.GetUntypedHeader("SubscriptionID", "");
            request.Headers.Add(untypedMessageHeader);
            return null;
        }
    }
}
