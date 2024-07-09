using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoForms;

namespace DemoForms.Data
{
    public class DemoFormsContext : DbContext
    {
        public DemoFormsContext (DbContextOptions<DemoFormsContext> options)
            : base(options)
        {
        }

        public DbSet<DemoForms.Form> Form { get; set; } = default!;
        public DbSet<DemoForms.FrmField> FrmFields { get; set; } = default!;
    }
}
