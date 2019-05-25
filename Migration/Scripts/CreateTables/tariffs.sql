CREATE TABLE tariffs
(
  KindOfServices varchar(20) PRIMARY KEY,
  ServiceFee money,
  UnitOfMeasurement varchar(10),
  SubscriptionFee money,
  PeriodOfPaymentMonth int
);

