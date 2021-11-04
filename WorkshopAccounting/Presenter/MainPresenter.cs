using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WorkshopAccounting.Model;

namespace WorkshopAccounting.Presenter
{
    class MainPresenter
    {
        private DataDBContext _context;
        private readonly IMainForm _view;
        private readonly IMessageService _messageService;

        public MainPresenter(IMainForm view, IMessageService service)
        {

        }

    }
}
