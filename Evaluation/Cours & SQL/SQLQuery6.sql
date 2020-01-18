-- Ins�rez un nouvel enregistrement dans la table Customers.
INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax)
VALUES ('', 'Compagnie Cr�ole', 'Joe Lopez', 'Joe dses morts', '12 rue de la Calotte', 'Bourg La Reine', 'IDF', '95500', 'France', '0909021212', '901123');

INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax)
VALUES ('VAMPI', 'BlizzTune', 'Vampinou', 'Nico Parenti', '7 rue Orange', 'Elancourt', 'IDF', '78500', 'France','0909021212', '901123');

SELECT *
FROM Customers
WHERE Region='IDF';

-- S�lectionnez tous les enregistrements des Customers o� la colonne PostalCode est vide.
SELECT *
FROM Customers
WHERE PostalCode is NULL;

-- S�lectionnez tous les enregistrements des Customers o� la colonne PostalCode n�est pas vide
SELECT *
FROM Customers
WHERE PostalCode is NOT NULL;

DELETE
FROM Customers
WHERE CustomerID='Vampi';

-- UPDATE 
UPDATE Customers
SET CustomerID='JOELO'
WHERE Fax='901123';

-- D�finissez la valeur des colonnes City sur "Oslo", mais uniquement sur celles o� la colonne Country a la valeur "Norway".
UPDATE Customers
SET City='Oslo'
WHERE Country='Norway';

-- MAJ de Custo ID = GOURL sur cquonveut // City & Country
UPDATE Customers
SET City='Quebec', Country='Quebec'
WHERE CustomerID='GOURL';


-- Supprimer tous les clients qui ont comme Country Norway
/* DELETE w
FROM WorkRecord2 w
INNER JOIN Employee e
  ON EmployeeRun=EmployeeNo
WHERE Company = '1' AND Date = '2013-05-06'
*/

DELETE c, o
FROM  Customers c
INNER JOIN Orders o
ON o.CustomerID = c.CustomerID
WHERE Country='Norway';

DELETE C FROM Customers AS C
INNER JOIN Orders AS O on O.CustomerID = C.CustomerID
	INNER JOIN [Order Details] od on od.OrderID = o.OrderID
WHERE Country='Norway';

-- Requ�te imbriqu�e  -- Brackets = Une table avec un espace
DELETE FROM [Order Details] WHERE OrdeID in (
	SELECT OrderID FROM Orders WHERE CustomerID IN (
		SELECT CustomerID FROM Customers where Country = 'Norway'));

DELETE FROM Orders WHERE CustomerID IN (
	SELECT CustomerID FROM Customers WHERE Country = 'Norway');

DELETE FROM Customers WHERE Country = 'Norway';

