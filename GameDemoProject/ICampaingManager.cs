using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    interface ICampaingManager
    {
        void Add(Campaing campaing);
        void Delete(Campaing campaing);
        void Update(Campaing campaing);
    }
}
