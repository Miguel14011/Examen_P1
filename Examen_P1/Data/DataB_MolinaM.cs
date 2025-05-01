using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Examen_P1.Models;

namespace Examen_P1
{
    public class DataB_MolinaM : DbContext
    {
        public DataB_MolinaM (DbContextOptions<DataB_MolinaM> options)
            : base(options)
        {
        }

        public DbSet<Examen_P1.Models.Cita> Cita { get; set; } = default!;
        public DbSet<Examen_P1.Models.Dueño> Dueño { get; set; } = default!;
        public DbSet<Examen_P1.Models.Mascota> Mascota { get; set; } = default!;
    }
}
