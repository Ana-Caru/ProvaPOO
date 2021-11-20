create database 3C1ANACAROLINA01;
use 3C1ANACAROLINA01;

create table tbl_Produto
(
    Id           int not null auto_increment primary key,
    Preco        varchar(15) not null,
    Produto      varchar(15) not null
)ENGINE=INNODB;
insert into tbl_Usuarios(id,email,senha)values(null,'carolpa466@hotmail.com','carol466');
create table tbl_Usuarios(
    id int not null primary key auto_increment,
    email varchar(100) not null,
    senha varchar(100) not null
)ENGINE = InnoDB;
select *from tbl_Produto;