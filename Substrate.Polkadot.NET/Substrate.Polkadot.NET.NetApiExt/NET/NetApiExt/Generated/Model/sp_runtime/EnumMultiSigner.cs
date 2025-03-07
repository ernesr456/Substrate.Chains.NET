//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_runtime
{
    
    
    /// <summary>
    /// >> MultiSigner
    /// </summary>
    public enum MultiSigner
    {
        
        /// <summary>
        /// >> Ed25519
        /// </summary>
        Ed25519 = 0,
        
        /// <summary>
        /// >> Sr25519
        /// </summary>
        Sr25519 = 1,
        
        /// <summary>
        /// >> Ecdsa
        /// </summary>
        Ecdsa = 2,
    }
    
    /// <summary>
    /// >> 381 - Variant[sp_runtime.MultiSigner]
    /// </summary>
    public sealed class EnumMultiSigner : BaseEnumRust<MultiSigner>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumMultiSigner()
        {
				AddTypeDecoder<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.ed25519.Public>(MultiSigner.Ed25519);
				AddTypeDecoder<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.sr25519.Public>(MultiSigner.Sr25519);
				AddTypeDecoder<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.ecdsa.Public>(MultiSigner.Ecdsa);
        }
    }
}
