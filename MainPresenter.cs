using System;
using TextEditor.BL;

namespace TextEditor
{
    class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly IFileManager _manager;
        private readonly IMessageService _messageService;

        public MainPresenter (IMainForm view, IFileManager manager, IMessageService service)
        {
            _view = view;
            _manager = manager;
            _messageService = service;
        }
    }
}
