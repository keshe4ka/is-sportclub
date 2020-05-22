/********************************************************************************
** Form generated from reading UI file 'auth_window.ui'
**
** Created by: Qt User Interface Compiler version 5.12.6
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_AUTH_WINDOW_H
#define UI_AUTH_WINDOW_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QLabel>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_auth_window
{
public:
    QLabel *label_logo;
    QLineEdit *login_lineEdit;
    QLabel *label_request;
    QLineEdit *password_lineEdit;
    QLabel *label_login;
    QLabel *label_password4;
    QPushButton *login_pushButton;

    void setupUi(QWidget *auth_window)
    {
        if (auth_window->objectName().isEmpty())
            auth_window->setObjectName(QString::fromUtf8("auth_window"));
        auth_window->resize(572, 462);
        label_logo = new QLabel(auth_window);
        label_logo->setObjectName(QString::fromUtf8("label_logo"));
        label_logo->setGeometry(QRect(-30, -40, 581, 361));
        label_logo->setPixmap(QPixmap(QString::fromUtf8("../../logo.png")));
        login_lineEdit = new QLineEdit(auth_window);
        login_lineEdit->setObjectName(QString::fromUtf8("login_lineEdit"));
        login_lineEdit->setGeometry(QRect(200, 340, 191, 24));
        label_request = new QLabel(auth_window);
        label_request->setObjectName(QString::fromUtf8("label_request"));
        label_request->setGeometry(QRect(200, 310, 191, 16));
        password_lineEdit = new QLineEdit(auth_window);
        password_lineEdit->setObjectName(QString::fromUtf8("password_lineEdit"));
        password_lineEdit->setGeometry(QRect(200, 370, 191, 24));
        label_login = new QLabel(auth_window);
        label_login->setObjectName(QString::fromUtf8("label_login"));
        label_login->setGeometry(QRect(150, 340, 41, 20));
        label_password4 = new QLabel(auth_window);
        label_password4->setObjectName(QString::fromUtf8("label_password4"));
        label_password4->setGeometry(QRect(150, 370, 51, 16));
        login_pushButton = new QPushButton(auth_window);
        login_pushButton->setObjectName(QString::fromUtf8("login_pushButton"));
        login_pushButton->setGeometry(QRect(200, 400, 191, 25));
        QWidget::setTabOrder(login_lineEdit, password_lineEdit);
        QWidget::setTabOrder(password_lineEdit, login_pushButton);

        retranslateUi(auth_window);

        QMetaObject::connectSlotsByName(auth_window);
    } // setupUi

    void retranslateUi(QWidget *auth_window)
    {
        auth_window->setWindowTitle(QApplication::translate("auth_window", "Form", nullptr));
        label_logo->setText(QString());
        label_request->setText(QApplication::translate("auth_window", "\320\237\320\276\320\266\320\260\320\273\321\203\320\271\321\201\321\202\320\260, \320\260\320\262\321\202\320\276\321\200\320\270\320\267\320\270\321\200\321\203\320\271\321\202\320\265\321\201\321\214", nullptr));
        label_login->setText(QApplication::translate("auth_window", "\320\233\320\276\320\263\320\270\320\275 ", nullptr));
        label_password4->setText(QApplication::translate("auth_window", "\320\237\320\260\321\200\320\276\320\273\321\214 ", nullptr));
        login_pushButton->setText(QApplication::translate("auth_window", "\320\222\320\276\320\271\321\202\320\270 \320\262 \321\201\320\270\321\201\321\202\320\265\320\274\321\203", nullptr));
    } // retranslateUi

};

namespace Ui {
    class auth_window: public Ui_auth_window {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_AUTH_WINDOW_H
