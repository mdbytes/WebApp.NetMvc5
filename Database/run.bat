color 0a
@ECHO OFF
ECHO Creating Database

sqlcmd -S localhost -E -i app_db.sql
sqlcmd -S localhost -E -i app_db_data.sql


rem server is localhost

ECHO Database created if no errors occured
PAUSE
