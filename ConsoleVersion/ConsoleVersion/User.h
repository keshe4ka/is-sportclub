#ifndef USER_H_
#define USER_H_
#include <string>
using namespace std;

class User
{
private:
	string m_second_name; //�������
	string m_first_name; //���
	string m_patronymic; //��������
	string m_login; 
	string m_password;
	int m_id; //�� id ������� �������������� ����������� ��� ������������
};

#endif