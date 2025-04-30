CREATE TABLE pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
	nome_cliente VARCHAR(150) NOT NULL,
    telefone VARCHAR(11) NULL,
    data_entrega DATETIME NOT NULL,
	preco DECIMAL(10, 2) NOT NULL ,
    pagamento VARCHAR(30) NOT NULL,
    situacao VARCHAR(30) NOT NULL
);

INSERT INTO pedido (nome_cliente, telefone, data_entrega, preco, pagamento, situacao)
VALUES
('Felipe Araújo', '11986457814', '2025-05-05 14:30:00', 125.99, 'pendente', 'em preparo'),
('Tamires Oliveira', '11958977549', '2025-05-06 11:45:00', 55.50, 'pago', 'entregue'),
('Heverton Souza', '11956457812', '2025-05-07 16:00:00', 210.75, 'a pagar', 'saiu para entrega');

SELECT * FROM pedido;