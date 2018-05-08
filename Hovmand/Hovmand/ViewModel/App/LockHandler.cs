using System;
using System.Collections.Generic;
using Hovmand.Model.Domain;

namespace Hovmand.ViewModel.App
{
    public class LockHandler
    {
        public void LockLead(int leadID) //locks lead for edit
        {
            var dbHandler = new DBHandler();
            var lead = dbHandler.GetLeadByID(leadID);

            //Todo- Lock for edit
        }

        public void ReleaseLock(int leadID) //unlocks lead for edit
        {
            var dbHandler = new DBHandler();
            var lead = dbHandler.GetLeadByID(leadID);

            //Todo- Release lock
        }
    }
}