-- CHECK NAME CONTAINS IN TABLE
USE ORG
SELECT FIRST_NAME FROM WORKER

-- Get highst salary
select MAX(SALARY) AS SALARY FROM WORKER

-- Get highst salary AND HIS NAME 
SELECT FIRST_NAME, max(salary) FROM WORKER 
WHERE salary = (
                SELECT max(salary)
                FROM WORKER
               )
GROUP BY FIRST_NAME

-- Get top 3 (n) salary 
SELECT DISTINCT TOP (3) Salary
                         FROM   WORKER
                         ORDER  BY Salary DESC

-- Get highst salary AND HIS NAME 
SELECT FIRST_NAME, Salary FROM WORKER
WHERE Salary = (SELECT Max(Salary) FROM WORKER)

-- Get SECOND highest salary
SELECT MAX(SALARY) FROM WORKER   
WHERE SALARY<(SELECT MAX(SALARY) FROM WORKER)  

-- Get SECOND highest salary AND HIS NAME
SELECT FIRST_NAME, SALARY
FROM   WORKER
WHERE  Salary = (SELECT MIN(Salary)
                 FROM   (SELECT DISTINCT TOP (2) Salary
                         FROM   WORKER
                         ORDER  BY Salary DESC) T);

-- Get SECOND highest salary AND HIS NAME, Id..etc
SELECT * from WORKER 
WHERE Salary IN (SELECT MAX(Salary) 
                 FROM WORKER 
                 WHERE Salary NOT IN (SELECT MAX(Salary) 
                                      FROM WORKER));

-- Get n th salary
SELECT 
      MIN(SALARY) 
FROM 
      WORKER 
WHERE 
      SALARY in (SELECT 
                      DISTINCT TOP 2 SALARY 
                 FROM 
                      WORKER 
                 ORDER BY 
                      SALARY DESC
                )

-- Get records BETWEEN from 4 to 7
select * from WORKER ORDER BY(SELECT NULL) 
    OFFSET 3 ROWS FETCH NEXT 4 ROWS ONLY

-- Get records BETWEEN from 4 to 7 USING
SELECT * 
	FROM WORKER
	ORDER BY WORKER_ID
	OFFSET 3 ROWS
	FETCH NEXT 4 ROWS ONLY


-- Search value in table using LIKE
SELECT COUNT(*)
FROM WORKER
WHERE FIRST_NAME like '%Vipul%'

-- Search value in table using CONTAINS
-- ERROR 
SELECT * FROM WORKER WHERE CONTAINS(FIRST_NAME, 'Vipul');

-- get count of employes in each department
SELECT DEPARTMENT, COUNT(WORKER_ID) AS EMPCOUNT  FROM WORKER
GROUP BY DEPARTMENT

-- To Fetch Duplicate Records Having Matching Data In Some Fields Of A Table.
-- compare data in two different columns and count 
-- SELECT * from Title
SELECT WORKER_TITLE, AFFECTED_FROM, COUNT(*)
FROM Title
GROUP BY WORKER_TITLE, AFFECTED_FROM
HAVING COUNT(*) > 1;

-- show ODD EVEN rows using ROW_NUMBER
SELECT *
FROM (
    SELECT *, Row_Number() OVER(ORDER BY (SELECT NULL)) AS RowNumber 
            --Row_Number() starts with 1
    FROM WORKER
) t
WHERE t.RowNumber % 2 = 0 --Even
--WHERE t.RowNumber % 2 = 1 --Odd

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

SELECT Salary
FROM Worker order by salary desc

-- get 3rd or Nth salary without TOP 
-- replace 2 with N-1 if we need N'th salary
SELECT *
FROM Worker Emp1
WHERE 2 = (
            SELECT COUNT( DISTINCT ( Emp2.Salary ) )
            FROM Worker Emp2
            WHERE Emp2.Salary > Emp1.Salary
          )