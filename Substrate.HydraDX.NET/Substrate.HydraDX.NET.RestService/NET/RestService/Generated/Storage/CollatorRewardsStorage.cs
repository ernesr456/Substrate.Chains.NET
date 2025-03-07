//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.HydraDX.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// ICollatorRewardsStorage interface definition.
    /// </summary>
    public interface ICollatorRewardsStorage : IStorage
    {
        
        /// <summary>
        /// >> Collators
        ///  Stores the collators per session (index).
        /// </summary>
        Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT33 GetCollators(string key);
    }
    
    /// <summary>
    /// CollatorRewardsStorage class definition.
    /// </summary>
    public sealed class CollatorRewardsStorage : ICollatorRewardsStorage
    {
        
        /// <summary>
        /// _collatorsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT33> _collatorsTypedStorage;
        
        /// <summary>
        /// CollatorRewardsStorage constructor.
        /// </summary>
        public CollatorRewardsStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.CollatorsTypedStorage = new TypedMapStorage<Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT33>("CollatorRewards.Collators", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _collatorsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT33> CollatorsTypedStorage
        {
            get
            {
                return _collatorsTypedStorage;
            }
            set
            {
                _collatorsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await CollatorsTypedStorage.InitializeAsync("CollatorRewards", "Collators");
        }
        
        /// <summary>
        /// Implements any storage change for CollatorRewards.Collators
        /// </summary>
        [StorageChange("CollatorRewards", "Collators")]
        public void OnUpdateCollators(string key, string data)
        {
            CollatorsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Collators
        ///  Stores the collators per session (index).
        /// </summary>
        public Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT33 GetCollators(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (CollatorsTypedStorage.Dictionary.TryGetValue(key, out Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT33 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
