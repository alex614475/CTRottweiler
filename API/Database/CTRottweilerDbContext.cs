using CTRottweiler.Entities;
using Microsoft.EntityFrameworkCore;

namespace CTRottweiler.Database
{
    public class CTRottweilerDbContext: DbContext
    {

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Atividade> Atividades { get; set; }

        public DbSet<Instrutor> Instrutors { get; set; }

        public DbSet<AtividadeHora> AtividadeHoras { get; set; }

        public CTRottweilerDbContext(DbContextOptions options): base(options)
        {
        }

      

    }
}
