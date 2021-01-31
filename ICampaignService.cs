using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(int Id);
        void Delete(int Id);
        void Apply(Campaign campaign, Sale sale);
    }
}
