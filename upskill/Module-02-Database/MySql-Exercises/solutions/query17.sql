-- SQL Exercise 17
USE upskill_events;
SELECT e.title FROM events e LEFT JOIN registrations r ON r.event_id = e.event_id WHERE e.status = 'upcoming' GROUP BY e.event_id, e.title HAVING COUNT(r.registration_id) = 0;
