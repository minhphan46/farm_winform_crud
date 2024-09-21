-- Database for Farm Management

-- Table for Animal Types (Cows, Sheep, Goats)
CREATE TABLE AnimalType (
    AnimalTypeId INT PRIMARY KEY IDENTITY(1,1),
    AnimalName VARCHAR(50) NOT NULL,
    Sound VARCHAR(50) NOT NULL
);

-- Table for Animals in the farm
CREATE TABLE Animal (
    AnimalId INT PRIMARY KEY IDENTITY(1,1),
    AnimalTypeId INT FOREIGN KEY REFERENCES AnimalType(AnimalTypeId),
    MilkProduced FLOAT NOT NULL,
    OffspringCount INT NOT NULL
);

-- Table for Milk Statistics
CREATE TABLE MilkStatistics (
    StatisticsId INT PRIMARY KEY IDENTITY(1,1),
    AnimalId INT FOREIGN KEY REFERENCES Animal(AnimalId),
    Date DATETIME NOT NULL,
    MilkProduced FLOAT NOT NULL
);

-- Table for Offspring Statistics
CREATE TABLE OffspringStatistics (
    StatisticsId INT PRIMARY KEY IDENTITY(1,1),
    AnimalId INT FOREIGN KEY REFERENCES Animal(AnimalId),
    Date DATETIME NOT NULL,
    OffspringCount INT NOT NULL
);

-- Table for Farm Statistics (to summarize total milk and offspring)
CREATE TABLE FarmStatistics (
    StatisticsId INT PRIMARY KEY IDENTITY(1,1),
    Date DATETIME NOT NULL,
    TotalMilk FLOAT NOT NULL,
    TotalOffspring INT NOT NULL
);

-- Insert some animal types into the AnimalType table
INSERT INTO AnimalType (AnimalName, Sound) VALUES ('Cow', 'Moo');
INSERT INTO AnimalType (AnimalName, Sound) VALUES ('Sheep', 'Baa');
INSERT INTO AnimalType (AnimalName, Sound) VALUES ('Goat', 'Bleat');

-- Inserting sample animals into the Animal table
INSERT INTO Animal (AnimalTypeId, MilkProduced, OffspringCount) VALUES (1, 15.0, 1); -- Cow
INSERT INTO Animal (AnimalTypeId, MilkProduced, OffspringCount) VALUES (2, 3.0, 2);  -- Sheep
INSERT INTO Animal (AnimalTypeId, MilkProduced, OffspringCount) VALUES (3, 7.0, 3);  -- Goat

-- Inserting sample Milk Statistics
INSERT INTO MilkStatistics (AnimalId, Date, MilkProduced) VALUES (1, GETDATE(), 15.0);
INSERT INTO MilkStatistics (AnimalId, Date, MilkProduced) VALUES (2, GETDATE(), 3.0);
INSERT INTO MilkStatistics (AnimalId, Date, MilkProduced) VALUES (3, GETDATE(), 7.0);

-- Inserting sample Offspring Statistics
INSERT INTO OffspringStatistics (AnimalId, Date, OffspringCount) VALUES (1, GETDATE(), 1);
INSERT INTO OffspringStatistics (AnimalId, Date, OffspringCount) VALUES (2, GETDATE(), 2);
INSERT INTO OffspringStatistics (AnimalId, Date, OffspringCount) VALUES (3, GETDATE(), 3);

-- Inserting sample Farm Statistics (total for all animals)
INSERT INTO FarmStatistics (Date, TotalMilk, TotalOffspring) VALUES (GETDATE(), 25.0, 6); -- Total milk = 15 + 3 + 7, offspring = 1 + 2 + 3