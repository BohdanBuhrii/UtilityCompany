CREATE TABLE meters
(
  Id bigserial PRIMARY KEY,
  KindOfServices varchar(20) REFERENCES tariffs(KindOfServices),
  LastPaidReadings decimal,
  CurrentReadings decimal,
  LastCheckDate date
);

