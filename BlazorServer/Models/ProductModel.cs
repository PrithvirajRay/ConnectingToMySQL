using System.Collections.Generic;

namespace BlazorServer.Models
{
    public class ProductModel
    {
        List<BlazorServer.Models.ProductModel> product;
        public int product_id { get; set; }
        public string name { get; set; }
        public int quantity_in_stock { get; set; }
        public float unit_price { get; set; }
    }
}
