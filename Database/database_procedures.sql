use [car_db]

GO

create procedure [dbo].[sp_create_car] 
	@make varchar(100),
	@model varchar(100),
	@year int
as
begin
	insert into cars 
	(make, model, year)
	values 
	(@make, @model, @year);
	SELECT CAST(scope_identity() AS int);
end

GO
/****** Object:  StoredProcedure [dbo].[sp_create_user]    Script Date: 3/7/2024 3:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

create procedure [dbo].[sp_create_user] 
	@firstName varchar(100),
	@lastName varchar(100),
	@email varchar(250),
	@password varchar(250),
	@isLoggedIn bit,
	@isAdmin bit
as
begin
	insert into users 
	(first_name, last_name, email, password, is_loggedin, is_admin)
	values 
	(@firstName, @lastName, @email, @password, @isLoggedIn, @isAdmin);
	SELECT CAST(scope_identity() AS int);
end

GO
/****** Object:  StoredProcedure [dbo].[sp_delete_car]    Script Date: 3/7/2024 3:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

create procedure [dbo].[sp_delete_car] 
	@carId int
as
begin
	delete from cars where car_id = @carId;
end

GO
/****** Object:  StoredProcedure [dbo].[sp_delete_user]    Script Date: 3/7/2024 3:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

create procedure [dbo].[sp_delete_user] 
	@userId int
as
begin
	delete from users where user_id = @userId;
end

GO
/****** Object:  StoredProcedure [dbo].[sp_select_all_cars]    Script Date: 3/7/2024 3:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

create procedure [dbo].[sp_select_all_cars]
as
begin
	select * from cars;
end

GO
/****** Object:  StoredProcedure [dbo].[sp_select_all_users]    Script Date: 3/7/2024 3:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[sp_select_all_users]
AS
	select * from users;

GO
/****** Object:  StoredProcedure [dbo].[sp_select_car_by_id]    Script Date: 3/7/2024 3:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

create procedure [dbo].[sp_select_car_by_id] 
	@id int
as
begin 
	select * from cars where car_id = @id;
end

GO
/****** Object:  StoredProcedure [dbo].[sp_select_user_by_email]    Script Date: 3/7/2024 3:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

create procedure [dbo].[sp_select_user_by_email] 
	@email varchar(250)
as
begin 
	select * from users where email = @email
end

GO
/****** Object:  StoredProcedure [dbo].[sp_select_user_by_id]    Script Date: 3/7/2024 3:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

create procedure [dbo].[sp_select_user_by_id] 
	@id int
as
begin 
	select * from users where user_id = @id;
end

GO
/****** Object:  StoredProcedure [dbo].[sp_update_car]    Script Date: 3/7/2024 3:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

create procedure [dbo].[sp_update_car] 
	@carId int,
	@make varchar(100),
	@model varchar(100),
	@year int
as
begin
	update cars 
		set make = @make,
		model = @model,
		year = @year
	where 
		car_id = @carId;
	SELECT CAST(scope_identity() AS int);
end

GO
/****** Object:  StoredProcedure [dbo].[sp_update_user]    Script Date: 3/7/2024 3:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

create procedure [dbo].[sp_update_user] 
	@userId int,
	@firstName varchar(100),
	@lastName varchar(100),
	@email varchar(250),
	@password varchar(250),
	@isLoggedIn bit,
	@isAdmin bit
as
begin
	update users 
		set first_name = @firstName,
		last_name = @lastName,
		email = @email,
		password = @password,
		is_loggedin = @isLoggedIn,
		is_admin = @isAdmin
	where 
		user_id = @userId;
	SELECT CAST(scope_identity() AS int);
end

GO
