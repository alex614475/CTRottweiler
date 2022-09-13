using CTRottweiler.Entities;

namespace CTRottweiler.Dtos
{
    public class InstrutorDto

    {
        public string Name { get; set; }

        public string Documento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }

        public bool Ativo { get; set; }

        public string Observacao { get; set; }

    

    }
}
