using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class OnColision : MonoBehaviour
{
    public Text lbl;
    int i;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Fade());
        lbl.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Fade()
    {
        print("Коорутина запущена");
        yield return new WaitForSeconds(5.5f);
        print("Прошло 5.5 секунды");
        yield return new WaitForSeconds(2.5f);
        StartCoroutine(Fade());
    }

    private void OnCollisionEnter(Collision collision)
    {
        i--;
        lbl.text = "" + i;
        print(collision.collider.name); //не забыть добавить риджитбоди
    }

    public void plus()
    {
        i++;
        lbl.text = "" + i;
        this.gameObject.SetActive(i % 2 == 0);
    }
}
