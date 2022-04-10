using UnityEngine;
using Random = UnityEngine.Random;

public class Platform : MonoBehaviour
{
    [SerializeField] private float _forceJump;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            Doodle.Instance.doodleRigid.velocity = Vector2.up * _forceJump;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            var transform1 = transform;
            var position = transform1.position; 
            var randX = Random.Range(-1.7f, 1.7f);
            var randY = Random.Range(position.y + 12f, position.y + 12f);
            transform.position = new Vector3(randX, randY, 0);
        }
    }
}
