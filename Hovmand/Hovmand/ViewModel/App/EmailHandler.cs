namespace Hovmand.ViewModel.App
{
    public class EmailHandler
    {
        private void SendEmail(string recipient, User sender, int leadID) //sends email to recipient with lead details
        {
            var dbHandler = new DBHandler();
            var lead = dbHandler.GetLeadByID(leadID);
        }
    }
}