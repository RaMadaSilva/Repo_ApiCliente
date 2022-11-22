
namespace ApiCliente.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string SobreNome { get; set; } = null!;
        public DateTime DataNascimento { get; set; }

    }
}