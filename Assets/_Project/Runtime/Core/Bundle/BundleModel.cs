using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class BundleModel : SingletonModel<BundleModel>
{
    public async Task<GameObject> LoadPrefab(string key, Transform parent)
    {
        var asyncOperationHandle = Addressables.InstantiateAsync(key,parent);
        await asyncOperationHandle.Task;
        return asyncOperationHandle.Result;
    }

    public async Task<Sprite> LoadAssetAsync(string key)
    {
        var asyncOperationHandle = Addressables.LoadAssetAsync<Sprite>(key);
        await asyncOperationHandle.Task;
        return asyncOperationHandle.Result;
    }
}
