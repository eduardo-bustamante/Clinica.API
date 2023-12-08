namespace Clinica.API.Models
{
    public class EspecialidadeMedico
    {

        public int MedicoId { get; set; }
        public Medico Medicos { get; set; }
        public int EspecialidadeId { get; set; }
        public Especialidade Especialidade { get; set; }
    }
}
