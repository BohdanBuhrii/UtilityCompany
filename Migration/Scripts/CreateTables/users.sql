CREATE TABLE users
(
  Id bigserial PRIMARY KEY,
  Name varchar(100),
  Email varchar(100) UNIQUE,
  HashPassword varchar(88),
  IsEmployee boolean,
  AccessLevel varchar(50)
);

