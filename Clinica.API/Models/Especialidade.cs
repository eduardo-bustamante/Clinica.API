namespace Clinica.API.Models
{
    public class Especialidade: Entidade
    {
        public string? Nome { get; set; }
        public bool Ativa { get; set; }
        public List<Medico>? Medicos { get; set; }
        public List<Consulta>? Consultas { get; set; }
    }
}
