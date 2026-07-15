USE CommunityEventDB;


CREATE TABLE EventVenue(

    eventvenue_id INT AUTO_INCREMENT PRIMARY KEY,

    event_id INT,

    venue_id INT,

    FOREIGN KEY(event_id)

    REFERENCES Events(event_id),

    FOREIGN KEY(venue_id)

    REFERENCES Venue(venue_id)

);



INSERT INTO EventVenue

(event_id,venue_id)

VALUES

(1,1),

(2,2);



SELECT * FROM EventVenue;
