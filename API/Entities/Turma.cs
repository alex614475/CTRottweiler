using CTRottweiler.Entities;

namespace CTRottweiler.Entities
{
    public class Turma : Entity
    {


        public string Nome { get; set; }

        public string horarios { get; set; }


        public long InstrutorId { get; set; }

        public Instrutor Instrutor { get; set; }

        public long AlunoId { get; set; }

        public Aluno Aluno { get; set; }

        public long AulaId { get; set; }

        public Aula Aula { get; set; }






    }
}
