

// Generated on 04/03/2020 21:59:04
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeStartOkCraftMessage : NetworkMessage
    {
        public const uint Id = 5813;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public ExchangeStartOkCraftMessage()
        {
        }
        
        
        public override void Serialize(IDataWriter writer)
        {
        }
        
        public override void Deserialize(IDataReader reader)
        {
        }
        
    }
    
}