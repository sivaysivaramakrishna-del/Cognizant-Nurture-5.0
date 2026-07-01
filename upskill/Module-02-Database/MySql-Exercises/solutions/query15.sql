-- SQL Exercise 15
USE upskill_events;
SELECT a.event_id, a.title AS first_session, b.title AS second_session FROM sessions a JOIN sessions b ON a.event_id = b.event_id AND a.session_id < b.session_id AND a.start_time < b.end_time AND b.start_time < a.end_time;
