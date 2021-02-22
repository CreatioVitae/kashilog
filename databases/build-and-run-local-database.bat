@echo off
echo Build kashilogdb And kashilogdbtest...

docker build -t kashilogdb Mssql

echo Run kashilogdb And kashilogdbtest...

docker run --name kashilogdb -p 15331:1433 -d kashilogdb 

pause
