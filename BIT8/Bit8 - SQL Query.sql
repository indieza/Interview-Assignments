USE [Bit8];

CREATE TABLE Company(
		ID INT PRIMARY KEY IDENTITY NOT NULL,
		[NAME] nvarchar(150),
		EMPLOYEES int
);

INSERT INTO [dbo].[Company]
(
    --ID - column value is auto-generated
    [NAME],
    [EMPLOYEES]
)
VALUES
(
    -- ID - INT
    'Adobe', -- NAME - nvarchar
    28085 -- EMPLOYEES - int
),
(
    -- ID - INT
    'Flipkart', -- NAME - nvarchar
    35543 -- EMPLOYEES - int
),
(
    -- ID - INT
    'Amazon', -- NAME - nvarchar
    1089 -- EMPLOYEES - int
),
(
    -- ID - INT
    'Paytm', -- NAME - nvarchar
    9982 -- EMPLOYEES - int
),
(
    -- ID - INT
    'BookMyShow', -- NAME - nvarchar
    5589 -- EMPLOYEES - int
),
(
    -- ID - INT
    'Oracle', -- NAME - nvarchar
    4003 -- EMPLOYEES - int
),
(
    -- ID - INT
    'NIIT', -- NAME - nvarchar
    57782 -- EMPLOYEES - int
),
(
    -- ID - INT
    'Samsung', -- NAME - nvarchar
    2000 -- EMPLOYEES - int
),
(
    -- ID - INT
    'TCS', -- NAME - nvarchar
    10046 -- EMPLOYEES - int
),
(
    -- ID - INT
    'Wipro', -- NAME - nvarchar
    3500 -- EMPLOYEES - int
);

  SELECT [c].[ID] FROM [dbo].[Company] AS c
   WHERE [c].[EMPLOYEES] > 10000
ORDER BY [c].[ID] ASC;