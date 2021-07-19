CREATE TABLE [dbo].[Registered] (
    [Id]       NCHAR (10)   NOT NULL,
    [FullName] VARCHAR (50) NOT NULL,
    [Email]    VARCHAR (50) NOT NULL,
    [Password] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

