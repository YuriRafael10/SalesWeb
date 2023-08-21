using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private readonly SalesWebMVCContext _context;
        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any()) { return; /* BD ja foi populado*/ }
            Department d1 = new Department(1, "Computador");
            Department d2 = new Department(2, "Eletrônicos");
            Department d3 = new Department(3, "Roupas");
            Department d4 = new Department(4, "Alimentos");
            Department d5 = new Department(5, "Móveis");

            Seller s1 = new Seller(1, "João", "joao@example.com", new DateTime(1990, 1, 15), 2000.0, d1);
            Seller s2 = new Seller(2, "Maria", "maria@example.com", new DateTime(1985, 5, 3), 2500.0, d2);
            Seller s3 = new Seller(3, "Pedro", "pedro@example.com", new DateTime(1992, 9, 20), 1800.0, d1);
            Seller s4 = new Seller(4, "Ana", "ana@example.com", new DateTime(1995, 3, 10), 2100.0, d3);
            Seller s5 = new Seller(5, "Luís", "luis@example.com", new DateTime(1988, 7, 8), 2200.0, d2);
            Seller s6 = new Seller(6, "Carla", "carla@example.com", new DateTime(1993, 11, 25), 1900.0, d1);
            Seller s7 = new Seller(7, "Rafael", "rafael@example.com", new DateTime(1986, 6, 17), 2400.0, d4);
            Seller s8 = new Seller(8, "Julia", "julia@example.com", new DateTime(1991, 8, 30), 2300.0, d5);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2023, 8, 10), 1500.0, SaleStatus.Faturado, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2023, 3, 12), 800.0, SaleStatus.Pendente, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2023, 5, 15), 300.0, SaleStatus.Cancelado, s1);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2023, 6, 18), 2000.0, SaleStatus.Faturado, s3);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2023, 10, 20), 500.0, SaleStatus.Faturado, s1);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2023, 8, 5), 700.0, SaleStatus.Pendente, s2);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2023, 8, 8), 1200.0, SaleStatus.Faturado, s3);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2023, 7, 23), 1800.0, SaleStatus.Faturado, s1);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2023, 1, 29), 1000.0, SaleStatus.Pendente, s4);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2023, 4, 14), 600.0, SaleStatus.Faturado, s5);
            SalesRecord sr11 = new SalesRecord(11, new DateTime(2023, 4, 17), 900.0, SaleStatus.Faturado, s6);
            SalesRecord sr12 = new SalesRecord(12, new DateTime(2023, 11, 22), 1100.0, SaleStatus.Cancelado, s7);
            SalesRecord sr13 = new SalesRecord(13, new DateTime(2023, 12, 7), 300.0, SaleStatus.Faturado, s8);
            SalesRecord sr14 = new SalesRecord(14, new DateTime(2023, 7, 25), 1400.0, SaleStatus.Faturado, s1);
            SalesRecord sr15 = new SalesRecord(15, new DateTime(2023, 9, 27), 1700.0, SaleStatus.Pendente, s2);
            SalesRecord sr16 = new SalesRecord(16, new DateTime(2023, 8, 15), 1200.0, SaleStatus.Faturado, s3);
            SalesRecord sr17 = new SalesRecord(17, new DateTime(2023, 6, 7), 900.0, SaleStatus.Pendente, s6);
            SalesRecord sr18 = new SalesRecord(18, new DateTime(2023, 4, 18), 1500.0, SaleStatus.Faturado, s2);
            SalesRecord sr19 = new SalesRecord(19, new DateTime(2023, 3, 29), 1800.0, SaleStatus.Faturado, s1);
            SalesRecord sr20 = new SalesRecord(20, new DateTime(2023, 5, 10), 600.0, SaleStatus.Cancelado, s3);
            SalesRecord sr21 = new SalesRecord(21, new DateTime(2023, 2, 21), 1700.0, SaleStatus.Faturado, s4);
            SalesRecord sr22 = new SalesRecord(22, new DateTime(2023, 10, 5), 1400.0, SaleStatus.Faturado, s5);
            SalesRecord sr23 = new SalesRecord(23, new DateTime(2023, 9, 14), 2000.0, SaleStatus.Pendente, s7);
            SalesRecord sr24 = new SalesRecord(24, new DateTime(2023, 7, 26), 800.0, SaleStatus.Faturado, s2);
            SalesRecord sr25 = new SalesRecord(25, new DateTime(2023, 1, 3), 300.0, SaleStatus.Faturado, s3);
            SalesRecord sr26 = new SalesRecord(26, new DateTime(2023, 12, 12), 1000.0, SaleStatus.Pendente, s1);
            SalesRecord sr27 = new SalesRecord(27, new DateTime(2023, 11, 9), 1300.0, SaleStatus.Faturado, s4);
            SalesRecord sr28 = new SalesRecord(28, new DateTime(2023, 8, 30), 700.0, SaleStatus.Faturado, s6);
            SalesRecord sr29 = new SalesRecord(29, new DateTime(2023, 6, 16), 1600.0, SaleStatus.Pendente, s8);
            SalesRecord sr30 = new SalesRecord(30, new DateTime(2023, 5, 24), 400.0, SaleStatus.Cancelado, s2);

            _context.Department.AddRange(d1, d2, d3, d4, d5);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6, s7, s8);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10,
    sr11, sr12, sr13, sr14, sr15, sr16, sr17, sr18, sr19, sr20,
    sr21, sr22, sr23, sr24, sr25, sr26, sr27, sr28, sr29, sr30);

            _context.SaveChanges();
        }

    }
}

