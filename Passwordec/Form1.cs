using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Passwordec
{
    public partial class Form1 : Form
    {
        private Status Status = Status.Login;
        private readonly List<User> Users;
        private User _currentUser;
        private readonly string path = Path.Combine(Environment.CurrentDirectory, "data.txt");
        private List<string> Logins = new List<string>();
        public User CurrentUser
        {
            get => _currentUser;
            set
            {
                _currentUser = value;
                Text = _currentUser?.Login;
            }
        }

        public Form1()
        {
            InitializeComponent();
            if (File.Exists(path))
            {
                Users = JsonConvert.DeserializeObject<List<User>>(
                    File.ReadAllText(path, Encoding.UTF8));
            }
            else
            {
                Users = new List<User>();
                Save();
            }
        }
        private void action_Click(object sender, EventArgs e)
        {
            if (Status == Status.Login)
            {
                if (string.IsNullOrWhiteSpace(login.Text))
                {
                    MessageBox.Show("Неверный формат логина");
                    return;
                }
                if (string.IsNullOrWhiteSpace(password.Text))
                {
                    MessageBox.Show("Неверный формат пароля");
                    return;
                }
                //Вход
                var user = Users.FirstOrDefault(q => q.Login == login.Text && q.Password == password.Text);
                if (user != null)
                {
                    CurrentUser = user;
                    Status = Status.LogOff;
                    login.Enabled = false;
                    action.Text = "Выйти";
                    subAction.Text = "Сгенерировать пароль";
                    password.ReadOnly = true;
                }
                else
                {
                    Logins.Add(login.Text);
                    if (Logins.Count(q=> q == login.Text) >= 10)
                    {
                        Status = Status.Blocked;
                        foreach (var c in Controls)
                        {
                            ((Control) c).Enabled = false;
                        }
                        MessageBox.Show("Превышен интервал количества неудачных попыток входа");
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден");
                    }
                }
            }
            else if (Status == Status.LogOff)
            {
                //Выход
                action.Text = "Войти";
                subAction.Text = "Регистрация";
                CurrentUser = null;
                Status = Status.Login;
                login.Enabled = true;
                password.ReadOnly = false;
            }
        }
        private void subAction_Click(object sender, EventArgs e)
        {
            if (Status == Status.Login)
            {
                if (string.IsNullOrWhiteSpace(login.Text))
                {
                    MessageBox.Show("Неверный формат логина");
                    return;
                }
                else
                {
                    //Регистрация
                    var user = Users.FirstOrDefault(q => q.Login == login.Text);
                    if (user != null)
                    {
                        MessageBox.Show("Пользователь с таким логином уже есть");
                        return;
                    }

                    var r = new Random();
                    char[] low = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (char)i).ToArray();
                    char[] upper = low.Select(char.ToUpper).ToArray();
                    int[] numbers = Enumerable.Range(1, 9).ToArray();
                    const int M = 12;
                    int N = login.Text.Length;
                    var first = (int)(Math.Pow(N, 3) % 5) + 1;
                    var second = (int)(Math.Pow(N, 2) % 6) + 1 + first;
                    var sb = new StringBuilder();
                    for (int i = 1; i <= first; i++)
                    {
                        sb = sb.Append(low[r.Next(0, low.Length)]);
                    }

                    for (int i = first + 1; i <= second; i++)
                    {
                        sb = sb.Append(upper[r.Next(0, upper.Length)]);
                    }

                    for (int i = second + 1; i < M; i++)
                    {
                        sb = sb.Append(numbers[r.Next(0, numbers.Length)]);
                    }
                    /*
                     * Nmax <= Nmin + 2/3 * M.
                       Где:
                       1)	Nmin – минимальная длина идентификатора (логина);
                       2)	Nmax – максимальная длина идентификатора (логина);
                       3)	M – длина пароля.                       
                     */
                    if (login.Text.Length > 1 + 2/3 * M)
                    {
                        MessageBox.Show("Превышена максимальная длина идентификатора");
                        return;
                    }
                    user = new User
                    {
                        Login = login.Text,
                        Password = string.Concat(sb.ToString().Take(M))
                    };
                    Users.Add(user);
                    Save();
                    action.Text = "Выйти";
                    subAction.Text = "Сгенерировать пароль";
                    CurrentUser = user;
                    Status = Status.LogOff;
                    login.Enabled = false;
                    password.Text = user.Password;
                    password.ReadOnly = true;
                }
            }
            else if (Status == Status.LogOff)
            {
                //Генерация нового пароля
                var r = new Random();
                char[] low = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (char)i).ToArray();
                char[] upper = low.Select(char.ToUpper).ToArray();
                int[] numbers = Enumerable.Range(1, 9).ToArray();
                const int M = 12;
                int N = login.Text.Length;
                var first = (int)(Math.Pow(N, 3) % 5) + 1;
                var second = (int)(Math.Pow(N, 2) % 6) + 1 + first;
                var sb = new StringBuilder();
                for (int i = 1; i <= first; i++)
                {
                    sb = sb.Append(low[r.Next(0, low.Length)]);
                }

                for (int i = first + 1; i <= second; i++)
                {
                    sb = sb.Append(upper[r.Next(0, upper.Length)]);
                }

                for (int i = second + 1; i < M; i++)
                {
                    sb = sb.Append(numbers[r.Next(0, numbers.Length)]);
                }

                CurrentUser.Password = string.Concat(sb.ToString().Take(M));
                password.Text = CurrentUser.Password;
                Save();
            }
        }
        void Save()
        {
            File.WriteAllText(path,
                JsonConvert.SerializeObject(Users));

        }
    }

    public enum Status
    {
        Login,
        LogOff,
        Blocked
    }
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
