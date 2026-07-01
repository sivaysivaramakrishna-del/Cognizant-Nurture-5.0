-- SQL Exercise 20
USE upskill_events;
SELECT e.title, COUNT(DISTINCT r.user_id) AS registered_users, COUNT(DISTINCT f.user_id) AS feedback_users FROM events e LEFT JOIN registrations r ON r.event_id = e.event_id LEFT JOIN feedback f ON f.event_id = e.event_id GROUP BY e.event_id, e.title;
