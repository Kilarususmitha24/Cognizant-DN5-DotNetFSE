USE CommunityEventDB;



CREATE TABLE Venue(

    venue_id INT PRIMARY KEY,

    venue_name VARCHAR(100),

    city VARCHAR(100)

);



INSERT INTO Venue

VALUES

(1,'Vignan Auditorium','Guntur'),

(2,'Convention Hall','Hyderabad');



SELECT * FROM Venue;
