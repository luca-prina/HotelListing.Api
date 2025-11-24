namespace HotelListing.Api.DTOs.Hotel;

public class GetHotelSlimDto
{


    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Address { get; set; }
    public double Rating { get; set; }

}
