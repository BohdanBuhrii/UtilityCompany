CREATE TABLE users
(
  user_id bigserial PRIMARY KEY,
  user_name varchar(100),
  email varchar(100) UNIQUE,
  hash_password varchar(88),
  is_employee boolean,
  access_level varchar(50)
);

