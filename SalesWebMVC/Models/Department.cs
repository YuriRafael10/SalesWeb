using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;
using System.Xml.Linq;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
        public Department() { }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AddSellers(Seller seller)
        {
            Sellers.Add(seller);
        }
        public double TotalSales(DateTime Initial, DateTime Final)
        {
            return Sellers.Sum(seller => seller.TotalSales(Initial, Final));
        }
    }
}
