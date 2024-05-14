using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConsultorioPsicologiaDuane.Models
{
    [Table("Pacientes")]
    public class Paciente
    {
        [Key]
        public int IdPaciente { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Genero { get; set; }
        public string EstadoCivil { get; set; }
    }
}