
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DurakLibrary;

namespace DurakClient
{
    class DurakClientMain
    {
    
        /// Этот код на языке C# представляет собой метод Main() для консольного приложения
        /// Он использует STAThread атрибут, который указывает, что поток приложения должен использовать однопоточную модель COM для обработки вызовов.
        /// Это может быть полезным, если приложение использует элементы управления Windows Forms, WPF или другие библиотеки, которые используют COM.
        //Далее метод вызывает несколько методов класса Application из библиотеки Windows Forms для настройки и
        //    запуска графического интерфейса пользователя(GUI). Application.EnableVisualStyles() включает
        //    стиль Windows для элементов управления в приложении, Application.SetCompatibleTextRenderingDefault(false)
        //    устанавливает рендеринг текста для приложения, и Application.Run(new DurakClientForm()) запускает новый
        //    экземпляр DurakClientForm, который представляет главное окно приложения.После этого приложение ожидает,
        //        пока пользователь не закроет окно приложения.
      
                [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DurakClientForm());
        }
    }
}
