using System;
using System.Collections.Generic;

namespace AkayGame
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Users user1 = new Users();
            user1.Id = 1;
            user1.UserName = "cyberkonn";
            user1.Password = "12345";
            user1.Wallet = 250;
            

            UserManagement userManage = new UserManagement(user1);
            //userManage.Add();
            //userManage.Delete();
            userManage.Update();

            Games game1 = new Games();
            game1.GameId = 1;
            game1.GameName = "Assassins creed";
            game1.GamePrice = 199;

            Campaign campaign = new Campaign();
            campaign.CampaignText = "Şimdi tüm oyunlarda %50 indirim!";
            campaign.DiscountRate = 50;

            CampaignManagement campaignManagement = new CampaignManagement(campaign);
            campaignManagement.Add();
            //campaignManagement.Delete();
            //campaignManagement.Update();

            SellGameManagement sellGame = new SellGameManagement(user1, game1, campaign);
            sellGame.Sell();
            
        }
    }
}
