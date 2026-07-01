-- SQL Exercise 19
USE upskill_events;
SELECT e.title, res.resource_type, res.resource_url, res.uploaded_at FROM resources res JOIN events e ON e.event_id = res.event_id ORDER BY res.uploaded_at DESC;
