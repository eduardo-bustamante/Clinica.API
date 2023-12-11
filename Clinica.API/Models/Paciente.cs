namespace Clinica.API.Models
{
    public class Paciente :Entidade    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string? Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime? Celular { get; set; }
        public DateTime Cpf { get; set; }
        public List<Consulta>? Consultas { get; set; }

    }
}
