namespace Lista1DesenvolvimentoWeb.Models
{
    public class Frete
    {
        public string Nome { get; set; } = string.Empty;
        public float Peso { get; set; }
        public float Altura { get; set; }
        public float Largura { get; set; }
        public float Comprimento { get; set; }
        public string UF { get; set; } = string.Empty;
    }
}
