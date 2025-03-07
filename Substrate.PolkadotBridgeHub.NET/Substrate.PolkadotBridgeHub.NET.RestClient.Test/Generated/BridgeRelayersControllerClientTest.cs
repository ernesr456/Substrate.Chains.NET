//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.PolkadotBridgeHub.NET.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.PolkadotBridgeHub.NET.RestClient.Mockup.Generated.Clients;
   using Substrate.PolkadotBridgeHub.NET.RestClient.Generated.Clients;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.registration;
   
   public class BridgeRelayersControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.RewardsAccountParams> GetTestValue2()
      {
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.RewardsAccountParams> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.RewardsAccountParams>();
         result.Create(this.GetTestValue3(), this.GetTestValue4());
         return result;
      }
      public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue3()
      {
         Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.RewardsAccountParams GetTestValue4()
      {
         Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.RewardsAccountParams result;
         result = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.RewardsAccountParams();
         result.LaneId = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_messages.LaneId();
         result.LaneId = this.GetTestValue5();
         result.BridgedChainId = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Types.Base.Arr4U8();
         result.BridgedChainId.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         result.Owner = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.EnumRewardsAccountOwner();
         result.Owner.Create(this.GetTestValueEnum<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.RewardsAccountOwner>());
         return result;
      }
      public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_messages.LaneId GetTestValue5()
      {
         Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_messages.LaneId result;
         result = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_messages.LaneId();
         result.Value = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Types.Base.Arr4U8();
         result.Value.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestRelayerRewards()
      {
         // Construct new Mockup client to test with.
         BridgeRelayersControllerMockupClient mockupClient = new BridgeRelayersControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BridgeRelayersControllerClient rpcClient = new BridgeRelayersControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U128 mockupValue = this.GetTestValueU128();
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.RewardsAccountParams> mockupKey = this.GetTestValue2();

         Assert.IsTrue(await rpcClient.SubscribeRelayerRewards(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetRelayerRewards(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U128 rpcResult = await rpcClient.GetRelayerRewards(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.registration.Registration GetTestValue7()
      {
         Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.registration.Registration result;
         result = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.registration.Registration();
         result.ValidTill = this.GetTestValueU32();
         result.Stake = this.GetTestValueU128();
         return result;
      }
      public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue8()
      {
         Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestRegisteredRelayers()
      {
         // Construct new Mockup client to test with.
         BridgeRelayersControllerMockupClient mockupClient = new BridgeRelayersControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BridgeRelayersControllerClient rpcClient = new BridgeRelayersControllerClient(_httpClient, subscriptionClient);
         Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.registration.Registration mockupValue = this.GetTestValue7();
         Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue8();

         Assert.IsTrue(await rpcClient.SubscribeRegisteredRelayers(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetRegisteredRelayers(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.registration.Registration rpcResult = await rpcClient.GetRegisteredRelayers(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
