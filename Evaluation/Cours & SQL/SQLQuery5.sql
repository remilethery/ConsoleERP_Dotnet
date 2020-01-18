-- S�lectionnez tous les enregistrements pour lesquels la colonne City a la valeur 'Berlin' 
-- et la colonne PostalCode a la valeur 12209.
SELECT * 
FROM Customers
WHERE city = 'Berlin' AND PostalCode='12209';

-- S�lectionnez tous les enregistrements pour lesquels la colonne City a la valeur 'Berlin', 
-- ainsi que ceux pour lesquels la colonne City a la valeur 'London'.
SELECT *
FROM Customers
WHERE City = 'Berlin' OR City = 'London';

SELECT *
FROM Customers
WHERE City IN('Berlin', 'London');

-- S�lectionnez tous les enregistrements de la table Customers, 
-- triez le r�sultat invers� par ordre alphab�tique par la colonne City .
SELECT *
FROM Customers
ORDER BY City DESC;

-- S�lectionnez tous les enregistrements de la table Customers, 
-- triez le r�sultat par ordre alphab�tique, d�abord par la colonne Country, puis par la colonne City .
SELECT *
FROM Customers
ORDER BY Country, City;