USE CommunityEventDB;


SELECT *
FROM Users

WHERE user_id IN
(
    SELECT user_id
    FROM Registrations
);

SELECT *
FROM Events

WHERE event_id IN
(
    SELECT event_id
    FROM Feedback
);


SELECT *
FROM Users

WHERE user_id IN
(
    SELECT user_id
    FROM Feedback
);USE CommunityEventDB;

SELECT *
FROM Users

WHERE user_id IN
(
    SELECT user_id
    FROM Registrations
);

SELECT *
FROM Events

WHERE event_id IN
(
    SELECT event_id
    FROM Feedback
);

SELECT *
FROM Users

WHERE user_id IN
(
    SELECT user_id
    FROM Feedback
);
