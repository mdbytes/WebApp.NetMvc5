USE [app_db]
GO

CREATE PROCEDURE sp_delete_product_by_id
(
  @Id INT
)
AS 
	BEGIN

		DELETE FROM [dbo].[Product]
		WHERE Id = @Id

	END
GO

CREATE PROCEDURE sp_insert_product
(
	@ProductName  nvarchar(50),
    @SupplierId  int,
    @UnitPrice decimal(12,2),
    @Package nvarchar(30),
    @IsDiscontinued bit
)
AS
	BEGIN
	INSERT INTO [dbo].[Product]
           ([ProductName]
           ,[SupplierId]
           ,[UnitPrice]
           ,[Package]
           ,[IsDiscontinued])
     VALUES
           (@ProductName,
			@SupplierId,
			@UnitPrice,
			@Package,
			@IsDiscontinued)
	END
GO

CREATE PROCEDURE sp_update_product_by_id
(
	@Id int,
	@ProductName  nvarchar(50),
    @SupplierId  int,
    @UnitPrice decimal(12,2),
    @Package nvarchar(30),
    @IsDiscontinued bit
)
AS
	BEGIN
		UPDATE [dbo].[Product]
		SET [ProductName] = @ProductName
			,[SupplierId] = @SupplierId
			,[UnitPrice] = @UnitPrice
			,[Package] = @Package
			,[IsDiscontinued] = @IsDiscontinued
		WHERE [Id] = @Id
	END
GO

CREATE PROCEDURE sp_select_product_all
AS
	BEGIN
		SELECT [Id]
		  ,[ProductName]
		  ,[SupplierId]
		  ,[UnitPrice]
		  ,[Package]
		  ,[IsDiscontinued]
		FROM [dbo].[Product]

	END
GO

CREATE PROCEDURE sp_select_product_by_id
(
	@Id int
)
AS
	BEGIN
		SELECT [Id]
		  ,[ProductName]
		  ,[SupplierId]
		  ,[UnitPrice]
		  ,[Package]
		  ,[IsDiscontinued]
		FROM [dbo].[Product]

		WHERE [Id] = @Id
	END
GO

