using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globomantics.Services
{
    public class ConferenceApiService : IConferenceService
    {
        public Task Add(ConferenceModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ConferenceModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ConferenceModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<StatisticsModel> GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
