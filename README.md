# KShift

#For My SQL Connection : https://www.youtube.com/watch?v=HOdJUMlc4ZM 
#For C# CRUD Example : https://www.youtube.com/watch?v=aer8S1fFbNc&t=531s 
#Passing Data from one form to another : https://www.youtube.com/watch?v=u5tqYXrcuRo

#SQL Script

select * from job;

insert into Job(good_type, weight, sender_name, sender_mobile, sender_address, receiver_name, receiver_mobile, receiver_address, status) values ("furniture", "30kg", "a","a","a","b","b","b", "Pending");

drop table user; 

create table user(
uname varchar(20), 
mobile varchar(20),
address varchar(20),
user_role varchar(20),
password varchar(20),
primary key(uname));

insert into User(uname, mobile, address, user_role, password) values ("admin", "0770760470", "kalutara", "admin", "admin");
insert into User(uname, mobile, address, user_role, password) values ("customer", "0716283034", "kalutara", "customer", "customer");
insert into User(uname, mobile, address, user_role, password) values ("driver1", "0770760470", "kalutara", "driver", "");
insert into User(uname, mobile, address, user_role, password) values ("driver2", "0770760470", "kalutara", "driver", "");
insert into User(uname, mobile, address, user_role, password) values ("driver3", "0770760470", "kalutara", "driver", "");
insert into User(uname, mobile, address, user_role, password) values ("assistant1", "0770760470", "kalutara", "assistant", "");
insert into User(uname, mobile, address, user_role, password) values ("assistant2", "0770760470", "kalutara", "assistant", "");
insert into User(uname, mobile, address, user_role, password) values ("assistant3", "0770760470", "kalutara", "assistant", "");

select * from user;

create table product(good_type varchar(20), weight varchar(20), price varchar(20), constraint PK_product PRIMARY KEY(good_type, weight))
;

select * from product;

create table job_schedule(
job_schedule_id int not null auto_increment, 
lorry varchar(20), 
container varchar(20), 
driver varchar(20),  
assistant varchar(20),  
job_id int,
primary key(job_schedule_id), 
foreign key(job_id) references job(job_id)
)
;

select * from job_schedule;

update job set status = "approved" where job_id=8;




