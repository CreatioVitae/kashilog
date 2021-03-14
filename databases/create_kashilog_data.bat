@echo off

echo Copy sql file to docker...
docker cp ./MSSql/initialize/Insert_KashilogData.sql kashilogdb:/tmp/insert_kashilogdata.sql

echo Create data for kashilogdb from sql file...
docker exec -it kashilogdb /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P h0geFuga -i /tmp/insert_kashilogdata.sql

echo Create data for kashilogdb is Completed!

pause
