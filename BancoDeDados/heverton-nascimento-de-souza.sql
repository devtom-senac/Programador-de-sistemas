/* 1.ESTRUTURA DAS TABELAS*/

CREATE TABLE IF NOT EXISTS produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    categoria VARCHAR(100) NOT NULL,
    preco DECIMAL NOT NULL,
    estoque INT NOT NULL,
    fornecedor_id INT NOT NULL,
    FOREIGN KEY (fornecedor_id)
        REFERENCES fornecedor (id)
);

INSERT INTO produto (
nome,
categoria,
preco,
estoque,
fornecedor_id 
) VALUES 
 ('Celular X', 'Eletrônicos', 2500.00, 30, 1),
  ('Notebook Y', 'Eletrônicos', 4800.00, 15, 2),
   ('Mesa de Madeira', 'Móveis', 750.00, 10, 3),
    ('Cadeira Z', 'Móveis', 300.00, 25, 3),
     ('TV 50"', 'Eletrônicos', 3500.00, 8, 1);
	
SELECT 
    *
FROM
    produto;

CREATE TABLE IF NOT EXISTS fornecedor (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    cidade VARCHAR(100) NOT NULL
);

INSERT INTO fornecedor (
nome,
cidade
) VALUES 
('TechBrasil', 'São Paulo'),
('Computech', 'Rio de Janeiro'),
('Moveis&Co', 'Curitiba');

SELECT 
    *
FROM
    fornecedor;

CREATE TABLE IF NOT EXISTS pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
    produto_id int(100) NOT NULL,
	quantidade INT NOT NULL,
    data_pedido date,
    cliente_id INT NOT NULL,
    FOREIGN KEY (produto_id)
	  REFERENCES produto (id),
	FOREIGN KEY (cliente_id)
	  REFERENCES cliente (id)
);

INSERT INTO pedido (
produto_id,
quantidade,
data_pedido,
cliente_id 
) VALUES 
(1, 2, '2024-03-10', 1),
(3, 1, '2024-03-11', 2),
(2, 1, '2024-03-15', 3),
(5, 3, '2024-03-18', 1),
(4, 4, '2024-03-20', 4);

SELECT 
    *
FROM
    pedido;

CREATE TABLE IF NOT EXISTS cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    cidade VARCHAR(100) NOT NULL,
    idade INT NOT NULL
);

INSERT INTO cliente (
nome,
cidade,
idade
) VALUES 
('João Silva', 'São Paulo', 35),
('Maria Santos', 'Belo-Horizonte', 28),
('Carlos Lima', 'Rio de Janeiro', 42),
('Fernanda Rocha', 'Curitiba', 30);

SELECT 
    *
FROM
    cliente;

/* 2.Exercícios*/
SELECT 
*
FROM
produto
WHERE
    preco > 3000.00
    order by preco desc;

SELECT 
    *
FROM
    cliente
WHERE
    cidade != 'São Paulo' and idade > 30;
    
SELECT 
    *
FROM
    pedido 
WHERE
    data_pedido BETWEEN '2024-03-10' AND '2024-03-15'
     order by data_pedido ASC; 
     
INSERT INTO produto (
nome,
categoria,
preco,
estoque,
fornecedor_id 
) VALUES 
 ('Ipad Pro', 'Eletrônicos', 5500.00, 05, 2);

SELECT 
    *
FROM
    produto
WHERE
    estoque < 10
     order by estoque ASC;

SELECT 
    *
FROM
    fornecedor
WHERE
    cidade != 'Rio de Janeiro' and nome like 'T%';

SELECT 
    categoria,
    AVG(preco) 
FROM
    produto group by categoria; 

SELECT
cliente_id,
    COUNT(cliente_id)
FROM
    pedido
GROUP BY cliente_id; 
    
SELECT 
    categoria,
     SUM(estoque) 
FROM
    produto
GROUP BY categoria;

select id from ( SELECT 
   max(quantidade)
FROM
    pedido id);

 SELECT 
    id,
    produto_id,
    quantidade
FROM
    pedido
WHERE
    quantidade = (SELECT 
            max(quantidade)
        FROM
          pedido);
          
INSERT INTO cliente (
nome,
cidade,
idade
) VALUES 
('Heverton Souza', 'São Paulo', 19);

INSERT INTO cliente (
nome,
cidade,
idade
) VALUES 
('Rafão Volpe', 'Curitiba', 30);

SELECT
id,
cidade,
    COUNT(id)
FROM
    cliente
GROUP BY cidade; 

SELECT 
    p.nome AS produto, f.nome AS fornecedor
FROM
    produto p
        INNER JOIN
    fornecedor f ON p.fornecedor_id = f.id  order by fornecedor;

SELECT 
    p.id AS pedido, c.nome AS cliente, i.nome AS produto, p.data_pedido 
FROM
    pedido p
        JOIN
    produto i ON p.produto_id = i.id 

     JOIN
    cliente c ON p.cliente_id = c.id
     order by data_pedido;
   
 SELECT 
    p.id, c.nome AS cliente, i.nome AS produto, f.nome AS fornecedor
FROM
    pedido p
        JOIN
    cliente c ON p.cliente_id = c.id
        JOIN
    produto i ON p.produto_id = i.id
        JOIN
    fornecedor f ON f.id = i.fornecedor_id;
 
 
 SELECT 
    c.nome AS cliente, SUM(quantidade) AS comprados
FROM
    pedido p
        JOIN
    cliente c ON p.cliente_id = c.id
GROUP BY p.cliente_id;

SELECT 
    *
FROM
    produto
WHERE
   preco > (SELECT 
            AVG(preco)
        FROM
            produto);  
 
UPDATE produto 
SET 
    preco = preco * 1.10
WHERE
    categoria = 'Eletrônicos';
 
DELETE FROM pedido WHERE cliente_id = 4;

select * from pedido