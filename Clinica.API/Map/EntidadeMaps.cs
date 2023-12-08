﻿using Clinica.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinica.API.Map
{
    public class EntidadeMaps<T> : IEntityTypeConfiguration<T> where T : Entidade
    {
        private readonly string _tableName;

    public EntidadeMaps(string tableName)
    {
        _tableName = tableName;
    }
    public virtual void Configure(EntityTypeBuilder<T> builder)
        {
        if (!string.IsNullOrEmpty(_tableName)) builder.ToTable(_tableName);

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
    }
    }
}