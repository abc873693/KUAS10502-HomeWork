CREATE TABLE [dbo].[Table] (
    [PostalCode] INT  DEFAULT ((0)) NOT NULL,
    [Section]    TEXT NULL,
    [English]    TEXT NULL,
    PRIMARY KEY CLUSTERED ([PostalCode] ASC)
);

