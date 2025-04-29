using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepasoPrueba2._0P1.Models;

    public class DBSqlServer_01 : DbContext
    {
        public DBSqlServer_01 (DbContextOptions<DBSqlServer_01> options)
            : base(options)
        {
        }

        public DbSet<RepasoPrueba2._0P1.Models.Propietario> Propietario { get; set; } = default!;

public DbSet<RepasoPrueba2._0P1.Models.Carro> Carro { get; set; } = default!;
    }
