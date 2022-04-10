using UnityEngine;
using DG.Tweening;

public class Down : MonoBehaviour
{
    [SerializeField] private GameObject _brownPrefab;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            transform.DOKill(_brownPrefab);
            var randX = Random.Range(-1.7f, 1.7f);
            var position = transform.position;
            var randY = Random.Range(position.y + 15f, position.y + 18f);
            position = new Vector3(randX, randY, 0);
            transform.position = position;
            transform.DORestart(_brownPrefab);
        }
    }
}