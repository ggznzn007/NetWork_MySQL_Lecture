--emp���̺� ��� ���� ��ȸ
SELECT * FROM dbo.emp;

--dept���̺� ��� ���� ��ȸ
SELECT * FROM dbo.dept;

--�� ����� �ٹ��μ��� �˻��϶�
SELECT eno, ename, emp.dno,
		dept.dno, dname
FROM dept, emp
WHERE dept.dno = emp.dno;

-- �λ꿡 �ٹ��ϴ� ������ ����� �˻��Ѵ�
SELECT eno, ename, dept.dno, dname, loc
FROM emp, dept
WHERE emp.dno = dept.dno
AND loc='�λ�';

--'ȸ��' �μ� ����� �˻��϶�
SELECT dept.dno, dname, eno, ename, job
FROM emp, dept
WHERE emp.dno = dept.dno
AND dname='ȸ��';

--������ '�𵨸�'�� ��������� 
--�׻���� �μ������� �˻��϶�
SELECT dept.dno, dname, eno, ename, job
FROM emp, dept
WHERE emp.dno = dept.dno
AND job='�𵨸�';


