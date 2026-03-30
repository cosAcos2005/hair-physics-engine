using UnityEngine;

public class FaceController : MonoBehaviour
{
    private SkinnedMeshRenderer faceMash;

    private void Start()
    {
        faceMash = GetComponent<SkinnedMeshRenderer>();

        //BlendShapeの名前一覧をConsoleに出力
        for (int i = 0; i < faceMash.sharedMesh.blendShapeCount; i++)
        {
            Debug.Log($"BlendShape[{i}]: {faceMash.sharedMesh.GetBlendShapeName(i)}");
        }
    }
    void Update()
    {

        //スペースキーで目を閉じる
        if (Input.GetKey(KeyCode.Space))
        {
            float value = Mathf.PingPong(Time.time * 100f, 100f);
            faceMash.SetBlendShapeWeight(13, value); // Assuming BlendShape 0 is for eyes
        }
    }
}
