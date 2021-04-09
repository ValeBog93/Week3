CREATE DATABASE GestioneSpese
CREATE TABLE Categoria (
ID int IDENTITY(1,1) PRIMARY KEY,
Categoria varchar (100)
);
CREATE TABLE Spese(
ID int IDENTITY(1,1) PRIMARY KEY,
DataInsert Date,
Descrizione varchar(500),
Utente varchar(100),
Importo decimal,
Approvato bit,
CategoriaID int,
FOREIGN KEY (CategoriaID)REFERENCES Categoria(ID),
);
