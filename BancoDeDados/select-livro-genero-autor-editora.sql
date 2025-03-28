SELECT 
    livro.*, genero.nome AS genero, editora.nome AS editora, autor.nome AS autor
FROM
    livro,
    genero,
    editora,
    autor
WHERE
    livro.id_genero = genero.id
        AND livro.id_autor = autor.id
        AND livro.id_editora = editora.id

