using UnityEngine;

public class ChainSpawner : MonoBehaviour
{
    [SerializeField] private GameObject chainPrefab;
    [SerializeField] private float spawnInterval = 2f;

    private int spawnCount = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Vector3 spawnPos = new Vector3(spawnCount * 3f, 3f, 0f);
            GameObject newChain = Instantiate(chainPrefab, spawnPos, Quaternion.identity);
            newChain.name = $"Chain_{spawnCount}";
            spawnCount++;
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            GameObject last = GameObject.Find($"Chain_{spawnCount - 1}");

            if (last != null)
            {
                Destroy(last);
                spawnCount--;
                Debug.Log($"Destroyed: Chain_{spawnCount}");
            }
        }
    }   
}
