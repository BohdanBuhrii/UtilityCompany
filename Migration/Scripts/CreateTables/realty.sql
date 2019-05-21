CREATE TABLE realty
(
	realty_id bigserial PRIMARY KEY,
	address char(100),
	district char(100),
	realty_type char(50),
	available_meters bigint[],
	ownership char(50),
	owner_id bigserial REFERENCES users(users_id),
	status char(30)

);

