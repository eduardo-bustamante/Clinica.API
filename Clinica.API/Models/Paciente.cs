namespace Clinica.API.Models
{
    public class Paciente : Pessoa  
    {
        public string? Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime? Celular { get; set; }
        public DateTime Cpf { get; set; }
        public List<Consulta> Consultas { get; set; }

    }
}
