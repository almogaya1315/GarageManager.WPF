IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [Services] (
    [Id] int NOT NULL IDENTITY,
    [TicketNumber] int NOT NULL,
    CONSTRAINT [PK_Services] PRIMARY KEY ([Id])
);

CREATE TABLE [Tbl_Cars] (
    [Id] int NOT NULL IDENTITY,
    [LisencePlateNumber] int NOT NULL,
    [Type] int NOT NULL,
    [Name] nvarchar(50) NOT NULL,
    [CustomerId] int NOT NULL,
    CONSTRAINT [PK_Tbl_Cars] PRIMARY KEY ([Id])
);

CREATE TABLE [Tbl_Customers] (
    [Id] int NOT NULL IDENTITY,
    [SocialSecurityNumber] int NOT NULL,
    [FullName] nvarchar(500) NULL,
    [CarId] int NOT NULL,
    [Adress] nvarchar(200) NOT NULL,
    CONSTRAINT [PK_Tbl_Customers] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Tbl_Customers_Tbl_Cars_CarId] FOREIGN KEY ([CarId]) REFERENCES [Tbl_Cars] ([Id]) ON DELETE CASCADE
);

CREATE INDEX [IX_Tbl_Cars_CustomerId] ON [Tbl_Cars] ([CustomerId]);

CREATE INDEX [IX_Tbl_Customers_CarId] ON [Tbl_Customers] ([CarId]);

ALTER TABLE [Tbl_Cars] ADD CONSTRAINT [FK_Tbl_Cars_Tbl_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Tbl_Customers] ([Id]) ON DELETE CASCADE;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250129101840_InitialCreate', N'9.0.1');

COMMIT;
GO

