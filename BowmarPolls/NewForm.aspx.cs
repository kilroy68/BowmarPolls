using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BowmarPolls.App_Data;

namespace BowmarPolls
{
    public partial class NewForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateNewPoll_Click(object sender, EventArgs e)
        {

            BowmarPollsDataContext context = new BowmarPollsDataContext();

            Poll p = new Poll();
            p.id = Guid.NewGuid();
            p.title = poll_title.Text;

            PollElement pe;
            String choice;

            for (int i = 1; i < 8; i++)
            {
                choice = "";
                switch (i)
                {
                    case 1:
                        choice = Choice1.Text;
                        break;
                    case 2:
                        choice = Choice2.Text;
                        break;
                    case 3:
                        choice = Choice3.Text;
                        break;
                    case 4:
                        choice = Choice4.Text;
                        break;
                    case 5:
                        choice = Choice5.Text;
                        break;
                    case 6:
                        choice = Choice6.Text;
                        break;
                    case 7:
                        choice = Choice7.Text;
                        break;
                       
                }

                if (!String.IsNullOrEmpty(choice))
                {
                    pe = new PollElement();
                    pe.id = Guid.NewGuid();
                    pe.description = choice;
                    //pe.poll_id = p.id;
                    p.PollElements.Add(pe);
                }

            }

            context.Polls.InsertOnSubmit(p);

            // set the current poll for the selected service
            String serviceGuidStr = RadioButtonList1.SelectedValue;
            Guid serviceGuid = new Guid(serviceGuidStr);

            var query = from service in context.Services
                        where service.id == serviceGuid
                        select service;

            foreach (Service service in query)
            {
                service.current_poll = p.id;
            }

            context.SubmitChanges();
        }
    }
}