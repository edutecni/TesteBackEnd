using EscolaCleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Infra.Data.EntityConfiguration
{
    public class NotasAlunoConfiguration : IEntityTypeConfiguration<NotasAluno>
    {
        public void Configure(EntityTypeBuilder<NotasAluno> builder)
        {
            builder.Property(d => d.NotaDiciplina).HasPrecision(10, 2).IsRequired();
        }
    }
}
