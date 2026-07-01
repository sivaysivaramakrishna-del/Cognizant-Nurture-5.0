-- SQL Exercise 7
USE upskill_events;
SELECT u.full_name, e.title, f.rating, f.comments FROM feedback f JOIN users u ON u.user_id = f.user_id JOIN events e ON e.event_id = f.event_id WHERE f.rating < 3;
