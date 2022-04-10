using UnityEngine;
using Random = UnityEngine.Random;

public class PlatformGenerate : MonoBehaviour
{
    [SerializeField] private GameObject _platformPrefab;
    [SerializeField] private GameObject _bluePrefab;
    [SerializeField] private GameObject _brownPrefab;
    [SerializeField] private GameObject _darkPrefab;

    private void Start()
    {
        var spawnerPosition = new Vector3();
        var sp = new Vector3();
        var spDark = new Vector3();

        for (int i = 0; i < 7; i++)
        {
            var rand = new System.Random();
            var value = rand.Next(1, 7);
            var br = rand.Next(1, 7);
            var dar = rand.Next(1, 7);
            spawnerPosition.x = Random.Range(-1.2f, 1.2f);
            spawnerPosition.y += Random.Range(1.8f, 2.5f);
            sp.x = Random.Range(-1.6f, 1.6f);
            sp.y += Random.Range(1.8f, 2.5f);
            spDark.x = Random.Range(-1.5f, 2.5f);
            spDark.y += Random.Range(1.8f, 2.5f);
            Instantiate(i == value ? _bluePrefab : _platformPrefab, spawnerPosition, Quaternion.identity);

            if (i == br)
            {
                Instantiate(_brownPrefab, sp, Quaternion.identity);
            }

            if (i == dar)
            {
                Instantiate(_darkPrefab, spDark, Quaternion.identity);
            }
        }
    }
}