/* Sélectionner tous les enregistrements de la table Customers */
SELECT * FROM Customers;

--Sélectionner toutes les City de la table Customers
SELECT city FROM Customers;

--Sélectionner les differentes valeurs de Country de la table Customers
SELECT distinct country FROM Customers;

-- Sélectionner tous les enregistrements pour lesquels la colonne City a la valeur "Berlin".
SELECT *
FROM Customers
WHERE City = 'Berlin';

-- Sélectionnez tous les enregistrements pour lesquels la colonne Country vaut France.
SELECT *
FROM Customers
WHERE Country='France';