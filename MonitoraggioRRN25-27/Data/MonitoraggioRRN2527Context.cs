using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MonitoraggioPAC25_27.Models;

namespace MonitoraggioPAC25_27.Data;

public partial class MonitoraggioRRN2527Context : DbContext
{
    public MonitoraggioRRN2527Context()
    {
    }

    public MonitoraggioRRN2527Context(DbContextOptions<MonitoraggioRRN2527Context> options)
        : base(options)
    {
    }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<Enti> Entis { get; set; }

    public virtual DbSet<Output> Outputs { get; set; }

    public virtual DbSet<PeriodiMonitoraggio> PeriodiMonitoraggios { get; set; }

    public virtual DbSet<Progetti> Progettis { get; set; }

    public virtual DbSet<Schede> Schedes { get; set; }

    public virtual DbSet<Temi> Temis { get; set; }

    public virtual DbSet<TipiOutput> TipiOutputs { get; set; }

    public virtual DbSet<Utenti> Utentis { get; set; }

    public virtual DbSet<UtentiProgettoEnte> UtentiProgettoEntes { get; set; }

    public virtual DbSet<UtentiProgettoMinistero> UtentiProgettoMinisteros { get; set; }

    public virtual DbSet<UtentiRuoli> UtentiRuolis { get; set; }

    public virtual DbSet<UtentiSchedaEnte> UtentiSchedaEntes { get; set; }

    public virtual DbSet<v_ElencoOutput> v_ElencoOutputs { get; set; }

    public virtual DbSet<v_ElencoProgetti> v_ElencoProgettis { get; set; }

    public virtual DbSet<v_ElencoSchede> v_ElencoSchedes { get; set; }

    public virtual DbSet<v_SchedeProgettiOutput> v_SchedeProgettiOutputs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Enti>(entity =>
        {
            entity.HasKey(e => e.CodEnte).HasName("PK_Ente");

            entity.ToTable("Enti");

            entity.Property(e => e.CodEnte).ValueGeneratedNever();
            entity.Property(e => e.DescrizioneEnte)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Output>(entity =>
        {
            entity.HasKey(e => e.IdOutput);

            entity.ToTable("Output");

            entity.Property(e => e.CodOutputCompleto).HasMaxLength(14);
            entity.Property(e => e.CodPriorita)
                .HasMaxLength(2)
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CodTema)
                .HasMaxLength(3)
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CodTipoOutput).HasMaxLength(3);
            entity.Property(e => e.ComunicazioneData).HasColumnType("datetime");
            entity.Property(e => e.ObiettivoRete).HasMaxLength(2);
            entity.Property(e => e.ParereResponsabileMinisteroData).HasColumnType("datetime");
            entity.Property(e => e.UltimoAggiornamento)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CodTemaNavigation).WithMany(p => p.Outputs)
                .HasForeignKey(d => d.CodTema)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Output_Temi");

            entity.HasOne(d => d.CodTipoOutputNavigation).WithMany(p => p.Outputs)
                .HasForeignKey(d => d.CodTipoOutput)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Output_TipiOutput");

            entity.HasOne(d => d.IdProgettoNavigation).WithMany(p => p.Outputs)
                .HasForeignKey(d => d.IdProgetto)
                .HasConstraintName("FK_Output_Progetti");
        });

        modelBuilder.Entity<PeriodiMonitoraggio>(entity =>
        {
            entity.HasKey(e => e.DataMonitoraggio);

            entity.ToTable("PeriodiMonitoraggio");
        });

        modelBuilder.Entity<Progetti>(entity =>
        {
            entity.HasKey(e => e.idProgetto);

            entity.ToTable("Progetti");

            entity.Property(e => e.CodProgetto).HasMaxLength(10);
            entity.Property(e => e.DataInserimentoResponsabileProgettoEnte).HasColumnType("datetime");
            entity.Property(e => e.DataInserimentoResponsabileProgettoMinistero).HasColumnType("datetime");
            entity.Property(e => e.Progetto).HasMaxLength(255);

            entity.HasOne(d => d.IdSchedaNavigation).WithMany(p => p.Progettis)
                .HasForeignKey(d => d.IdScheda)
                .HasConstraintName("FK_Progetti_Schede");
        });

        modelBuilder.Entity<Schede>(entity =>
        {
            entity.HasKey(e => e.IdScheda);

            entity.ToTable("Schede");

            entity.Property(e => e.CodScheda).HasMaxLength(10);
            entity.Property(e => e.Scheda).HasMaxLength(255);

            entity.HasOne(d => d.CodEnteNavigation).WithMany(p => p.Schedes)
                .HasForeignKey(d => d.CodEnte)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Schede_Enti");

            entity.HasOne(d => d.DataMonitoraggioNavigation).WithMany(p => p.Schedes)
                .HasForeignKey(d => d.DataMonitoraggio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Schede_PeriodiMonitoraggio");
        });

        modelBuilder.Entity<Temi>(entity =>
        {
            entity.HasKey(e => e.CodTema);

            entity.ToTable("Temi");

            entity.Property(e => e.CodTema).HasMaxLength(3);
        });

        modelBuilder.Entity<TipiOutput>(entity =>
        {
            entity.HasKey(e => e.CodTipoOutput);

            entity.ToTable("TipiOutput");

            entity.Property(e => e.CodTipoOutput).HasMaxLength(3);
            entity.Property(e => e.CodReg8082013).HasMaxLength(10);
            entity.Property(e => e.TipoOutput).HasMaxLength(255);
        });

        modelBuilder.Entity<Utenti>(entity =>
        {
            entity.HasKey(e => e.idUtente).HasName("PK_Utentee");

            entity.ToTable("Utenti");

            entity.HasIndex(e => e.Email, "UQ_Utenti").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Utente).HasMaxLength(255);
            entity.Property(e => e.idAspNetUser).HasMaxLength(450);

            entity.HasOne(d => d.idAspNetUserNavigation).WithMany(p => p.Utentis)
                .HasForeignKey(d => d.idAspNetUser)
                .HasConstraintName("FK_Utenti_AspNetUsers");
        });

        modelBuilder.Entity<UtentiProgettoEnte>(entity =>
        {
            entity.HasKey(e => e.idUtenteProgettoEnte);

            entity.ToTable("UtentiProgettoEnte");

            entity.HasOne(d => d.idProgettoNavigation).WithMany(p => p.UtentiProgettoEntes)
                .HasForeignKey(d => d.idProgetto)
                .HasConstraintName("FK_UtentiProgettoEnte_Progetti");

            entity.HasOne(d => d.idUtenteNavigation).WithMany(p => p.UtentiProgettoEntes)
                .HasForeignKey(d => d.idUtente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UtentiProgettoEnte_Utenti");
        });

        modelBuilder.Entity<UtentiProgettoMinistero>(entity =>
        {
            entity.HasKey(e => e.idUtenteProgettoMinistero);

            entity.ToTable("UtentiProgettoMinistero");

            entity.HasOne(d => d.idProgettoNavigation).WithMany(p => p.UtentiProgettoMinisteros)
                .HasForeignKey(d => d.idProgetto)
                .HasConstraintName("FK_UtentiProgettoMinistero_Progetti");

            entity.HasOne(d => d.idUtenteNavigation).WithMany(p => p.UtentiProgettoMinisteros)
                .HasForeignKey(d => d.idUtente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UtentiProgettoMinistero_Utenti");
        });

        modelBuilder.Entity<UtentiRuoli>(entity =>
        {
            entity.HasKey(e => e.IdUtenteRuolo).HasName("PK_UtenteRuolo");

            entity.ToTable("UtentiRuoli");

            entity.Property(e => e.IdAspNetRoles).HasMaxLength(450);

            entity.HasOne(d => d.IdAspNetRolesNavigation).WithMany(p => p.UtentiRuolis)
                .HasForeignKey(d => d.IdAspNetRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UtentiRuoli_AspNetRoles");

            entity.HasOne(d => d.IdUtenteNavigation).WithMany(p => p.UtentiRuolis)
                .HasForeignKey(d => d.IdUtente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UtentiRuoli_Utenti");
        });

        modelBuilder.Entity<UtentiSchedaEnte>(entity =>
        {
            entity.HasKey(e => e.idUtenteScheda);

            entity.ToTable("UtentiSchedaEnte");

            entity.HasOne(d => d.idSchedaNavigation).WithMany(p => p.UtentiSchedaEntes)
                .HasForeignKey(d => d.idScheda)
                .HasConstraintName("FK_UtentiSchedaEnte_Schede");

            entity.HasOne(d => d.idUtenteNavigation).WithMany(p => p.UtentiSchedaEntes)
                .HasForeignKey(d => d.idUtente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UtentiSchedaEnte_Utenti");
        });

        modelBuilder.Entity<v_ElencoOutput>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ElencoOutput");

            entity.Property(e => e.CodOutputCompleto).HasMaxLength(14);
            entity.Property(e => e.CodPriorita).HasMaxLength(2);
            entity.Property(e => e.CodTema).HasMaxLength(3);
            entity.Property(e => e.CodTipoOutput).HasMaxLength(3);
            entity.Property(e => e.ComunicazioneData).HasColumnType("datetime");
            entity.Property(e => e.ObiettivoRete).HasMaxLength(2);
            entity.Property(e => e.ParereResponsabileMinisteroData).HasColumnType("datetime");
            entity.Property(e => e.UltimoAggiornamento).HasColumnType("datetime");
        });

        modelBuilder.Entity<v_ElencoProgetti>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ElencoProgetti");

            entity.Property(e => e.CodProgetto).HasMaxLength(10);
            entity.Property(e => e.DataInserimentoResponsabileProgettoEnte).HasColumnType("datetime");
            entity.Property(e => e.DataInserimentoResponsabileProgettoMinistero).HasColumnType("datetime");
            entity.Property(e => e.IdProgetto).ValueGeneratedOnAdd();
            entity.Property(e => e.Progetto).HasMaxLength(255);
        });

        modelBuilder.Entity<v_ElencoSchede>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ElencoSchede");

            entity.Property(e => e.CodScheda).HasMaxLength(10);
            entity.Property(e => e.Ente)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ResponsabileScheda).HasMaxLength(255);
            entity.Property(e => e.ResponsabileSchedaEmail).HasMaxLength(255);
            entity.Property(e => e.Scheda).HasMaxLength(255);
        });

        modelBuilder.Entity<v_SchedeProgettiOutput>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SchedeProgettiOutput");

            entity.Property(e => e.CodOutputCompleto).HasMaxLength(14);
            entity.Property(e => e.CodPriorita).HasMaxLength(2);
            entity.Property(e => e.CodProgetto).HasMaxLength(10);
            entity.Property(e => e.CodScheda).HasMaxLength(10);
            entity.Property(e => e.CodTema).HasMaxLength(3);
            entity.Property(e => e.CodTipoOutput).HasMaxLength(3);
            entity.Property(e => e.ComunicazioneData).HasColumnType("datetime");
            entity.Property(e => e.DataInserimentoResponsabileProgettoEnte).HasColumnType("datetime");
            entity.Property(e => e.DataInserimentoResponsabileProgettoMinistero).HasColumnType("datetime");
            entity.Property(e => e.Ente)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ObiettivoRete).HasMaxLength(2);
            entity.Property(e => e.ParereResponsabileMinisteroData).HasColumnType("datetime");
            entity.Property(e => e.Progetto).HasMaxLength(255);
            entity.Property(e => e.ResponsabileScheda).HasMaxLength(255);
            entity.Property(e => e.ResponsabileSchedaEmail).HasMaxLength(255);
            entity.Property(e => e.Scheda).HasMaxLength(255);
            entity.Property(e => e.UltimoAggiornamento).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}