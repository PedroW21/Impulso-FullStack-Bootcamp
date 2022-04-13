-- Modelando o controle de acesso para a estrela da morte

CREATE DATABASE EstrelaDaMorte;
USE EstrelaDaMorte;

CREATE TABLE Planetas(
idPlaneta INT NOT NULL,
Nome VARCHAR(50) NOT NULL,
Rotacao FLOAT NOT NULL,
Orbita FLOAT NOT NULL,
Diametro FLOAT NOT NULL,
Clima VARCHAR(50) NOT NULL,
Populacao INT NOT NULL
);

ALTER TABLE Planetas ADD CONSTRAINT PK_Planetas PRIMARY KEY (idPlaneta);

CREATE TABLE Pilotos (
idPiloto INT NOT NULL,
Nome VARCHAR(200) NOT NULL,
AnoNascimento VARCHAR(10) NOT NULL,
idPlaneta INT NOT NULL
);

ALTER TABLE Pilotos ADD CONSTRAINT PK_Pilotos PRIMARY KEY (idPiloto);
ALTER TABLE Pilotos ADD CONSTRAINT FK_Pilotos_Planetas FOREIGN KEY (idPlaneta) REFERENCES Planetas (idPlaneta);

CREATE TABLE PilotosNaves (
idPiloto INT NOT NULL,
idNave INT NOT NULL,
FlagAutorizado BIT NOT NULL
);

ALTER TABLE PilotosNaves ADD CONSTRAINT PK_PilotosNaves PRIMARY KEY (idPiloto, idNave);
ALTER TABLE PilotosNaves ADD CONSTRAINT FK_PilotosNaves_Naves FOREIGN KEY (idNave) REFERENCES Naves(idNave);
ALTER TABLE PilotosNaves ADD CONSTRAINT FK_PilotosNaves_Pilotos FOREIGN KEY (idPiloto) REFERENCES Pilotos(idPiloto);


CREATE TABLE HistoricoViagens (
idNave INT NOT NULL,
idPiloto INT NOT NULL,
DtSaida DATETIME NOT NULL,
DtChegada DATETIME NULL
);

ALTER TABLE HistoricoViagens ADD CONSTRAINT FK_HistoricoViagens_PilotoNaves FOREIGN KEY (idPiloto, idNave) REFERENCES PilotosNaves (idPiloto, idNave);
