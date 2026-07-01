-- SQL Exercise 1
USE upskill_events;
SELECT u.full_name, u.city, e.title, e.start_date FROM users u JOIN registrations r ON r.user_id = u.user_id JOIN events e ON e.event_id = r.event_id WHERE e.status = 'upcoming' AND e.city = u.city ORDER BY e.start_date;
