using UnityEngine;

public class ObjectGrowingAndDecreases : MonoBehaviour
{
    public float maxSize = 1.5f;
    public float minSize = 1f;
    private bool isExpanding = true;

    void Update()
    {
        if (isExpanding)
        {
            transform.localScale += Vector3.one * 0.5f * Time.deltaTime;

            if (transform.localScale.x >= maxSize)
            {
                isExpanding = false;
            }
        }
        else
        {
            transform.localScale -= Vector3.one * 0.5f * Time.deltaTime;

            if (transform.localScale.x <= minSize)
            {
                isExpanding = true;
            }
        }
    }
}
