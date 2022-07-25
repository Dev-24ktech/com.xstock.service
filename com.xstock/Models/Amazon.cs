using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sunco.Models
{
    public class Amazon
    {
        private int amaz_id;
        private string amaz_order;
        private string amaz_dte;
        private string amaz_status;
        private double amaz_amount;
        private string amaz_market;

        public Amazon()
        {
            //defalt
        }
        public Amazon(int amaz_id, string amaz_order, string amaz_dte="", string amaz_status="", double amaz_amount=0.0, string amaz_market="")
        {
            this.Amaz_id = amaz_id;
            this.Amaz_order = amaz_order;
            this.Amaz_dte = amaz_dte;
            this.Amaz_status = amaz_status;
            this.Amaz_amount = amaz_amount;
            this.Amaz_market = amaz_market;
        }
        public double Amaz_amount { get => amaz_amount; set => amaz_amount = value; }
        public string Amaz_order { get => amaz_order; set => amaz_order = value; }
        public string Amaz_status { get => amaz_status; set => amaz_status = value; }
        public string Amaz_market { get => amaz_market; set => amaz_market = value; }
        public string Amaz_dte { get => amaz_dte; set => amaz_dte = value; }
        public int Amaz_id { get => amaz_id; set => amaz_id = value; }
    }
}