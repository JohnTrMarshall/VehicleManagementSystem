CREATE TABLE [dbo].[Vehicle]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [make] NCHAR(25) NOT NULL, 
    [model] NCHAR(30) NOT NULL, 
    [year] DATE NOT NULL, 
    [color] NCHAR(10) NOT NULL, 
    [owner] NCHAR(50) NULL, 
    [holder] NCHAR(50) NULL
)
