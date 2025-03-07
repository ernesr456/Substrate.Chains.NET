//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Kusama.NET.RestClient
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Kusama.NET.RestClient.Generated.Interfaces;
   using Substrate.Kusama.NET.RestClient.Generated.Clients;
   
   public sealed class Client
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public IAssetRateControllerClient AssetRateControllerClient;
      public IAuctionsControllerClient AuctionsControllerClient;
      public IAuthorityDiscoveryControllerClient AuthorityDiscoveryControllerClient;
      public IAuthorshipControllerClient AuthorshipControllerClient;
      public IBabeControllerClient BabeControllerClient;
      public IBalancesControllerClient BalancesControllerClient;
      public IBeefyControllerClient BeefyControllerClient;
      public IBeefyMmrLeafControllerClient BeefyMmrLeafControllerClient;
      public IBountiesControllerClient BountiesControllerClient;
      public IChildBountiesControllerClient ChildBountiesControllerClient;
      public IClaimsControllerClient ClaimsControllerClient;
      public IConfigurationControllerClient ConfigurationControllerClient;
      public IConvictionVotingControllerClient ConvictionVotingControllerClient;
      public ICoretimeAssignmentProviderControllerClient CoretimeAssignmentProviderControllerClient;
      public ICrowdloanControllerClient CrowdloanControllerClient;
      public IDmpControllerClient DmpControllerClient;
      public IElectionProviderMultiPhaseControllerClient ElectionProviderMultiPhaseControllerClient;
      public IFastUnstakeControllerClient FastUnstakeControllerClient;
      public IFellowshipCollectiveControllerClient FellowshipCollectiveControllerClient;
      public IFellowshipReferendaControllerClient FellowshipReferendaControllerClient;
      public IGrandpaControllerClient GrandpaControllerClient;
      public IHistoricalControllerClient HistoricalControllerClient;
      public IHrmpControllerClient HrmpControllerClient;
      public IIndicesControllerClient IndicesControllerClient;
      public IInitializerControllerClient InitializerControllerClient;
      public IMessageQueueControllerClient MessageQueueControllerClient;
      public IMmrControllerClient MmrControllerClient;
      public IMultisigControllerClient MultisigControllerClient;
      public INisControllerClient NisControllerClient;
      public INisCounterpartBalancesControllerClient NisCounterpartBalancesControllerClient;
      public INominationPoolsControllerClient NominationPoolsControllerClient;
      public IOffencesControllerClient OffencesControllerClient;
      public IOnDemandAssignmentProviderControllerClient OnDemandAssignmentProviderControllerClient;
      public IParaInclusionControllerClient ParaInclusionControllerClient;
      public IParaInherentControllerClient ParaInherentControllerClient;
      public IParametersControllerClient ParametersControllerClient;
      public IParaSchedulerControllerClient ParaSchedulerControllerClient;
      public IParasControllerClient ParasControllerClient;
      public IParasDisputesControllerClient ParasDisputesControllerClient;
      public IParaSessionInfoControllerClient ParaSessionInfoControllerClient;
      public IParasSharedControllerClient ParasSharedControllerClient;
      public IParasSlashingControllerClient ParasSlashingControllerClient;
      public IPreimageControllerClient PreimageControllerClient;
      public IProxyControllerClient ProxyControllerClient;
      public IRecoveryControllerClient RecoveryControllerClient;
      public IReferendaControllerClient ReferendaControllerClient;
      public IRegistrarControllerClient RegistrarControllerClient;
      public ISchedulerControllerClient SchedulerControllerClient;
      public ISessionControllerClient SessionControllerClient;
      public ISlotsControllerClient SlotsControllerClient;
      public ISocietyControllerClient SocietyControllerClient;
      public IStakingControllerClient StakingControllerClient;
      public ISystemControllerClient SystemControllerClient;
      public ITimestampControllerClient TimestampControllerClient;
      public ITransactionPaymentControllerClient TransactionPaymentControllerClient;
      public ITreasuryControllerClient TreasuryControllerClient;
      public IVestingControllerClient VestingControllerClient;
      public IVoterListControllerClient VoterListControllerClient;
      public IWhitelistControllerClient WhitelistControllerClient;
      public IXcmPalletControllerClient XcmPalletControllerClient;
      public Client(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
         AssetRateControllerClient = new AssetRateControllerClient(_httpClient, _subscriptionClient);
         AuctionsControllerClient = new AuctionsControllerClient(_httpClient, _subscriptionClient);
         AuthorityDiscoveryControllerClient = new AuthorityDiscoveryControllerClient(_httpClient, _subscriptionClient);
         AuthorshipControllerClient = new AuthorshipControllerClient(_httpClient, _subscriptionClient);
         BabeControllerClient = new BabeControllerClient(_httpClient, _subscriptionClient);
         BalancesControllerClient = new BalancesControllerClient(_httpClient, _subscriptionClient);
         BeefyControllerClient = new BeefyControllerClient(_httpClient, _subscriptionClient);
         BeefyMmrLeafControllerClient = new BeefyMmrLeafControllerClient(_httpClient, _subscriptionClient);
         BountiesControllerClient = new BountiesControllerClient(_httpClient, _subscriptionClient);
         ChildBountiesControllerClient = new ChildBountiesControllerClient(_httpClient, _subscriptionClient);
         ClaimsControllerClient = new ClaimsControllerClient(_httpClient, _subscriptionClient);
         ConfigurationControllerClient = new ConfigurationControllerClient(_httpClient, _subscriptionClient);
         ConvictionVotingControllerClient = new ConvictionVotingControllerClient(_httpClient, _subscriptionClient);
         CoretimeAssignmentProviderControllerClient = new CoretimeAssignmentProviderControllerClient(_httpClient, _subscriptionClient);
         CrowdloanControllerClient = new CrowdloanControllerClient(_httpClient, _subscriptionClient);
         DmpControllerClient = new DmpControllerClient(_httpClient, _subscriptionClient);
         ElectionProviderMultiPhaseControllerClient = new ElectionProviderMultiPhaseControllerClient(_httpClient, _subscriptionClient);
         FastUnstakeControllerClient = new FastUnstakeControllerClient(_httpClient, _subscriptionClient);
         FellowshipCollectiveControllerClient = new FellowshipCollectiveControllerClient(_httpClient, _subscriptionClient);
         FellowshipReferendaControllerClient = new FellowshipReferendaControllerClient(_httpClient, _subscriptionClient);
         GrandpaControllerClient = new GrandpaControllerClient(_httpClient, _subscriptionClient);
         HistoricalControllerClient = new HistoricalControllerClient(_httpClient, _subscriptionClient);
         HrmpControllerClient = new HrmpControllerClient(_httpClient, _subscriptionClient);
         IndicesControllerClient = new IndicesControllerClient(_httpClient, _subscriptionClient);
         InitializerControllerClient = new InitializerControllerClient(_httpClient, _subscriptionClient);
         MessageQueueControllerClient = new MessageQueueControllerClient(_httpClient, _subscriptionClient);
         MmrControllerClient = new MmrControllerClient(_httpClient, _subscriptionClient);
         MultisigControllerClient = new MultisigControllerClient(_httpClient, _subscriptionClient);
         NisControllerClient = new NisControllerClient(_httpClient, _subscriptionClient);
         NisCounterpartBalancesControllerClient = new NisCounterpartBalancesControllerClient(_httpClient, _subscriptionClient);
         NominationPoolsControllerClient = new NominationPoolsControllerClient(_httpClient, _subscriptionClient);
         OffencesControllerClient = new OffencesControllerClient(_httpClient, _subscriptionClient);
         OnDemandAssignmentProviderControllerClient = new OnDemandAssignmentProviderControllerClient(_httpClient, _subscriptionClient);
         ParaInclusionControllerClient = new ParaInclusionControllerClient(_httpClient, _subscriptionClient);
         ParaInherentControllerClient = new ParaInherentControllerClient(_httpClient, _subscriptionClient);
         ParametersControllerClient = new ParametersControllerClient(_httpClient, _subscriptionClient);
         ParaSchedulerControllerClient = new ParaSchedulerControllerClient(_httpClient, _subscriptionClient);
         ParasControllerClient = new ParasControllerClient(_httpClient, _subscriptionClient);
         ParasDisputesControllerClient = new ParasDisputesControllerClient(_httpClient, _subscriptionClient);
         ParaSessionInfoControllerClient = new ParaSessionInfoControllerClient(_httpClient, _subscriptionClient);
         ParasSharedControllerClient = new ParasSharedControllerClient(_httpClient, _subscriptionClient);
         ParasSlashingControllerClient = new ParasSlashingControllerClient(_httpClient, _subscriptionClient);
         PreimageControllerClient = new PreimageControllerClient(_httpClient, _subscriptionClient);
         ProxyControllerClient = new ProxyControllerClient(_httpClient, _subscriptionClient);
         RecoveryControllerClient = new RecoveryControllerClient(_httpClient, _subscriptionClient);
         ReferendaControllerClient = new ReferendaControllerClient(_httpClient, _subscriptionClient);
         RegistrarControllerClient = new RegistrarControllerClient(_httpClient, _subscriptionClient);
         SchedulerControllerClient = new SchedulerControllerClient(_httpClient, _subscriptionClient);
         SessionControllerClient = new SessionControllerClient(_httpClient, _subscriptionClient);
         SlotsControllerClient = new SlotsControllerClient(_httpClient, _subscriptionClient);
         SocietyControllerClient = new SocietyControllerClient(_httpClient, _subscriptionClient);
         StakingControllerClient = new StakingControllerClient(_httpClient, _subscriptionClient);
         SystemControllerClient = new SystemControllerClient(_httpClient, _subscriptionClient);
         TimestampControllerClient = new TimestampControllerClient(_httpClient, _subscriptionClient);
         TransactionPaymentControllerClient = new TransactionPaymentControllerClient(_httpClient, _subscriptionClient);
         TreasuryControllerClient = new TreasuryControllerClient(_httpClient, _subscriptionClient);
         VestingControllerClient = new VestingControllerClient(_httpClient, _subscriptionClient);
         VoterListControllerClient = new VoterListControllerClient(_httpClient, _subscriptionClient);
         WhitelistControllerClient = new WhitelistControllerClient(_httpClient, _subscriptionClient);
         XcmPalletControllerClient = new XcmPalletControllerClient(_httpClient, _subscriptionClient);
      }
   }
}
