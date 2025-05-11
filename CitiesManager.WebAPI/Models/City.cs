using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CitiesManager.WebAPI.Models;

public class City
{
    [Key]
    [Column("CityId")]

    public Guid CityID { get; set; } 
    public string CityName { get; set; }
}