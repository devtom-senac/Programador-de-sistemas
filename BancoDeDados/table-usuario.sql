CREATE TABLE usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(20) NOT NULL
);

insert into usuario (email, senha)
values 
('neymar.jr@gmail.com', 'Bruna@123'),
('pablo.vitar@gmail.com', '12345ABC!'),
('sukuna.silva@gamil.com', 'Sete7Sete!');


select * from usuario where email = 'pablo.vitar@gmail.com';

