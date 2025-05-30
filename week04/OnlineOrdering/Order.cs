using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineOrdering
{
    public class Order
    {
        private Customer _customer;
        private List<Product> _products = new List<Product>();

        public Order(Customer customer)
        {
            _customer = customer;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal CalculateTotalPrice()
        {
            var productsTotal = _products.Sum(p => p.GetTotalCost());
            var shipping = _customer.IsInUSA() ? 5m : 35m;
            return productsTotal + shipping;
        }

        public string GetPackingLabel()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Packing Label:");
            foreach (var p in _products)
            {
                sb.AppendLine($"  - {p.PackingInfo}");
            }
            return sb.ToString();
        }

        public string GetShippingLabel()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Shipping Label:");
            sb.AppendLine(_customer.Name);
            sb.AppendLine(_customer.Address.ToString());
            return sb.ToString();
        }
    }
}
