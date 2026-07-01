-- SQL Exercise 10
USE upskill_events;
SELECT e.title FROM events e JOIN registrations r ON r.event_id = e.event_id LEFT JOIN feedback f ON f.event_id = e.event_id WHERE f.feedback_id IS NULL GROUP BY e.event_id, e.title;
