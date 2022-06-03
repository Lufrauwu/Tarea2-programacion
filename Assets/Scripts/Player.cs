using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _speed = 10;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.collider.tag != ("Plane"))
                {
                    StartCoroutine(uwu(hit.collider.gameObject));
                }
               
            }
          
        } 
        }

    IEnumerator uwu( GameObject obj)
    {
        yield return new WaitForSeconds(1f);
        obj.GetComponent<Renderer>().material.color = Random.ColorHSV();
        yield return new WaitForSeconds(2.3f);
        obj.GetComponent<Rigidbody>().AddForce(transform.up * _speed, ForceMode.Impulse);
        yield return new WaitForSeconds(0.5f);
        obj.GetComponent<Renderer>().material.color = Color.white;
        yield return new WaitForSeconds(0.2f);
        obj.GetComponent<Rigidbody>().AddForce(transform.forward * _speed, ForceMode.Impulse);
        yield return new WaitForSeconds(1f);
        obj.GetComponent<MeshRenderer>().enabled = false;
    }
}
