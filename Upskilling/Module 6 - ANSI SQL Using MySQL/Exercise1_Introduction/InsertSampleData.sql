USE CommunityEventDB;

INSERT INTO Users(full_name,email,city,registration_date)

VALUES

('Sai Babu','sai@gmail.com','Guntur','2026-07-01'),

('Rahul','rahul@gmail.com','Vijayawada','2026-07-02'),

('Anjali','anjali@gmail.com','Hyderabad','2026-07-03'),

('Kiran','kiran@gmail.com','Chennai','2026-07-04'),

('Meena','meena@gmail.com','Bangalore','2026-07-05');

INSERT INTO Events

(title,description,city,start_date,end_date,status,organizer_id)

VALUES

('Tech Meetup',

'Technology Event',

'Hyderabad',

'2026-08-10 10:00:00',

'2026-08-10 16:00:00',

'upcoming',

1),

('AI Conference',

'Artificial Intelligence',

'Bangalore',

'2026-09-15 09:00:00',

'2026-09-15 17:00:00',

'upcoming',

2),

('Web Development',

'Frontend Bootcamp',

'Chennai',

'2026-10-20 10:00:00',

'2026-10-22 16:00:00',

'upcoming',

3);

INSERT INTO Sessions

(event_id,title,speaker_name,start_time,end_time)

VALUES

(1,'Opening Session',

'Dr. Kumar',

'2026-08-10 10:00:00',

'2026-08-10 11:00:00'),

(1,'Cloud Computing',

'Ramesh',

'2026-08-10 11:30:00',

'2026-08-10 12:30:00'),

(2,'AI Basics',

'Anita',

'2026-09-15 09:30:00',

'2026-09-15 10:30:00');

INSERT INTO Registrations

(user_id,event_id,registration_date)

VALUES

(1,1,'2026-07-15'),

(2,1,'2026-07-15'),

(3,2,'2026-07-16'),

(4,2,'2026-07-16'),

(5,3,'2026-07-17');

INSERT INTO Feedback

(user_id,event_id,rating,comments,feedback_date)

VALUES

(1,1,5,'Excellent Event','2026-08-11'),

(2,1,4,'Very Good','2026-08-11'),

(3,2,5,'Amazing','2026-09-16');

INSERT INTO Resources

(event_id,resource_type,resource_url,uploaded_at)

VALUES

(1,'PDF',

'https://example.com/file1.pdf',

NOW()),

(2,'Video',

'https://example.com/video.mp4',

NOW());
