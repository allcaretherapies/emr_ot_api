﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OTNotes.DataAccess;

#nullable disable

namespace OTNotes.DataAccess.Migrations
{
    [DbContext(typeof(OtnotesContext))]
    [Migration("20240207075314_Altercolumn")]
    partial class Altercolumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OTNotes.DataAccess.Chgeneral", b =>
                {
                    b.Property<int>("ChgeneralId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChgeneralId"));

                    b.Property<string>("AdaptiveEquipment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdaptiveEquipmentDeatil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdditionalLanguages")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AttendSchool")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassGrade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int?>("ComWordsAge")
                        .HasColumnType("int");

                    b.Property<int?>("ComWordsAge1")
                        .HasColumnType("int");

                    b.Property<string>("CommunicatesThrough")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CrawlAge")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CurrentPlan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeficitEffect")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DominantLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DominantLanguageOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvBarrier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvBarrierEquipment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpectedOutcome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FallHistory")
                        .HasColumnType("datetime2");

                    b.Property<string>("FamilyDefictDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HasFallHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HasFamilyDefict")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HasSocialSkillConcern")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HasSpeechTherapyInPast")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HaveYouReceiveReport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomBoundDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomBoundDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InterventionDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsHomeBound")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsIntervention")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsReceivingOutsideAgencyService")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LivingSiblingDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LivingSituation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LivingSituationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewColumn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherSpecialistsWorkedWith")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PastSpeechTherapyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PriorAdl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceivedPastSpeechTherapyReport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceivingOutsideAgencyWhere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SitupAge")
                        .HasColumnType("int");

                    b.Property<string>("SocialSkillConcernDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SpeakWordAge")
                        .HasColumnType("int");

                    b.Property<string>("SpeechTherapyReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StandAge")
                        .HasColumnType("int");

                    b.Property<string>("UnderstandingLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.Property<int?>("WalkAge")
                        .HasColumnType("int");

                    b.Property<string>("WhereName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChgeneralId");

                    b.ToTable("CHGeneral");
                });

            modelBuilder.Entity("OTNotes.DataAccess.Chmedical", b =>
                {
                    b.Property<int>("ChmedicalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChmedicalId"));

                    b.Property<string>("AllergyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diagnosis1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Diagnosis1OnsetDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diagnosis2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Diagnosis2OnsetDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diagnosis3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Diagnosis3OnsetDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diagnosis4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Diagnosis4OnsetDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoesWearGlasses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoesWearHearingAids")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FcmIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HadHeadInjury")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HasAllergy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HasRecentChangeInVoice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeadInjuryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsOnMedication")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastHearingScreeningDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastHearingScreeningResult")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastVisionScreeningDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastVisionScreeningResult")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NoticeChange")
                        .HasColumnType("datetime2");

                    b.Property<string>("OverallHealthDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreviousSurgeriesDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.HasKey("ChmedicalId");

                    b.ToTable("CHMedical");
                });
#pragma warning restore 612, 618
        }
    }
}
