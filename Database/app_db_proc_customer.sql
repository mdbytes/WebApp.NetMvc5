USE [app_db]
GO

CREATE PROCEDURE sp_delete_customer_by_id
(
  @Id INT
)
AS 
	BEGIN

		DELETE FROM [dbo].[Customer]
		WHERE Id = @Id

	END
GO

CREATE PROCEDURE sp_insert_customer
(
	@FirstName nvarchar(40),
	@LastName nvarchar(40),
    @City nvarchar(40),
    @Country nvarchar(40),
    @Phone nvarchar(20)
)
AS
	BEGIN
	INSERT INTO [dbo].[Customer]
           ([FirstName]
           ,[LastName]
           ,[City]
           ,[Country]
           ,[Phone])
     VALUES
			(
			@FirstName,
			@LastName,
			@City,
			@Country,
			@Phone
			)
	END
GO

CREATE PROCEDURE sp_update_customer_by_id
(
	@Id int,
	@FirstName nvarchar(40),
	@LastName nvarchar(40),
    @City nvarchar(40),
    @Country nvarchar(40),
    @Phone nvarchar(20)
)
AS
	BEGIN
		UPDATE [dbo].[Customer]
		SET [FirstName] = @FirstName
			,[LastName] = @LastName
			,[City] = @City
			,[Country] = @Country
			,[Phone] = @Phone
		WHERE [Id] = @Id

	END
GO

CREATE PROCEDURE sp_select_customer_all
AS
	BEGIN
		SELECT [Id]
		  ,[FirstName]
		  ,[LastName]
		  ,[City]
		  ,[Country]
		  ,[Phone]
		FROM [dbo].[Customer]
	END
GO

CREATE PROCEDURE sp_select_customer_by_id
(
	@Id int
)
AS
	BEGIN
		SELECT [Id]
		  ,[FirstName]
		  ,[LastName]
		  ,[City]
		  ,[Country]
		  ,[Phone]
		FROM [dbo].[Customer]
		WHERE [Id] = @Id
	END
GO

