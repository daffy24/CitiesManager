using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CitiesManager.Core.Entities;

public class City
{
    [Key]
    [Column("CityId")]

    public Guid CityID { get; set; } 
    public string CityName { get; set; }
}