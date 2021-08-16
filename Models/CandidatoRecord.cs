using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace aec_gama_api.Models
{
    [Table("candidatos")]
    public class CandidatoRecord
    {
        public int Id_Candidato { get; set; }
        public string Nome { get; set; }
        public string Nascimento { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }
        public int ProfissaoID { get; set; }

    }
}