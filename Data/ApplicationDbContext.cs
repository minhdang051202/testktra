using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NMD_2021050190.Models;

namespace YourNamespce
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NMD_2021050190.Models.LopHoc> LopHoc { get; set; } = default!;
        public DbSet<NMD_2021050190.Models.SinhVien> SinhVien { get; set; } = default!;
    }
}
