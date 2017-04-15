using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using Frog.Notification.ViewModels;

namespace Frog.Notification
{
    public class App: FormsApplication
    {

        private SimpleContainer Container = null;

        public App(SimpleContainer container)
        {

            this.Container = container;

            this.Container
                .Singleton<HomeViewModel>()
                .Singleton<MasterViewModel>();

            var f = ViewLocator.LocateTypeForModelType;
            ViewLocator.LocateTypeForModelType = (t, b, c) => {
                return f(t, b, c ?? Device.OS) ?? f(t, b, c);
            };

            this.DisplayRootView<HomeView>();
        }

        protected override void PrepareViewFirst(NavigationPage navigationPage)
        {
            this.Container.Instance<INavigationService>(new NavigationPageAdapter(navigationPage));
        }

    }
}
