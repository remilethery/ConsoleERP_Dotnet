-- Cr�er une table :
CREATE Table Persons (
	ID INT IDENTITY NOT NULL,
	Nom VARCHAR(500) NOT NULL,
	Pr�nom VARCHAR(500) NOT NULL,
	Adresse VARCHAR(500) NOT NULL,
	PRIMARY KEY (ID));


-- On peut aussi utiliser le tool pour cr�er facilement une table;


-- Pour supprimer : DROP table
DROP Table Persons;