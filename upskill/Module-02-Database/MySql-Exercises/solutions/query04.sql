-- SQL Exercise 4
USE upskill_events;
SELECT e.title, COUNT(s.session_id) AS sessions_between_10_and_12 FROM events e LEFT JOIN sessions s ON s.event_id = e.event_id AND TIME(s.start_time) >= '10:00:00' AND TIME(s.start_time) < '12:00:00' GROUP BY e.event_id, e.title;
