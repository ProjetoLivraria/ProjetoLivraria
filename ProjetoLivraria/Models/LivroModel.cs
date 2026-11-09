namespace ProjetoLivraria.Models
{
    public class LivroModel
    {
        public int Id { get; set; }

        public string Isbn { get; set; } = string.Empty;

        public string Nome { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;

        public decimal Valor { get; set; }
    }
}