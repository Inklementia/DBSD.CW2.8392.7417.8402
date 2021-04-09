use BIS_hospital
go
--1. Trigger that checks that ward has maximum 5 patients that are currently in hospital (not discharged)
create trigger tr_ward_max_pat_5
on patient
for insert, update
as
if exists (
select * from ward as w 
join (select wardId, count(*) as pat_count from patient where isDischarged=0 group by wardId) as p
on w.id = p.wardId and p.pat_count > 5
)
begin
	throw 500001, 'Each ward can have maximum 5 patients', 1;
end
go
--2. Trigger that checks that nurse maintains maximum 3 wards
create trigger tr_nurse_max_ward_3
on ward
for insert, update
as
if exists (
select * from nurse as n 
join (select nurseId, count(*) as ward_count from ward group by nurseId) as w
on n.id = w.nurseId and ward_count>3
)
begin
	throw 500002, 'Each nurse can maintain maximum 3 wards', 1;
end
go
--Triggers that disallow modifications of tables on holidays
--patient table
create trigger tr_modification_not_allowed_pat 
on patient
for insert, update, delete
as 
begin
	if exists (select [day], [month] from disallowed_dates where day(getdate())=[day] and month(getdate())=[month])
	begin
	throw 500003, 'Modifications are not allowed on this day',1;
	end
end
go
--doctor table
create trigger tr_modification_not_allowed_doc
on doctor
for insert, update, delete
as 
begin
	if exists (select [day], [month] from disallowed_dates where day(getdate())=[day] and month(getdate())=[month])
	begin
	throw 500003, 'Modifications are not allowed on this day',1;
	end
end
go
--nurse table
create trigger tr_modification_not_allowed_nur 
on nurse
for insert, update, delete
as 
begin
	if exists (select [day], [month] from disallowed_dates where day(getdate())=[day] and month(getdate())=[month])
	begin
	throw 500003, 'Modifications are not allowed on this day',1;
	end
end
go
--department table
create trigger tr_modification_not_allowed_dept 
on department
for insert, update, delete
as 
begin
	if exists (select [day], [month] from disallowed_dates where day(getdate())=[day] and month(getdate())=[month])
	begin
	throw 500003, 'Modifications are not allowed on this day',1;
	end
end
go
--ward table
create trigger tr_modification_not_allowed_ward 
on ward
for insert, update, delete
as 
begin
	if exists (select [day], [month] from disallowed_dates where day(getdate())=[day] and month(getdate())=[month])
	begin
	throw 500003, 'Modifications are not allowed on this day',1;
	end
end
go
--diagnose table
create trigger tr_modification_not_allowed_diag 
on diagnose
for insert, update, delete
as 
begin
	if exists (select [day], [month] from disallowed_dates where day(getdate())=[day] and month(getdate())=[month])
	begin
	throw 500003, 'Modifications are not allowed on this day',1;
	end
end
go
--Trigger for audit logging of patient table
create trigger tr_patients_log
on patient
for insert, update, delete
as
begin
	declare @operation nvarchar(20)
	if exists(select 1 from inserted) and not exists(select 1 from deleted)
		set @operation = 'Insert'
	else if exists(select 1 from inserted) and exists(select 1 from deleted)
		set @operation = 'Update'
	else
		set @operation = 'Delete'

	INSERT INTO [dbo].[patient_log]
           ([firstName]
           ,[lastName]
           ,[dob]
           ,[occupation]
           ,[gender]
           ,[phone]
           ,[address]
           ,[registeredDate]
           ,[diagnoseId]
           ,[doctorId]
           ,[wardId]
           ,[photo]
           ,[emergencyHospitalization]
           ,[isDischarged]
		   ,[dateModified]
		   ,[operation])
     select
	 [firstName]
           ,[lastName]
           ,[dob]
           ,[occupation]
           ,[gender]
           ,[phone]
           ,[address]
           ,[registeredDate]
           ,[diagnoseId]
           ,[doctorId]
           ,[wardId]
           ,[photo]
           ,[emergencyHospitalization]
           ,[isDischarged]
		   ,getdate()
		   ,@operation
		from ((select * from inserted)
		union all 
			  (select * from deleted)) as [changes]
end
