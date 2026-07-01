-- SQL Exercise 16
USE upskill_events;
SELECT city, DATE_FORMAT(registration_date, '%Y-%m') AS registration_month, COUNT(*) AS users_registered FROM users GROUP BY city, registration_month ORDER BY registration_month, city;
