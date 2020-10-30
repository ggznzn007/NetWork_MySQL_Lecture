--emp테이블 모든 정보 조회
SELECT * FROM dbo.emp;

--dept테이블 모든 정보 조회
SELECT * FROM dbo.dept;

--각 사원의 근무부서를 검색하라
SELECT eno, ename, emp.dno,
		dept.dno, dname
FROM dept, emp
WHERE dept.dno = emp.dno;

-- 부산에 근무하는 직원의 명단을 검색한다
SELECT eno, ename, dept.dno, dname, loc
FROM emp, dept
WHERE emp.dno = dept.dno
AND loc='부산';

--'회계' 부서 사원을 검색하라
SELECT dept.dno, dname, eno, ename, job
FROM emp, dept
WHERE emp.dno = dept.dno
AND dname='회계';

--업무가 '모델링'인 사원정보와 
--그사원의 부서정보를 검색하라
SELECT dept.dno, dname, eno, ename, job
FROM emp, dept
WHERE emp.dno = dept.dno
AND job='모델링';


