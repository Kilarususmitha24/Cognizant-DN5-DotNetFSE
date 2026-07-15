USE CommunityEventDB;


SELECT
    Users.full_name,
    Registrations.event_id
FROM Users
LEFT JOIN Registrations
ON Users.user_id = Registrations.user_id;


SELECT
    Events.title,
    Sessions.title AS SessionTitle
FROM Events
LEFT JOIN Sessions
ON Events.event_id = Sessions.event_id;


SELECT
    Events.title,
    Resources.resource_type
FROM Events
LEFT JOIN Resources
ON Events.event_id = Resources.event_id;
