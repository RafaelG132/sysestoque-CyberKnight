using System.ComponentModel.DataAnnotations;

namespace sysestoque_CyberKnight.Models {
    public class Usuario{
        [Key]
        [Required] // Mesmo que o NOT NULL
        public string login { get; set; }
        [Required]
        public string cpf { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public string HashSenha { get; set; }
        [Required]
        public string telefone { get; set; }
    }
}