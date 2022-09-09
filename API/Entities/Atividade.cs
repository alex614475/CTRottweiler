using CTRottweiler.Entities;

namespace CTRottweiler.Entities
{
    public class Atividade : Entity
    {
        public string Descricao { get; set; }

        public decimal Mensalidade { get; set; }

   
        public string DescricaoNome { get; set; }

        public int? InstrutorId { get; set; }

        public ICollection<Instrutor> Instrutors { get; set; }


    }
}
