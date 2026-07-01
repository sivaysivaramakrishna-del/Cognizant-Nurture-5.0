-- SQL Exercise 22
USE upskill_events;
SELECT city, DATE(start_date) AS event_date, GROUP_CONCAT(title ORDER BY start_date SEPARATOR ', ') AS events_on_date FROM events GROUP BY city, DATE(start_date) ORDER BY event_date;
