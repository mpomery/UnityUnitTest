using UnityEngine;

public class Example : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (MethodToTest())
        {
            Debug.Log("Instatiate");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (MethodToTest())
        {
            Debug.Log("Frame");
        }
    }

    public static bool MethodToTest()
    {
        return true;
    }
}
