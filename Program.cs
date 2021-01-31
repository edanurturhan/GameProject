using System;

namespace GameProject
{
    class Program
    {
        private static readonly Gamer gamer;

        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { IdentityNumber = 1, BirthYear = 1997, Firstname = "Edanur", Lastname = "Turhan", Id=1 });

            GamerManager gamerManager1 = new GamerManager(new UserValidationManager());
            gamerManager1.Add(new Gamer { IdentityNumber = 2, BirthYear = 1997, Firstname = "Esma", Lastname = "Altun", Id = 2});



            Campaign campaign = new Campaign { Id = 1, CampaignName = "Efsane Cuma", Detail = "sepette %70 indirim" };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
           

           
            Sale sale = new Sale { Id = 1, GameName = "GTA", Price = 200 };
            

            if (campaign != null)
            {
                ICampaignService discountCampaign = new DiscountCampaignManager();
                discountCampaign.Apply(campaign, sale);
            }
            else
            {
                SaleManager saleManager = new SaleManager();
                saleManager.Buy(sale, gamer);
            }
        }
    }
}
