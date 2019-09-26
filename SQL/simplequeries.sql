use ORG

-- Alias Name
SELECT FIRST_NAME as Worker_Name from Worker
-- Upper case
SELECT UPPER(FIRST_NAME) as Worker_Name from Worker
-- lower case
SELECT LOWER(FIRST_NAME) as Worker_Name from Worker
-- get unique values
SELECT distinct DEPARTMENT from Worker;
-- find the text length
SELECT LEN('Dinesh Balasundaram') as TextLength;
-- print first three characters
SELECT SUBSTRING(FIRST_NAME, 1,3) from WORKER
-- find position of Alphabet 
SELECT CHARINDEX('OM', 'Customer') AS Position;
-- find position of Alphabet FROM table
SELECT CHARINDEX('bh',
(SELECT FIRST_NAME FROM WORKER WHERE FIRST_NAME = 'Amitabh')) 
As Position
-- trim values Left and Right Trim
SELECT LTRIM(FIRST_NAME) As WorkerName from WORKER 
SELECT RTRIM(FIRST_NAME) As WorkerName from WORKER 
-- find the count of columns
SELECT COUNT(DEPARTMENT) AS TotalColumns
FROM WORKER
-- find the count of unique values
SELECT COUNT(DISTINCT DEPARTMENT) AS DistinctDepartments
FROM WORKER
-- replace value
SELECT REPLACE(FIRST_NAME,'a','A') from Worker;
-- replace value using where condition
Select REPLACE(FIRST_NAME,'v','V') from Worker 
WHERE FIRST_NAME like 'V%';
-- concatenation
SELECT CONCAT(FIRST_NAME,'-', LAST_NAME) As FullName
from Worker
-- Order by First Name - Ascending
SELECT * from Worker ORDER BY FIRST_NAME 
-- Order by First Name - Decending
SELECT * from Worker ORDER BY FIRST_NAME desc
-- TWO columns order by
SELECT * from Worker ORDER BY FIRST_NAME, DEPARTMENT 
SELECT FIRST_NAME, DEPARTMENT from Worker 
ORDER BY FIRST_NAME asc, DEPARTMENT desc
-- get the Vipul and satish details
SELECT * FROM Worker where FIRST_NAME IN ('VIPUL', 'SATISH')
-- ERROR -  get the Vipul and satish details USING AND
SELECT * FROM Worker where (FIRST_NAME ='Vipul' 
AND FIRST_NAME ='Satish')
-- get EXCLUDING Vipul and satish details
SELECT * FROM Worker where FIRST_NAME NOT IN ('VIPUL', 'SATISH')
-- get first name STARTS with 'A'
SELECT * FROM WORKER WHERE FIRST_NAME LIKE 'A%'
-- get first name CONTAINS with 'A'
SELECT * FROM WORKER WHERE FIRST_NAME LIKE '%A%'
-- get first name ENDS with 'A'
SELECT * FROM WORKER WHERE FIRST_NAME LIKE '%A'
-- get workers; names end with 'h' and contains SIX alphabets
SELECT * FROM WORKER WHERE FIRST_NAME LIKE '______h'
-- get worker; salary lies between 100000 and 500000
SELECT * FROM Worker WHERE SALARY BETWEEN 100000 AND 500000
-- get Workers joined in FEB 2014
Select * from Worker WHERE year(JOINING_DATE) = 2014 
AND month(JOINING_DATE) = 2;
-- get count of employees working in admin Department
SELECT COUNT(*) FROM Worker where DEPARTMENT = 'admin'
-- get workers details with salary  >= 50000 And <= 80000.
SELECT CONCAT(first_name, ' ', last_name) as WorkerName, salary
FROM worker where SALARY >=50000 and SALARY <=80000
-- get workers details with salary  >= 50000 And <= 80000
-- USING Sub Query
SELECT CONCAT(first_name, ' ', last_name) as WorkerName, salary
from worker where worker_id in 
(select WORKER_ID from worker where SALARY between 50000 and 80000)
-- get count of employes in each department
SELECT DEPARTMENT, COUNT(WORKER_ID) AS EMPCOUNT  FROM WORKER
GROUP BY DEPARTMENT
-- get count in group by
SELECT WORKER_TITLE, AFFECTED_FROM, COUNT(*)
FROM Title GROUP BY WORKER_TITLE, AFFECTED_FROM
-- show ODD EVEN rows
SELECT * FROM WORKER WHERE WORKER_ID%2=0
SELECT * FROM WORKER WHERE WORKER_ID%2=1

-- show ODD EVEN rows using ROW_NUMBER
SELECT *
FROM (
    SELECT *, Row_Number() OVER(ORDER BY (SELECT NULL)) AS RowNumber 
            --Row_Number() starts with 1
    FROM WORKER
) t
WHERE t.RowNumber % 2 = 0 --Even
--WHERE t.RowNumber % 2 = 1 --Odd

-- clone table
SELECT * INTO WorkerClone FROM Worker;
(SELECT * FROM Worker)
INTERSECT
(SELECT * FROM WorkerClone);

--Write An SQL Query To Show Records From One Table That 
--Another Table Does Not Have.
SELECT * FROM Worker
MINUS SELECT * FROM Title;
-- show current date
SELECT getdate();
-- Show TOP N records
select top 5 * from Worker
-- get 5 th salary
select top 1 * from (
    select DISTINCT top 5 SALARY from worker order by SALARY desc
)t ORDER by SALARY asc
-- get list of employees with same salary in same TABLE
select w.Worker_id, w.first_name, w.salary from Worker w, 
worker w1 where w.SALARY = w1.salary
and W.WORKER_ID != W1.WORKER_ID;
--get the Departments That Have Less Than Five People In It.
SELECT Department, COUNT(Worker_id) from worker
GROUP by DEPARTMENT 
HAVING COUNT(WORKER_ID)<5
-- Write An SQL Query To Show The Last Record From A Table.
SELECT * FROM Worker 
WHERE WORKER_ID = (SELECT MAX(WORKER_ID) FROM Worker)
-- Write An SQL Query To Show The Last Record From A Table.
SELECT TOP 1 * FROM Worker ORDER BY WORKER_ID DESC

-- top 3 MIN salary
SELECT distinct Salary from worker a 
WHERE 3 >= (SELECT count(distinct Salary) from worker b 
WHERE a.Salary >= b.Salary) order by a.Salary desc;