-- SQL Exercise 23
USE upskill_events;
SELECT u.full_name, COUNT(r.registration_id) AS registrations FROM users u JOIN registrations r ON r.user_id = u.user_id GROUP BY u.user_id, u.full_name HAVING COUNT(r.registration_id) >= 2;
