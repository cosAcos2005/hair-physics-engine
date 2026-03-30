using UnityEngine;

public class ChainController : MonoBehaviour
{
    [SerializeField] private float followSpeed = 5f;

    void Update()
    {
        Vector3 mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = 10f;
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mouseScreenPos);

        transform.position = Vector3.Lerp(
            transform.position,
            mouseWorldPos,
            Time.deltaTime * followSpeed
        );
    }
}
