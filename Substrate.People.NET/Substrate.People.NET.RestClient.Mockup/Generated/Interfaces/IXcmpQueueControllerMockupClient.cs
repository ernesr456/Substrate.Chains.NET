//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.People.NET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.People.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.People.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.People.NET.NetApiExt.Generated.Model.sp_arithmetic.fixed_point;
   
   public interface IXcmpQueueControllerMockupClient
   {
      Task<bool> SetInboundXcmpSuspended(BoundedBTreeSet value);
      Task<bool> SetOutboundXcmpStatus(BaseVec<OutboundChannelDetails> value);
      Task<bool> SetOutboundXcmpMessages(BaseVec<U8> value, BaseTuple<Substrate.People.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, U16> key);
      Task<bool> SetSignalMessages(BaseVec<U8> value, Substrate.People.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id key);
      Task<bool> SetQueueConfig(QueueConfigData value);
      Task<bool> SetQueueSuspended(Bool value);
      Task<bool> SetDeliveryFeeFactor(FixedU128 value, Substrate.People.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id key);
   }
}
