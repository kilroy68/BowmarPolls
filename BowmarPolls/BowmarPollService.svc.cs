using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Collections;
using BowmarPolls.App_Data;

namespace BowmarPolls.App_Data
{
    //public partial class Poll
    //{
    //    [DataMember]
    //    public bool isResult { get; set; }
    //}

    //public partial class PollElement
    //{
    //}
}

namespace BowmarPolls
{

    public class BowmarPollService : IBowmarPollService
    {

        
        public Poll GetPoll(string serviceID, string clientID)
        {
            Poll poll;

            BowmarPolls.App_Data.BowmarPollsDataContext context = new App_Data.BowmarPollsDataContext();

            var dataOptions = new System.Data.Linq.DataLoadOptions();
            dataOptions.LoadWith<Poll>(Poll => Poll.PollElements);
            context.LoadOptions = dataOptions;
            
            var result = from a in context.Polls
                         where a.id == "c57b79a8-ea4e-4b6a-82c4-4f3fea54ca49"
                         select a;

            poll = result.First();

            
            return poll;

        }

        public bool Vote(string serviceID, string clientID, string choice)
        {

            return true;
        }
    }
}
