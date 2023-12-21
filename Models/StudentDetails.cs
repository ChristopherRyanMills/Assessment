using System.Text.Json.Serialization;

namespace Assessment;

public class StudentDetails
{
    [JsonPropertyName("id")]
    public int Id {get; set; }
    [JsonPropertyName("name")]
    public string Name {get; set; }
    [JsonPropertyName("email")]
    public string Email {get; set; }
    [JsonPropertyName("courses")]
    public List<CourseDetails> Courses {get; set; }

}