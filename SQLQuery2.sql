

Select dMainID, mdate , m.mSupCusID,s.supName, SUM(d.amount) from tblMain m
inner join tblDetails d on d.dMainID = m.MainID
inner join Supplier s on s.supID = m.mSupCusID
where m.mType = 'PUR'
group by dMainID , mdate , m.mSupCusID,s.supName