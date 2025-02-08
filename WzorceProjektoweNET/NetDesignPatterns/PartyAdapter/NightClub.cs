namespace PartyAdapter
{

    internal class NightClub
    {     
        public void letsParty(Client client)
        {
            
            if (client.checkIsAdult())
            {
                client.letsParty();
            }
            else
            {
                Console.WriteLine("Do domu młody");
            }
        }
    }
}
