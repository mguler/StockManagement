﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockManagement.Data.DataContext;

namespace StockManagement.Data.DataContext.Migrations
{
    [DbContext(typeof(StockManagementDataContext))]
    partial class StockManagementDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StockManagement.Data.Model.CurrentAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("CurrentAccount", "StockManagement");
                });

            modelBuilder.Entity("StockManagement.Data.Model.MaterialCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("MaterialCode", "StockManagement");
                });

            modelBuilder.Entity("StockManagement.Data.Model.MeasureUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("MeasureUnit", "StockManagement");
                });

            modelBuilder.Entity("StockManagement.Data.Model.StockAlertLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlertMessage")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ColorCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StockCardId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StockCardId");

                    b.ToTable("StockAlertLevel", "StockManagement");
                });

            modelBuilder.Entity("StockManagement.Data.Model.StockBalance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Inbound")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Outbound")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StockCardId")
                        .HasColumnType("int");

                    b.Property<int>("StockTransactionId")
                        .HasColumnType("int");

                    b.Property<int>("TrackingNumber")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StockCardId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("StockBalance", "StockManagement");
                });

            modelBuilder.Entity("StockManagement.Data.Model.StockCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barcode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MaterialCodeId")
                        .HasColumnType("int");

                    b.Property<int>("MeasureUnitId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialCodeId");

                    b.HasIndex("MeasureUnitId");

                    b.ToTable("StockCard", "StockManagement");
                });

            modelBuilder.Entity("StockManagement.Data.Model.StockConsumptionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("StockConsumptionType", "StockManagement");
                });

            modelBuilder.Entity("StockManagement.Data.Model.StockImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("StockCardId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StockCardId");

                    b.ToTable("StockImage", "StockManagement");
                });

            modelBuilder.Entity("StockManagement.Data.Model.StockSupplementType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("StockSupplementType", "StockManagement");
                });

            modelBuilder.Entity("StockManagement.Data.Model.StockTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Inbound")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("InboundCurrentAccountId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Outbound")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OutboundCurrentAccountId")
                        .HasColumnType("int");

                    b.Property<int>("StockCardId")
                        .HasColumnType("int");

                    b.Property<int>("TrackingNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InboundCurrentAccountId");

                    b.HasIndex("OutboundCurrentAccountId");

                    b.HasIndex("StockCardId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("StockTransaction", "StockManagement");
                });

            modelBuilder.Entity("StockManagement.Data.Model.StockValor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Begin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("End")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Inbound")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Outbound")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StockCardId")
                        .HasColumnType("int");

                    b.Property<int>("StockTransactionId")
                        .HasColumnType("int");

                    b.Property<int>("TrackingNumber")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StockCardId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("StockValor", "StockManagement");
                });

            modelBuilder.Entity("StockManagement.Data.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User", "StockManagement");
                });

            modelBuilder.Entity("StockManagement.Data.Model.UserWarehouseAssignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("UserWarehouseAssignment", "StockManagement");
                });

            modelBuilder.Entity("StockManagement.Data.Model.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Warehouse", "StockManagement");
                });

            modelBuilder.Entity("StockManagement.Data.Model.StockAlertLevel", b =>
                {
                    b.HasOne("StockManagement.Data.Model.StockCard", "StockCard")
                        .WithMany("StockAlertLevel")
                        .HasForeignKey("StockCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StockCard");
                });

            modelBuilder.Entity("StockManagement.Data.Model.StockBalance", b =>
                {
                    b.HasOne("StockManagement.Data.Model.StockCard", "StockCard")
                        .WithMany()
                        .HasForeignKey("StockCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManagement.Data.Model.Warehouse", "Warehouse")
                        .WithMany()
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StockCard");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("StockManagement.Data.Model.StockCard", b =>
                {
                    b.HasOne("StockManagement.Data.Model.MaterialCode", "MaterialCode")
                        .WithMany("StockCard")
                        .HasForeignKey("MaterialCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManagement.Data.Model.MeasureUnit", "MeasureUnit")
                        .WithMany()
                        .HasForeignKey("MeasureUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MaterialCode");

                    b.Navigation("MeasureUnit");
                });

            modelBuilder.Entity("StockManagement.Data.Model.StockImage", b =>
                {
                    b.HasOne("StockManagement.Data.Model.StockCard", "StockCard")
                        .WithMany("StockImage")
                        .HasForeignKey("StockCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StockCard");
                });

            modelBuilder.Entity("StockManagement.Data.Model.StockTransaction", b =>
                {
                    b.HasOne("StockManagement.Data.Model.CurrentAccount", "InboundCurrentAccount")
                        .WithMany()
                        .HasForeignKey("InboundCurrentAccountId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StockManagement.Data.Model.CurrentAccount", "OutboundCurrentAccount")
                        .WithMany()
                        .HasForeignKey("OutboundCurrentAccountId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StockManagement.Data.Model.StockCard", "StockCard")
                        .WithMany()
                        .HasForeignKey("StockCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManagement.Data.Model.Warehouse", "Warehouse")
                        .WithMany()
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InboundCurrentAccount");

                    b.Navigation("OutboundCurrentAccount");

                    b.Navigation("StockCard");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("StockManagement.Data.Model.StockValor", b =>
                {
                    b.HasOne("StockManagement.Data.Model.StockCard", "StockCard")
                        .WithMany()
                        .HasForeignKey("StockCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManagement.Data.Model.Warehouse", "Warehouse")
                        .WithMany()
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StockCard");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("StockManagement.Data.Model.UserWarehouseAssignment", b =>
                {
                    b.HasOne("StockManagement.Data.Model.User", "User")
                        .WithMany("UserWarehouseAssignment")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManagement.Data.Model.Warehouse", "Warehouse")
                        .WithMany("UserWarehouseAssignment")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("StockManagement.Data.Model.MaterialCode", b =>
                {
                    b.Navigation("StockCard");
                });

            modelBuilder.Entity("StockManagement.Data.Model.StockCard", b =>
                {
                    b.Navigation("StockAlertLevel");

                    b.Navigation("StockImage");
                });

            modelBuilder.Entity("StockManagement.Data.Model.User", b =>
                {
                    b.Navigation("UserWarehouseAssignment");
                });

            modelBuilder.Entity("StockManagement.Data.Model.Warehouse", b =>
                {
                    b.Navigation("UserWarehouseAssignment");
                });
#pragma warning restore 612, 618
        }
    }
}
