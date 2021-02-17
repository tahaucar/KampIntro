using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderManager
    {
        public bool Sales(Campaign campaign)
        {

            if (campaign.Id == 1 && campaign.CampaignName == "Muhteşem Kampanya" && campaign.RateOfCampaign == 10)
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
