-- SQL Exercise 21
USE upskill_events;
SELECT title, CASE status WHEN 'upcoming' THEN 'Open for registration' WHEN 'completed' THEN 'Ready for feedback review' ELSE 'No action required' END AS status_message FROM events;
