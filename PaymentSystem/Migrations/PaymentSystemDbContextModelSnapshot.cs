﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaymentSystem.PaymentDbContext;

#nullable disable

namespace PaymentSystem.Migrations
{
    [DbContext(typeof(PaymentSystemDbContext))]
    partial class PaymentSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.12");

            modelBuilder.Entity("PaymentSystem.Model.Merchant", b =>
                {
                    b.Property<string>("MerchantId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MerchantId");

                    b.ToTable("Merchants");
                });

            modelBuilder.Entity("PaymentSystem.Model.PaymentTerminal", b =>
                {
                    b.Property<string>("TerminalId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MerchantId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TerminalType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TerminalId");

                    b.HasIndex("MerchantId");

                    b.ToTable("Terminal");
                });

            modelBuilder.Entity("PaymentSystem.Model.Transactions", b =>
                {
                    b.Property<string>("TranId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<string>("CardType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RRN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TerminalId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TranId");

                    b.HasIndex("TerminalId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("PaymentSystem.Model.PaymentTerminal", b =>
                {
                    b.HasOne("PaymentSystem.Model.Merchant", "Merchant")
                        .WithMany("Terminals")
                        .HasForeignKey("MerchantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Merchant");
                });

            modelBuilder.Entity("PaymentSystem.Model.Transactions", b =>
                {
                    b.HasOne("PaymentSystem.Model.PaymentTerminal", "Terminal")
                        .WithMany("Transactions")
                        .HasForeignKey("TerminalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Terminal");
                });

            modelBuilder.Entity("PaymentSystem.Model.Merchant", b =>
                {
                    b.Navigation("Terminals");
                });

            modelBuilder.Entity("PaymentSystem.Model.PaymentTerminal", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
