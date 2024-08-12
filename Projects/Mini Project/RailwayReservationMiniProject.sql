Create database RailwayReservationMiniProject

Use RailwayReservationMiniProject


create table Trains (Train_No int primary key,
					 Train_Name varchar(55) not null,
					 From_station varchar(55)not null,
					 To_Station varchar(55)not null,
					 Train_Type varchar(55),
					 Schedule varchar(120),
					 No_of_Coaches int,
					 Status varchar(55) check(Status IN ('Active', 'Inactive')) default 'Active')

Create table Coaches (
    Coach_ID int primary key identity,
    Train_No int,
    Coach_Type varchar(55),  
    Coach_Class varchar(55),  
    foreign key (Train_No) references Trains(Train_No))





create table Class_Details(Class_ID int  primary key identity,
						  Train_No int,
						  Class_Name Varchar(55),
						  Total_no_of_seats int ,
						  Available_no_of_seats int,
						  Price decimal(10,2)
						  foreign key (Train_No) references Trains(Train_No))
						 
select*from Class_Details


create table Bookings (Booking_ID int primary key,
					   Passenger_Name varchar(55),
					   age int,
					   sex char(7),
					   Train_No int,
					   Class_Name varchar(55),
					   Date_of_travel date ,
					   No_of_tickets int ,
					   Total_Amount decimal(10, 2) ,
					   Status varchar(55) check (Status IN ('Active', 'Inactive')) default 'Active'
					   foreign key (Train_No) references Trains(Train_No))
select* from Bookings

create table Cancellation (Cancellation_ID  int primary key identity,
						   Booking_ID int,
						   Passenger_Name varchar(55),
						   Train_No int,
						   Class_Name varchar(55) ,
						   No_of_tickets int,
						   Cancellation_date date default GETDATE(),
						   foreign key (Booking_ID) references bookings(Booking_ID),
						   foreign key (Train_No) references Trains(Train_No))
select* from Cancellation



CREATE OR ALTER PROCEDURE Addtraindetails
    @Train_No INT,
    @Train_Name VARCHAR(55),
    @From_Station VARCHAR(55),
    @To_Station VARCHAR(55),
    @Train_Type VARCHAR(55),
    @Schedule VARCHAR(120),
    @No_of_Coaches INT
AS
BEGIN
    INSERT INTO Trains (Train_No, Train_Name, From_Station, To_Station, Train_Type, Schedule, No_of_Coaches)
    VALUES (@Train_No, @Train_Name, @From_Station, @To_Station, @Train_Type, @Schedule, @No_of_Coaches);
END
 

Exec AddTrain @Train_No=18701, @Train_Name=RajdhaniExpress, @From_Station=Delhi, @To_Station=Lucknow, @Train_Type=Passenger, @Schedule= Monday,Tuesday,Friday, @No_of_Coaches = 210;
select* from Trains



CREATE OR ALTER PROCEDURE Addcoachdetails
    @Train_No INT,
    @Coach_Type VARCHAR(55),
    @Coach_Class VARCHAR(55)
AS
BEGIN
    INSERT INTO Coaches (Train_No, Coach_Type, Coach_Class)
    VALUES (@Train_No, @Coach_Type, @Coach_Class);
END

create or alter procedure AddClass_Details 
@Train_No int,
@Class_Name Varchar(55),
@Total_no_of_seats int ,
@Available_no_of_seats int,
@Price decimal(10,2)  
as
begin
insert into Class_Details(Train_No,Class_Name, Total_no_of_seats,Available_no_of_seats,Price)
values (@Train_No,@Class_Name, @Total_no_of_seats,@Available_no_of_seats,@Price);
end

create or alter proc Displaytraindetails
as
begin
select*from Trains
end 
exec Displaytraindetails


CREATE OR ALTER PROCEDURE BookTrainTicket
    @Train_No INT,
    @Passenger_Name VARCHAR(55),
    @Coach_Class VARCHAR(55),
    @Date_of_travel DATE,
    @No_of_tickets INT,
    @Age INT,
    @Sex CHAR(7)
AS
BEGIN
    DECLARE @Ticket_Price DECIMAL(10, 2);
    DECLARE @Total_Amount DECIMAL(10, 2);
 
    -- Get fare
    SELECT @Ticket_Price = Price FROM Class_Details
    WHERE Train_No = @Train_No AND Class_Name = @Coach_Class;
 
    SET @Total_Amount = @Ticket_Price * @No_of_tickets;
 
    -- Insert booking details
    INSERT INTO Bookings (Train_No, Passenger_Name, Class_Name, Date_of_travel, No_of_tickets, Total_Amount, Status, Age, Sex)
    VALUES (@Train_No, @Passenger_Name, @Coach_Class, @Date_of_travel, @No_of_tickets, @Total_Amount, 'Active', @Age, @Sex);
	end
Select*from Bookings
EXEC BookTrainTicket 
    @Passenger_Name = 'Rin',
    @Train_No = 12456,
    @Class_Name = '1AC',
    @Date_of_travel = '2024-09-29',
    @No_of_tickets = 2



CREATE OR ALTER PROCEDURE CancelTicket
    @Booking_ID INT,
    @Passenger_Name VARCHAR(55),
    @Train_No INT,
    @Class_Name VARCHAR(55),
    @No_of_tickets INT
AS

    UPDATE Class_Details
    SET Available_no_of_seats = Available_no_of_seats + @No_of_tickets
    WHERE Train_No = @Train_No AND Class_Name = @Class_Name;
 
    INSERT INTO Cancellation (Booking_ID, Passenger_Name, Train_No, Class_Name, No_of_tickets)
    VALUES (@Booking_ID, @Passenger_Name, @Train_No, @Class_Name, @No_of_tickets);
END

EXEC Cancel_Ticket 
    @Booking_ID = 1,
    @Passenger_Name =Sweta,
    @Train_No = 43212,
    @Class_Name = SL,
    @No_of_tickets = 2;



create or alter procedure TrainStatus
    @Train_No INT
as
begin

update Trains
set Status = 'Active'
where Train_No = @Train_No AND Status = 'Inactive';

update Trains
set Status = 'Inactive'
where Train_No = @Train_No AND Status = 'Active';

-- Select and return the updated status of the train
select Status from Trains
where Train_No = @Train_No;
end