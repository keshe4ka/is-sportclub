#include <iostream>
#include <string>
#include "administrator.h"
using namespace std;

//функция стартового окна, которая предлагает пользователю войти или зарегистрироваться
void start_window() {
	cout << "Write 'S' if you want sign in \n or write 'U' for sign up" << endl;
	char input_value;
	cin >> input_value;
	if (input_value == 'S') {
		sign_in();
	}
	else if (input_value == 'U') {
		sign_up();
	}
	//
	else {
		cout << "Uncorrect symbol" << endl;
		start_window();
	}
}

//функция входа
void sign_in() {
	cout << "login: " << endl;
	string login;
	cin >> login;
	cout << "password: " << endl;
	string password;
	cin >> password;
}

//функция регистрации
void sign_in() {
	cout << "login: " << endl;
	string login;
	cin >> login;
	cout << "password: " << endl;
	string password;
	cin >> password;
}

int main()
{
    std::cout << "Hello World!\n";
}
