CREATE TABLE IF NOT EXISTS cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    idade INT NOT NULL,
    cidade VARCHAR(100) NOT NULL,
    saldo INT NOT NULL
);

INSERT INTO cliente (
    nome, 
    idade, 
	cidade,
    saldo
)
VALUES 
 ('Carlos',  45,  'São Paulo', 2500.00),
 ('Mariana',  32,  'Rio de Janeiro', 3200.50),
 ('Pedro',  27,  'Belo Horizonte', 1500.75),
 ('Fernanda',  38,  'Curitiba', 4200.00);
 
 /*2. 1*/
  SELECT * FROM cliente
WHERE cidade like 'Rio de Janeiro';

 /*2. 2*/
  SELECT * FROM cliente
WHERE saldo > 2000;

 /*2. 3*/
SELECT 
    nome, idade
FROM
    cliente
WHERE
    idade > 30;

/*2. 1*/
  SELECT 
    *
FROM
    cliente
WHERE
    idade between 25 and 40;
    
/*2. 2*/
SELECT 
    *
FROM
    cliente
WHERE
    nome LIKE 'f%';
    
/*2. 3*/
SELECT 
    *
FROM
    cliente
WHERE
    cidade NOT LIKE 'São Paulo' and cidade NOT LIKE 'Curitiba';

/*3. 1*/    
CREATE TABLE IF NOT EXISTS cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome varchar(100) NOT NULL
);

drop table cliente;

INSERT INTO cliente (
nome)
values ('Carlos'), ('Mariana'), ('Pedro'), ('Fernanda');

CREATE TABLE IF NOT EXISTS pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
    id_cliente int(100) NOT NULL,
    valor float(30),
    data_pedido date,
    FOREIGN KEY (id_cliente)
	  REFERENCES cliente (id)
);

INSERT INTO pedido (
    id_cliente,
    valor,
    data_pedido
)
VALUES 
 (1,  500.00, '2024-03-10'),
 (2,  1200.00, '2024-03-12'),
 (3,  300.50, '2024-03-15'),
 (4,  800.00, '2024-03-18');

SELECT 
    COUNT(id) AS pedido
FROM
    pedido; 
    
SELECT 
    AVG(valor) AS pedido
FROM
    pedido; 
    
/* 4 */
select * from pedido;

SELECT
    c.nome AS cliente,
    p.valor AS valor_pedido
FROM pedido AS p
INNER JOIN cliente AS c
ON p.id_cliente = c.id;

DROP TABLE cliente
