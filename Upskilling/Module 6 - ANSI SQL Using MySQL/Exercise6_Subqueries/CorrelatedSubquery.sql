USE CommunityEventDB;

SELECT
    event_id,
    rating

FROM Feedback F

WHERE rating =
(
    SELECT MAX(rating)
    FROM Feedback
    WHERE event_id = F.event_id
);



SELECT *

FROM Users U

WHERE registration_date =
(
    SELECT MAX(registration_date)
    FROM Users
    WHERE city = U.city
);


SELECT *

FROM Events E

WHERE
(
    SELECT COUNT(*)
    FROM Registrations R
    WHERE R.event_id = E.event_id
)
>= 1;
