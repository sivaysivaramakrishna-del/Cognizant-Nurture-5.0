-- SQL Exercise 2
USE upskill_events;
SELECT e.title, AVG(f.rating) AS average_rating, COUNT(*) AS feedback_count FROM events e JOIN feedback f ON f.event_id = e.event_id GROUP BY e.event_id, e.title HAVING COUNT(*) >= 10 ORDER BY average_rating DESC;
