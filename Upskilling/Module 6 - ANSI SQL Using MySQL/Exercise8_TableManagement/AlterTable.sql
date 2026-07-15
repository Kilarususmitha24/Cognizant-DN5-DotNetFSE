USE CommunityEventDB;



ALTER TABLE Speakers

ADD experience INT;


ALTER TABLE Speakers

MODIFY phone VARCHAR(20);


ALTER TABLE Speakers

RENAME COLUMN specialization TO expertise;


ALTER TABLE Speakers

DROP COLUMN experience;


DESCRIBE Speakers;
