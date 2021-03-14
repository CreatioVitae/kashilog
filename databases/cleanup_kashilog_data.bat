@echo off

echo Copy sql file to docker...
docker cp ./MSSql/initialize/CleanUpKashilog.sql kashilogdb:/tmp/cleanupkashilog.sql

echo Cleanup data for kashilogdb from sql file...
docker exec -it kashilogdb /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P h0geFuga -i /tmp/cleanupkashilog.sql

echo Cleanup data for kashilogdb is Completed!

pause
