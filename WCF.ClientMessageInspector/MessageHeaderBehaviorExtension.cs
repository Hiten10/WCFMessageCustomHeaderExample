using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.MessageHeader.Client
{
    class MessageHeaderBehaviorExtension : System.ServiceModel.Configuration.BehaviorExtensionElement
    {
        public override Type BehaviorType { get { return typeof(MessageHeaderBehavior); } }

        protected override object CreateBehavior()
        {
            return new MessageHeaderBehavior();
        }
    }
}
