﻿using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    public class ServicoPredioMap : IEntityTypeConfiguration<ServicoPredio>
    {
        public void Configure(EntityTypeBuilder<ServicoPredio> builder)
        {
            builder.HasKey(sp => sp.ServicoPredioId);
            builder.Property(sp => sp.ServicoId).IsRequired();
            builder.Property(sp => sp.DataExcucao).IsRequired();

            builder.HasOne(sp => sp.Servico).WithMany(sp => sp.ServicoPredios).HasForeignKey(sp => sp.ServicoId);

            builder.ToTable("ServicoPredios");
        }
    }
}
