using UnityEngine;
using System.Collections;

public class GoldBar : MonoBehaviour
{
    [SerializeField] bool collectedGoldBar;

   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 2, 0, Space.World);
        if (collectedGoldBar == true)
        {
            transform.Translate(Vector3.up * Time.deltaTime * 6, Space.World);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        collectedGoldBar = true;
        //StatControl.goldBarCount += 1;
        this.gameObject.GetComponent<Animator>().Play("disappear");
        StartCoroutine(DeleteGoldBar());
    }

    IEnumerator DeleteGoldBar()
    {
        yield return new WaitForSeconds(0.5f);
        this.gameObject.SetActive(false);
    }





}
