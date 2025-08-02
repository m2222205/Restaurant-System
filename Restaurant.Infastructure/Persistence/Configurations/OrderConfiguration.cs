using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infastructure.Persistence.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            // Primary key
            builder.HasKey(o => o.Id);      

            builder.Property(o => o.OrderDate)
                .IsRequired();
                     
            builder.Property(o => o.Status)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
