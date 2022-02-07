using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class  Activity
    {
        public Guid Id { get; set; }
        public int Level { get; set; }
        public bool IsPremium { get; set; }
        public int GlobalRankPLace { get; set; }
    }
}