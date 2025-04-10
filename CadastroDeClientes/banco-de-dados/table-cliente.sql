CREATE TABLE cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    nome_social VARCHAR(100) NULL,
    data_nascimento DATE NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    telefone VARCHAR(11) NOT NULL UNIQUE,
    tipo INT NOT NULL,
    etnia INT NOT NULL,
    genero INT NOT NULL,
    estrangeiro BIT NOT NULL,
    id_endereco INT NOT NULL,
    FOREIGN KEY (id_endereco)
        REFERENCES endereco (id)
);

INSERT INTO cliente
(nome, data_nascimento, email, telefone, tipo, etnia, genero, estrangeiro, id_endereco)
VALUES
('Heverton Souza', '2000-02-20', 'heverton@email.com', '11999999999', (SELECT id FROM endereco WHERE logradouro = 'All Happy')),
('Notreveh', '1958-03-08', 'notreveh@email.com', '11988888888', (SELECT id FROM endereco WHERE logradouro = 'Sky Light'));
