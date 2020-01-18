-- Sélectionnez tous les enregistrements pour lesquels la valeur de la colonne City commence par la lettre "a". (table Customers)
SELECT *
FROM Customers
WHERE City LIKE 'a%'
ORDER BY City;


-- Sélectionnez tous les enregistrements pour lesquels la valeur de la colonne City finit par la lettre "a". (table Customers)
SELECT *
FROM Customers
WHERE City LIKE '%a'
ORDER BY City;


-- Sélectionnez tous les enregistrements pour lesquels la valeur de la colonne City contient  la lettre "a". (table Customers)
SELECT *
FROM Customers
WHERE City LIKE '%a%'
ORDER BY City;


-- Sélectionnez tous les enregistrements pour lesquels la valeur de la colonne City commence par  la lettre « a »  et finit par « b ». 
SELECT *
FROM Customers
WHERE City LIKE 'a%b'
ORDER BY City;


-- Sélectionnez tous les enregistrements pour lesquels la valeur de la colonne City NE commence PAS par la lettre "a".
SELECT *
FROM Customers
WHERE City NOT LIKE 'a%'
ORDER BY City;

-- Sélectionnez tous les enregistrements où la première lettre de la City est un "a", un "c" ou un "s".
SELECT *
FROM Customers
WHERE City LIKE 'a%' OR City LIKE 'c%' OR City LIKE 's%'
ORDER BY City;


