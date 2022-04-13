CREATE DATABASE DioAvanade;

USE DioAvanade;

CREATE TABLE PRODUTOS (
CODIGO INT NOT NULL,
DESCRICAO VARCHAR(50) NOT NULL,
DATA_VALIDADE DATETIME,
EAN VARCHAR(15) NOT NULL,
IND_INATIVO INT NOT NULL DEFAULT 1

);

ALTER TABLE PRODUTOS ADD CONSTRAINT PK_PRODUTOS PRIMARY KEY (CODIGO);

CREATE INDEX IDX_PRODUTOS_EAN ON Produtos(EAN);

INSERT INTO PRODUTOS VALUES (1, 'Nome do Produto', Now(), '1234567891234', 0);

INSERT INTO PRODUTOS (CODIGO, DESCRICAO, EAN) VALUES (2, 'Nome do Produto 2', '2234567891234');
INSERT INTO PRODUTOS (CODIGO, DESCRICAO, EAN) VALUES (3, 'Nome do Produto 3', '3234567891233');

SELECT * FROM PRODUTOS;

SELECT COUNT(*) AS TOTAL FROM PRODUTOS;

CREATE TABLE LOJAS (
CODIGO INT NOT NULL,
NOME VARCHAR(50) NOT NULL,
IND_INATIVO INT NOT NULL DEFAULT 0,
CONSTRAINT PK_LOJA PRIMARY KEY (CODIGO)
);

INSERT INTO LOJAS (CODIGO, NOME) VALUES (1000, 'Filial Campos do Jordao');
INSERT INTO LOJAS (CODIGO, NOME) VALUES (1001, 'Filial Brasília');
INSERT INTO LOJAS (CODIGO, NOME) VALUES (1002, 'Filial Goiânia');

CREATE TABLE ESTOQUE (
CODIGO_PRODUTO INT NOT NULL,
CODIGO_FILIAL INT NOT NULL,
QUANTIDADE DECIMAL NOT NULL DEFAULT (0),
CONSTRAINT PK_ESTOQUE  PRIMARY KEY (CODIGO_PRODUTO, CODIGO_FILIAL)
);

ALTER TABLE ESTOQUE ADD CONSTRAINT FK_ESTOQUE_PRODUTOS FOREIGN KEY (CODIGO_PRODUTO) REFERENCES PRODUTOS(CODIGO);
ALTER TABLE ESTOQUE ADD CONSTRAINT FK_ESTOQUE_FILIAL FOREIGN KEY (CODIGO_FILIAL) REFERENCES LOJAS(CODIGO);

INSERT INTO ESTOQUE (CODIGO_PRODUTO, CODIGO_FILIAL, QUANTIDADE) VALUES (1, 1000, 3);
INSERT INTO ESTOQUE (CODIGO_PRODUTO, CODIGO_FILIAL, QUANTIDADE) VALUES (2, 1001, 320);
INSERT INTO ESTOQUE (CODIGO_PRODUTO, CODIGO_FILIAL, QUANTIDADE) VALUES (3, 1002, 402);

SELECT E.CODIGO_FILIAL, L.NOME, P.CODIGO, P.DESCRICAO, E.QUANTIDADE FROM ESTOQUE E 
INNER JOIN LOJAS L 
ON E.CODIGO_FILIAL = L.CODIGO
INNER JOIN PRODUTOS P
ON E.CODIGO_PRODUTO = P.CODIGO;

