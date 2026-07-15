USE CommunityEventDB;


CREATE TABLE Speakers(

    speaker_id INT AUTO_INCREMENT PRIMARY KEY,

    speaker_name VARCHAR(100) NOT NULL,

    email VARCHAR(100) UNIQUE,

    phone VARCHAR(15),

    specialization VARCHAR(100)

);


CREATE TABLE Sponsors(

    sponsor_id INT AUTO_INCREMENT PRIMARY KEY,

    sponsor_name VARCHAR(100),

    company VARCHAR(100),

    amount DECIMAL(10,2)

);



SHOW TABLES;

DESCRIBE Speakers;

DESCRIBE Sponsors;
