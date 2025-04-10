CREATE TABLE endereco (
    id INT PRIMARY KEY AUTO_INCREMENT,
    logradouro VARCHAR(10) NOT NULL,
    numero VARCHAR(10) NOT NULL,
    complemento VARCHAR(50) NULL,
    bairro VARCHAR(50) NOT NULL,
    municipio VARCHAR(50) NOT NULL,
    estado VARCHAR(2) NOT NULL,
    cep VARCHAR(8) NOT NULL
);

insert into endereco (logradouro, numero, bairro, municipio, estado, cep, complemento)
 values
 ('All Happy', '859', 'Almacrom', 'Denvil', 'LO', '20202788', NULL),
('Sky Light', '088', 'Divine Wood', 'Samptom', 'LA', '10101788', NULL);

