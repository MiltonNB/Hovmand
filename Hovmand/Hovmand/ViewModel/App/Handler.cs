using System.Collections.Generic;
using Hovmand.Model.Domain;

namespace Hovmand.ViewModel.App
{
    public class Handler
    {
        // TODO - method types are temporary

        public List<Lead> GetLeads() //returns all leads from db
        {
            return null;
        }

        public void SelectLeads() //?
        {
            
        }

        public void SaveOffer(int leadID) //saves offer
        {

        }

        public Lead GetLeadByID(int ID) //returns lead details
        {
            return null;
        }

        public void EditLock(int ID) //locks lead for edit
        {
            
        }

        public void EditUnlock(int ID) //unlocks lead for edit
        {
            
        }

        private void SendEmail(string recipient) //sends email
        {
            
        }

        public void ChangeLeadStatus(int LeadID) //changes status on lead
        {
            
        }

        public string SaveConfirmation() //?
        {
            return null;
        }
    }
}