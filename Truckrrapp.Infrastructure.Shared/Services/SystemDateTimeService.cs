using Truckrrapp.Application.Interfaces.Shared;
using System;

namespace Truckrrapp.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}