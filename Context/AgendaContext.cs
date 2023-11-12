using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dioMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace dioMVC.Context
{
    public class AgendaContext :DbContext
    {
        //criação do context que vai representar o banco


        //construtor
        public AgendaContext(DbContextOptions<AgendaContext> options) :base(options)
        {

        }

        //criação do dbset que vai representar uma tabela
        public DbSet<Contato> Contatos {get; set;}
    }
}