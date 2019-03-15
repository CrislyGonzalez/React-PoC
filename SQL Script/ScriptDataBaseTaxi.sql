use Taxi



create TABLE Meter (
    IdTrip int IDENTITY(1,1)  ,
	DateAndTimeTrip DateTime,
	StateTrip varchar(50),
    OrigenRouteTrip varchar(100),
	DestinationRouteTrip varchar(100),
	MilesTrip varchar(50),
	PRIMARY KEY (IdTrip)
);



drop table Meter



select * from Meter