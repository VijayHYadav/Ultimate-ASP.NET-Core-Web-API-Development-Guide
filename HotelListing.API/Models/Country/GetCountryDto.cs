using System.ComponentModel.DataAnnotations.Schema;
using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Models.Country
{
    public class GetCountryDto : BaseCountryDto
    {
        public int Id { get; set; }
        //public string Name { get; set; }
        //public string ShortName { get; set; }
    }

}


// Rule of thumb: A DTO shouldn't have field that is directly relate a model type or data model