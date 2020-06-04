#include <iostream>
#include <string>
#include "User.h"
using namespace std;



//функция входа
void sign_in() {
	cout << "login: " << endl;
	string login;
	cin >> login;
	cout << "password: " << endl;
	string password;
	cin >> password;

	if 
}

//функция регистрации
void sign_up() {
	cout << "login: " << endl;
	string login;
	cin >> login;
	cout << "password: " << endl;
	string password;
	cin >> password;
}

//функция стартового окна, которая предлагает пользователю войти или зарегистрироваться
void start_window() {
	cout << "Write 'S' if you want sign in \n or write 'U' for sign up" << endl;
	char input_value;
	cin >> input_value;
	if ((input_value == 'S') || (input_value == 's') ) {
		sign_in();
	}
	else if (input_value == 'U' || (input_value == 'u')) {
		sign_up();
	}
	//защита от дебила
	else {
		cout << "Uncorrect symbol" << endl;
		start_window();
	}
}

//test for github3
int main()
{
	start_window();
	return 0;
}
