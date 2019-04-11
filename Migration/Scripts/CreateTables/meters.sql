CREATE TABLE meters
(
  meter_id bigserial PRIMARY KEY,
  kind_of_services char(20) REFERENCES tariffs(kind_of_services),
  last_paid_readings decimal,
  current_readings decimal,
  last_check_date date
);

