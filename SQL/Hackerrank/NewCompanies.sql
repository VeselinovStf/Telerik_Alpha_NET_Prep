/*
Amber's conglomerate corporation just acquired some new companies.
Given the table schemas , write a query to print the:
 company_code, 
 founder name, 
 total number of lead managers, 
 total number of senior managers, 
 total number of managers, 
 and total number of employees. 
 Order your output by ascending company_code.
*/

--Using Join
SELECT 
	C.company_code, 
	C.founder, 
	COUNT(DISTINCT LM.lead_manager_code),
	COUNT(DISTINCT SM.senior_manager_code),
	COUNT(DISTINCT M.manager_code),
	COUNT(DISTINCT E.employee_code)
FROM Company AS C
JOIN Lead_Manager AS LM
	ON LM.company_code = C.company_code
JOIN Senior_Manager AS SM
	ON SM.lead_manager_code = LM.lead_manager_code
JOIN Manager AS M
	ON M.senior_manager_code = SM.senior_manager_code
JOIN Employee AS E
	ON E.manager_code = M.manager_code
GROUP BY C.company_code
ORDER BY C.company_code ASC

--Using Where
SELECT c.company_code, 
	   c.founder, 
    COUNT(DISTINCT l.lead_manager_code), 
	COUNT(DISTINCT s.senior_manager_code), 
    COUNT(DISTINCT m.manager_code),
	COUNT(DISTINCT e.employee_code) 
FROM Company c, 
	Lead_Manager l, 
	Senior_Manager s, 
	Manager m, 
	Employee e 
WHERE c.company_code = l.company_code 
    AND l.lead_manager_code = s.lead_manager_code 
    AND s.senior_manager_code = m.senior_manager_code 
    AND m.manager_code = e.manager_code 
GROUP BY c.company_code 
ORDER BY c.company_code;