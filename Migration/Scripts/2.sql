BEGIN;

INSERT INTO tariffs(kind_of_services, service_fee, unit_of_measurement, subscription_fee, 
period_of_payment_month)
VALUES ('cold water',40.34,'m3',0,1),
('hot water',95.25,'m3',0,1),
('electricity',0.75,'kw/h',0,1),
('heating',0,'none',123,3),
('gas',9.56,'m3',0,1)

COMMIT;

