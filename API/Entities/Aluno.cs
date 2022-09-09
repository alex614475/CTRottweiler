using CTRottweiler.Entities;

namespace CTRottweiler.Entities
{
    public class Aluno : Entity
    {

        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public DateTime Nascimento { get; set; }
 

        public bool Ativo { get; set; }

        public string Observacao { get; set; }

        //Endereço 
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }


        public DateTime CriadoEm { get; set; }





    }
}
