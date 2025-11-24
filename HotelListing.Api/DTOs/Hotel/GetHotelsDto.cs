namespace HotelListing.Api.DTOs.Hotel;

public class GetHotelsDto
{

    public int Id { get; set; }

    public required string Name { get; set; }

    public required string Address { get; set; }

    public double Rating { get; set; }


    // Foreign Key
    public int CountryId { get; set; }


}
