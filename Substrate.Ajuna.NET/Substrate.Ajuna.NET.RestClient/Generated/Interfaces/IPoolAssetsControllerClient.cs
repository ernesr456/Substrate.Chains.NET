//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Ajuna.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_assets.types;
   
   public interface IPoolAssetsControllerClient
   {
      Task<AssetDetails> GetAsset(Substrate.NetApi.Model.Types.Primitive.U32 key);
      Task<bool> SubscribeAsset(Substrate.NetApi.Model.Types.Primitive.U32 key);
      Task<AssetAccount> GetAccount(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key);
      Task<bool> SubscribeAccount(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key);
      Task<Approval> GetApprovals(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key);
      Task<bool> SubscribeApprovals(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key);
      Task<AssetMetadata> GetMetadata(Substrate.NetApi.Model.Types.Primitive.U32 key);
      Task<bool> SubscribeMetadata(Substrate.NetApi.Model.Types.Primitive.U32 key);
   }
}
