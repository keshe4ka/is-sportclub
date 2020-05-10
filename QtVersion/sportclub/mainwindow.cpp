#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "auth_window.h"
#include <QWidget>
#include <QtDebug>
#include <QtSql/QSql>

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    user_counter = 0;
    m_loginSuccesfull = false;
    connect(&ui_Auth, SIGNAL(login_button_clicked()),
            this, SLOT(authorizeUser()));
    connect(&ui_Auth,SIGNAL(destroyed()),
            this, SLOT(show()));
    connect(&ui_Auth,SIGNAL(register_button_clicked()),
            this,SLOT(registerWindowShow()));
    ui->setupUi(this);
}

MainWindow::~MainWindow()
{
    delete ui;
}

