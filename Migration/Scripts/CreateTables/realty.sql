CREATE TABLE realty
(
	Id bigserial PRIMARY KEY,
	Address varchar(100),
	District varchar(100),
	Type varchar(50),
	AvailableMeters bigint[],
	Ownership varchar(50),
	OwnerId bigserial REFERENCES users(Id),
	Status varchar(30)

);

