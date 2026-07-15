USE CommunityEventDB;

CREATE TABLE Users(

    user_id INT AUTO_INCREMENT PRIMARY KEY,

    full_name VARCHAR(100) NOT NULL,

    email VARCHAR(100) UNIQUE NOT NULL,

    city VARCHAR(100),

    registration_date DATE

);

CREATE TABLE Events(

    event_id INT AUTO_INCREMENT PRIMARY KEY,

    title VARCHAR(200) NOT NULL,

    description TEXT,

    city VARCHAR(100),

    start_date DATETIME,

    end_date DATETIME,

    status ENUM('upcoming','completed','cancelled'),

    organizer_id INT,

    FOREIGN KEY(organizer_id)

    REFERENCES Users(user_id)

);

CREATE TABLE Sessions(

    session_id INT AUTO_INCREMENT PRIMARY KEY,

    event_id INT,

    title VARCHAR(200),

    speaker_name VARCHAR(100),

    start_time DATETIME,

    end_time DATETIME,

    FOREIGN KEY(event_id)

    REFERENCES Events(event_id)

);

CREATE TABLE Registrations(

    registration_id INT AUTO_INCREMENT PRIMARY KEY,

    user_id INT,

    event_id INT,

    registration_date DATE,

    FOREIGN KEY(user_id)

    REFERENCES Users(user_id),

    FOREIGN KEY(event_id)

    REFERENCES Events(event_id)

);

CREATE TABLE Feedback(

    feedback_id INT AUTO_INCREMENT PRIMARY KEY,

    user_id INT,

    event_id INT,

    rating INT,

    comments TEXT,

    feedback_date DATE,

    FOREIGN KEY(user_id)

    REFERENCES Users(user_id),

    FOREIGN KEY(event_id)

    REFERENCES Events(event_id)

);

CREATE TABLE Resources(

    resource_id INT AUTO_INCREMENT PRIMARY KEY,

    event_id INT,

    resource_type VARCHAR(50),

    resource_url VARCHAR(255),

    uploaded_at DATETIME,

    FOREIGN KEY(event_id)

    REFERENCES Events(event_id)

);
