use ORG

select * from Worker
select * from Title

-- get worker who are also managers (from two different tables)
-- manager details are in TITLE table
-- worker details are in WORKER table
select W.First_Name, T.WORKER_TITLE from Worker W
inner join Title T on w.WORKER_ID = T.WORKER_REF_ID

-- To Fetch Duplicate Records Having Matching Data In Some Fields Of A Table.
-- compare data in two different columns and count 
-- SELECT * FROM TITLE
SELECT WORKER_TITLE, AFFECTED_FROM, COUNT(*)
FROM Title
GROUP BY WORKER_TITLE, AFFECTED_FROM
HAVING COUNT(*) > 1;

