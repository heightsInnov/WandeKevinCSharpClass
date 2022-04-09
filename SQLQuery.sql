--Create
Insert into Student(uniqueRef, name, phone) values('wertyhfdssd', 'Yewande Money', '07067009776');
Insert into Student(uniqueRef, name, phone) values('wertyhxsddss', 'Segun Boss', '08108013440');
Insert into Student(uniqueRef, name, phone) values('ertyhxsddtts', 'Kevin Winner', '07035489054');

--Read
Select * from Student 
Select * from Student where uniqueRef = 'wertyhfdssd'
Select * from Student where name = 'Segun Boss'
Select * from Student where phone = '07035489054'
Select phone from Student
Select phone from Student where uniqueRef = 'wertyhfdssd' and name like '%Yewande%';
Select * from Student where name = 'Oluwasegun'


--Update
update Student set name = 'Ayotola';
update Student set name = 'Oluwasegun' where name = 'Segun Boss';