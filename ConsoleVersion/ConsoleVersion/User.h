#ifndef USER_H_
#define USER_H_
#include <string>
using namespace std;

class User
{
private:
	string m_second_name; //фамилия
	string m_first_name; //имя
	string m_patronymic; //отчество
	string m_login; 
	string m_password;
	int m_id; //от id зависят функциональные возможности для пользователя
};

#endif