/* S�lectionner tous les enregistrements de la table Customers */
SELECT * FROM Customers;

--S�lectionner toutes les City de la table Customers
SELECT city FROM Customers;

--S�lectionner les differentes valeurs de Country de la table Customers
SELECT distinct country FROM Customers;

-- S�lectionner tous les enregistrements pour lesquels la colonne City a la valeur "Berlin".
SELECT *
FROM Customers
WHERE City = 'Berlin';

-- S�lectionnez tous les enregistrements pour lesquels la colonne Country vaut France.
SELECT *
FROM Customers
WHERE Country='France';