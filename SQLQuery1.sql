create database ContentDB
use ContentDB

CREATE TABLE Articles
(
    ArticleId INT PRIMARY KEY,
    Title NVARCHAR(200),
    Content NVARCHAR(200),
    PublishDate DATETIME

)
insert into Articles values(1,'laptop','processor','1/1/2019')
insert into Articles values(2,'global warming','metro cities','9/9/2022')
insert into Articles values(3,'purchasing','Cryptocurrency','12/10/2018')
insert into Articles values(4,'laptop','hard drives','10/11/2020')
insert into Articles values(5,'laptop','hard drives','10/11/2020')


