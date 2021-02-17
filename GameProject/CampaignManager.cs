using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignManager
    {

        private IOrderManager _orderManager;

        public CampaignManager(IOrderManager orderManager)
        {
            _orderManager = orderManager;
        }

        public void Add(Campaign campaing)
        {
            if (_orderManager.Sales(campaing) == true)
            {
                Console.WriteLine("Kampanya eklendi");
            }
            else
            {
                Console.WriteLine("Kampanya bulunamadı");
            }
        }

        public void Delete(Campaign campaing)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Campaign campaing)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
