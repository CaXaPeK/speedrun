using Microsoft.EntityFrameworkCore;
using Speedrun.Models.Database.Entities;
using Speedrun.Models.Enums;

namespace Speedrun.Models.Database;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Club> Clubs => Set<Club>();
    public DbSet<Sport> Sports => Set<Sport>();
    public DbSet<Discipline> Disciplines => Set<Discipline>();
    public DbSet<Feature> Features => Set<Feature>();
    public DbSet<FeatureValue> FeatureValues => Set<FeatureValue>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<SelectionCriterion> SelectionCriteria => Set<SelectionCriterion>();
    public DbSet<Competition> Competitions => Set<Competition>();
    public DbSet<Venue> Venues => Set<Venue>();
    public DbSet<CompetitionCategory> CompetitionCategories => Set<CompetitionCategory>();
    public DbSet<CompetitionParticipant> CompetitionParticipants => Set<CompetitionParticipant>();
    public DbSet<ParticipantBracketSnapshot> ParticipantBracketSnapshots => Set<ParticipantBracketSnapshot>();
    public DbSet<Application> Applications => Set<Application>();
    public DbSet<ApplicationEntry> ApplicationEntries => Set<ApplicationEntry>();
    public DbSet<ApplicationEntryFeatureValue> ApplicationEntryFeatureValues => Set<ApplicationEntryFeatureValue>();
    public DbSet<Payment> Payments => Set<Payment>();
    public DbSet<Subgroup> Subgroups => Set<Subgroup>();
    public DbSet<SubgroupParticipant> SubgroupParticipants => Set<SubgroupParticipant>();
    public DbSet<Grid> Grids => Set<Grid>();
    public DbSet<GridRound> GridRounds => Set<GridRound>();
    public DbSet<Match> Matches => Set<Match>();
    public DbSet<MatchParticipant> MatchParticipants => Set<MatchParticipant>();
    public DbSet<MatchEvent> MatchEvents => Set<MatchEvent>();
    public DbSet<JudgementType> JudgementTypes => Set<JudgementType>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasMany(u => u.Trainers)
            .WithMany(u => u.Trainees)
            .UsingEntity(j => j.ToTable("SportsmanTrainer"));

        modelBuilder.Entity<User>()
            .HasMany(u => u.AdministratedClubs)
            .WithMany(c => c.Administrators)
            .UsingEntity(j => j.ToTable("ClubAdministrator"));

        modelBuilder.Entity<User>()
            .HasMany(u => u.Features)
            .WithOne(f => f.User)
            .HasForeignKey(f => f.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Club>()
            .HasMany(c => c.Members)
            .WithOne(u => u.Club)
            .HasForeignKey(u => u.ClubId)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<SelectionCriterion>()
            .HasDiscriminator<string>("CriterionKind")
            .HasValue<RangeSelectionCriterion>("Range")
            .HasValue<ListSelectionCriterion>("List");

        modelBuilder.Entity<ListSelectionCriterion>()
            .PrimitiveCollection(c => c.AcceptableValues);

        modelBuilder.Entity<Feature>()
            .PrimitiveCollection(f => f.AllowedValues);

        modelBuilder.Entity<MatchEvent>()
            .HasDiscriminator(e => e.Kind)
            .HasValue<MatchStartedEvent>(MatchEventKind.MatchStarted)
            .HasValue<MatchPausedEvent>(MatchEventKind.MatchPaused)
            .HasValue<MatchResumedEvent>(MatchEventKind.MatchResumed)
            .HasValue<MatchEndedEvent>(MatchEventKind.MatchEnded)
            .HasValue<ScoreRecordedEvent>(MatchEventKind.ScoreRecorded);

        modelBuilder.Entity<Match>()
            .HasOne(m => m.NextMatchIfWin)
            .WithMany()
            .HasForeignKey(m => m.NextMatchIfWinId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Match>()
            .HasOne(m => m.NextMatchIfLose)
            .WithMany()
            .HasForeignKey(m => m.NextMatchIfLoseId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CompetitionParticipant>()
            .HasOne(p => p.BracketSnapshot)
            .WithOne(s => s.CompetitionParticipant)
            .HasForeignKey<ParticipantBracketSnapshot>(s => s.CompetitionParticipantId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ApplicationEntry>()
            .HasOne<CompetitionParticipant>()
            .WithOne(p => p.ApplicationEntry)
            .HasForeignKey<CompetitionParticipant>(p => p.ApplicationEntryId)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Application>()
            .HasIndex(a => new { a.CompetitionId, a.SubmittedByUserId })
            .IsUnique();

        modelBuilder.Entity<ScoreRecordedEvent>()
            .HasOne(e => e.JudgementType)
            .WithMany()
            .HasForeignKey(e => e.JudgementTypeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
