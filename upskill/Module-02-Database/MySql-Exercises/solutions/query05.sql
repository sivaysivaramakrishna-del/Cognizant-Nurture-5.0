-- SQL Exercise 5
USE upskill_events;
SELECT u.city, COUNT(DISTINCT r.user_id) AS distinct_registrations FROM users u JOIN registrations r ON r.user_id = u.user_id GROUP BY u.city ORDER BY distinct_registrations DESC LIMIT 5;
