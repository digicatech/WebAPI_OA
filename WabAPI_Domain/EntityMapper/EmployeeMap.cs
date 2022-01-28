using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WabAPI_Domain.Models;

namespace WabAPI_Domain.EntityMapper
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("pk_empId");
            builder.Property(x => x.Id).ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("int");
            builder.Property(x => x.Name).HasColumnName("Name").HasColumnType("Varchar(100)").IsRequired();
        }
    }
}
