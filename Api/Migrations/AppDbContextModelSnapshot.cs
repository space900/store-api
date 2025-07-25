﻿// <auto-generated />
using System;
using Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Api.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("SpecialTag")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Категория 3",
                            Description = "Настолько модели идейные кадровой социально-ориентированный.",
                            Image = "https://placehold.co/200",
                            Name = "Практичный Бетонный Кошелек",
                            Price = 94.620000000000005,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Категория 2",
                            Description = "Внедрения начало обуславливает задания нашей.",
                            Image = "https://placehold.co/200",
                            Name = "Свободный Стальной Майка",
                            Price = 621.02999999999997,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Категория 1",
                            Description = "Насущным однако уточнения задача сомнений напрямую разработке.",
                            Image = "https://placehold.co/200",
                            Name = "Интеллектуальный Стальной Ботинок",
                            Price = 137.40000000000001,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Категория 1",
                            Description = "Поставленных всего систему.",
                            Image = "https://placehold.co/200",
                            Name = "Эргономичный Хлопковый Ботинок",
                            Price = 749.21000000000004,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Категория 2",
                            Description = "Прогресса анализа гражданского показывает модель.",
                            Image = "https://placehold.co/200",
                            Name = "Эргономичный Пластиковый Ножницы",
                            Price = 309.48000000000002,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Категория 2",
                            Description = "Уровня модели укрепления материально-технической.",
                            Image = "https://placehold.co/200",
                            Name = "Невероятный Гранитный Носки",
                            Price = 785.11000000000001,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 7,
                            Category = "Категория 2",
                            Description = "Предложений активности принципов проверки повседневная представляет создание.",
                            Image = "https://placehold.co/200",
                            Name = "Практичный Кожанный Кулон",
                            Price = 917.52999999999997,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 8,
                            Category = "Категория 1",
                            Description = "Прежде начало стороны.",
                            Image = "https://placehold.co/200",
                            Name = "Интеллектуальный Пластиковый Клатч",
                            Price = 272.17000000000002,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 9,
                            Category = "Категория 3",
                            Description = "Сфера предложений соображения участия позволяет же специалистов обеспечивает.",
                            Image = "https://placehold.co/200",
                            Name = "Лоснящийся Деревянный Автомобиль",
                            Price = 139.50999999999999,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 10,
                            Category = "Категория 2",
                            Description = "Порядка особенности практика.",
                            Image = "https://placehold.co/200",
                            Name = "Грубый Меховой Куртка",
                            Price = 880.29999999999995,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 11,
                            Category = "Категория 3",
                            Description = "Обеспечивает повседневной роль административных общества плановых.",
                            Image = "https://placehold.co/200",
                            Name = "Фантастический Деревянный Кошелек",
                            Price = 882.29999999999995,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 12,
                            Category = "Категория 1",
                            Description = "Однако важную отношении.",
                            Image = "https://placehold.co/200",
                            Name = "Лоснящийся Натуральный Кулон",
                            Price = 898.94000000000005,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 13,
                            Category = "Категория 1",
                            Description = "Развития степени начало позиции управление соответствующих определения структуры.",
                            Image = "https://placehold.co/200",
                            Name = "Лоснящийся Хлопковый Кепка",
                            Price = 249.38,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 14,
                            Category = "Категория 2",
                            Description = "Определения правительством развития массового постоянное значение постоянный дальнейшее постоянный на.",
                            Image = "https://placehold.co/200",
                            Name = "Свободный Гранитный Портмоне",
                            Price = 651.89999999999998,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 15,
                            Category = "Категория 1",
                            Description = "Качества нас зависит богатый общества прогресса повышение современного а деятельности.",
                            Image = "https://placehold.co/200",
                            Name = "Большой Кожанный Свитер",
                            Price = 745.86000000000001,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 16,
                            Category = "Категория 3",
                            Description = "Же собой современного богатый выполнять также принципов высшего шагов.",
                            Image = "https://placehold.co/200",
                            Name = "Лоснящийся Кожанный Ножницы",
                            Price = 766.88999999999999,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 17,
                            Category = "Категория 3",
                            Description = "Различных мира эксперимент.",
                            Image = "https://placehold.co/200",
                            Name = "Большой Бетонный Автомобиль",
                            Price = 746.55999999999995,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 18,
                            Category = "Категория 1",
                            Description = "Сущности анализа сущности повседневная нас структура формированию существующий.",
                            Image = "https://placehold.co/200",
                            Name = "Невероятный Меховой Автомобиль",
                            Price = 944.98000000000002,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 19,
                            Category = "Категория 2",
                            Description = "Активизации мира рамки сомнений.",
                            Image = "https://placehold.co/200",
                            Name = "Эргономичный Пластиковый Портмоне",
                            Price = 217.58000000000001,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 20,
                            Category = "Категория 1",
                            Description = "Уточнения условий кругу нами с прогресса же следует нами.",
                            Image = "https://placehold.co/200",
                            Name = "Фантастический Пластиковый Ремень",
                            Price = 746.87,
                            SpecialTag = "Рекомендуемый"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Api.Model.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("AppUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
