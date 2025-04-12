CREATE TABLE atividade (
    id INT PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(100) NOT NULL,
    situacao INT NOT NULL DEFAULT 0
);
 
 insert into atividade (titulo) values (@titulo);

UPDATE atividade set situacao = @situacao WHERE id = @id;

SELECT * FROM atividade WHERE situacao = 1;

SELECT * FROM atividade WHERE situacao = 0;