using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.Collections;
using BowmarPolls.App_Data;

namespace BowmarPolls
{
    [ServiceContract]
    public interface IBowmarPollService
    {

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetPoll/{serviceID}/{clientID}")]
        Poll GetPoll(string serviceID, string clientID);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Vote/{serviceID}/{clientID}/{choice}")]
        bool Vote(string serviceID, string clientID, string choice);
    }
}
