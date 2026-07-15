USE CommunityEventDB;


SELECT
    Users.full_name,
    Registrations.registration_id
FROM Users
RIGHT JOIN Registrations
ON Users.user_id = Registrations.user_id;


SELECT
    Events.title,
    Sessions.title AS SessionTitle
FROM Events
RIGHT JOIN Sessions
ON Events.event_id = Sessions.event_id;
