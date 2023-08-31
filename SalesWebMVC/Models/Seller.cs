using System.ComponentModel.DataAnnotations;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Nome obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Nome inválido!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} obrigatório")]
        [EmailAddress(ErrorMessage = "Insira um email válido")]
        public string Email { get; set; }
        [Display(Name = "Nascimento")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Data de nascimento obrigatório")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Salário")]
        [Required(ErrorMessage = "Salário obrigatório")]
        public double BaseSalary { get; set; }
        [Display(Name = "Departamento")]
        public Department? Department { get; set; }
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
