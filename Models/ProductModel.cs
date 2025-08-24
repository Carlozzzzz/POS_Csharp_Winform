using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_V1.Models
{
    public class ProductModel
    {
        // fields for database
        private int id;
        private string product_name;
        private int category_id;
        private int supplier_id;
        private string barcode;
        private string description;
        private int cost_price;
        private int selling_price;
        private int stock_quantity;
        private int unit;
        private bool is_active;
        private bool is_deleted;
        private DateTime created_at;
        private DateTime updated_at;

        public int Id { get => id; set => id = value; }
        public string Product_name { get => product_name; set => product_name = value; }
        public int Category_id { get => category_id; set => category_id = value; }
        public int Supplier_id { get => supplier_id; set => supplier_id = value; }
        public string Barcode { get => barcode; set => barcode = value; }
        public string Description { get => description; set => description = value; }
        public int Cost_price { get => cost_price; set => cost_price = value; }
        public int Selling_price { get => selling_price; set => selling_price = value; }
        public int Stock_quantity { get => stock_quantity; set => stock_quantity = value; }
        public int Unit { get => unit; set => unit = value; }
        public bool Is_active { get => is_active; set => is_active = value; }
        public bool Is_deleted { get => is_deleted; set => is_deleted = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
    }
}
