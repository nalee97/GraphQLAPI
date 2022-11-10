﻿// <auto-generated />
using System;
using GraphQLAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GraphQLAPI.Migrations
{
    [DbContext(typeof(SuperHeroDbContext))]
    [Migration("20221110155033_CreateInitial")]
    partial class CreateInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GraphQLAPI.Models.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instructor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SuperheroId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f7b8bebf-779c-460f-bc30-837e77ff74e8"),
                            Description = "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("67a91459-acaf-4e59-ad14-aa8487733190"),
                            Title = "Batman Begins"
                        },
                        new
                        {
                            Id = new Guid("109324dc-2535-4224-acd4-079939ec1f48"),
                            Description = "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("67a91459-acaf-4e59-ad14-aa8487733190"),
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            Id = new Guid("68fccad3-963c-4e68-8f35-acb001b262d9"),
                            Description = "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("67a91459-acaf-4e59-ad14-aa8487733190"),
                            Title = "The Dark Knight Rises"
                        },
                        new
                        {
                            Id = new Guid("88b392dd-3279-4a77-bbfa-74c6ea138584"),
                            Description = "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.",
                            Instructor = "George Lucas",
                            ReleaseDate = new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("b3f31f5c-63df-4336-999a-2efb21a02106"),
                            Title = "Star Wars: Episode IV – A New Hope"
                        },
                        new
                        {
                            Id = new Guid("dfd1f97a-8c03-4ac4-90fb-2f4e1f39749f"),
                            Description = "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.",
                            Instructor = "Irvin Kershner",
                            ReleaseDate = new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("b3f31f5c-63df-4336-999a-2efb21a02106"),
                            Title = "Star Wars: Episode V – The Empire Strikes Back"
                        },
                        new
                        {
                            Id = new Guid("801c203c-0b1a-4c36-959c-4fb4d49b127c"),
                            Description = "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.",
                            Instructor = "Richard Marquand",
                            ReleaseDate = new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("b3f31f5c-63df-4336-999a-2efb21a02106"),
                            Title = "Star Wars: Episode VI – Return of the Jedi"
                        },
                        new
                        {
                            Id = new Guid("8fd99aef-afa3-4a64-a2e1-92026b982686"),
                            Description = "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).",
                            Instructor = "Cate Shortland",
                            ReleaseDate = new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("dc542550-e9fc-4f08-9f1f-374afb04138d"),
                            Title = "Black Widow"
                        });
                });

            modelBuilder.Entity("GraphQLAPI.Models.Superhero", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Superheroes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("67a91459-acaf-4e59-ad14-aa8487733190"),
                            Description = "Batman is a superhero who appears in American comic books published by DC Comics. The character was created by artist Bob Kane and writer Bill Finger, and first appeared in Detective Comics #27 (May 1939). Originally",
                            Height = "6'2",
                            Name = "Batman"
                        },
                        new
                        {
                            Id = new Guid("b3f31f5c-63df-4336-999a-2efb21a02106"),
                            Description = "Superman is a fictional superhero appearing in American comic books published by DC Comics. The character was created by writer Jerry Siegel and artist Joe Shuster, high school students living in Cleveland, Ohio, in 1933.",
                            Height = "6'3",
                            Name = "Superman"
                        },
                        new
                        {
                            Id = new Guid("dc542550-e9fc-4f08-9f1f-374afb04138d"),
                            Description = "Luke Skywalker is a fictional character and the main protagonist of the original film trilogy of the Star Wars franchise created by George Lucas. He is portrayed by Mark Hamill in the original trilogy and by Hayden Christensen in the prequel trilogy.",
                            Height = "5'11",
                            Name = "Luke Skywalker"
                        });
                });

            modelBuilder.Entity("GraphQLAPI.Models.Superpower", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuperPower")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SuperheroId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId");

                    b.ToTable("Superpowers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e35dfd2a-2a7f-48da-bca3-fba1a092f51a"),
                            Description = "He's always a step ahead.",
                            SuperPower = "Intellect.",
                            SuperheroId = new Guid("67a91459-acaf-4e59-ad14-aa8487733190")
                        },
                        new
                        {
                            Id = new Guid("de133e85-a46e-4dc7-af6d-50fe20385221"),
                            Description = "Sublime fighting skills.",
                            SuperPower = "Fighting",
                            SuperheroId = new Guid("67a91459-acaf-4e59-ad14-aa8487733190")
                        },
                        new
                        {
                            Id = new Guid("a1b6c31e-c2d6-45e1-a3ce-0e8a4ca31fe1"),
                            Description = "He got a lot of money",
                            SuperPower = "Wealth.",
                            SuperheroId = new Guid("67a91459-acaf-4e59-ad14-aa8487733190")
                        },
                        new
                        {
                            Id = new Guid("0a907fe2-96b8-4dc6-88fe-a4d62cff68f2"),
                            Description = "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.",
                            SuperPower = "Deflect blaster power.",
                            SuperheroId = new Guid("b3f31f5c-63df-4336-999a-2efb21a02106")
                        },
                        new
                        {
                            Id = new Guid("b40f7cab-9826-4b3a-818a-d277638edc39"),
                            Description = "She's good at spying at people.",
                            SuperPower = "Espionage",
                            SuperheroId = new Guid("dc542550-e9fc-4f08-9f1f-374afb04138d")
                        },
                        new
                        {
                            Id = new Guid("5f8ffd0c-5493-4fc0-802e-99d72ff0277e"),
                            Description = "She knows how to infiltrate the enemy.",
                            SuperPower = "Infiltration",
                            SuperheroId = new Guid("dc542550-e9fc-4f08-9f1f-374afb04138d")
                        },
                        new
                        {
                            Id = new Guid("5da6cbf6-e376-473e-add5-b6d5d1bcae12"),
                            Description = "The knowledge of how to undermine others.",
                            SuperPower = "Subterfuge",
                            SuperheroId = new Guid("dc542550-e9fc-4f08-9f1f-374afb04138d")
                        });
                });

            modelBuilder.Entity("GraphQLAPI.Models.Movie", b =>
                {
                    b.HasOne("GraphQLAPI.Models.Superhero", "Superhero")
                        .WithMany("Movies")
                        .HasForeignKey("SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Superhero");
                });

            modelBuilder.Entity("GraphQLAPI.Models.Superpower", b =>
                {
                    b.HasOne("GraphQLAPI.Models.Superhero", "Superhero")
                        .WithMany("Superpowers")
                        .HasForeignKey("SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Superhero");
                });

            modelBuilder.Entity("GraphQLAPI.Models.Superhero", b =>
                {
                    b.Navigation("Movies");

                    b.Navigation("Superpowers");
                });
#pragma warning restore 612, 618
        }
    }
}