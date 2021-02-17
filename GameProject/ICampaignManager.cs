using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignManager
    {
        void Add(Campaign campaing);
        void Delete(Campaign campaing);
        void Update(Campaign campaing);
    }
}

