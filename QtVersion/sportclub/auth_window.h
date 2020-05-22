#ifndef AUTH_WINDOW_H
#define AUTH_WINDOW_H

#include <QWidget>

namespace Ui {
class auth_window;
}

class auth_window : public QWidget
{
    Q_OBJECT

public:
    explicit auth_window(QWidget *parent = nullptr);
    ~auth_window();
    QString getLogin();
    QString getPass();

signals:
    void login_button_clicked();

private slots:
    void on_login_lineEdit_textEdited(const QString &arg1);

    void on_password_lineEdit_textEdited(const QString &arg1);

    void on_login_pushButton_clicked();

private:
    Ui::auth_window *ui;
    QString m_username;
    QString m_userpass;
    friend class mainwindow;
};

#endif // AUTH_WINDOW_H
