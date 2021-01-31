using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya kaydı yapıldı.");
        }

        public void Apply(Campaign campaign, Sale sale)
        {
            Console.WriteLine(campaign.CampaignName+ ""+ "kampanyası uygulandı.");
        }

        public void Delete(int Id)
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void Update(int Id)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
