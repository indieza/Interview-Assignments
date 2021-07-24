CREATE DATABASE Bit8;

USE Bit8;

CREATE TABLE Department(
	ID INT PRIMARY KEY IDENTITY NOT NULL,
	[NAME] nvarchar(150),
	[LOCATION] nvarchar(150)
);

INSERT INTO [dbo].[Department]
(
    --ID - column value is auto-generated
    [NAME],
    [LOCATION]
)
VALUES
(
    -- ID - int
    N'Executive', -- NAME - nvarchar
    N'Sydney' -- LOCATION - nvarchar
),
(
    -- ID - int
    N'Production', -- NAME - nvarchar
    N'Sydney' -- LOCATION - nvarchar
),
(
    -- ID - int
    N'Resources', -- NAME - nvarchar
    N'Cape Town' -- LOCATION - nvarchar
),
(
    -- ID - int
    N'Technical', -- NAME - nvarchar
    N'Texas' -- LOCATION - nvarchar
),
(
    -- ID - int
    N'Management', -- NAME - nvarchar
    N'PAris' -- LOCATION - nvarchar
);

CREATE TABLE Employee(
	ID INT PRIMARY KEY IDENTITY NOT NULL,
	[NAME] nvarchar(150),
	Salary int,
	DEPT_ID int FOREIGN KEY REFERENCES [dbo].[Department]([ID]) NOT NULL
);

INSERT INTO [dbo].[Employee]
(
    --ID - column value is auto-generated
    [NAME],
    [Salary],
    [DEPT_ID]
)
VALUES
(
    -- ID - INT
    N'Candice', -- NAME - nvarchar
    4685, -- Salary - int
    1 -- DEPT_ID - int
),
(
    -- ID - INT
    N'Julia', -- NAME - nvarchar
    2559, -- Salary - int
    2 -- DEPT_ID - int
),
(
    -- ID - INT
    N'Bob', -- NAME - nvarchar
    4405, -- Salary - int
    4 -- DEPT_ID - int
),
(
    -- ID - INT
    N'Scarlet', -- NAME - nvarchar
    2350, -- Salary - int
    1 -- DEPT_ID - int
),
(
    -- ID - INT
    N'Ileana', -- NAME - nvarchar
    1151, -- Salary - int
    4 -- DEPT_ID - int
);

         SELECT [d].[NAME], COUNT([e].[ID]) AS EmployeeCount
           FROM [dbo].[Department] AS d
LEFT OUTER JOIN [dbo].[Employee] AS e ON [e].[DEPT_ID] = [d].[ID]
       GROUP BY [d].[NAME]
       ORDER BY [EmployeeCount] DESC, [d].[NAME] ASC;