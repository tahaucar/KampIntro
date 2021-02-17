using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new UserValidationService());
            gamerManager.Add(new Gamer { Id = 1, FirstName = "Zeynel Taha", LastName = "UÇAR", BirthYear = 1995, IdentityNumber = 113235664535 });

            CampaingManager campaingManager= new CampaingManager(new OrderManager());
            campaingManager.Add(new Campaing{Id = 1, CampaingName = "Muhteşem Kampanya", RateOfCampaing = 10});
        }
    }
}
