using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Conrollers;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data
{
    public class SistemadeTarefasDBContex : DbContext
    {
        public SistemadeTarefasDBContex(DbContextOptions<SistemadeTarefasDBContex> options)
            :base(options) 
        { 
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }   
        public DbSet<TarefaModel> Tarefa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
