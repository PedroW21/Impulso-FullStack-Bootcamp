CREATE DATABASE Ecommerce;
USE Ecommerce;

CREATE TABLE Produtos (
Codigo INT,
Nome VARCHAR(100),
Descricao VARCHAR(200),
Preco FLOAT
);

CREATE TABLE Clientes (
Codigo INT NOT NULL,
Nome VARCHAR(200) NOT NULL,
TipoPessoa CHAR(1) NOT NULL
);

CREATE TABLE Pedido (
Codigo INT NOT NULL,
DataSolicitacao DATETIME NOT NULL,
FlagPago BIT NOT NULL,
TotalPedido FLOAT NOT NULL,
CodigoCliente INT NOT NULL
);

CREATE TABLE PedidoItem (
CodigoPedido INT NOT NULL,
CodigoProduto INT NOT NULL,
Preco FLOAT NOT NULL,
Quantidade INT NOT NULL
);

INSERT INTO Clientes (Codigo, Nome, TipoPessoa) VALUES (1, 'Pedro', 'M');
INSERT INTO Clientes (Codigo, Nome, TipoPessoa) VALUES (2, 'Julio', 'F');
INSERT INTO Clientes (Codigo, Nome, TipoPessoa) VALUES (3, 'Adeneia', 'J');
INSERT INTO Clientes (Codigo, Nome, TipoPessoa) VALUES (4, 'Irovaltro', 'F');

UPDATE Clientes SET TipoPessoa = 'J' WHERE Codigo= 1;

INSERT INTO Produtos (Codigo, Nome, Descricao, Preco) VALUES (1, 'Caneca', 'Caneca do Batman', 32.99);
INSERT INTO Produtos (Codigo, Nome, Descricao, Preco) VALUES (2, 'Caderno', 'Caderdo da Tilibra com tema do Homem Aranha', 2.99);
INSERT INTO Produtos (Codigo, Nome, Descricao, Preco) VALUES (3, 'Caneta', 'Caneta da BIC com tema do Flash', 32.99);
INSERT INTO Produtos (Codigo, Nome, Descricao, Preco) VALUES (4, 'Post-it', 'Bloco de Notas Adesivas', 16.42);

UPDATE Produtos SET Preco = 3.29 WHERE Codigo = 3;

INSERT INTO Pedido (Codigo, DataSolicitacao, FlagPago, TotalPedido, CodigoCliente) VALUES (1, Now(), 0, 36.28, 1); 

INSERT INTO PedidoItem(CodigoPedido, CodigoProduto, Preco, Quantidade) VALUES (1, 1, 32.99, 1);

-- ADICIONANDO CHAVES PRIMARIAS E ESTRANGEIRAS

ALTER TABLE Clientes ADD CONSTRAINT pk_cliente PRIMARY KEY(Codigo);

ALTER TABLE PedidoItem ADD CONSTRAINT fk_pedido FOREIGN KEY (CodigoPedido) REFERENCES Pedido(Codigo);

-- Utilizando JOIN


SELECT * FROM Clientes cli INNER JOIN Pedido ped ON cli.Codigo = ped.CodigoCliente;
