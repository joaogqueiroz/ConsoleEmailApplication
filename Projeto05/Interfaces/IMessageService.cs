﻿using Projeto05.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto05.Interfaces
{
    public interface IMessageService
    {
        void SendEmail(Message message);
    }
}
