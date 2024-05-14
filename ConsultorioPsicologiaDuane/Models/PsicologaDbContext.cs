using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ConsultorioPsicologiaDuane.Models
{
    public class PsicologaDbContext : DbContext
    {
        public PsicologaDbContext() : base("ClinicaPsiDb")
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPsiDb"].ConnectionString;
        }
        public DbSet<Paciente> Pacientes { get; set; }

    }
}