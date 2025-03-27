SELECT * FROM livro
WHERE data_publicacao >= '1990-01-01 00:00:00'
AND data_publicacao <= '1999-12-31 23:59:59';

SELECT * FROM livro
where data_publicacao between '1990-01-01 00:00:00' and '1999-12-31 23:59:59';

SELECT * FROM livro
WHERE data_publicacao like '199%';

select autor from livro;

select distinct(autor) from livro;

select sum(preco), max(preco), min(preco) from livro
where autor = 'rafael sousa';
