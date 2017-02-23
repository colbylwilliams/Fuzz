using System;
using System.Collections.Generic;

namespace Fuzz.Domain
{
	public class Company
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public Location Location { get; set; }
		public List<Elevator> Elevators { get; set; }
	}
}