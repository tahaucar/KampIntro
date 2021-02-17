using System;

namespace GameDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager= new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer{Id = 1, FirstName = "Zeynel Taha", LastName = "UÇAR", BirthYear = 1996, IdentityNumber = 13445313666});
            
            //CampaingManager campaingManager= new CampaingManager(new OrderManager());
            //campaingManager.Add(new Campaing{Id = 1, CampaingName = "Muhteşem kampanya", RateOfCampaing = 10});
        }
    }
}
