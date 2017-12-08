/*
—оздаЄт таблицы/индексы/ограничени€ целостности
*/
USE sqlex_help;

IF OBJECT_ID('TicketStatusHistory', 'U') IS NOT NULL DROP TABLE TicketStatusHistory
IF OBJECT_ID('TicketChat', 'U') IS NOT NULL DROP TABLE TicketChat
IF OBJECT_ID('Ticket', 'U') IS NOT NULL DROP TABLE Ticket
IF OBJECT_ID('TicketShift', 'U') IS NOT NULL DROP TABLE TicketShift
IF OBJECT_ID('TicketUser', 'U') IS NOT NULL DROP TABLE TicketUser
GO

CREATE TABLE TicketUser (
  id INT IDENTITY(1, 1) NOT NULL,
  email VARCHAR(255) NOT NULL,
  dateFirstActivity DATETIME NULL,
  dateLastActivity DATETIME NULL,
  loginCount INT NOT NULL,
  ticketCount INT NOT NULL
)
CREATE UNIQUE INDEX IN_TicketUser_email ON TicketUser (email ASC)
GO

CREATE TABLE TicketShift (
  id INT IDENTITY(1, 1) NOT NULL,
  moderator INT NOT NULL,
  needEnd BIT NOT NULL,
  dateStart DATETIME NOT NULL,
  dateEnd DATETIME NULL
)
CREATE INDEX IN_TicketShift_moderator ON TicketShift (moderator ASC)
GO

CREATE TABLE Ticket (
  id INT IDENTITY(1, 1) NOT NULL,
  ticketUser INT NOT NULL,
  ticketShift INT NOT NULL,
  moderator INT NULL,
  ticketPriority INT NOT NULL,
  ticketStatus VARCHAR(50) NOT NULL,
  ticketDescription NVARCHAR(MAX) NOT NULL,
  Title NVARCHAR(1023) NOT NULL,
  taskNumber INT NULL,
  taskQuery NVARCHAR(MAX) NULL,
  taskModquer NVARCHAR(MAX) NULL,
  dateCreated DATETIME NOT NULL,
  dateChanged DATETIME NOT NULL
)
--TODO продумать индексы по датам итп
CREATE INDEX IN_Ticket_ticketUser ON Ticket (ticketUser ASC)
CREATE INDEX IN_Ticket_moderator ON Ticket (moderator ASC)
CREATE INDEX IN_Ticket_ticketShift ON Ticket (ticketShift ASC)
GO

CREATE TABLE TicketChat (
  id INT IDENTITY(1, 1) NOT NULL,
  ticket INT NOT NULL,
  author INT NOT NULL,
  dateCreated DATETIME NOT NULL,
  chatMessage NVARCHAR(MAX) NOT NULL
)
CREATE INDEX IN_TicketChat_ticket ON TicketChat (ticket ASC) --TODO проверить, будет ли без него нормально LOOP JOIN работать? Ќа первый взгл€д это лишний индекс
CREATE INDEX IN_TicketChat_ticket_dateCreated ON TicketChat (ticket ASC, dateCreated ASC)
CREATE INDEX IN_TicketChat_author ON TicketChat (author ASC)
GO

CREATE TABLE TicketStatusHistory (
  id INT IDENTITY(1, 1) NOT NULL,
  ticket INT NOT NULL,
  dateChanged DATETIME NOT NULL,
  ticketStatus VARCHAR(50),
  note NVARCHAR(1024)
)

CREATE INDEX IN_TicketStatusHistory_ticket ON TicketStatusHistory(ticket ASC)--TODO проверить, будет ли без него нормально LOOP JOIN работать? Ќа первый взгл€д это лишний индекс
CREATE INDEX IN_TicketStatusHistory_ticket_dateChanged ON TicketStatusHistory(ticket ASC, dateChanged ASC)
