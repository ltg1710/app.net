# app.net
* vb.net code is in VB_Code directory
* c#.net code is in CS_Code directory

# procedures

``` sql
CREATE PROCEDURE CreateAppTable
 
AS
BEGIN
CREATE TABLE App(
ID int IDENTITY(1,1),
Name varchar(50) NOT NULL,
PRIMARY KEY (ID) )
END 
```
``` sql
CREATE PROCEDURE InsertAppDataIntoTable
@Name varchar(50)

AS
BEGIN
INSERT INTO App(Name)
VALUES ( @Name)
END
```
``` sql
CREATE PROCEDURE ReadAppDataFromTable
@ID int

AS
BEGIN
SELECT * FROM App
WHERE ID = @ID
END
```
