using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage = 100f;
    public float range = 500f;
    public Camera fpsCam;
    AudioSource sshot; 

    void Update()
    {
        sshot = GetComponent<AudioSource>();

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            sshot.Play();
        }
    }

    void Shoot ()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            
            target Target = hit.transform.GetComponent<target>();
            if(Target != null)
            {
                Target.TakeDamage(damage);
            }
        }
    }
}
