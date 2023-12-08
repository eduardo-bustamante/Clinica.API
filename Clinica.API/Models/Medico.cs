namespace Clinica.API.Models
{
    public class Medico : Pessoa
    {
        
        public Especialidade? Especialidade { get; set; }
        public bool? Ativo { get; set; }
        public List<Consulta> Consultas { get; set; }

        public List<Especialidade> Especialidades { get; set; }

    }
}
