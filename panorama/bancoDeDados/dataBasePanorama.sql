CREATE TABLE cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(150) NOT NULL,
    telefone VARCHAR(11) NULL
);
 
insert into cliente( nome, telefone)
values
('Felipe Araujo', '11986457814'),
('Polyana Sayuri', '11983848850'),
('Tamires Oliveira', '11958977549'),
('Heverton Souza', '11956457812');
 
CREATE TABLE pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
    data_entrega DATETIME NOT NULL,
    situacao VARCHAR(30) NOT NULL,
    pagamento VARCHAR(30) NOT NULL,
    preco DECIMAL(10,2) NOT NULL,
    cliente_id INT NOT NULL,
    FOREIGN KEY (cliente_id)
        REFERENCES cliente (id)
);

INSERT INTO pedido (data_entrega, situacao, pagamento, preco, cliente_id)
VALUES 
('2025-04-26 14:00:00', 'Em andamento', 'Pago', 120.50, 1),
('2025-04-27 16:30:00', 'Concluído', 'A pagar', 89.90, 2),
('2025-04-28 12:00:00', 'Pendente', '50% Pago', 45.00, 3);

SELECT 
    pedido.id AS id_pedido,
    cliente.nome AS nome_cliente,
    cliente.telefone,
    pedido.preco,
    pedido.data_entrega,
    pedido.situacao AS status_pedido,
    pedido.pagamento AS situacao_pagamento
FROM 
    pedido
JOIN 
    cliente ON pedido.cliente_id = cliente.id
ORDER BY 
    pedido.id;

drop table pedido