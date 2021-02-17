using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
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
