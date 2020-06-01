use hotel;

Create table funcionarios(
	fun_id int(8) primary key auto_increment,
    fun_nome varchar(15) not null,
    fun_sobrenome varchar(15) not null,
    fun_cpf varchar(15) not null,
    fun_titulo varchar(15) not null
);

select * from funcionarios;

