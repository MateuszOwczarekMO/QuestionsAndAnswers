// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuestionsAndAnswers.Infrastructure.Storeage;

#nullable disable

namespace QuestionsAndAnswers.Infrastructure.Storeage.Migrations
{
    [DbContext(typeof(QuestionsAndAnswersDbContext))]
    [Migration("20220925101316_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("QuestionsAndAnswers.Models.QnA", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("QnAs");
                });
#pragma warning restore 612, 618
        }
    }
}
