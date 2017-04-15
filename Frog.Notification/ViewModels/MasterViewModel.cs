using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using System.Windows.Input;
using Xamarin.Forms;

namespace Frog.Notification.ViewModels
{
    public class MasterViewModel : Screen
    {
        //public Dictionary<string, Color> Colors {
        //    get; set;
        //}

        public BindableCollection<NamedColor> Colors { get; set; }

        public string Title { get; set; }

        public ICommand TestCmd { get; set; }

        public MasterViewModel()
        {
            this.TestCmd = new Command(() =>
            {

            });

            // if set dictionary as data source, the Label bind to Key, 
            // in emulator it will show the key, but if in device, the key not show !

            //this.Colors = new Dictionary<string, Color>() {
            //    {"Aqua", Color.Aqua},
            //    {"Black", Color.Black},
            //    {"Blue", Color.Blue},
            //    {"Fuchsia", Color.Fuchsia},
            //    {"Gray", Color.Gray},
            //    {"Green", Color.Green},
            //    {"Lime", Color.Lime},
            //    {"Maroon", Color.Maroon},
            //    {"Navy", Color.Navy},
            //    {"Olive", Color.Olive},
            //    {"Purple", Color.Purple},
            //    {"Red", Color.Red},
            //    {"Silver", Color.Silver},
            //    {"Teal", Color.Teal},
            //    {"White", Color.White},
            //    {"Yellow", Color.Yellow}
            //};

            this.Colors = new BindableCollection<NamedColor>() {
                new NamedColor("Aqua", Color.Aqua),
                new NamedColor("Black", Color.Black),
                new NamedColor("Blue", Color.Blue),
                new NamedColor("Fuchsia", Color.Fuchsia),
                new NamedColor("Gray", Color.Gray),
                new NamedColor("Green", Color.Green),
                new NamedColor("Lime", Color.Lime),
                new NamedColor("Maroon", Color.Maroon),
                new NamedColor("Navy", Color.Navy),
                new NamedColor("Olive", Color.Olive),
                new NamedColor("Purple", Color.Purple),
                new NamedColor("Red", Color.Red),
                new NamedColor("Silver", Color.Silver),
                new NamedColor("Teal", Color.Teal),
                new NamedColor("White", Color.White),
                new NamedColor("Yellow", Color.Yellow)
            };

            this.Title = "AAA";
            this.NotifyOfPropertyChange(() => this.Colors);
            this.NotifyOfPropertyChange(() => this.Title);
            this.NotifyOfPropertyChange(() => this.TestCmd);
        }
        public class NamedColor
        {
            public string Name { get; set; }
            public Color Color { get; set; }

            public NamedColor(string name, Color color)
            {
                this.Name = name;
                this.Color = color;
            }
        }
    }
}
