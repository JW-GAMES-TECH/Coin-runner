using UnityEngine;

public class StatControl : MonoBehaviour
{
    public static int coinCount;
    //public static int goldBarCount;
    [SerializeField] GameObject textBox;
    [SerializeField] int internalCoinCount;
    //[SerializeField] int internalGoldBarCount;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalCoinCount = coinCount;
        textBox.GetComponent<TMPro.TMP_Text>().text = "" + coinCount;

        //internalGoldBarCount = goldBarCount;
        //textBox.GetComponent<TMPro.TMP_Text>().text = "" + goldBarCount;







    }
}
