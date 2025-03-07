//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.Base;
using System.Collections.Generic;


namespace Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_core
{
    
    
    /// <summary>
    /// >> 454 - Composite[snowbridge_core.Channel]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Channel : BaseType
    {
        
        /// <summary>
        /// >> agent_id
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256 AgentId { get; set; }
        /// <summary>
        /// >> para_id
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id ParaId { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Channel";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(AgentId.Encode());
            result.AddRange(ParaId.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            AgentId = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256();
            AgentId.Decode(byteArray, ref p);
            ParaId = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id();
            ParaId.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
