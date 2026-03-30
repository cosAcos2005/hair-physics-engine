using UnityEngine;

public class PendulumTest : MonoBehaviour
{
    [SerializeField] private float swingAngle = 45f;
    [SerializeField] private float returnSpeed =2f;

    private Quaternion targetRotation;

    void Update()
    {
        //スペースキーで振る/
        if (Input.GetKeyDown(KeyCode.Space))
        {
            targetRotation = Quaternion.AngleAxis(swingAngle, Vector3.forward);
            swingAngle = -swingAngle;
        }

        transform.localRotation = Quaternion.Slerp(
            transform.localRotation,
            targetRotation,
            Time.deltaTime * returnSpeed
        );
    }
}
