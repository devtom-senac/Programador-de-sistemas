USE sanacdb;

CREATE TABLE IF NOT EXISTS servico (
    codigo INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    valor varchar(50) NOT NULL,
    tempo VARCHAR(16) NOT NULL
);

SELECT 
    *
FROM
    servico;
    
 INSERT INTO servico (
    nome,
    valor,
    tempo
)
VALUES 
 ('BARRA MAQUINA', 'R$ 25', '30min'),
 ('BARRA GALONEIRA', 'R$ 25', '30min'),
 ('BARRA MÃO', 'R$ 25', '30min'),
 ('BARRA ITALIANA', 'R$ 25', '30min'),
 ('BARRA DESFIADA', 'R$ 25', '30min'),
 ('BARRA INFANTIL', 'R$ 15', '30min'),
 ('BARRA VESTIDO', 'R$ 30', '40min'),
 ('BARRA PANTALONA', 'R$ 30', '30min'),
 ('COSTURA MIN.', 'R$ 15', '20min'),
 ('REFORÇO', 'R$ 20', '30min'),
 ('LATERAL', 'R$ 30', '40min'),
 ('CINTURA', 'R$ 35', '50min'),
 ('ALÇA', 'R$ 20', '25min');
 
INSERT INTO servico (
    codigo,
    nome,
    valor,
    tempo
)
VALUES 
 ('OMBRO', 'R$ 20', '25min'),
 ('CINZIDO', 'R$ 20', '35min');
 
 SELECT
 *
 FROM
 servico
 where 
 codigo  like ('06');
