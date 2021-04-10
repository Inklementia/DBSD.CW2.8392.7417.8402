
use BIS_hospital
go
create table diagnose (
id int identity(1,1) not null,
[name] nvarchar(100) not null,
 constraint pk_diagnose_id primary key(id)
)
create table department (
id int identity(1,1) not null,
[name] nvarchar(30) not null,
constraint pk_department_id primary key(id)
)
create table nurse (
id int identity(1,1) not null,
firstName nvarchar(50) not null,
lastName nvarchar(50) not null,
dob date not null,
gender int not null,
phone nvarchar(20) not null,
salary decimal not null,
email nvarchar(50) not null,
constraint pk_nurse_id primary key(id)
)
create table ward (
id int identity(1,1) not null,
number nvarchar(20) not null,
nurseId int not null,
constraint pk_ward_id primary key(id)
)
create table doctor (
id int identity(1,1) not null,
firstName nvarchar(50) not null,
lastName nvarchar(50) not null,
dob date not null,
gender int not null,
phone nvarchar(20) not null,
salary decimal not null,
email nvarchar(50) not null,
departmentId int not null,
constraint pk_doctor_id primary key(id)
)
create table patient (
id int identity(1,1) not null,
firstName nvarchar(50) not null,
lastName nvarchar(50) not null,
dob date not null,
occupation nvarchar(100),
gender int not null,
phone nvarchar(20) not null,
[address] nvarchar(200) not null,
registeredDate date not null,
diagnoseId int,
doctorId int,
wardId int,
photo varbinary(max),
emergencyHospitalization bit not null,
isDischarged bit not null,
constraint pk_patient_id primary key(id)
)


alter table patient add constraint fk_patient_diagnose foreign key(diagnoseId) references diagnose(id)
alter table patient add constraint fk_patient_doctor foreign key(doctorId) references doctor(id)
alter table patient add constraint fk_patient_ward foreign key(wardId) references ward(id)

alter table doctor add constraint fk_doctor_department foreign key(departmentId) references department(id)
alter table doctor add constraint ch_doctor_dob check(datediff(year, dob, getdate())>21)

alter table nurse add constraint ch_nurse_dob check(datediff(year, dob, getdate())>18)

alter table ward add constraint fk_ward_nurse foreign key(nurseId) references nurse(id)
alter table ward add constraint uq_ward_number unique(number)

--table with holidays, on which modification of tables is not allowed
create table disallowed_dates (
id int identity(1,1) not null,
[day] int not null,
[month] int not null
)

--table for logging modifications made to patient table
select * into patient_log from patient where 1<>1 order by id
alter table patient_log add dateModified datetime
alter table patient_log add operation nvarchar(20)

