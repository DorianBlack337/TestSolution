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
select
CounterpartyID,
Name,
COUNT(t.AssetID) + COUNT(t.RcvID) + COUNT(t.SndID) as Cnt
from dbo.Counterparty c with(nolock)
left join dbo.Trans t with(nolock) on t.RcvID = c.CounterpartyID
where t.AssetID = c.CounterpartyID or t.RcvID = c.CounterpartyID or t.SndID = c.CounterpartyID
---


--������� 4
--
select
(select pt1.PeriodID
from dbo.PeriodTable pt1 with(nolock)
where (pt1.PeriodID not pt.PeriodID) and (pt.Value not pt1.Value)) as PeriodID
from dbo.PeriodTable pt with(nolock)
--
delete from dbo.PeriodTable pt where (select pt1.PeriodID
from dbo.PeriodTable pt1 with(nolock)
where (pt.PeriodID not pt1.PeriodID) and (pt.Value not pt1.Value)) = PeriodID

--������� 5
--
