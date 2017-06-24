using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Commands;

namespace POAFGVApp.ViewModels
{
    public class LoginPageViewModel : BindableBase
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public DelegateCommand DoLoginCmd { get; set; }

        INavigationService _navigationService { get; }
        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            DoLoginCmd = new DelegateCommand(DoLogin);
        }

        Action DoLogin
        {
            get
            {
                return new Action(async () =>
                {
                    if (string.IsNullOrWhiteSpace(Login) ||
                        string.IsNullOrWhiteSpace(Password))
                    {
                        throw new ArgumentException("Usuário/Senha inválido");
                    }

                    //TODO: consultar base de dados
                    if (1==1)
                    {
                        await _navigationService.NavigateAsync("");
                    }
                })
            }
        }

    }
}
