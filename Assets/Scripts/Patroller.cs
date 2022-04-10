using DG.Tweening;
using UnityEngine;

public class Patroller : MonoBehaviour
{
    private void Start()
    {
        transform.DOLocalMoveX(1f, 5).SetLoops(-1, LoopType.Yoyo).SetAutoKill(false);
    }
}
