//Parking lot
//	Supossing that is the onew where you pay ticket and put it in your windshield

// Objects
//	- Spaces (handicapped, motorbikes, cars)
//	- Meter
//	

public class Space
{
	public bool IsAvailable {get;set;}
	public bool IsReserved {get;set;}
}

public class BikeSpace : Space{

}

public class CarSpace : Space{
	public bool IsHandicapped {get; private set;}	
}

public class TicketMachine
{
	private decimal _insertedAmount;
	public decimal CarSpacePrice {get;set;}
	public decimal BikeSpacePrice {get;set;}
	public void GetTicketFor(CarSpace space)
	{
		decimal price;
		switch(typeof(space)){
			case CarSpace: 
				price = CarSpacePrice;
				break;
			case BikeSpace: 
				price = CarSpacePrice;
				break;
			default: throw new Exception($"Not set price for car space type {typeof(space)}");
		}
		while()
	}
}

public class ParkingLot{
	private List<Space> _spaces;
	private List<TicketMachine> _ticketMachine;

	public bool RequestAccessFor(Vehicle vehicle)
	{
		if(vehicle == Vehicle.Car)
			return OccupySpace(typeof(CarSpace));
		else
			return OccupySpace(typeof(BikeSpace));
	}

	public int GetAvailableSpaceCount(){
		return _spaces.Count(s => s.IsAvailable);
	}

	private bool OccupySpace(type carSpaceType)
	{
		var space = _spaces.FirstOrDefault(s => s.IsAvailable && s is carSpaceType);
		if(space != null)
		{
			space.IsAvailable = false;
			return true;
		}
		return false;
	}
}

public enum Vehicle{
	Car,
	Bike
}
