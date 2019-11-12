
DROP table Recipes
DROP table RecipeIngredients

CREATE TABLE Recipes
(
	RecipeName varchar(100) constraint PK_Recipes NOT NULL PRIMARY KEY,
	Price varchar(55) NOT NULL,
	Description varchar(max),
	IngredientList varchar(200)
)

go
CREATE TABLE RecipeIngredients
(
	IngredientName varchar(100) foreign Key references Recipes(RecipeName)
)

