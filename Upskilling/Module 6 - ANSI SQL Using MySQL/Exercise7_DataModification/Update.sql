USE CommunityEventDB;


UPDATE Users

SET city='Vijayawada'

WHERE user_id=1;


UPDATE Events

SET status='completed'

WHERE event_id=1;


UPDATE Feedback

SET rating=5

WHERE feedback_id=2;


UPDATE Sessions

SET speaker_name='Dr. Ramesh'

WHERE session_id=2;


SELECT * FROM Users;

SELECT * FROM Events;

SELECT * FROM Feedback;

SELECT * FROM Sessions;
