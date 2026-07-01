-- SQL Exercise 14
USE upskill_events;
SELECT e.title, COUNT(r.registration_id) AS registration_count FROM events e LEFT JOIN registrations r ON r.event_id = e.event_id GROUP BY e.event_id, e.title ORDER BY registration_count DESC LIMIT 3;
