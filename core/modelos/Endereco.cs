using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Endereco
    {
        private int id;
        private string logradouro;
        private string nomeDaRua;
        private string bairro;
        private string cidade;
        private string estado;
        private Cliente cliente;

        [Required]
        public int Id {get => id; set => id = value;}
        
        [Required]
        [StringLength(50)]
        public string Logradouro {get => logradouro;set => logradouro=value;}

        [Required]
        [StringLength(40)]
        public string NomeDaRua {get => nomeDaRua;set => nomeDaRua=value;}

        [Required]
        [StringLength(40)]
        public string Bairro {get => bairro;set => bairro=value;}

        [Required]
        [StringLength(40)]
        public string Cidade {get => cidade;set => cidade=value;}

        [Required]
        [StringLength(40)]
        public string Estado {get => estado;set => estado=value;}

        [Required]
        public Cliente Cliente {get=> cliente; set=> cliente=value;}
        
    }
    
}