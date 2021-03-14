@echo off

echo Copy sql file to docker...
docker cp ./MSSql/initialize/SetUpKashilog.sql kashilogdb:/tmp/setupkashilog.sql

echo Create data for kashilogdb from sql file...
docker exec -it kashilogdb /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P h0geFuga -i /tmp/setupkashilog.sql

echo Create data task for kashilogdb is Completed!

pause
