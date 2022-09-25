using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Of_Thoth.Models
{
    [Table("Developers")]
    public class Developer
    {
        [Column("ID")]
        public int ID { get; set; }
        [Column("NOME")]
        public string Nome { get; set; }
        [Column("SOBRENOME")]
        public string Sobrenome { get; set; }
        [Column("CPF_CNPJ")]
        public string CPF_CNPJ { get; set; }
        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("CELULAR")]
        public string Celular { get; set; }
        [Column("DataNascimento")]
        public DateTime DataNascimento { get; set; }
        [Column("CAMPOCORINGA1")]
        public string CampoCoringa1 { get; set; }
        [Column("CAMPOCORINGA2")]
        public string CampoCoringa2 { get; set; }
        [Column("CAMPOCORINGA3")]
        public string CampoCoringa3 { get; set; }
        [Column("CAMPOCORINGA4")]
        public string CampoCoringa4 { get; set; }
        [Column("CAMPOCORINGA5")]
        public string CampoCoringa5 { get; set; }
        [Column("CAMPOCORINGA6")]
        public string CampoCoringa6 { get; set; }
        [Column("CAMPOCORINGA7")]
        public string CampoCoringa7 { get; set; }
        [Column("CAMPOCORINGA8")]
        public string CampoCoringa8 { get; set; }
        [Column("CAMPOCORINGA9")]
        public string CampoCoringa9 { get; set; }
        [Column("CaminhoPPK")]
        public string CaminhoPPK { get; set; }
        [Column("ROBOS")]
        public string ROBOS { get; set; }
        [Column("ATIVO")]
        public Boolean Ativo { get; set; }
    }
}
