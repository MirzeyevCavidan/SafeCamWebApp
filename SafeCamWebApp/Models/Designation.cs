using SafeCamWebApp.Models.Base;
namespace SafeCamWebApp.Models;

public class Designation : BaseEntity
{
    public string Name { get; set; }
    public List<Worker> Workers { get; set; } = new List<Worker>();
}