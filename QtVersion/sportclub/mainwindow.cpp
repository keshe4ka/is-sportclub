#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "auth_window.h"
#include <QWidget>
#include <QtDebug>
#include <QSqlQuery>
#include <QSqlError>
#include <QSqlDatabase>
#include <QSqlRecord>
#include <QtSql/QSql>
#include "QMessageBox"
#include "QtSql/QSqlDatabase"

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent),
    ui(new Ui::MainWindow)

{
    QSqlDatabase mw_db;

    mw_db.setDatabaseName("C:\\...\\data.db");                                           //указываем путь до бд
    mw_db.open();

    user_counter = 0;
    m_loginSuccesfull = false;
    connect(&ui_Auth, SIGNAL(login_button_clicked()),
            this, SLOT(authorizeUser()));
    connect(&ui_Auth,SIGNAL(destroyed()),
            this, SLOT(show()));
    if(!connectDB())
    {
        qDebug() << "Failed to connect DB";
    }


QSqlQuery query;



    ui->setupUi(this);

}
void MainWindow::authorizeUser()
{
    QString id    = 0;
    QString login    = "";
    QString password    = "";
    QSqlDatabase mw_db;

    QSqlQuery query;

    QSqlRecord rec;
    query.exec("SELECT id, Login, Password FROM user");                                                              //делаем запрос

    m_username          = ui_Auth.getLogin();
    m_userpass          = ui_Auth.getPass();




    while (query.next() && m_loginSuccesfull == false ){
    rec = query.record();
    id    = query.value(0).toInt();                                                                            //достаем из
    login    = query.value(1).toString();                                                                            //бд
    password    = query.value(2).toString();                                                                            //разные штуки

    if(m_username != login || m_userpass != password)
    {

        m_loginSuccesfull = false;

    }
    else
    {
        m_loginSuccesfull = true;
        ui_Auth.close();
        this->show();
    }

}
    if(m_loginSuccesfull == true){
        QMessageBox::information(0, QObject::tr("Поздравляем"),
                                     QObject::tr("Вы вошли!"));
    }
    else{
        QMessageBox::warning(0, QObject::tr("Увы"),
                                     QObject::tr("Попробуйте ввести логин и пароль заново!"));
    }
}
 /*
    QString str_t       = " SELECT * "
                          " FROM userlist "
                          " WHERE name = '%1'";
    //int db_number       = 0;







    db_input    = str_t.arg(m_username);

    QSqlQuery query;

    QSqlRecord rec;

    if(!query.exec(db_input))
    {
        qDebug() << "Unable to execute query - exiting" << query.lastError() << " : " << query.lastQuery();
    }
    rec = query.record();
    query.next();
    user_counter   = query.value(rec.indexOf("number")).toInt();
    username    = query.value(rec.indexOf("name")).toString();
    userpass    = query.value(rec.indexOf("pass")).toString();
    if(m_username != username || m_userpass != userpass)
    {
        qDebug() << "Password missmatch" << username << " " << userpass;
        m_loginSuccesfull = false;
    }

    }*/

void MainWindow::display()                                                              //реализация пользотвальского метода отображения главного окна
{
    ui_Auth.show();                                                             //отобразить окно авторизации(НЕ главное окно)


}


MainWindow::~MainWindow()                                                               //реализация деструктора
{
    if(m_loginSuccesfull)
    {
        QString str_t       =   "UPDATE userlist "
                                "SET xpos = %2, ypos = %3, width = %4, length = %5 "
                                "WHERE name = '%1';";
        db_input            = str_t .arg(m_username)
                                    .arg(this->x())
                                    .arg(this->y())
                                    .arg(this->width())
                                    .arg(this->height());
        QSqlQuery query;
        if(!query.exec(db_input))
        {
            qDebug() << "Unable to insert data"  << query.lastError() << " : " << query.lastQuery() ;
        }
    }
    mw_db.removeDatabase("authorisation");
    qDebug() << "MainWindow Destroyed";
    delete ui;                                                                     //удалить указатель на экземпляр главного окна
    exit(0);                                                                            //завершить приложение
}

bool MainWindow::connectDB()
{
    QSqlDatabase mw_db;
    mw_db = QSqlDatabase::addDatabase("QSQLITE");
    mw_db.setDatabaseName("C:\\...\\data.db");                               //здесь снова указываем бд, чтобы пройти проверку подключения
    mw_db.open();
    if(!mw_db.open())
    {
        qDebug() << "Cannot open database: " << mw_db.lastError();
        return false;
    }
    /*mw_db.setUserName("elton");                                                      //так подключаются к пентагону
    mw_db.setHostName("epica");
    mw_db.setPassword("password");*/
    return true;
}

