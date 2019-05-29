CREATE TABLE news
(
	Id bigserial primary key,
	Title varchar(200),
	Content text,
	CreationDate date
)
