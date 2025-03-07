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


namespace Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types
{
    
    
    /// <summary>
    /// >> 441 - Composite[snowbridge_beacon_primitives.types.CompactBeaconState]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CompactBeaconState : BaseType
    {
        
        /// <summary>
        /// >> slot
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64> Slot { get; set; }
        /// <summary>
        /// >> block_roots_root
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256 BlockRootsRoot { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "CompactBeaconState";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Slot.Encode());
            result.AddRange(BlockRootsRoot.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Slot = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>();
            Slot.Decode(byteArray, ref p);
            BlockRootsRoot = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256();
            BlockRootsRoot.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
