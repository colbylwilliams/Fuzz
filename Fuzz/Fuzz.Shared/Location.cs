using System;

namespace Fuzz.Domain
{
	public class Location
	{
	    public Guid Id { get; set; }
	    public Guid CompanyId { get; set; }
	    public string Street { get; set; }
	    public string City { get; set; }
	    public string State { get; set; }
	    public string Country { get; set; }
	    public string CountryCode { get; set; }
	    public string PostalCode { get; set; }
	    public double Latitude { get; set; }
	    public double Longitude { get; set; }
	}
}