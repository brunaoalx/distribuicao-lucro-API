using DistribuicaoLucorAPI.Models.Implementation;
using DistribuicaoLucorAPI.Models.Interface;
using Microsoft.EntityFrameworkCore;
using System;

namespace DistribuicaoLucrosAPI.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Funcionario> Funcionarios { get; set; }

    }
}
