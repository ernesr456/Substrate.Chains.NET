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


namespace Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config
{
    
    
    /// <summary>
    /// >> 168 - Composite[pallet_ajuna_awesome_avatars.types.config.MintConfig]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MintConfig : BaseType
    {
        
        /// <summary>
        /// >> open
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool Open { get; set; }
        /// <summary>
        /// >> cooldown
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Cooldown { get; set; }
        /// <summary>
        /// >> free_mint_fee_multiplier
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U16 FreeMintFeeMultiplier { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "MintConfig";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Open.Encode());
            result.AddRange(Cooldown.Encode());
            result.AddRange(FreeMintFeeMultiplier.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Open = new Substrate.NetApi.Model.Types.Primitive.Bool();
            Open.Decode(byteArray, ref p);
            Cooldown = new Substrate.NetApi.Model.Types.Primitive.U32();
            Cooldown.Decode(byteArray, ref p);
            FreeMintFeeMultiplier = new Substrate.NetApi.Model.Types.Primitive.U16();
            FreeMintFeeMultiplier.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
