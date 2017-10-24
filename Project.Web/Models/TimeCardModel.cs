using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Web.Models
{
    public class TimeCardModel
    {
        public string UserName { get; set; }
        public string Project { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Notes { get; set; }

        public double difference(DateTime? endDate, DateTime startDate)
        {
            if(endDate != null)
            {
                return endDate.Value.Subtract(startDate).TotalHours;
            }
            else
            {
                return 0.0;
            }
        }
    }
}