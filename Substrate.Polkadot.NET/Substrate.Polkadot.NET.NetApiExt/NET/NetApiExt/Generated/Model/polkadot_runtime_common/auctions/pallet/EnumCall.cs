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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_common.auctions.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> new_auction
        /// See [`Pallet::new_auction`].
        /// </summary>
        new_auction = 0,
        
        /// <summary>
        /// >> bid
        /// See [`Pallet::bid`].
        /// </summary>
        bid = 1,
        
        /// <summary>
        /// >> cancel_auction
        /// See [`Pallet::cancel_auction`].
        /// </summary>
        cancel_auction = 2,
    }
    
    /// <summary>
    /// >> 377 - Variant[polkadot_runtime_common.auctions.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>>(Call.new_auction);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>>(Call.bid);
				AddTypeDecoder<BaseVoid>(Call.cancel_auction);
        }
    }
}
