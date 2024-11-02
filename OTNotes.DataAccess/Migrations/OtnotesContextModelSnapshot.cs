﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OTNotes.DataAccess;

#nullable disable

namespace OTNotes.DataAccess.Migrations
{
    [DbContext(typeof(OtnotesContext))]
    partial class OtnotesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OTNotes.DataAccess.DBObject.AreaOfAssess", b =>
                {
                    b.Property<int>("AreaOfAssessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AreaOfAssessId"));

                    b.Property<string>("AssessArea")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.HasKey("AreaOfAssessId");

                    b.ToTable("AreaOfAssess");
                });

            modelBuilder.Entity("OTNotes.DataAccess.DBObject.ChGeneral", b =>
                {
                    b.Property<int>("CHGeneralId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CHGeneralId"));

                    b.Property<string>("AdaptiveEquipment")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("AdaptiveEquipmentDeatil")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("AdditionalLanguages")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("AttendSchool")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChildChalenges")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ChildIntrest")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ChildPastTherapy")
                        .HasMaxLength(5000)
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CrawlAge")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CurrentPlan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentlyWorking")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("DeficitEffect")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiscribServiceOfOtherAgency")
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DominantLanguage")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DominantLanguageOther")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EnvBarrier")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("EnvBarrierEquipment")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ExpectationFromTherepist")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ExpectedOutcome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FallHistoryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FamilyDefictDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HasFallHistory")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("HasFamilyDefict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HasSocialSkillConcern")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HasSpeechTherapyInPast")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HaveYouReceiveReport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomBoundDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomBoundDetail")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("InterventionDetail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IsHomeBound")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("IsIntervention")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("IsReceivingOutsideAgencyService")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LivingInHomeChild")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("LivingSiblingDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LivingSituation")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("LivingSituationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtBeforDiscription")
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("OtBeforeTaken")
                        .HasColumnType("bit");

                    b.Property<string>("OtherSpecialistsWorkedWith")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PastSpeechTherapyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PriorAdl")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ReceivedPastSpeechTherapyReport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceivingOutsideAgencyWhere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("SitupAge")
                        .HasColumnType("int");

                    b.Property<string>("SocialSkillConcernDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SpeakWordAge")
                        .HasColumnType("int");

                    b.Property<string>("SpeechTherapyReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StandAge")
                        .HasColumnType("int");

                    b.Property<bool?>("TakingServiceByAgency")
                        .HasColumnType("bit");

                    b.Property<string>("UnderstandingLevel")
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

                    b.Property<string>("livingInHome")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CHGeneralId");

                    b.ToTable("CHGeneral");
                });

            modelBuilder.Entity("OTNotes.DataAccess.DBObject.ChMedical", b =>
                {
                    b.Property<int>("CHMedicalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CHMedicalId"));

                    b.Property<string>("AllergyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnyPreviousSurgeries")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("BehavioralDiagnoses")
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<string>("CoughAfterDrink")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DevelopmentalDiagnoses")
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("FCMIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HadHeadInjury")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HasAllergy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HasRecentChangeInVoice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeadInjuryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsOnMedication")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JointPainDiscomfort")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastHearingScreeningDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastHearingScreeningResult")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastVisionScreeningDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastVisionScreeningResult")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalDiagnosisList")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NoticeChange")
                        .HasColumnType("datetime2");

                    b.Property<string>("OverallHealthDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrecautionsLimitations")
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrenatalBirthHistory")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreviousSurgeriesDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProblemSwallowSwitch")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StayNICU")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.HasKey("CHMedicalId");

                    b.ToTable("CHMedical");
                });
#pragma warning restore 612, 618
        }
    }
}
