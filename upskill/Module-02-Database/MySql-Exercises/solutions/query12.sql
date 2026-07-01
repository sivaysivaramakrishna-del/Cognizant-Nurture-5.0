-- SQL Exercise 12
USE upskill_events;
SELECT e.title, COUNT(s.session_id) AS session_count FROM events e LEFT JOIN sessions s ON s.event_id = e.event_id GROUP BY e.event_id, e.title HAVING COUNT(s.session_id) = (SELECT MAX(session_total) FROM (SELECT COUNT(*) AS session_total FROM sessions GROUP BY event_id) totals);
