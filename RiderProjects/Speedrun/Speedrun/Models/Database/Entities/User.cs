using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class User
{
    [Key]
    public Guid Id { get; set; }
    
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string Patronymic { get; set; } = null!;
    
    public string Email { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;

    public Club? Club { get; set; }
    public ICollection<Club> AdministratedClubs = new List<Club>();
        
    public ICollection<User> Trainers = new List<User>();
    public ICollection<User> Trainees = new List<User>();
    
    public ICollection<FeatureValue> Features = new List<FeatureValue>();

    public ICollection<Competition> OrganizedCompetitions = new List<Competition>();
    public ICollection<CompetitionParticipant> CompetitionParticipations = new List<CompetitionParticipant>();
    public ICollection<Subgroup> SecretatedSubgroups { get; set; } = null!;
}