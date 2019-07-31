CREATE TABLE animais(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100),
extinto BIT,
peso decimal(4,2)
);
drop table animais;
select * from animais;
drop table animais;

Alter table animais add peso decimal(4,2) default 0.0;
update animais set peso = 0;
delete from animais where id = 2;