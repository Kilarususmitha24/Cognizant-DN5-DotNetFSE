USE CommunityEventDB;


SELECT
    Users.full_name,
    Events.title
FROM Users
CROSS JOIN Events;
