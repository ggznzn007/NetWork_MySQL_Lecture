--emp���̺� ��� ���� ��ȸ
SELECT * From dbo.emp;

--dept���̺� ��� ���� ��ȸ
SELECT * From dept;

--�� ����� �ٹ��μ��� �˻��϶�
SELECT eno, ename, emp.dno, dept.dno,dname
FROM dept, emp
WHERE dept.dno = emp.dno;
AND loc = '�λ�';

--ȸ�� �μ� ����� �˻��϶�

--������ �𵨸� �� ����� �μ������� �˻��϶�