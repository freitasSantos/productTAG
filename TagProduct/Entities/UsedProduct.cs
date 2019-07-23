using System;
using System.Globalization;


namespace TagProduct.Entities {
    class UsedProduct: Product {
        public DateTime ManufacturaDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price,DateTime manufactureDate) : base(name, price) {
            ManufacturaDate = manufactureDate;
        }

        public override string PriceTag() {
            return Name + " (Used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) +
                   " (Manufacture date: " + ManufacturaDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
