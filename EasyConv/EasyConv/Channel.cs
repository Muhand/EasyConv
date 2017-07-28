using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyConv
{
    class Channel
    {
        public string ChannelName { get; set; }
        public string ChannelURL { get; set; }
        public Channel()
        {
            ChannelName = "";
            ChannelURL = "";
        }
        public Channel(string channelName, string channelURL)
        {
            ChannelName = channelName;
            ChannelURL = channelName;
        }

        public override string ToString()
        {
            return(String.Format("Channel Name: {0}\nChannel URL: {1}",ChannelName,ChannelURL));
        }
    }
}
