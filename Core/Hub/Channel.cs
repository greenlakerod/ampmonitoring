using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.Amp.Core.Hub
{
    public class Channel
    {
        public const string MonitoringChannelName = "monitoring";
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public interface IChannelStoreExt
    {
        Task<IEnumerable<Channel>> ListChannelsAsync();
        Task<Channel> GetChannelAsync(string name);
        Task<string> CreateChannelAsync(Channel channel);
        Task DeleteChannelAsync(string name);
        Task PushToChannelAsync(string name, string content);
        Channel GetChannel(string name);
        string CreateChannel(Channel channel);
    }
}
