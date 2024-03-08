USE [car_db];

GO

INSERT INTO [dbo].[AspNetUsers]
		   ([Id]
		   ,[Email]
		   ,[EmailConfirmed]
		   ,[PasswordHash]
		   ,[SecurityStamp]
		   ,[PhoneNumberConfirmed]
		   ,[TwoFactorEnabled]
		   ,[LockoutEnabled]
		   ,[AccessFailedCount]
		   ,[UserName])
	 VALUES
		   ('b9117d9f-0bee-4d3e-a86c-899a77c0893d'
		   ,'user@user.com'
		   ,0
		   ,'APje638kp4PXo/OIsLZseVWswuyKqxYr4hazVz0zfNSiY1FKIBQv0l5DFQYkWQaKHQ=='
		   ,'5a75f19a-d8b6-4a1a-9bb7-f6f861cec496'
		   ,0
		   ,0
		   ,1
		   ,0
		   ,'user@user.com')
GO

INSERT INTO [dbo].[AspNetUsers]
		   ([Id]
		   ,[Email]
		   ,[EmailConfirmed]
		   ,[PasswordHash]
		   ,[SecurityStamp]
		   ,[PhoneNumberConfirmed]
		   ,[TwoFactorEnabled]
		   ,[LockoutEnabled]
		   ,[AccessFailedCount]
		   ,[UserName])
	 VALUES
		   ('cb334af2-7b4b-401e-acf9-565086051374'
		   ,'admin@company.com'
		   ,0
		   ,'ANkjkqL4yTlSQr3JNHQtAyDgstaVKjQqzH5bOV5zy6My7ENlFoaJpeagpxGNrkeA5A=='
		   ,'9193f6c8-14e7-448c-b586-5524dc09b6fc'
		   ,0
		   ,0
		   ,1
		   ,0
		   ,'admin@company.com')
GO


INSERT INTO [dbo].[AspNetRoles]
		   ([Id]
		   ,[Name])
	 VALUES
		   (1,'USER'),
		   (2,'ADMIN')
GO


INSERT INTO [dbo].[AspNetUserRoles]
		   ([UserId]
		   ,[RoleId])
	 VALUES
		   ('cb334af2-7b4b-401e-acf9-565086051374'
		   ,1),
		   ('cb334af2-7b4b-401e-acf9-565086051374'
		   ,2)
GO

INSERT INTO [dbo].[AspNetUserRoles]
		   ([UserId]
		   ,[RoleId])
	 VALUES
		   ('b9117d9f-0bee-4d3e-a86c-899a77c0893d'
		   ,1)
GO

insert into users 
(first_name,last_name,email, password,is_loggedin, is_admin)
values
('Martin','Dwyer','martin@mdbytes.com','test123',1,1),
('Rose','Dwyer','rose@ymail.com','test123',1,0);

GO

insert into cars
(make,model,year)
values
('chevy','impala',1987),
('ford','mustang',1984),
('chevy','camaro',1972),
('pontiac','grand prix', 1972);