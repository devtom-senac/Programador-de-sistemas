create table if not exists empregado (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    idade VARCHAR(3) NOT NULL,
    departamento VARCHAR(100) NOT NULL,
    salario INT(30)
);

/*Inserindo valores na tabela*/

INSERT INTO empregado (
    nome, 
    idade, 
    departamento,
    salario
)
VALUES 
 ('João',  '30',  'RH', 50000),
 ('Sarah',  '28',  'TI', 60000),
 ('Miguel',  '35',  'Vendas', 55000),
 ('Ana',  '27',  'TI', 62000);
 
 /*Agora vamos buscar o pessoal do TI*/
 SELECT * FROM empregado
WHERE departamento like 'TI';

/*Vamos descobrir agora quem está ganhando mais de 55 mil*/
 SELECT 
	nome, salario
FROM
    empregado
WHERE
    salario > 55000;
    
/*Listando os empregados por ordem crescente*/
SELECT 
    *
FROM
    empregado
ORDER BY idade DESC;

/*Encontrando empregados com idade entre 28 e 35*/
SELECT * FROM empregado
where idade between '28' and '35';

/*Selecionado os que começam com M*/
SELECT * FROM empregado
WHERE nome like 'M%';

/*Empregados que não estão no departamento de RH*/
SELECT 
    *
FROM
    empregado
WHERE
    departamento NOT LIKE 'RH';

/*Número de empregados em cada departamento (FIZ ESTE COM AJUDA DE COLEGAS) */
SELECT departamento, count(departamento) from empregado group by departamento;

/*Salario médio dos empregados no departamento de TI  (FIZ ESTE COM AJUDA DE COLEGAS*/
SELECT 
    AVG(salario)
FROM
    empregado
WHERE
    departamento = 'TI';
    
/*Total de salarios pagos ao departamento de vendas*/
SELECT 
    SUM(salario)
FROM
    empregado
WHERE
    departamento = 'Vendas';

/*Use um INNER JOIN para obter uma lista de empregados e seus respectivos departamentos*/

CREATE TABLE IF NOT EXISTS departamento (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL
);

INSERT INTO departamento (
    nome
)
VALUES 
 ('RH'),
  ('TI'),
   ('Vendas');


