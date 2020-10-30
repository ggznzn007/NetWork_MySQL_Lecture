--emp테이블 모든 정보 조회
SELECT * From dbo.emp;

--dept테이블 모든 정보 조회
SELECT * From dept;

--각 사원의 근무부서를 검색하라
SELECT eno, ename, emp.dno, dept.dno,dname
FROM dept, emp
WHERE dept.dno = emp.dno;
AND loc = '부산';

--회계 부서 사원을 검색하라

--업무가 모델링 인 사원과 부서정보를 검색하라