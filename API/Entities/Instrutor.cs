namespace CTRottweiler.Entities
{
    public class Instrutor : Entity
    {
           public string Name { get; set; }

        public ICollection<Turma> Turmas { get; set; }
    }
}
