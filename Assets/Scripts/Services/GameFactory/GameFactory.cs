using UnityEngine;

public class GameFactory : MonoBehaviour, IGameFactory
{
    public GameObject CreatePrefab(GameObject prefab, Vector3 spawnPosition)
        {
             GameObject objectInstance = Instantiate(prefab, spawnPosition, Quaternion.identity);
            return objectInstance;
        }

}
