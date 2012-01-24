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
    public partial class Poll
    {
        [DataMember]
        public bool isResult { get; set; }
    }

    //public partial class PollElement
    //{
    //}
}

namespace BowmarPolls
{

    public class BowmarPollService : IBowmarPollService
    {

        public bool Vote(string serviceID, string clientID, string pollStr, string choiceStr)
        {
            BowmarPollsDataContext context = new BowmarPollsDataContext();

            Guid choice = new Guid(choiceStr);
            Guid poll = new Guid(pollStr);

            if (this.hasClientParticipated(context, poll, clientID))
                return false;

            var query = from element in context.PollElements
                        where element.id == choice
                        select element;

            foreach (PollElement element in query)
            {
                if (element.count == null)
                    element.count = 0;

                element.count++;
            }


                ClientParticipation cp = new ClientParticipation();
                cp.client_id = clientID;
                cp.poll_id = poll;
                context.ClientParticipations.InsertOnSubmit(cp);


            context.SubmitChanges();

            return true;
        }
        
        public Poll GetPoll(string serviceID, string clientID)
        {
            Poll poll;

            BowmarPollsDataContext context = new BowmarPollsDataContext();
            var dataOptions = new System.Data.Linq.DataLoadOptions();
            dataOptions.LoadWith<Poll>(Poll => Poll.PollElements);
            context.LoadOptions = dataOptions;

            Guid current_poll = this.getPollforService(context, serviceID);
            

            if (current_poll == null)
                return null;
            
            var result = from a in context.Polls
                         where a.id == current_poll
                         select a;

            poll = result.First();

            // check to see if client has participated, if so return results, if not don't
            bool participated = this.hasClientParticipated(context, current_poll, clientID);

            poll.isResult = participated;

            //if (!participated)
            //{
            //    poll.isResult = false;
            //    this.setClientAsParticipated(context, current_poll, clientID);
            //}

            return poll;

        }

        private bool hasClientParticipated(BowmarPollsDataContext context, Guid poll, string client)
        {

            var query = from p in context.ClientParticipations
                        where p.client_id == client
                        && p.poll_id == poll
                        select p;

            if (query.Count() == 0)
                return false;
            else
                return true;

        }

        private void setClientAsParticipated(BowmarPollsDataContext context, Guid poll, string client)
        {

            if (!this.hasClientParticipated(context, poll, client))
            {
                ClientParticipation cp = new ClientParticipation();
                cp.client_id = client;
                cp.poll_id = poll;
                context.ClientParticipations.InsertOnSubmit(cp);
                context.SubmitChanges();
            }
        }

        private Guid getPollforService(BowmarPollsDataContext context, string serviceID)
        {
 
            Guid serviceGuid = new Guid(serviceID);

            var query = from service in context.Services
                        where service.id == serviceGuid
                        select service;

            Service s = query.First();

            Guid rv = (Guid)s.current_poll;

            return rv;


        }


    }
}
