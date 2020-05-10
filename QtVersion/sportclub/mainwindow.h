#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QString>
#include <QtSql/QSql>
#include <QSqlDatabase>
#include "auth_window.h"

QT_BEGIN_NAMESPACE
namespace Ui { class MainWindow; }
QT_END_NAMESPACE

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    MainWindow(QWidget *parent = nullptr);
    ~MainWindow();

    void display(); //прототип пользовательской функции отображения
    bool connectDB(); //прототип метода подключения к БД

private:
    Ui::MainWindow *ui;

    auth_window ui_Auth; //экземпляры окна авторизации и окна регистрации

    QString m_username; //строки для обработки
    QString m_userpass; //пользовательского ввода

    QString db_input; //строка для отправки запроса к БД

    QSqlDatabase mw_db; //экземпляр подключения к БД

    int user_counter; //счетчик пользователей
    bool m_loginSuccesfull; // флаг успешной авторизации

private slots:
    void authorizeUser(); //пользовательские слоты
};
#endif // MAINWINDOW_H
