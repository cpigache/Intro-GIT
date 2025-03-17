using UnityEngine;

public class cubeClone : MonoBehaviour
{
    public GameObject Other;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Other.transform.position = new Vector3(1, transform.position.x, 1);
    }
}
