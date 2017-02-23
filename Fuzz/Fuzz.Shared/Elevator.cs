using System;

namespace Fuzz.Domain
{
	public class Elevator
	{
	    public Guid Id { get; set; }
	    public Guid CompanyId { get; set; }
	    public Guid LocationId { get; set; }
	    public ElevatorStatus Status { get; set; }
	}
}