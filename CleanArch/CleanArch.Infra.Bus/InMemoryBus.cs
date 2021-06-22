using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Commands;
using MediatR;

namespace CleanArch.Infra.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediatr;

        public InMemoryBus(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediatr.Send(command);
        }
    }
}
