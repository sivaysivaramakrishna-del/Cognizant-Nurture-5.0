-- SQL Exercise 6
USE upskill_events;
SELECT e.title,
       COALESCE(SUM(res.resource_type = 'pdf'), 0) AS pdfs,
       COALESCE(SUM(res.resource_type = 'image'), 0) AS images,
       COALESCE(SUM(res.resource_type = 'link'), 0) AS links,
       COUNT(res.resource_id) AS total_resources
FROM events e
LEFT JOIN resources res ON res.event_id = e.event_id
GROUP BY e.event_id, e.title;
