CREATE TABLE Insurances (
    PolicyNumber VARCHAR(12) PRIMARY KEY,
    CostPerMonth DECIMAL(20, 2) NOT NULL,
    BasePremium DECIMAL(20, 2) NOT NULL,
    ClientNumber INT NOT NULL,
    Description VARCHAR(200)
);