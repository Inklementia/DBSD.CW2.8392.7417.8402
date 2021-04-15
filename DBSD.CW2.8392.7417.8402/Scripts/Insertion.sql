use BIS_hospital
go
insert into diagnose ([name]) values ('Asthma') 
insert into diagnose ([name]) values ('Diabetes') 
insert into diagnose ([name]) values('Covid-19') 
insert into diagnose ([name]) values ('Nail fungus')
insert into diagnose ([name]) values ('Depressive disorder')
insert into diagnose ([name]) values('Anxiety disorder') 
insert into diagnose ([name]) values('Ulcer') 
insert into diagnose ([name]) values('Cancer')
insert into diagnose ([name]) values('Flu') 
insert into diagnose ([name]) values('Appendicitis') 
insert into diagnose ([name]) values('Hepatitis') 
insert into diagnose ([name]) values('Herpes')
insert into diagnose ([name]) values('Heart failure')
insert into diagnose ([name]) values('Heart attack')
insert into diagnose ([name]) values('Chickenpox') 
insert into diagnose ([name]) values('Food poisoning') 
insert into diagnose ([name]) values('Parkinson disease')
insert into diagnose ([name]) values('Meningitis') 
insert into diagnose ([name]) values('Stroke') 
insert into diagnose ([name]) values('Tuberculosis')

insert into department ([name]) values ('Infectious disease department')
insert into department ([name]) values ('Therapy')
insert into department ([name]) values ('Dermatology')
insert into department ([name]) values ('Psychiatry') 
insert into department ([name]) values ('Cardiology')
insert into department ([name]) values ('Gastroenterology') 
insert into department ([name]) values ('Oncology')
insert into department ([name]) values ('Surgery') 
insert into department ([name]) values ('Traumatology') 
insert into department ([name]) values ('Gynecology')
insert into department ([name]) values ('Allergy and Immunology') 
insert into department ([name]) values ('Emergency medicine') 
insert into department ([name]) values ('Pediatrics') 
insert into department ([name]) values ('Urology')
insert into department ([name]) values ('Ophtalmology') 
insert into department ([name]) values ('Neurology')
insert into department ([name]) values ('Anesthesiology')
insert into department ([name]) values ('Orthopedics')
insert into department ([name]) values ('Physiotherapy') 
insert into department ([name]) values ('Diagnostics')

/* 0 - male , 1 - female*/
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values ('Boburissa', 'Igrasheva', '1995-10-02', 1, '+998902222222', '1000', 'boburissa1995@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('Bobko', 'Firgashev', '2000-10-02', 0, '+998902222233', '1200', 'bobkorider@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('Saur', 'Bredpittov', '1998-04-20', 1, '+998904444443', '1800', 'aot@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('Bob', 'Guylord', '1990-04-10', 0, '+998945676565', '1000', 'warlord@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('John', 'Doe', '2000-04-02', 0, '+998991112222', '800', 'john2000@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('Svetoslav', 'Andijanov', '1992-04-19', 0, '+99890657788', '1000', 'light1992@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('Basal', 'Svetliy', '2001-01-02', 0, '+998902555511', '900', 'basal_work@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('Ahmed', 'Basalov', '1998-03-10', 0, '+998901235544', '1100', 'ahmed2001@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('Anna', 'Satoru', '1990-04-02', 1, '+998923334455', '950', 'satoru1990@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('Angella', 'Irgasheva', '2000-01-02', 1, '+998994567711', '1115', 'angella2000@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('Andrey', 'Olegov', '1998-03-04', 0, '++998976452314', '1115', 'andrew23@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('Zinaida', 'Lukyanova', '1995-01-02', 1, '++998997894536', '1000', 'zinaida@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('Laylo', 'Nigmatova', '2001-05-02', 1, '++998903456789', '2000', 'nlaylo0@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('Inessa', 'Pak', '1999-07-08', 0, '+998972134562', '1000', 'inna@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('Adele', 'Moring', '1995-04-03', 1, '+9989075633234', '2000', 'amoring@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('Sara', 'Oneil', '1999-01-02', 1, '+998907564523', '1115', 'saraneil@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('Eva', 'Rivers', '2000-01-02', 1, '++998905674523', '1000', 'eva@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('Violet', 'Evergarden', '1998-09-02', 1, '+998906542312', '1000', 'violet@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('Yudji', 'Itadori', '1996-02-02', 0, '+998901111111', '1000', 'yitadori@gmail.com')
insert into nurse (firstName, lastName, dob, gender, phone, salary, email) values 	('Tony', 'Kark', '1995-04-02', 0, '+998907776655', '2000', 'tony@gmail.com')


insert into ward (number, nurseId) values 	('221A', 1)
insert into ward (number, nurseId) values 	('221B', 2)
insert into ward (number, nurseId) values 	('222A', 3)
insert into ward (number, nurseId) values 	('222B', 4)
insert into ward (number, nurseId) values 	('300A', 5)
insert into ward (number, nurseId) values 	('300B', 6)
insert into ward (number, nurseId) values 	('300C', 7)
insert into ward (number, nurseId) values 	('301A', 8)
insert into ward (number, nurseId) values 	('302B', 9)
insert into ward (number, nurseId) values 	('303A', 10)
insert into ward (number, nurseId) values 	('408A', 12)
insert into ward (number, nurseId) values 	('403B', 13)
insert into ward (number, nurseId) values 	('405C', 16)
insert into ward (number, nurseId) values 	('405D', 17)
insert into ward (number, nurseId) values 	('501A', 17)
insert into ward (number, nurseId) values 	('502A', 18)
insert into ward (number, nurseId) values 	('501B', 18)
insert into ward (number, nurseId) values 	('502B', 19)
insert into ward (number, nurseId) values 	('606A', 19)
insert into ward (number, nurseId) values 	('606B', 19)


insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Andrew', 'Sattarov', '1980-02-02', 0, '+998901111111', '5000', 'andrey007@gmail.com', 1)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Sauron', 'Targarien', '1988-04-14', 0, '+998907674434', '1000', 'example@gmail.com', 2)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('BredPitt', 'Saurov', '1998-11-15', 0, '+998902346576', '1000', 'bred1998@gmail.com', 3)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Gaydar', 'Bobov', '1990-03-02', 0, '+998943456654', '1000', 'noblesse@gmail.com', 4)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Den', 'Khanov', '1989-04-02', 0, '+998991112222', '1000', 'mustaches@gmail.com', 5)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Andijon', 'Ferganievv', '1976-09-02', 0, '+99987767648', '1000', 'adf1992@gmail.com', 6)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Karas', 'Basalov', '1960-01-20', 0, '+998909998888', '1000', 'random1@gmail.com', 7)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Basal', 'Ahmedov', '1998-03-10', 0, '+998909872200', '1000', 'random2@gmail.com', 8)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Melon', 'Waterov', '1990-01-02', 0, '+998920106655', '1000', 'kish1990@gmail.com', 9)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Maria', 'Irgasheva', '1988-04-10', 1, '+998923334422', '4500', 'dracula@gmail.com', 11)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Julia', 'Shevtsova', '1980-12-31', 1, '+998907864523', '5000', 'shevtsova@gmail.com', 12)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Aliya', 'Absatarova', '1974-02-19', 1, '+998907554433', '5500', 'absatarova@gmail.com', 13)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Oksana', 'Strokova', '1958-04-06', 1, '+998997552345', '6000', 'strokova@gmail.com', 14)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Anastasiya', 'Matveeva', '1967-09-05', 1, '+998907776655', '6500', 'matveeva@gmail.com', 15)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Natalya', 'Sergeeva', '1960-05-02', 1, '+998901234567', '7000', 'sergeeva@gmail.com', 16)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Alexey', 'Smirnov', '1993-11-20', 0, '+998905668935', '7500', 'asmirnov@gmail.com', 17)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Michael', 'Sergeev', '1995-12-13', 0, '+998901345678', '8000', 'msergeev@gmail.com', 18)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Pavel', 'Petrov', '1990-10-10', 0, '+998905671234', '8500', 'ppetrov@gmail.com', 19)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Ivan', 'Vasilyev', '1997-12-14', 0, '+998905742345', '2000', 'vasilyev@gmail.com', 20)
insert into doctor (firstName, lastName, dob, gender, phone, salary, email, departmentId) values 	('Evgeny', 'Pak', '1995-05-05', 0, '+998997886655', '2500', 'epak@gmail.com', 10)


insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Sara', 'ONeil', '2000-02-02', 'accountant', 1, '+998901234567', 'Some street, 12, 1', getdate(),11,1,1,1,1)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Luke', 'Moring', '1999-03-04', 'teacher', 0, '+998907654321', 'Some other street, 125, 12', getdate(),11,1,1,1,1)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Michael', 'Turner', '2002-02-01', 'student', 0, '+998901111111', 'Other street, 12, 11', getdate(),16,6,2,1,0)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Bobby', 'Turner', '2003-02-06', 'student', 0, '+998902222222', 'Other street, 12, 11', getdate(),16,6,2,1,1)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('John', 'Hall', '1998-12-11', 'lecturer', 0, '+998906666666', 'Street 5, 8, 12', getdate(),8,7,3,0,1)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Annet', 'William', '1999-02-06', 'not employed', 1, '+998909999999', 'Street 5, 8, 12', getdate(),19,5,4,1,0)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Agata', 'Harris', '1998-12-13', 'uni graduate', 1, '+998903333333', 'Somewhere, 13, 1', getdate(),19,5,4,1,0)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Alexander', 'Nelson', '1997-07-08', 'company director', 0, '+998908888888', 'Some street, 13, 1', getdate(),5,4,5,0,0)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Eliza', 'Harris', '1999-10-15', 'company manager', 1, '+998907777777', 'Some street, 12, 1', getdate(),9,1,6,0,0)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Zach', 'Harris', '1999-10-15', 'company director', 0, '+998906666666', 'Some street, 12, 1', getdate(),9,1,6,0,0)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Annet', 'Harris', '1968-08-12', 'company owner', 1, '+998905555555', 'Some street, 12, 1', getdate(),9,1,6,0,0)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Vicky', 'Walker', '1999-12-03', 'student', 1, '+998904444444', 'Heaven street, 5, 14', getdate(),18,8,7,1,1)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Dino', 'Walker', '1995-06-17', 'lecturer', 0, '+998903333333', 'Heaven street, 5, 14', getdate(),18,8,7,1,1)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Laya', 'Burnell', '1996-03-01', 'artist', 1, '+998902222222', 'Lestvill street, 19, 10', getdate(),13,5,8,0,0)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Milly', 'Burnell', '2001-03-12', 'student', 1, '+998902223344', 'Lestvill street, 19, 10', getdate(),13,5,8,0,0)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Spencer', 'Hastings', '1994-12-15', 'lawyer', 1, '+998903334455', 'Baker street, 34, 5', getdate(),3,1,9,0,1)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Toby', 'Kavanaugh', '1993-03-08', 'carpenter', 0, '+998904445566', 'Baker street, 34, 5', getdate(),3,1,9,0,1)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Hannah', 'Marin', '1994-03-10', 'designer', 1, '+998905556677', 'London street, 23, 35', getdate(),15,1,10,0,1)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Caleb', 'Rivers', '1994-11-12', 'IT specialist', 0, '+998906667788', 'London street, 23, 35', getdate(),15,1,10,0,0)
insert into patient (firstName, lastName, dob, occupation, gender, phone, [address], registeredDate, 
diagnoseId, doctorId, wardId, emergencyHospitalization, isDischarged) values('Emily', 'Fields', '1994-05-14', 'athlete', 1, '+998907778899', 'New York street, 44, 67', getdate(),10,11,11,1,1)


--holidays
insert into disallowed_dates ([day], [month]) values
(1,9),
(1,10),
(8,12),
(31, 12),
(1, 1),
(8, 3),
(21, 3),
(9, 5)


