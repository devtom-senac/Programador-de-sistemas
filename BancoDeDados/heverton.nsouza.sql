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
 SELECT 
    *
FROM
    empregado
WHERE
    departamento LIKE 'TI';

/*Agora descobrir quem está ganhando mais de 55 mil*/
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
SELECT 
    *
FROM
    empregado
WHERE
    nome LIKE 'M%';

/*Empregados que não estão no departamento de RH*/
SELECT 
    *
FROM
    empregado
WHERE
    departamento != 'RH';

/*Número de empregados em cada departamento (FIZ ESTE COM AJUDA DE COLEGAS) */
SELECT 
    departamento, COUNT(departamento)
FROM
    empregado
GROUP BY departamento; /* group by = agrupar elementos iguais*/

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

/*4.Use um INNER JOIN para obter uma lista de empregados e seus respectivos departamentos*/
/*departamento*/
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

/*6 */
CREATE TABLE IF NOT EXISTS empregado (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
	idade INT NOT NULL,
    salario decimal(10) NOT NULL,
    id_departamento INT NOT NULL,
    FOREIGN KEY (id_departamento)
	  REFERENCES departamento (id)
);

INSERT INTO empregado (
    nome, 
    idade, 
    salario,
    id_departamento
)
VALUES 
 ('João', 30, 50000, 1),
('Sarah', 28, 60000, 2),
('Miguel', 35, 55000, 3),
('Ana', 27, 62000, 2);
 
select * from empregado;

SELECT
  e.nome AS Empregado,
  d.nome AS Departamento
FROM empregado AS e
INNER JOIN departamento AS d
ON e.id_departamento = d.id;

/*SELECT 
    d.nome AS Departamento, d.nome AS Empregado
FROM
    departamento d
        LEFT LEFT
    empregado e ON d.id = e.id_departamento;*/

SELECT 
    *
FROM
    empregado
WHERE
    salario > (SELECT 
            AVG(salario)
        FROM
            empregado);
    
/*SELECT 
    e.nome AS Empregado, d.nome AS departamento
FROM
    empregado e
WHERE
    e.id_departamento = (SELECT 
            e.id_departamento
        FROM
            empregado e
        WHERE
            nome = 'Sarah');*/
    
/*7*/
INSERT INTO empregado (
    nome, 
    idade, 
    salario,
    id_departamento
)
VALUES 
 ('Tomás', 19, 58000, 3);
 
 update empregado
 set salario = salario * 1.05
 where id_departamento = (select id from departamento where nome = 'TI');

delete from empregado
where idade > 40;


