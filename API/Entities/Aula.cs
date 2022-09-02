using CTRottweiler.Entities;

namespace CTRottweiler.Entities
{
    public class Aula: Entity
    {
        public string Nome { get; set; }

        public string Instrutor { get; set; }    
        public decimal Mensalidade { get; set; }

        public ICollection<Turma> Turmas { get; set; }
    }
}
