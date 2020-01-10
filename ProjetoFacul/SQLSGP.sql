create database tst;
use tst;
create table usuario (
codigo_usuario integer primary key auto_increment,
nome_usuario varchar(30),
senha_usuario varchar(30),
tipo_usuario integer);

insert into usuario (nome_usuario,senha_usuario,tipo_usuario) values ('admin','admin',1);

create table ponto (
nome_usuario varchar(30),
pontodata varchar(30),
ponto_inicio varchar(30),
ponto_final varchar(30));

create table funcionario (
nome_usuario varchar(30),
nome_completo varchar(50),
cpf varchar(30),
endereço varchar(50),
salario double);