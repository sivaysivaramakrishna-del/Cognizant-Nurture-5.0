-- SQL Exercise 3
USE upskill_events;
SELECT u.user_id, u.full_name FROM users u LEFT JOIN registrations r ON r.user_id = u.user_id AND r.registration_date >= CURRENT_DATE - INTERVAL 90 DAY WHERE r.registration_id IS NULL;
