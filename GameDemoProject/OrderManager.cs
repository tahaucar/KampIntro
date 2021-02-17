using System;
using System.Collections.Generic;
using System.Text;
using ClassMetotDemo;

namespace GameDemoProject
{
    class OrderManager : IOrderManager

    {
        public bool Sales(Campaing campaing)
        {

            if (campaing.Id == 1 && campaing.CampaingName == "Muhteşem Kampanya" && campaing.RateOfCampaing == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
