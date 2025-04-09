SELECT 
    *
FROM
    produto
WHERE
    categoria = 'Eletrônicos'
        AND preco > 3000
ORDER BY preco DESC;

/* */

SELECT 
    *
FROM
    cliente
WHERE
    cidade <> 'sao paulo' AND idade > 30;
    
/* */

SELECT 
    *
FROM
    pedido
WHERE
    data_pedido BETWEEN '2024-03-10' AND '2024-03-15'
ORDER BY data_pedido ASC;

/* */

SELECT 
    *
FROM
    produto
WHERE
    estoque < 10
ORDER BY estoque ASC;

/* */

INSERT INTO fornecedor (
nome,
cidade
) VALUES 
('TechBrasil Campinas', 'Campinas');

SELECT 
    *
FROM
    fornecedor
WHERE
    cidade <> 'rio de janeiro'
        AND nome LIKE 't%';
        
/* */

SELECT 
    categoria, AVG(preco)
FROM
    produto
GROUP BY categoria;

/* */

SELECT 
    cliente.nome, COUNT(pedido.id) AS 'Qtd de pedidos'
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id
GROUP BY cliente_id;

/* */

SELECT 
    categoria, SUM(estoque)
FROM
    produto
GROUP BY categoria;

/* */
SELECT 
    MAX(quantidade)
FROM
    pedido;
    
SELECT 
    id, produto_id, quantidade
FROM
    pedido
ORDER BY quantidade = (SELECT 
        MAX(quantidade)
    FROM
        pedido);

SELECT 
    id, produto_id, quantidade
FROM
    pedido
ORDER BY quantidade DESC
limit 1; /* para trazer apenas um resultado */

/* */

SELECT 
    cidade, COUNT(id) as 'Total clientes'
FROM
    cliente
GROUP BY cidade
order by 'Total clientes' desc;

/* */

SELECT 
    produto.id,
    produto.nome as 'Nome do produto',
    produto.categoria,
    produto.preco,
    produto.estoque,
    fornecedor.nome as 'nome do fornecedor'
FROM
    produto
        INNER JOIN
    fornecedor ON produto.fornecedor_id = fornecedor.id
ORDER BY fornecedor.nome ASC;

/* */

SELECT 
    pedido.id AS 'id do pedido',
    cliente.nome AS 'nome do cliente',
    produto.nome AS 'nome do produto',
    fornecedor.nome as 'nome do fornecedor'
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id
        INNER JOIN
    produto ON pedido.produto_id = produto.id
    inner join fornecedor on produto.fornecedor_id = fornecedor.id;

/* */ 

SELECT 
    cliente.nome as 'nome do cliente',
    SUM(pedido.quantidade) as 'quantidade total'
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente_id
    group by pedido.cliente_id;

/* */

SELECT 
    *
FROM
    produto p
WHERE
    preco > (SELECT 
            AVG(preco)
        FROM
            produto pr
        WHERE
            p.categoria = pr.categoria)
ORDER BY p.categoria;
            
/* */

UPDATE produto 
SET 
    preco = preco * 1.1
WHERE
    categoria = 'eletronico';
    
/* */
select * from cliente;

DELETE FROM pedido 
WHERE
    cliente_id IN = (SELECT 
        id
    FROM
        cliente

    WHERE
        cidade = 'curitiba');

/* */

SELECT * from produto where nome = 'notebook y';

SELECT * from cliente where nome = 'joao silva' and cidade = 'sao paulo';

insert into pedido (quantidade, data_pedido, produto_id, cliente_id)
values (2, '2024-03-25', (select id from produto where nome = 'notebook y'), (SELECT id from cliente where nome = 'joao silva' and cidade = 'sao paulo')
);

select * from pedido;

/* */

SELECT DISTINCT
    cliente.nome
FROM
    cliente
        INNER JOIN
    pedido ON cliente.id = pedido.cliente_id
        INNER JOIN
    produto ON pedido.produto_id = produto.id
WHERE
    produto.categoria = 'moveis'
    

