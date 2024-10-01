using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SendQarchakData.Entities;

public partial class TaxitaniQarchakContext : DbContext
{
    public TaxitaniQarchakContext()
    {
    }

    public TaxitaniQarchakContext(DbContextOptions<TaxitaniQarchakContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VetehadieJameTable> VetehadieJameTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("server=.;database=TaxitaniQarchak;User id = dalvand;password=12345;trustservercertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Arabic_CI_AS");

        modelBuilder.Entity<VetehadieJameTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VEtehadi__3214EC070D17E1CF");

            entity.ToTable("VEtehadieJameTable");

            entity.Property(e => e.AzadRegionPlateType).HasMaxLength(10);
            entity.Property(e => e.BeneficiaryPersonAddress).HasMaxLength(500);
            entity.Property(e => e.BeneficiaryPersonBirthCity).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryPersonBirthDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BeneficiaryPersonFatherName).HasMaxLength(30);
            entity.Property(e => e.BeneficiaryPersonGender).HasMaxLength(400);
            entity.Property(e => e.BeneficiaryPersonIdentity)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryPersonLastName).HasMaxLength(40);
            entity.Property(e => e.BeneficiaryPersonMarital).HasMaxLength(400);
            entity.Property(e => e.BeneficiaryPersonMobile)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryPersonName).HasMaxLength(40);
            entity.Property(e => e.BeneficiaryPersonNationalCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryPersonNecessaryPhone).HasMaxLength(11);
            entity.Property(e => e.BeneficiaryPersonPhone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryPersonPostalCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryPersonReligion).HasMaxLength(50);
            entity.Property(e => e.CarChassisNumber)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.CarColor).HasMaxLength(400);
            entity.Property(e => e.CarFuelType).HasMaxLength(400);
            entity.Property(e => e.CarInsuranceBranchCode).HasMaxLength(5);
            entity.Property(e => e.CarInsuranceBranchName).HasMaxLength(100);
            entity.Property(e => e.CarInsuranceCompany).HasMaxLength(400);
            entity.Property(e => e.CarInsuranceExpireDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CarInsuranceIssueDate).HasMaxLength(10);
            entity.Property(e => e.CarInsuranceNumber).HasMaxLength(70);
            entity.Property(e => e.CarInsuranceStartDate).HasMaxLength(10);
            entity.Property(e => e.CarInsuranceUniqueCode).HasMaxLength(500);
            entity.Property(e => e.CarModel)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CarMotorNumber)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.CarOwnerAddress).HasMaxLength(500);
            entity.Property(e => e.CarOwnerBirthCity).HasMaxLength(50);
            entity.Property(e => e.CarOwnerBirthDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CarOwnerFatherName).HasMaxLength(30);
            entity.Property(e => e.CarOwnerFirstName).HasMaxLength(40);
            entity.Property(e => e.CarOwnerGender).HasMaxLength(400);
            entity.Property(e => e.CarOwnerLastName).HasMaxLength(40);
            entity.Property(e => e.CarOwnerMarital).HasMaxLength(400);
            entity.Property(e => e.CarOwnerMobile)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.CarOwnerNationalCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CarOwnerNecessaryPhone).HasMaxLength(11);
            entity.Property(e => e.CarOwnerPhone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CarOwnerPostalCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CarOwnerReligion).HasMaxLength(50);
            entity.Property(e => e.CarPannumber)
                .HasMaxLength(17)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CarPlateChar).HasMaxLength(128);
            entity.Property(e => e.CarPlateCode).HasMaxLength(128);
            entity.Property(e => e.CarPlatePart1).HasMaxLength(128);
            entity.Property(e => e.CarPlatePart2).HasMaxLength(128);
            entity.Property(e => e.CarPlateType).HasMaxLength(20);
            entity.Property(e => e.CarSystemType).HasMaxLength(400);
            entity.Property(e => e.CarType).HasMaxLength(400);
            entity.Property(e => e.CarVinnumber)
                .HasMaxLength(17)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DriverPersonAddress).HasMaxLength(500);
            entity.Property(e => e.DriverPersonBirthCity).HasMaxLength(50);
            entity.Property(e => e.DriverPersonBirthDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DriverPersonFatherName).HasMaxLength(30);
            entity.Property(e => e.DriverPersonFirstName).HasMaxLength(40);
            entity.Property(e => e.DriverPersonGender).HasMaxLength(400);
            entity.Property(e => e.DriverPersonIdentityNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.DriverPersonLastName).HasMaxLength(40);
            entity.Property(e => e.DriverPersonLicense).HasMaxLength(400);
            entity.Property(e => e.DriverPersonLicenseExpirationDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DriverPersonLicenseIssuanceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DriverPersonLicenseNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DriverPersonLicenseSerialNumber).HasMaxLength(15);
            entity.Property(e => e.DriverPersonMarital).HasMaxLength(400);
            entity.Property(e => e.DriverPersonMobile)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.DriverPersonNationalCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DriverPersonNecessaryPhone).HasMaxLength(11);
            entity.Property(e => e.DriverPersonPhone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DriverPersonPostalCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DriverPersonReligion).HasMaxLength(50);
            entity.Property(e => e.FileNumber).HasMaxLength(30);
            entity.Property(e => e.LicenseExpirationDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LicenseIssuanceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LicenseMinorUseType).HasMaxLength(400);
            entity.Property(e => e.LicenseNumber).HasMaxLength(20);
            entity.Property(e => e.LicenseUseType).HasMaxLength(400);
            entity.Property(e => e.SecondDriverEmploymentFileNumber).HasMaxLength(30);
            entity.Property(e => e.SecondDriverEmploymentLicenseExpirationDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SecondDriverEmploymentLicenseIssuanceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SecondDriverEmploymentLicenseMinorUseType).HasMaxLength(400);
            entity.Property(e => e.SecondDriverEmploymentLicenseUseType).HasMaxLength(400);
            entity.Property(e => e.SecondDriverEmploymentNumber).HasMaxLength(20);
            entity.Property(e => e.SecondDriverPersonAddress).HasMaxLength(500);
            entity.Property(e => e.SecondDriverPersonBirthCity).HasMaxLength(50);
            entity.Property(e => e.SecondDriverPersonBirthDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SecondDriverPersonFatherName).HasMaxLength(30);
            entity.Property(e => e.SecondDriverPersonFirstName).HasMaxLength(40);
            entity.Property(e => e.SecondDriverPersonGender).HasMaxLength(400);
            entity.Property(e => e.SecondDriverPersonIdentityNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SecondDriverPersonLastName).HasMaxLength(40);
            entity.Property(e => e.SecondDriverPersonLicense).HasMaxLength(400);
            entity.Property(e => e.SecondDriverPersonLicenseExpirationDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SecondDriverPersonLicenseIssuanceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SecondDriverPersonLicenseNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SecondDriverPersonLicenseSerialNumber).HasMaxLength(15);
            entity.Property(e => e.SecondDriverPersonMarital).HasMaxLength(400);
            entity.Property(e => e.SecondDriverPersonMobile)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.SecondDriverPersonNationalCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SecondDriverPersonNecessaryPhone).HasMaxLength(11);
            entity.Property(e => e.SecondDriverPersonPhone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SecondDriverPersonPostalCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecondDriverPersonReligious).HasMaxLength(50);
            entity.Property(e => e.TechnicalCheckupDescription).HasMaxLength(500);
            entity.Property(e => e.TechnicalCheckupExpireDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TechnicalCheckupIssueDate).HasMaxLength(10);
            entity.Property(e => e.TechnicalCheckupStartDate).HasMaxLength(10);
            entity.Property(e => e.TechnicalCheckupTechnicalNumber).HasMaxLength(70);
            entity.Property(e => e.ThirdDriverEmploymentFileNumber).HasMaxLength(30);
            entity.Property(e => e.ThirdDriverEmploymentLicenseExpirationDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ThirdDriverEmploymentLicenseIssuanceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ThirdDriverEmploymentLicenseMinorUseType).HasMaxLength(400);
            entity.Property(e => e.ThirdDriverEmploymentLicenseUseType).HasMaxLength(400);
            entity.Property(e => e.ThirdDriverEmploymentNumber).HasMaxLength(20);
            entity.Property(e => e.ThirdDriverPersonAddress).HasMaxLength(500);
            entity.Property(e => e.ThirdDriverPersonBirthCity).HasMaxLength(50);
            entity.Property(e => e.ThirdDriverPersonBirthDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ThirdDriverPersonFatherName).HasMaxLength(30);
            entity.Property(e => e.ThirdDriverPersonFirstName).HasMaxLength(40);
            entity.Property(e => e.ThirdDriverPersonGender).HasMaxLength(400);
            entity.Property(e => e.ThirdDriverPersonIdentityNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ThirdDriverPersonLastName).HasMaxLength(40);
            entity.Property(e => e.ThirdDriverPersonLicense).HasMaxLength(400);
            entity.Property(e => e.ThirdDriverPersonLicenseExpirationDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ThirdDriverPersonLicenseIssuanceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ThirdDriverPersonLicenseNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ThirdDriverPersonLicenseSerialNumber).HasMaxLength(15);
            entity.Property(e => e.ThirdDriverPersonMarital).HasMaxLength(400);
            entity.Property(e => e.ThirdDriverPersonMobile)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.ThirdDriverPersonNationalCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ThirdDriverPersonNecessaryPhone).HasMaxLength(11);
            entity.Property(e => e.ThirdDriverPersonPhone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ThirdDriverPersonPostalCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ThirdDriverPersonReligious).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
