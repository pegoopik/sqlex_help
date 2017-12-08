/*
Создаёт таблицу, которая "мокает" таблицу пользователей и оборачивает её во вью.
Данный скрипт следует изменить для целевого решения, оставив только вью.
*/
USE sqlex_help;

IF OBJECT_ID('SqlExUserMock', 'U') IS NOT NULL
  DROP TABLE SqlExUserMock;

CREATE TABLE SqlExUserMock (
  id INT IDENTITY(1, 1) NOT NULL,
  email VARCHAR(255) NOT NULL,
  nickName NVARCHAR(255) NOT NULL,
  fullName NVARCHAR(255) NOT NULL
);

CREATE UNIQUE INDEX IN_SqlExUserMock_email ON SqlExUserMock (email ASC);

GO

IF OBJECT_ID('V_SQLEX_USERS', 'V') IS NOT NULL
  DROP VIEW V_SQLEX_USERS;

GO 

CREATE VIEW V_SQLEX_USERS AS
SELECT * FROM SqlExUserMock;

GO