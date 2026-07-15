USE CommunityEventDB;


SELECT
    Users.user_id,
    Users.full_name,
    Events.title
FROM Users
INNER JOIN Registrations
ON Users.user_id = Registrations.user_id
INNER JOIN Events
ON Registrations.event_id = Events.event_id;


SELECT
    Events.title,
    Sessions.title AS SessionTitle,
    Sessions.speaker_name
FROM Events
INNER JOIN Sessions
ON Events.event_id = Sessions.event_id;


SELECT
    Users.full_name,
    Feedback.rating,
    Feedback.comments
FROM Users
INNER JOIN Feedback
ON Users.user_id = Feedback.user_id;
