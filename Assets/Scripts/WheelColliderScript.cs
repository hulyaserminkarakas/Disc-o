using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WheelColliderScript : MonoBehaviour {

	// Use this for initialization
    void OnTriggerEnter2D(Collider2D col)
    {
        print(gameObject.GetComponent<SpriteRenderer>().material.name + " - " + col.gameObject.GetComponent<MeshRenderer>().material.name);
        if (gameObject.GetComponent<SpriteRenderer>().material.name.Contains(col.gameObject.GetComponent<MeshRenderer>().material.name))
        {
            if (Constants.combo)//art arda yapılan doğru vuruş kombo kazandırır.
            {
                Constants.scoreMutltiplier++;
            }
            if (Constants.scoreMutltiplier % 5 == 0)//her 5 komboda 1 can kazanır
            {
                Constants.health++;
                if (Constants.health <= 20)//max can 20 olduğu için kontrol edilmeli
                {
                    GameObject.Find("health_bar").GetComponent<Image>().fillAmount = (float)(0.05 * Constants.health);
                }
            }
            Constants.score += Constants.scoreMutltiplier;
            GameObject.Find("ScoreText").GetComponent<Text>().text = "Score : " + Constants.score;
            Destroy(col.gameObject);

            Constants.combo = true;
        }
        else
        {
            --Constants.health;//her yanlış vuruşta can bir azalır.
            if (Constants.health == 0) // can 0 ise yanma gerçekleşir
            {
				Application.LoadLevel (2);
            }

            GameObject.Find("health_bar").GetComponent<Image>().fillAmount = (float)(0.05 * Constants.health);
            Constants.combo = false; // yanınca kombo sıfırlanır.
            Constants.scoreMutltiplier = 1;
        }
        GameObject.Destroy(col.gameObject);
    }
}
