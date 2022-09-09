using CTRottweiler.Entities;

namespace CTRottweiler.Entities
{
    public class AtividadeHora : Entity
    {



        public string Descricao { get; set; }

        public DateTime HorarioInicial { get; set; }

        public DateTime HorarioFinal { get; set; }

        public int AtividadeId { get; set; }    
 
        public Atividade Atividade { get; set; }    


    }
}
