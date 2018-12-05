using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tours.Dto;

namespace Tours.BusinessLayer
{
    public class ClientProcess : IClientProcess
    {
        private static readonly IDictionary<int, ClientDto> Clients = new Dictionary<int, ClientDto>();
        public IList<ClientDto> GetList()
        {
            return new List<ClientDto>(Clients.Values);
        }
        public ClientDto Get(int id)
        {
            if (Clients.ContainsKey(id))
                return Clients[id];
            else return null;
        }
        public void Add(ClientDto client)
        {
            int max = Clients.Keys.Count == 0 ? 1 : Clients.Keys.Max(p => p) + 1;
            client.Id = max;
            Clients.Add(max, client);
        }
        public void Update(ClientDto client)
        {
            if (Clients.ContainsKey(client.Id))
                Clients[client.Id] = client;
        }
        public void Delete(int id)
        {
            if (Clients.ContainsKey(id))
                Clients.Remove(id);
        }
    }
}
