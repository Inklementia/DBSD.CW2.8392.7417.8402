use BIS_hospital
go
--create patient
create procedure udp_create_patient (@firstName nvarchar(50),
									 @lastName nvarchar(50),
									 @dob date,
									 @occupation nvarchar(100),
									 @gender int,
									 @phone nvarchar(20),
									 @address nvarchar(200),
									 @diagnoseId int,
									 @doctorId int,
									 @wardId int,
									 @photo varbinary(max) = null,
									 @emergencyHospitalization bit)
as
begin
set nocount on
insert into patient (firstName, 
					lastName, 
					dob, 
					occupation,
					gender,
					phone, 
					[address],
					registeredDate, 
					diagnoseId,
					doctorId, 
					wardId, 
					emergencyHospitalization, 
					isDischarged)
values	(@firstName,
		 @lastName,
		 @dob,
		 @occupation,
		 @gender,
		 @phone,
		 @address,
		 --registered date is set automatically during registration
		 getdate(),
		 @diagnoseId,
		 @doctorId,
		 @wardId,
		 @emergencyHospitalization,
		 --when patient gets hospitalized, isDischarged field is automatically set to false, it can be modified later
		 0)
end
go

--update patient
create procedure udp_update_patient (@id int,
									 @firstName nvarchar(50),
									 @lastName nvarchar(50),
									 @dob date,
									 @occupation nvarchar(100),
									 @gender int,
									 @phone nvarchar(20),
									 @address nvarchar(200),
									 @registeredDate date,
									 @diagnoseId int,
									 @doctorId int,
									 @wardId int,
									 @photo varbinary(max),
									 @emergencyHospitalization bit,
									 @isDischarged bit)
as
begin
set nocount on
update patient set firstName = @firstName,
				   lastName = @lastName,
				   dob = @dob,
				   occupation = @occupation,
				   gender = @gender,
				   phone = @phone,
				   [address] = @address,
				   registeredDate = @registeredDate,
				   diagnoseId= @diagnoseId,
				   doctorId= @doctorId,
				   wardId= @wardId ,
				   photo= @photo ,
				   emergencyHospitalization= @emergencyHospitalization ,
				   isDischarged= @isDischarged 
				where id = @id 
end
go
--get patient by id
create procedure udp_get_by_id (@id int) as
begin
--getting all related data
select	p.id,
		p.firstName,
		p.lastName,
		p.dob,
		p.occupation,
		p.gender,
		p.phone,
		p.address,
		p.registeredDate,
		p.diagnoseId,
		diag.name as diagnoseName,
		p.doctorId,
		concat(doc.lastName, ' ', doc.firstName) as doctorName,
		dept.name as departmentName,
		p.wardId,
		ward.number as wardNo,
		concat(nurse.lastName, ' ', nurse.firstName) as nurseName,
		p.photo,
		p.emergencyHospitalization,
		p.isDischarged
		from patient p
		left outer join diagnose diag on p.diagnoseId = diag.id
		left outer join doctor doc on p.doctorId = doc.id
		left outer join ward on p.wardId = ward.id
		left outer join nurse on ward.nurseId = nurse.id
		left outer join department dept on doc.departmentId = dept.id
		where p.id = @id
end
go
--delete patient
create procedure udp_delete_patient (@id int) as
begin
set nocount on
delete from patient where id = @id
end
go
--filter patients
create procedure udp_filter_patients (
									  @name nvarchar(50) = null,
									  @address nvarchar(200) = null,
									  @registeredDate date = null,
									  @diagnoseName nvarchar(100) = null,
									  @doctorName nvarchar(50) = null,
									  @orderBy nvarchar(50) = null,
									  @orderDesc bit = 0,
									  @pageNum int = 1,
									  @pageSize int = 4,
									  @rowsCount int out --necessary for paging implementation
) as
begin
set nocount on
--building dynamic query
declare @query as nvarchar(max)
--parameters to pass to extended stored procedure
declare @parameters as nvarchar(max)
--getting necessary fields from 6 tables
set @query = 'select p.id,
					 p.firstName,
					 p.lastName,
					 p.dob,
					 p.address,
					 p.gender,
					 p.phone,
					 p.registeredDate,
					 diag.name as diagnoseName,
					 concat(doc.lastName, '' '', doc.firstName) as doctorName,
					 dept.name as departmentName,
					 ward.number as wardNo,
					 concat(nurse.lastName,'' '', nurse.firstName) as nurseName
				from patient p'
				
	declare @joinClause nvarchar(max) = ' left outer join diagnose diag on p.diagnoseId = diag.id
				left outer join doctor doc on p.doctorId = doc.id
				left outer join ward on p.wardId = ward.id
				left outer join nurse on ward.nurseId = nurse.id
				left outer join department dept on doc.departmentId = dept.id'
--filtering
 declare @whereClause nvarchar(max) = ' where p.id<>0';
 --if name is not null, search value in last name and first name
	if @name is not null
	begin
		set @whereClause = @whereClause + ' and ((p.firstName like '''+ '%' + rtrim(ltrim(@name)) + '%' + ''') 
								or (p.lastName like '''+ '%' + rtrim(ltrim(@name)) + '%' + '''))'
	end
--if address is not null, search by it
	if @address is not null
		set @whereClause = @whereClause + ' and p.address like ''' + '%' + rtrim(ltrim(@address)) + '%' + ''''
--if registered date is not null, search by it
	if @registeredDate is not null
		set @whereClause = @whereClause + ' and p.registeredDate='''+cast(@registeredDate as nvarchar(100))+''''
--if diagnise name is not null, search by it
	if @diagnoseName is not null
		set @whereClause = @whereClause + ' and diag.name like ''' + '%' + rtrim(ltrim(@diagnoseName)) + '%' + ''''
--if doctor name is not null, search value in last name and first name
	if @doctorName is not null
		begin
		set @whereClause = @whereClause + ' and ((doc.firstName like '''+ '%' + rtrim(ltrim(@doctorName)) + '%' + ''') 
								or (doc.lastName like '''+ '%' + rtrim(ltrim(@doctorName)) + '%' + '''))'
		end
	set @query = @query +@joinClause + @whereClause
--sorting
--sort by ward number
	if(@orderBy='wardNo')
		set @query = @query + ' order by wardNo'
--sort by date of birth
	else if(@orderBy='dob')
		set @query = @query + ' order by p.dob'
--sort by registered date
	else if(@orderBy='registeredDate')
		set @query = @query + ' order by p.registeredDate'
--sort by nurse last name
	else if (@orderBy='nurseName')
		set @query = @query + ' order by nurse.lastName'
--sort by doctor last name
	else if (@orderBy='doctorName')
		set @query = @query + ' order by doc.lastName'
--sort by patient last name by default
	else 
		set @query = @query + ' order by p.lastName'
	
	if @orderDesc=1
		set @query = @query + ' desc'
--paging
	set @query = @query + ' offset @pageSize*(@pageNum-1) rows fetch next @pageSize rows only'
--executing query
	set @parameters = '@name nvarchar(50),
					   @address nvarchar(200),
					   @registeredDate date,
					   @diagnoseName nvarchar(100),
					   @doctorName nvarchar(50),
					   @orderBy nvarchar(50),
					   @orderDesc bit,
					   @pageNum int,
					   @pageSize int
					   '
	execute sp_executesql @query,@parameters,@name,@address,@registeredDate,@diagnoseName,@doctorName,@orderBy,@orderDesc,@pageNum,@pageSize
	--setting parameters for executing query that returns number of rows 
	set @parameters = '@name nvarchar(50),
					   @address nvarchar(200),
					   @registeredDate date,
					   @diagnoseName nvarchar(100),
					   @doctorName nvarchar(50),
					   @rowsCount int out'
	declare @countQuery  nvarchar(max) = 'select @rowsCount = count(*) from patient p '+ @joinClause + @whereClause
	execute sp_executesql @countQuery,@parameters, @name,@address,@registeredDate,@diagnoseName,@doctorName,@rowsCount = @rowsCount out
end

--stored procedure for bulk insertion
go
create type patientTable as table (
firstName nvarchar(50) not null,
lastName nvarchar(50) not null,
dob date not null,
occupation nvarchar(100),
gender int not null,
phone nvarchar(20) not null,
[address] nvarchar(200) not null,
diagnoseId int not null,
doctorId int not null,
wardId int not null,
photo varbinary(max),
emergencyHospitalization bit not null
)

go
create procedure udp_patient_bulk_insert 
(
	@patientTable patientTable readonly
)
as
begin
set nocount on
begin try
insert into patient (firstName, 
					lastName, 
					dob, 
					occupation,
					gender,
					phone, 
					[address],
					registeredDate, 
					diagnoseId,
					doctorId, 
					wardId, 
					emergencyHospitalization,
					isDischarged)

select  firstName,
		lastName,
		dob,
		occupation,
		gender,
		phone,
		[address],
		getdate(),
		diagnoseId,
		doctorId,
		wardId,
		emergencyHospitalization,
		0
from @patientTable
return(0) --success
end try
begin catch
return(1) --error
end catch
end
go

