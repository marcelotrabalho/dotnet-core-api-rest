using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Cliente
    {
        private int id;
        private string nome;
        private string cpf;
        private DateTime nascimento;

        private List<Endereco> enderecos;
        

        [Required]
        public int Id { get => id; set => id = value; }

        [Required]
        [StringLength(30)]
        public string Nome { get => nome; set => nome=value; }
        [Required]
        public string Cpf { get => cpf; set => cpf=value; }
        [Required]
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}")]
        public DateTime DataNascimento {get => nascimento; set => nascimento=value; }

        [Range(14,120)]
        public int idade 
        { 
            get 
            {
                DateTime data;
                if(nascimento != null)
                {
                    if (DateTime.TryParse(nascimento.ToString(),out data))
                    {
                        return (int)data.Subtract(DateTime.Today).TotalDays;
                    }
                }
                return 0;
            }
            
        }

        public List<Endereco> Enderecos {get => enderecos; set => enderecos=value;}
    }

}
