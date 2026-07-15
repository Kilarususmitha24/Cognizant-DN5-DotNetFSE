USE CommunityEventDB;


CREATE TABLE Organizers(

    organizer_id INT AUTO_INCREMENT PRIMARY KEY,

    organizer_name VARCHAR(100),

    email VARCHAR(100) UNIQUE

);



INSERT INTO Organizers

(organizer_name,email)

VALUES

('Sai Babu',

'sai@gmail.com'),

('Rahul',

'rahul@gmail.com');



SELECT * FROM Organizers;
