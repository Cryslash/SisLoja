--- #=-==-=--=-=-==-=-=--=-=-=-=-=-=-=-==-=-=-#
-- #          <SisLoja - DataBase>             #
-- #    Copyright (C) <2023-2023> <CL-Dev>     #
-- #		                                   #
-- #       | C | L | - | D | e | v | �         #
-- #       ������ By Crystofher Lins.�        #
--- #-=--==-=-=-=-=-=-=--==-=-=-=-=-=-=-==-=-=# 
CREATE DATABASE SisLoja;
GO
USE SisLoja;
GO

IF NOT EXISTS (SELECT 1 FROM SYS.COLUMNS WHERE OBJECT_ID = OBJECT_ID(N'Clientes') AND NAME = N'ID')
BEGIN
CREATE TABLE Clientes (
ID INT IDENTITY PRIMARY KEY NOT NULL,
Data DATETIME,
Nome VARCHAR(50) NOT NULL,
CPF VARCHAR(18),
Rua VARCHAR(100),
Bairro VARCHAR(50),
Cidade VARCHAR(50),
Cep VARCHAR(9),
Estado VARCHAR(50),
Telefone VARCHAR(15) NOT NULL,
Whatsapp VARCHAR(15),
Email VARCHAR(50),
EstaAtivo CHAR(1) NOT NULL DEFAULT(1)
);
END
GO
IF NOT EXISTS (SELECT 1 FROM SYS.COLUMNS WHERE OBJECT_ID = OBJECT_ID(N'Produtos') AND NAME = N'ID')
BEGIN
CREATE TABLE Produtos (
ID INT IDENTITY PRIMARY KEY NOT NULL,
CodBar VARCHAR(13),
QrCode VARCHAR (13),
Referencia VARCHAR(13),
Img VARCHAR(100),
Nome VARCHAR(50) NOT NULL,
Modelo VARCHAR(50),
Estoque INT DEFAULT(0),
EstoqueMin INT DEFAULT(0),
PrecoVenda DECIMAL(10,2) NOT NULL,
EstaAtivo CHAR(1) NOT NULL DEFAULT(1)
)
END

