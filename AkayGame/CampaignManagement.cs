using System;
using System.Collections.Generic;
using System.Text;

namespace AkayGame
{
    class CampaignManagement : IProjectInterface
    {
        private string newCampaign;
        
        public CampaignManagement(Campaign campaign)
        {
            newCampaign = campaign.CampaignText;
        }
        public void Add()
        {
            Console.WriteLine(newCampaign+" yeni kampanya olarak eklendi.");
        }

        public void Delete()
        {
            Console.WriteLine("Kampanya kaldırıldı.");
        }

        public void Update()
        {
            Console.WriteLine("Kampanya "+newCampaign+" olarak güncellendi.");
        }
    }
}
