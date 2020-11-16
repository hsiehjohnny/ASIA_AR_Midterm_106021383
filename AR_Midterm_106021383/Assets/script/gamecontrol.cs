using UnityEngine;

public class gamecontrol : zom
{
    public Transform dogknight;
    public Transform zombie;

    public FixedJoystick Joystick;

    public Animator anidog;
    public Animator anizombie;


    public bool dogruning = false;


    // Start is called before the first frame update
    void Start()
    {
        dogruning = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        dogknight.Translate(0, 0, Joystick.Vertical * 0.01f);

        if (Joystick.Vertical != 0)
        {
            dogruning = true;
            if (dogruning == true)
            {
                anidog.SetBool("dogruning", true);
            }
        }
        else
        {
            dogruning = false;
            if (dogruning == false)
            {
               anidog.SetBool("dogruning", false);
            }
        }
    }
    public void anicontroll(string anicall)
    {
        if (anicall == "dogatk")
        {
            if (zom.canatk == false)
            {
                anidog.SetTrigger(anicall);
                anizombie.SetTrigger("zomhit");
            }
            if (zom.canatk == true)
            {
                anizombie.SetTrigger("zomatk");
                anidog.SetTrigger("doghit");
            }
        }
        else
        {
            anidog.SetTrigger("dogrun");
            anizombie.SetTrigger("zomrun");
        }
    }
}
