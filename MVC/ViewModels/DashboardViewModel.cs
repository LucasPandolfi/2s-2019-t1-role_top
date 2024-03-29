using System.Collections.Generic;
using MVC.Models;

namespace MVC.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public List<Agendamento> Agendamentos {get;set;}
        public uint AgendamentosAprovados {get;set;}
        public uint AgendamentosReprovados {get;set;}
        public uint AgendamentosPendentes {get;set;}

        public DashboardViewModel()
        {
            this.Agendamentos = new List<Agendamento>();
        }
    }
}