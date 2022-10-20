--������� 0
--
select
ID,
Name
from dbo.Employee with(nolock)
where (select max(Sale) from dbo.Employee with(nolock) where ID <> ChiefID)
> (select max(Sale) from dbo.Employee with(nolock) where ID = ChiefID)

--������� 1
--
/*
������� 2 (Read Commited) ��������� ������ � 0 -> 1 � ���.
������� 3 (Read Uncommited) ��������� ������ � 0 -> 1 � ���.
*/
--������� 2
--
select
b.BookID as ID,
b.Name as Name,
iif(bl.Date like '01.02.2005', bl.Date, NULL) as Date
from dbo.tblBook b with(nolock)
left join dbo.BookInLibrary bl with(nolock) on b.BookID = bl.BookID
---
select
b.BookID as ID,
b.Name as Name,
bl.Date as Date
from dbo.tblBook b with(nolock)
left join dbo.BookInLibrary bl with(nolock) on b.BookID = bl.BookID
where bl.Date > '01.02.2005' or bl.Date like NULL

--������� 3
--


--������� 4
--


--������� 5
--
