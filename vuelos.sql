create table usuarios(
	userid SERIAL PRIMARY KEY,
	nickname varchar(15),
	password varchar(15)
)

create table roles(
	roleid SERIAL PRIMARY KEY,
	rolename varchar(15)
)

create table vuelos(
	flyid SERIAL PRIMARY KEY,
	source varchar(15),
	dest varchar(15),
	aval integer,
	status varchar(10)
)


insert into vuelos (source,dest,aval,status) values ('USA','CANADA',0,'AGOTADO')
insert into usuarios (nickname,password) values ('Alam','1234')
insert into roles (rolename) values ('Client')

select*from vuelos order by flyid
select*from usuarios order by userid
select*from roles order by roleid