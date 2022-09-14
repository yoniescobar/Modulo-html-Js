using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6C_Forms.Data
{
    public class Northwinds: DbContext
    {
        //invocamos las tablas que utilizaremos
        public DbSet<Shippers>? Shippers { get; set; }

        //para conexión
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string strConexion = "Data Source=MSI; Initial Catalog = Northwind; Integrated Security=false; User=soporte; Password=12003906;";
            optionsBuilder.UseSqlServer(strConexion);
            
        }
    }
}
