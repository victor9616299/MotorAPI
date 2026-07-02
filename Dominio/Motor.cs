namespace Dominio
{
    public class Motor
    {
        public int IdMotor { get; set; }
        public string NomeMotor { get; set; }
        public bool Estado { get; set; }
        public int Rotacao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}