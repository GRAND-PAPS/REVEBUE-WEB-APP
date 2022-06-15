Create Table Revenueusers
(
	userId int identity (1,1) primary key,
	Firstname nvarchar(50) not null,
    Surname nvarchar(50) not null,
    Usertype nvarchar(25) not null,
    Password varbinary(50) not null,
    Email nvarchar(50) not null
);