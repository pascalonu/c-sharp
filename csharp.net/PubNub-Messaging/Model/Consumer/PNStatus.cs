using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pubnub.Api.Enum;

namespace PubNubMessaging.Model.Consumer
{
    public class PNStatus
    {

        PNStatusCategory Category;
        PNErrorData ErrorData;
        bool Error;

        private int StatusCode;
        private PNOperationType Operation;
        private bool TLSEnabled;
        private string Uuid;
        private string AuthKey;
        private string Origin;
        private Object ClientRequest;

        // send back channel, channel groups that were affected by this operation
        List<string> AffectedChannels;
        List<string> AffectedChannelGroups;

        /*
        public void retry(){
            // TODO
        }
        public void cancelAutomaticRetry() {
            // TODO
        }
        */

    }
}
