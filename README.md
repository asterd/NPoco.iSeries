# NPoco.iSeries
iSeries extension of NPoco library with support to SQL Stored Procedures

# Summary
This project was created to extend the NPoco library with support to iSeries DB2 (AS400) DB for the ORM
functionalities. 
There is also an additional extension (NPoco.SqlStoredProcedure) that provide ORM on iSeries Sql Stored Procedures.
This library does not use ExpandoObject but only Annotated POCOs. 

# Important notes !!!!
The project NPoco inside this repo is a fork of the [NPoco] (https://github.com/schotime/NPoco) project of **Adam Schroder**.
(Thank you Adam for this fabolous work!)

I have created/modified only two files of this project:
* **CREATED** DatabaseType/ISeriesDatabaseType.cs class to manage iSeries DB2 AS400
* **MODIFIED** DatabaseType.cs to add iDB2 reference to my new class

So, every change/update to the original NPoco project may be not reported here.
If in the future, this class can be added to the original project, the only thing that you have to use is
the NPoco.SqlStoredProcedure project.
