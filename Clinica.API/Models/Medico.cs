namespace Clinica.API.Models
{
    public class Medico : Entidade
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public List<Consulta>? Consultas { get; set; }
        public List<Especialidade> Especialidades { get; set; }

    }
}
