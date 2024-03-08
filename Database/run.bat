color 0a
@ECHO OFF
ECHO Creating Database

sqlcmd -S localhost -E -i database.sql
sqlcmd -S localhost -E -i database_identity.sql
sqlcmd -S localhost -E -i database_procedures.sql
sqlcmd -S localhost -E -i database_inserts.sql

rem server is localhost

ECHO Database created if no errors occured
PAUSE
