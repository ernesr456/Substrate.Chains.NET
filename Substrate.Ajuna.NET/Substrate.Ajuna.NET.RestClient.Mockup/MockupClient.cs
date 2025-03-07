//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Ajuna.NET.RestClient.Mockup
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Ajuna.NET.RestClient.Mockup.Generated.Interfaces;
   using Substrate.Ajuna.NET.RestClient.Mockup.Generated.Clients;
   
   public sealed class MockupClient
   {
      private HttpClient _httpClient;
      public IAffiliatesAAAControllerMockupClient AffiliatesAAAControllerClient;
      public IAssetConversionControllerMockupClient AssetConversionControllerClient;
      public IAssetRegistryControllerMockupClient AssetRegistryControllerClient;
      public IAssetsControllerMockupClient AssetsControllerClient;
      public IAuraControllerMockupClient AuraControllerClient;
      public IAuraExtControllerMockupClient AuraExtControllerClient;
      public IAuthorshipControllerMockupClient AuthorshipControllerClient;
      public IAwesomeAvatarsControllerMockupClient AwesomeAvatarsControllerClient;
      public IBalancesControllerMockupClient BalancesControllerClient;
      public ICollatorSelectionControllerMockupClient CollatorSelectionControllerClient;
      public ICouncilControllerMockupClient CouncilControllerClient;
      public ICouncilMembershipControllerMockupClient CouncilMembershipControllerClient;
      public IDemocracyControllerMockupClient DemocracyControllerClient;
      public IIdentityControllerMockupClient IdentityControllerClient;
      public IMessageQueueControllerMockupClient MessageQueueControllerClient;
      public IMultisigControllerMockupClient MultisigControllerClient;
      public INftControllerMockupClient NftControllerClient;
      public INftTransferControllerMockupClient NftTransferControllerClient;
      public IParachainInfoControllerMockupClient ParachainInfoControllerClient;
      public IParachainSystemControllerMockupClient ParachainSystemControllerClient;
      public IPolkadotXcmControllerMockupClient PolkadotXcmControllerClient;
      public IPoolAssetsControllerMockupClient PoolAssetsControllerClient;
      public IPreimageControllerMockupClient PreimageControllerClient;
      public IProxyControllerMockupClient ProxyControllerClient;
      public IRandomnessControllerMockupClient RandomnessControllerClient;
      public ISchedulerControllerMockupClient SchedulerControllerClient;
      public ISessionControllerMockupClient SessionControllerClient;
      public ISystemControllerMockupClient SystemControllerClient;
      public ITechnicalCommitteeControllerMockupClient TechnicalCommitteeControllerClient;
      public ITechnicalCommitteeMembershipControllerMockupClient TechnicalCommitteeMembershipControllerClient;
      public ITimestampControllerMockupClient TimestampControllerClient;
      public ITournamentAAAControllerMockupClient TournamentAAAControllerClient;
      public ITransactionPaymentControllerMockupClient TransactionPaymentControllerClient;
      public ITreasuryControllerMockupClient TreasuryControllerClient;
      public IVestingControllerMockupClient VestingControllerClient;
      public IXcmpQueueControllerMockupClient XcmpQueueControllerClient;
      public MockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
         AffiliatesAAAControllerClient = new AffiliatesAAAControllerMockupClient(_httpClient);
         AssetConversionControllerClient = new AssetConversionControllerMockupClient(_httpClient);
         AssetRegistryControllerClient = new AssetRegistryControllerMockupClient(_httpClient);
         AssetsControllerClient = new AssetsControllerMockupClient(_httpClient);
         AuraControllerClient = new AuraControllerMockupClient(_httpClient);
         AuraExtControllerClient = new AuraExtControllerMockupClient(_httpClient);
         AuthorshipControllerClient = new AuthorshipControllerMockupClient(_httpClient);
         AwesomeAvatarsControllerClient = new AwesomeAvatarsControllerMockupClient(_httpClient);
         BalancesControllerClient = new BalancesControllerMockupClient(_httpClient);
         CollatorSelectionControllerClient = new CollatorSelectionControllerMockupClient(_httpClient);
         CouncilControllerClient = new CouncilControllerMockupClient(_httpClient);
         CouncilMembershipControllerClient = new CouncilMembershipControllerMockupClient(_httpClient);
         DemocracyControllerClient = new DemocracyControllerMockupClient(_httpClient);
         IdentityControllerClient = new IdentityControllerMockupClient(_httpClient);
         MessageQueueControllerClient = new MessageQueueControllerMockupClient(_httpClient);
         MultisigControllerClient = new MultisigControllerMockupClient(_httpClient);
         NftControllerClient = new NftControllerMockupClient(_httpClient);
         NftTransferControllerClient = new NftTransferControllerMockupClient(_httpClient);
         ParachainInfoControllerClient = new ParachainInfoControllerMockupClient(_httpClient);
         ParachainSystemControllerClient = new ParachainSystemControllerMockupClient(_httpClient);
         PolkadotXcmControllerClient = new PolkadotXcmControllerMockupClient(_httpClient);
         PoolAssetsControllerClient = new PoolAssetsControllerMockupClient(_httpClient);
         PreimageControllerClient = new PreimageControllerMockupClient(_httpClient);
         ProxyControllerClient = new ProxyControllerMockupClient(_httpClient);
         RandomnessControllerClient = new RandomnessControllerMockupClient(_httpClient);
         SchedulerControllerClient = new SchedulerControllerMockupClient(_httpClient);
         SessionControllerClient = new SessionControllerMockupClient(_httpClient);
         SystemControllerClient = new SystemControllerMockupClient(_httpClient);
         TechnicalCommitteeControllerClient = new TechnicalCommitteeControllerMockupClient(_httpClient);
         TechnicalCommitteeMembershipControllerClient = new TechnicalCommitteeMembershipControllerMockupClient(_httpClient);
         TimestampControllerClient = new TimestampControllerMockupClient(_httpClient);
         TournamentAAAControllerClient = new TournamentAAAControllerMockupClient(_httpClient);
         TransactionPaymentControllerClient = new TransactionPaymentControllerMockupClient(_httpClient);
         TreasuryControllerClient = new TreasuryControllerMockupClient(_httpClient);
         VestingControllerClient = new VestingControllerMockupClient(_httpClient);
         XcmpQueueControllerClient = new XcmpQueueControllerMockupClient(_httpClient);
      }
   }
}
