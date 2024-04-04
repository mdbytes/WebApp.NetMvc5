## ASP.NET MVC 5 Application

#### Using .NET Framework 4.8.1 and Identity 

<p>An application used for teaching and tutoring</p>

<p>Provides SQL code to create database including necessary identity tables.  Please run the SQL batch file in the Database folder.  When opening Visual Studio, simply enter the 'update-database' command in the NuGet Package Manager Ccnsole.</p>

<p>Roles of User and Admin are immediately available.</p>

<p>There are two test users:</p>

<table>
	<thead>
		<tr>
			<th>Username</th>
			<th>Password</th>
			<th>Role</th>
		</tr>
	</thead>
	<tbody>
		<tr>
			<td>user@user.com</td>
			<td>Test&1234</td>
			<td>USER</td>
		</tr>
		<tr>
			<td>admin@company.com</td>
			<td>Test&1234</td>
			<td>ADMIN</td>
		</tr>
	</tbody>
</table>


<p>See Migrations folder in MVC project to review setup of users along with additional fields for user information.</p>

<p>The database SQL scripts for this project are a modern version of the Northwind Traders database, retrieved from https://www.dofactory.com/sql/sample-database in April, 2024.</p>