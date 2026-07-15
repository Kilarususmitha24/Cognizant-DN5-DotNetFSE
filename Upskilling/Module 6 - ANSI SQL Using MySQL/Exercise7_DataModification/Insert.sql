USE CommunityEventDB;


INSERT INTO Users
(full_name,email,city,registration_date)

VALUES
('Priya',
'priya@gmail.com',
'Visakhapatnam',
'2026-07-20');

INSERT INTO Users
(full_name,email,city,registration_date)

VALUES
('Arun',
'arun@gmail.com',
'Hyderabad',
'2026-07-21'),

('Sneha',
'sneha@gmail.com',
'Guntur',
'2026-07-21');

INSERT INTO Events
(title,
description,
city,
start_date,
end_date,
status,
organizer_id)

VALUES
('Cyber Security Workshop',
'Security Awareness Program',
'Hyderabad',
'2026-11-10 10:00:00',
'2026-11-10 16:00:00',
'upcoming',
1);


INSERT INTO Registrations
(user_id,event_id,registration_date)

VALUES
(6,4,'2026-07-22');


SELECT * FROM Users;

SELECT * FROM Events;

SELECT * FROM Registrations;
