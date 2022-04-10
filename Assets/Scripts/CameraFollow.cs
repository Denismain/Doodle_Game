using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _doodlePos;
    private void Update()
    {
        if (_doodlePos.position.y > transform.position.y)
        {
            var transform1 = transform;
            var position = transform1.position;
            position = new Vector3(position.x, _doodlePos.position.y , position.z);
            transform1.position = position;
        }
    }
}
