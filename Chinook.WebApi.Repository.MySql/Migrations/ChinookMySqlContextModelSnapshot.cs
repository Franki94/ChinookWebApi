﻿// <auto-generated />
using System;
using Chinook.WebApi.Repository.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Chinook.WebApi.Repository.MySql.Migrations
{
    [DbContext(typeof(ChinookMySqlContext))]
    partial class ChinookMySqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Chinook.WebApi.Models.Album", b =>
                {
                    b.Property<int>("AlbumId");

                    b.Property<int>("ArtistId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(160);

                    b.HasKey("AlbumId")
                        .HasName("album_pkey");

                    b.HasIndex("ArtistId")
                        .HasName("album_ix_artist_id");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("Chinook.WebApi.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId");

                    b.Property<string>("Name")
                        .HasMaxLength(120);

                    b.HasKey("ArtistId")
                        .HasName("artist_pkey");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("Chinook.WebApi.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId");

                    b.Property<string>("Address")
                        .HasMaxLength(70);

                    b.Property<string>("City")
                        .HasMaxLength(40);

                    b.Property<string>("Company")
                        .HasMaxLength(80);

                    b.Property<string>("Country")
                        .HasMaxLength(40);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Fax")
                        .HasMaxLength(24);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Phone")
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("State")
                        .HasMaxLength(40);

                    b.Property<int?>("SupportRepId");

                    b.HasKey("CustomerId")
                        .HasName("customer_pkey");

                    b.HasIndex("SupportRepId")
                        .HasName("customer_ix_support_rep_id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Chinook.WebApi.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId");

                    b.Property<string>("Address")
                        .HasMaxLength(70);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime");

                    b.Property<string>("City")
                        .HasMaxLength(40);

                    b.Property<string>("Country")
                        .HasMaxLength(40);

                    b.Property<string>("Email")
                        .HasMaxLength(60);

                    b.Property<string>("Fax")
                        .HasMaxLength(24);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("datetime");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Phone")
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10);

                    b.Property<int?>("ReportsTo");

                    b.Property<string>("State")
                        .HasMaxLength(40);

                    b.Property<string>("Title")
                        .HasMaxLength(30);

                    b.HasKey("EmployeeId")
                        .HasName("employee_pkey");

                    b.HasIndex("ReportsTo")
                        .HasName("employee_ix_reports_to");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Chinook.WebApi.Models.Genre", b =>
                {
                    b.Property<int>("GenreId");

                    b.Property<string>("Name")
                        .HasMaxLength(120);

                    b.HasKey("GenreId")
                        .HasName("genre_pkey");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Chinook.WebApi.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId");

                    b.Property<string>("BillingAddress")
                        .HasMaxLength(70);

                    b.Property<string>("BillingCity")
                        .HasMaxLength(40);

                    b.Property<string>("BillingCountry")
                        .HasMaxLength(40);

                    b.Property<string>("BillingPostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("BillingState")
                        .HasMaxLength(40);

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("InvoiceId")
                        .HasName("invoice_pkey");

                    b.HasIndex("CustomerId")
                        .HasName("invoice_ix_customer_id");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("Chinook.WebApi.Models.InvoiceLine", b =>
                {
                    b.Property<int>("InvoiceLineId");

                    b.Property<int>("InvoiceId");

                    b.Property<int>("Quantity");

                    b.Property<int>("TrackId");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("InvoiceLineId")
                        .HasName("invoice_line_pkey");

                    b.HasIndex("InvoiceId")
                        .HasName("invoice_line_ix_invoice_id");

                    b.HasIndex("TrackId")
                        .HasName("invoice_line_ix_track_id");

                    b.ToTable("InvoiceLine");
                });

            modelBuilder.Entity("Chinook.WebApi.Models.MediaType", b =>
                {
                    b.Property<int>("MediaTypeId");

                    b.Property<string>("Name")
                        .HasMaxLength(120);

                    b.HasKey("MediaTypeId")
                        .HasName("media_type_pkey");

                    b.ToTable("MediaType");
                });

            modelBuilder.Entity("Chinook.WebApi.Models.Playlist", b =>
                {
                    b.Property<int>("PlaylistId");

                    b.Property<string>("Name")
                        .HasMaxLength(120);

                    b.HasKey("PlaylistId")
                        .HasName("playlist_pkey");

                    b.ToTable("Playlist");
                });

            modelBuilder.Entity("Chinook.WebApi.Models.PlaylistTrack", b =>
                {
                    b.Property<int>("PlaylistId");

                    b.Property<int>("TrackId");

                    b.HasKey("PlaylistId", "TrackId")
                        .HasName("playlist_track_pkey");

                    b.HasIndex("TrackId")
                        .HasName("playlist_track_ix_track_id");

                    b.ToTable("PlaylistTrack");
                });

            modelBuilder.Entity("Chinook.WebApi.Models.Track", b =>
                {
                    b.Property<int>("TrackId");

                    b.Property<int?>("AlbumId");

                    b.Property<int?>("Bytes");

                    b.Property<string>("Composer")
                        .HasMaxLength(220);

                    b.Property<int?>("GenreId");

                    b.Property<int>("MediaTypeId");

                    b.Property<int>("Milliseconds");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("TrackId")
                        .HasName("track_pkey");

                    b.HasIndex("AlbumId")
                        .HasName("track_ix_album_id");

                    b.HasIndex("GenreId")
                        .HasName("track_ix_genre_id");

                    b.HasIndex("MediaTypeId")
                        .HasName("track_ix_media_type_id");

                    b.ToTable("Track");
                });

            modelBuilder.Entity("Chinook.WebApi.Models.Album", b =>
                {
                    b.HasOne("Chinook.WebApi.Models.Artist", "Artist")
                        .WithMany("Album")
                        .HasForeignKey("ArtistId")
                        .HasConstraintName("album_artist_id_fkey");
                });

            modelBuilder.Entity("Chinook.WebApi.Models.Customer", b =>
                {
                    b.HasOne("Chinook.WebApi.Models.Employee", "SupportRep")
                        .WithMany("Customer")
                        .HasForeignKey("SupportRepId")
                        .HasConstraintName("customer_support_rep_id_fkey");
                });

            modelBuilder.Entity("Chinook.WebApi.Models.Employee", b =>
                {
                    b.HasOne("Chinook.WebApi.Models.Employee", "ReportsToNavigation")
                        .WithMany("InverseReportsToNavigation")
                        .HasForeignKey("ReportsTo")
                        .HasConstraintName("employee_reports_to_fkey");
                });

            modelBuilder.Entity("Chinook.WebApi.Models.Invoice", b =>
                {
                    b.HasOne("Chinook.WebApi.Models.Customer", "Customer")
                        .WithMany("Invoice")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("invoice_customer_id_fkey");
                });

            modelBuilder.Entity("Chinook.WebApi.Models.InvoiceLine", b =>
                {
                    b.HasOne("Chinook.WebApi.Models.Invoice", "Invoice")
                        .WithMany("InvoiceLine")
                        .HasForeignKey("InvoiceId")
                        .HasConstraintName("invoice_line_invoice_id_fkey");

                    b.HasOne("Chinook.WebApi.Models.Track", "Track")
                        .WithMany("InvoiceLine")
                        .HasForeignKey("TrackId")
                        .HasConstraintName("invoice_line_track_id_fkey");
                });

            modelBuilder.Entity("Chinook.WebApi.Models.PlaylistTrack", b =>
                {
                    b.HasOne("Chinook.WebApi.Models.Playlist", "Playlist")
                        .WithMany("PlaylistTrack")
                        .HasForeignKey("PlaylistId")
                        .HasConstraintName("playlist_track_playlist_id_fkey");

                    b.HasOne("Chinook.WebApi.Models.Track", "Track")
                        .WithMany("PlaylistTrack")
                        .HasForeignKey("TrackId")
                        .HasConstraintName("playlist_track_track_id_fkey");
                });

            modelBuilder.Entity("Chinook.WebApi.Models.Track", b =>
                {
                    b.HasOne("Chinook.WebApi.Models.Album", "Album")
                        .WithMany("Track")
                        .HasForeignKey("AlbumId")
                        .HasConstraintName("track_album_id_fkey");

                    b.HasOne("Chinook.WebApi.Models.Genre", "Genre")
                        .WithMany("Track")
                        .HasForeignKey("GenreId")
                        .HasConstraintName("track_genre_id_fkey");

                    b.HasOne("Chinook.WebApi.Models.MediaType", "MediaType")
                        .WithMany("Track")
                        .HasForeignKey("MediaTypeId")
                        .HasConstraintName("track_media_type_id_fkey");
                });
#pragma warning restore 612, 618
        }
    }
}
