using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pubnub.Api.Enum
{
    public enum PNStatusCategory
    {

        PNUnknownCategory,
        PNAcknowledgmentCategory,
        PNAccessDeniedCategory,
        PNTimeoutCategory,
        PNNetworkIssuesCategory,
        PNConnectedCategory,
        PNReconnectedCategory,
        PNDisconnectedCategory,
        PNUnexpectedDisconnectCategory,
        PNCancelledCategory,
        PNBadRequestCategory,
        PNMalformedFilterExpressionCategory,
        PNMalformedResponseCategory,
        PNDecryptionErrorCategory,
        PNTLSConnectionFailedCategory,
        PNTLSUntrustedCertificateCategory,

    }
}
