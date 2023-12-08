namespace Clinica.API.Models
{
    public class Medico : Pessoa
    {
        
        public Especialidade? Especialidade { get; set; }
        public string? Crm { get; set; }

    }
}
