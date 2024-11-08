using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_Implementacion_JEVB_2.VistaModelo
{
    public class VMpagina1 : BaseViewModel
    {
        #region VARIABLES
        string _Mensaje;
        #endregion
        #region CONTRUCTOR
        public VMpagina1(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS

        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        #endregion
        #region PROCESOS

        public async Task Alerta()
        {
            await DisplayAlert("Titulo",Mensaje,"ok");
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Alertacommand => new Command(async () => await Alerta());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
