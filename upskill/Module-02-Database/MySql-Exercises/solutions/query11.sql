-- SQL Exercise 11
USE upskill_events;
SELECT registration_date, COUNT(*) AS new_users FROM users WHERE registration_date >= CURRENT_DATE - INTERVAL 7 DAY GROUP BY registration_date ORDER BY registration_date;
