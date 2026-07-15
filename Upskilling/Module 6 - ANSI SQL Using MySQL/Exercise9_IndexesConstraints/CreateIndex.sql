USE CommunityEventDB;


CREATE INDEX idx_user_name

ON Users(full_name);


CREATE INDEX idx_event_city

ON Events(city);


SHOW INDEX

FROM Users;

SHOW INDEX

FROM Events;
