using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System;

public class BallSpawner : MonoBehaviour {

    public int level;
	public GameObject ball;

    private float spawnTime = 0.0f;

    private SpawnInfo siradaki;

    private List<SpawnInfo> spawnInfoList;

    void Awake()
    {
        spawnInfoList = new List<SpawnInfo>();
        try
        {
            string line;
         
            StreamReader theReader = new StreamReader("level" + level + ".txt", Encoding.Default);
            using (theReader)
            {
                do
                {
                    line = theReader.ReadLine();
                     
                    if (line != null)
                    {
                        string[] entries = line.Split(':');
                        print(line);
                        if (entries.Length > 0)
                        {
                            float time = float.Parse(entries[0]);
                            Transform t = ((Constants)GameObject.Find("consts").GetComponent("Constants")).targets[int.Parse(entries[1]) - 1];
                            Material m = ((Constants)GameObject.Find("consts").GetComponent("Constants")).materials[int.Parse(entries[2]) - 1];
                            spawnInfoList.Add(new SpawnInfo(t, m, time));
                        }
                    }
                }
                while (line != null);
                 
                theReader.Close();
             }
         }
         catch (Exception e)
         {
             print(e.Message);
         }
    }


	void Start () {
        siradaki = spawnInfoList[0];
        spawnInfoList.RemoveAt(0);
	}

	void Update () {
        spawnTime += Time.deltaTime;
        if (siradaki != null && siradaki.time <= spawnTime)
        {
            ball.GetComponent<MeshRenderer>().material = siradaki.material;
            ((BallMovement)ball.GetComponent("BallMovement")).target = siradaki.target;
			GameObject go = Instantiate(ball, transform.position , Quaternion.identity)  as GameObject;
            ((BallMovement)ball.GetComponent("BallMovement")).target = GameObject.Find("empty_target").transform;
            if (spawnInfoList.Count != 0)
            {
                siradaki = spawnInfoList[0];
                spawnInfoList.RemoveAt(0);
            }
            else
            {
                siradaki = null;
            }
        }
	}
}
