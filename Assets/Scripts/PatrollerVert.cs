using UnityEngine;
using DG.Tweening;
using Random = UnityEngine.Random;

public class PatrollerVert : MonoBehaviour
{
    [SerializeField] private GameObject _dark;

    private void Start()
    {
        _dark.transform.DOLocalMoveY(transform.position.y+1f, 3).SetLoops(-1, LoopType.Yoyo).SetAutoKill(false);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            transform.DOKill(_dark);
            var randX = Random.Range(-1.7f, 1.7f);
            var randY = Random.Range(transform.position.y + 14f, transform.position.y + 15f);
            _dark.transform.position = new Vector3(randX, randY, 0);
            _dark.transform.DOLocalMoveY(_dark.transform.position.y+1f, 3).SetLoops(-1, LoopType.Yoyo).SetAutoKill(false);
            _dark.transform.DORestart(_dark);
        }
    }
    
}
