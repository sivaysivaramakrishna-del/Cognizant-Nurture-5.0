-- SQL Exercise 13
USE upskill_events;
SELECT e.city, AVG(f.rating) AS average_rating FROM events e JOIN feedback f ON f.event_id = e.event_id GROUP BY e.city;
