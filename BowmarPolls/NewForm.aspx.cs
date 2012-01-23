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
            p.id = Guid.NewGuid().ToString();
            p.title = "My New Poll";

            PollElement pe = new PollElement();
            pe.id = Guid.NewGuid().ToString();
            pe.description = "Item 1";
            p.PollElements.Add(pe);

            pe = new PollElement();
            pe.id = Guid.NewGuid().ToString();
            pe.description = "Item 2";
            p.PollElements.Add(pe);

            pe = new PollElement();
            pe.id = Guid.NewGuid().ToString();
            pe.description = "Item 3";
            p.PollElements.Add(pe);

            pe = new PollElement();
            pe.id = Guid.NewGuid().ToString();
            pe.description = "Item 4";
            p.PollElements.Add(pe);

            //PollElement pe = PollElement.CreatePollElement(Guid.NewGuid().ToString(), "Item 1");
            //p.PollElements.Add(pe);
            //pe = PollElement.CreatePollElement(Guid.NewGuid().ToString(), "Item 2");
            //p.PollElements.Add(pe);
            //pe = PollElement.CreatePollElement(Guid.NewGuid().ToString(), "Item 3");

            //p.PollElements.Add(pe);

            //context.Polls.AddObject(p);

            context.SubmitChanges();

        }
    }
}