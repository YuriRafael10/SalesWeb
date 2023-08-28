using System.ComponentModel.DataAnnotations;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Name { get; set; }
        public string Email { get; set; }
        [Display(Name = "Nascimento")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Salário")]
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSeller(SalesRecord SalesRecord)
        {
            Sales.Add(SalesRecord);
        }
        public void RemoveSeller(SalesRecord SalesRecord)
        {
            Sales.Remove(SalesRecord);
        }
        public double TotalSales(DateTime Initial, DateTime Final)
        {
            return Sales.Where(SalesRecord => SalesRecord.Date >= Initial && SalesRecord.Date <= Final).Sum(SalesRecord => SalesRecord.Amount);
        }
    }
}
