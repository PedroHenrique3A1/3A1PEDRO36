create database pedro36;
use pedro36;

create table login(
id int auto_increment primary key,
nome varchar(40) not null,
senha varchar(40) not null
)ENGINE = innodb;

create table games(
id int auto_increment primary key,
nome varchar(50) not null,
preco double not null
)ENGINE = innodb;

create table tipo_game(
id int auto_increment primary key,
tipo_midia varchar(50) not null,
descricao varchar(50) not null
)ENGINE = innodb;

alter table tipo_game add constraint fk_id foreign key (id) references games (id); 

