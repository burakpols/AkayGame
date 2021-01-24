using System;
using System.Collections.Generic;
using System.Text;

namespace AkayGame
{
    class SellGameManagement
    {
        // Customer Info
        private string userName;
        private float wallet;
         
        // Game Info
        private string gameName;
        private float gamePrice;

        // Campaign Info
        private string campaignText;
        private float discountRate;

        public SellGameManagement(Users user, Games game, Campaign campaign)
        {
            userName = user.UserName;
            wallet = user.Wallet;
            gameName = game.GameName;
            gamePrice = game.GamePrice;
            campaignText = campaign.CampaignText;
            discountRate = campaign.DiscountRate;


        }

        public void Sell()
        {
            float newPrice = gamePrice * (discountRate / 100);
            if (wallet >= newPrice)
            {
                float newWallet = wallet - newPrice;
                Console.WriteLine("sayın {0}; {1} oyununu {2} TL yerine {3} TL karşılığında satın aldınız. " +
                    "Yararlandığınız kampanya: {4}\n Bakiyenizde kalan para: {5}\nİyi eğlenceler dileriz."
                    ,userName,gameName,gamePrice,newPrice,campaignText,newWallet);
            }
            else
            {
                Console.WriteLine("Yeterli bakiyeniz yok.");
            }

        }



    }
}
