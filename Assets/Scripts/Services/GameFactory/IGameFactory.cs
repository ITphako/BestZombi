using UnityEngine;

  public interface IGameFactory
    {
        GameObject CreatePrefab(GameObject prefab, Vector3 position);
    }