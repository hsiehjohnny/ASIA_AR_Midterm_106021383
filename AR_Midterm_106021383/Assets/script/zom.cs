using UnityEngine;

public class zom : MonoBehaviour
{
    static public bool canatk = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
        if (other.name == "dog")
        {
            print(canatk);
            canatk = false;
        }

    }
    private void OnTriggerExit(Collider other)
    {

        canatk = true;

    }
}
