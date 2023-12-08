namespace Clinica.API.Models
{
    public class Consulta : Entidade
    {
        public DateTime? DataConsulta { get; set; }
        public int PacienteId {  get; set; }
        public Paciente? Paciente { get; set; }

        public int EspecialidadeId { get; set; }
        public Especialidade? Especialidade { get; set; }
        public int MedicoId { get; set; }
        public Medico? Medico { get; set; }

    }
}
