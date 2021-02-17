using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaingManager
    {
        void Add(Campaing campaing);
        void Delete(Campaing campaing);
        void Update(Campaing campaing);
    }
}

