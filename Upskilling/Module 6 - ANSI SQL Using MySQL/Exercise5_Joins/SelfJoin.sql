USE CommunityEventDB;


SELECT
    U1.full_name AS User1,
    U2.full_name AS User2,
    U1.city
FROM Users U1
INNER JOIN Users U2
ON U1.city = U2.city
AND U1.user_id < U2.user_id;
