using System.Text.Json.Serialization;

namespace Assessment;

public class Student
{
    [JsonPropertyName("id")]
    public int Id {get; set; }
    [JsonPropertyName("name")]
    public string Name {get; set; }
    [JsonPropertyName("email")]
    public string Email {get; set; }
    public List<Course> EnrolledCourses {get;set; }
}