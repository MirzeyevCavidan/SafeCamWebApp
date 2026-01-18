using SafeCamWebApp.Models.Base;

namespace SafeCamWebApp.Models;

public class Worker : BaseEntity
{
    public string Fullname { get; set; }
    public string ImageUrl { get; set; }
    public int DesignationId { get; set; }
    public Designation Designation { get; set; }
}