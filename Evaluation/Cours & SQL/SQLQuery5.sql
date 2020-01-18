-- Sélectionnez tous les enregistrements pour lesquels la colonne City a la valeur 'Berlin' 
-- et la colonne PostalCode a la valeur 12209.
SELECT * 
FROM Customers
WHERE city = 'Berlin' AND PostalCode='12209';

-- Sélectionnez tous les enregistrements pour lesquels la colonne City a la valeur 'Berlin', 
-- ainsi que ceux pour lesquels la colonne City a la valeur 'London'.
SELECT *
FROM Customers
WHERE City = 'Berlin' OR City = 'London';

SELECT *
FROM Customers
WHERE City IN('Berlin', 'London');

-- Sélectionnez tous les enregistrements de la table Customers, 
-- triez le résultat inversé par ordre alphabétique par la colonne City .
SELECT *
FROM Customers
ORDER BY City DESC;

-- Sélectionnez tous les enregistrements de la table Customers, 
-- triez le résultat par ordre alphabétique, d’abord par la colonne Country, puis par la colonne City .
SELECT *
FROM Customers
ORDER BY Country, City;