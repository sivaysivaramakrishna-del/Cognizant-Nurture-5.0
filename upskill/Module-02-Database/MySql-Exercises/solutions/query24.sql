-- SQL Exercise 24
USE upskill_events;
SELECT title, TIMESTAMPDIFF(HOUR, start_date, end_date) AS duration_hours FROM events ORDER BY duration_hours DESC;
