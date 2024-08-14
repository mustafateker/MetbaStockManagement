using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetbStockKontrol
{
    internal class product
    {
        private int id;
        private String productType;
        private bool status;
        private String productCode;
        private String barkod;
        private float heavy;
        private float width;
        private float height;
        private String gtin;
        private String gtip;
        private String mpn;
        private String productName;
        private String categorie;
        private int stock;
        private int criticalStock;
        private String currency;
        private int KDV;
        private String brand;
        private float listPrice;
        private float discountedPrice;


        public int Id { get => id; set => id = value; }
        public string ProductType { get => productType; set => productType = value; }
        public bool Status { get => status; set => status = value; }
        public string ProductCode { get => productCode; set => productCode = value; }
        public string Barkod { get => barkod; set => barkod = value; }
        public float Heavy { get => heavy; set => heavy = value; }
        public float Width { get => width; set => width = value; }
        public float Height { get => height; set => height = value; }
        public string Gtin { get => gtin; set => gtin = value; }
        public string Gtip { get => gtip; set => gtip = value; }
        public string Mpn { get => mpn; set => mpn = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public int Stock { get => stock; set => stock = value; }
        public int CriticalStock { get => criticalStock; set => criticalStock = value; }
        public string Currency { get => currency; set => currency = value; }
        public int KDV1 { get => KDV; set => KDV = value; }
        public string Brand { get => brand; set => brand = value; }
        public float ListPrice { get => listPrice; set => listPrice = value; }
        public float DiscountedPrice { get => discountedPrice; set => discountedPrice = value; }
    }
}
