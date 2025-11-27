using UnityEngine;

public class Example : MonoBehaviour
{
    int myAge;
    float myHeight = 1.0f;
    string myName = "Alper";
    bool isStudent = true;

    void Start()
    {
        print("Merhaba");
        print(myHeight);

        myHeight = 1 + 1f * 2 + 1;
        print(myHeight);

    }

    // Update is called once per frame
    void Update()
    {
        print("Nasılsın?");
    }
}
