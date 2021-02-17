using System;
using System.Collections.Generic;
using System.Text;
using ClassMetotDemo;

namespace GameDemoProject
{
    class CampaingManager : ICampaingManager
    {
        private IOrderManager _orderManager;

        public CampaingManager(IOrderManager orderManager)
        {
            _orderManager = orderManager;
        }

        public void Add(Campaing campaing)
        {
            if (_orderManager.Sales(campaing)==true)
            {
                Console.WriteLine("Kampanya eklendi");
            }
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
