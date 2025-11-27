using UnityEngine;

public class GoForward : MonoBehaviour
{
    public float speed = 1f;

    private void Start()
    {
        Debug.Log("Going forward! Speed: " + speed);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += new Vector3(0, 0, speed * Time.deltaTime); 
    }
}