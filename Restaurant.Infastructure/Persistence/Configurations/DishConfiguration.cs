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
    public class DishConfiguration : IEntityTypeConfiguration<Dish>
    {
        public void Configure(EntityTypeBuilder<Dish> builder)
        {
            builder.ToTable("Dishes");

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(d => d.Description)
                .HasMaxLength(500);

            builder.Property(d => d.Price)
                .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder.Property(d => d.ImageUrl)
                .HasMaxLength(200);

            // Связь с Category (многие к одному)
            builder.HasOne(d => d.Category)
                   .WithMany(c => c.Dishes)
                   .HasForeignKey(d => d.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict); // или Cascade

            // Связь с OrderItems (многие ко многим через промежуточную таблицу)
            builder.HasMany(d => d.OrderItems)
                   .WithOne(oi => oi.Dish)
                   .HasForeignKey(oi => oi.DishId);
        }
    }
}
