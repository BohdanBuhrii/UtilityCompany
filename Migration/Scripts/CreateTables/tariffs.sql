CREATE TABLE tariffs
(
  kind_of_services char(20) PRIMARY KEY,
  service_fee money,
  unit_of_measurement char(10),
  subscription_fee money,
  period_of_payment_month int
);

