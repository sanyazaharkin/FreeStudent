using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Models
{
    public enum FeeType {InDay, InWeek,InMounth, Once}
    public class Tariff : TableBase
    {
        public List<UserProfile> UserProfiles { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PerformerCommissionPercentage { get; set; }
        public int CustomerCommissionPercentage { get; set; }
        public int Price { get; set; }
        public FeeType SubscriptionFee { get; set; }

    }
}
