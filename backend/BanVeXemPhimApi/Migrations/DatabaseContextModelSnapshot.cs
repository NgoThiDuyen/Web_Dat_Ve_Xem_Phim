﻿// <auto-generated />
using System;
using BanVeXemPhimApi.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BanVeXemPhimApi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("BanVeXemPhimApi.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("NumberPhone")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(4669),
                            Email = "admin@gmail.com",
                            Name = "Admin",
                            Password = "75D23AF433E0CEA4C0E45A56DBA18B30",
                            Role = "Manager",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Username = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("BanVeXemPhimApi.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("cenimas");
                });

            modelBuilder.Entity("BanVeXemPhimApi.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .HasColumnType("longtext");

                    b.Property<string>("Cast")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<int>("MovieType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("NumberBooking")
                        .HasColumnType("int");

                    b.Property<int>("NumberView")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Gorō Taniguchi",
                            Cast = "Mayumi Tanaka (Luffy), Shuichi Ikeda (Shanks), Hiroaki Hirata (Sanji), Ikue Otani (Tony Tony Chopper)",
                            CreatedDate = new DateTime(2023, 5, 19, 8, 22, 57, 597, DateTimeKind.Local).AddTicks(9455),
                            Description = "Bối cảnh One Piece Film Red diễn ra ở hòn đảo âm nhạc Elegia, nơi diva nổi tiếng bậc nhất thế giới tên Uta thực hiện buổi biểu diễn trực tiếp đầu tiên trước công chúng. Uta đứng trên sân khấu với một ước mơ giản dị rằng ” Âm nhạc của tôi sẽ khiến cho thế giới hạnh phúc”. Đằng sau hình ảnh cô ca sĩ sở hữu giọng hát được đánh giá là ở “Đẳng cấp hoàn toàn khác” là một thân thế vô cùng bí ẩn được che giấu. Băng hải tặc Mũ Rơm và các fan khác của Uta từ nhiều thế lực khác nhau như hải tặc lẫn hải quân đều đã cùng tề tựu về buổi biểu diễn này. Biến cố bắt đầu ngay khi sự thật kinh hoàng được tiết lộ rằng Uta chính là “con gái của Shanks”. Luffy và Uta lần đầu tiên hội ngộ sau lần gặp gỡ vào 12 năm trước tại Làng Foosha.",
                            Image = "image/movie/movie_1.jpg",
                            MovieType = 1,
                            Name = "ONE PIECE FILM RED",
                            NumberBooking = 0,
                            NumberView = 0,
                            ReleaseDate = new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(1399),
                            Time = 115,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Author = "Ryan Coogler",
                            Cast = "Tenoch Huerta, Martin Freeman, Lupita Nyong'o",
                            CreatedDate = new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(2192),
                            Description = "Bối cảnh One Piece Film Red diễn ra ở hòn đảo âm nhạc Elegia, nơi diva nổi tiếng bậc nhất thế giới tên Uta thực hiện buổi biểu diễn trực tiếp đầu tiên trước công chúng. Uta đứng trên sân khấu với một ước mơ giản dị rằng ” Âm nhạc của tôi sẽ khiến cho thế giới hạnh phúc”. Đằng sau hình ảnh cô ca sĩ sở hữu giọng hát được đánh giá là ở “Đẳng cấp hoàn toàn khác” là một thân thế vô cùng bí ẩn được che giấu. Băng hải tặc Mũ Rơm và các fan khác của Uta từ nhiều thế lực khác nhau như hải tặc lẫn hải quân đều đã cùng tề tựu về buổi biểu diễn này. Biến cố bắt đầu ngay khi sự thật kinh hoàng được tiết lộ rằng Uta chính là “con gái của Shanks”. Luffy và Uta lần đầu tiên hội ngộ sau lần gặp gỡ vào 12 năm trước tại Làng Foosha.",
                            Image = "image/movie/movie_2.jpg",
                            MovieType = 1,
                            Name = "CHIẾN BINH BÁO ĐEN 2: WAKANDA BẤT DIỆT",
                            NumberBooking = 0,
                            NumberView = 0,
                            ReleaseDate = new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(2197),
                            Time = 115,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Author = "James Lee",
                            Cast = "Alif Satar, Ikmal Amry, Abbas Mahmood",
                            CreatedDate = new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(2199),
                            Description = "Bối cảnh One Piece Film Red diễn ra ở hòn đảo âm nhạc Elegia, nơi diva nổi tiếng bậc nhất thế giới tên Uta thực hiện buổi biểu diễn trực tiếp đầu tiên trước công chúng. Uta đứng trên sân khấu với một ước mơ giản dị rằng ” Âm nhạc của tôi sẽ khiến cho thế giới hạnh phúc”. Đằng sau hình ảnh cô ca sĩ sở hữu giọng hát được đánh giá là ở “Đẳng cấp hoàn toàn khác” là một thân thế vô cùng bí ẩn được che giấu. Băng hải tặc Mũ Rơm và các fan khác của Uta từ nhiều thế lực khác nhau như hải tặc lẫn hải quân đều đã cùng tề tựu về buổi biểu diễn này. Biến cố bắt đầu ngay khi sự thật kinh hoàng được tiết lộ rằng Uta chính là “con gái của Shanks”. Luffy và Uta lần đầu tiên hội ngộ sau lần gặp gỡ vào 12 năm trước tại Làng Foosha.",
                            Image = "image/movie/movie_3.jpg",
                            MovieType = 4,
                            Name = "CHÚ NGUYỀN TÁI SINH",
                            NumberBooking = 0,
                            NumberView = 0,
                            ReleaseDate = new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(2201),
                            Time = 115,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Author = "Nguyễn Chung",
                            Cast = "NSND Kim Xuân, NSƯT Lê Thiện, NSƯT Công Ninh, Dược Sĩ Tiến, Phạm Huỳnh Hữu Tài",
                            CreatedDate = new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(2202),
                            Description = "Bối cảnh One Piece Film Red diễn ra ở hòn đảo âm nhạc Elegia, nơi diva nổi tiếng bậc nhất thế giới tên Uta thực hiện buổi biểu diễn trực tiếp đầu tiên trước công chúng. Uta đứng trên sân khấu với một ước mơ giản dị rằng ” Âm nhạc của tôi sẽ khiến cho thế giới hạnh phúc”. Đằng sau hình ảnh cô ca sĩ sở hữu giọng hát được đánh giá là ở “Đẳng cấp hoàn toàn khác” là một thân thế vô cùng bí ẩn được che giấu. Băng hải tặc Mũ Rơm và các fan khác của Uta từ nhiều thế lực khác nhau như hải tặc lẫn hải quân đều đã cùng tề tựu về buổi biểu diễn này. Biến cố bắt đầu ngay khi sự thật kinh hoàng được tiết lộ rằng Uta chính là “con gái của Shanks”. Luffy và Uta lần đầu tiên hội ngộ sau lần gặp gỡ vào 12 năm trước tại Làng Foosha.",
                            Image = "image/movie/movie_4.jpg",
                            MovieType = 4,
                            Name = "HẠNH PHÚC MÁU",
                            NumberBooking = 0,
                            NumberView = 0,
                            ReleaseDate = new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(2204),
                            Time = 115,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Author = "Samuel Tourneux",
                            Cast = "",
                            CreatedDate = new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(2205),
                            Description = "Bối cảnh One Piece Film Red diễn ra ở hòn đảo âm nhạc Elegia, nơi diva nổi tiếng bậc nhất thế giới tên Uta thực hiện buổi biểu diễn trực tiếp đầu tiên trước công chúng. Uta đứng trên sân khấu với một ước mơ giản dị rằng ” Âm nhạc của tôi sẽ khiến cho thế giới hạnh phúc”. Đằng sau hình ảnh cô ca sĩ sở hữu giọng hát được đánh giá là ở “Đẳng cấp hoàn toàn khác” là một thân thế vô cùng bí ẩn được che giấu. Băng hải tặc Mũ Rơm và các fan khác của Uta từ nhiều thế lực khác nhau như hải tặc lẫn hải quân đều đã cùng tề tựu về buổi biểu diễn này. Biến cố bắt đầu ngay khi sự thật kinh hoàng được tiết lộ rằng Uta chính là “con gái của Shanks”. Luffy và Uta lần đầu tiên hội ngộ sau lần gặp gỡ vào 12 năm trước tại Làng Foosha.",
                            Image = "image/movie/movie_5.jpg",
                            MovieType = 3,
                            Name = "KHỈ CON LON TON THẾ GIỚI",
                            NumberBooking = 0,
                            NumberView = 0,
                            ReleaseDate = new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(2206),
                            Time = 115,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BanVeXemPhimApi.Models.ReviewMovie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("reviewMovies");
                });

            modelBuilder.Entity("BanVeXemPhimApi.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PlaySchedule")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("schedules");
                });

            modelBuilder.Entity("BanVeXemPhimApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("NumberPhone")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 5, 19, 8, 22, 57, 592, DateTimeKind.Local).AddTicks(2458),
                            Name = "Nguyễn Văn Test",
                            Password = "3213D1FD1AEAE020606E12C32EAFE45E",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Username = "nguyenvantest@gmail.com"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
