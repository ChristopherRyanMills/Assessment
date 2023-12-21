using Microsoft.EntityFrameworkCore;
using Assessment;

public class AssessmentContext : DbContext
{
    public DbSet<StudentDTO> StudentDTOs {get; set; }

    public string DbPath {get; }

    public AssessmentContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "Assessment.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // cleared out personal connection string details, will need to fill in username and password 
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=<yourUserName>;Password=<yourPassword>;Database=PfsAssessment");
    }
}