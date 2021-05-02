using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class make_trees : MonoBehaviour
{
    public GameObject[] instantiated_trees;
    public GameObject tree_prefabs;
    private int num_of_trees = 50;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = new Vector3(0, 0, 0);
        GameObject tree = Instantiate(tree_prefabs, pos, Quaternion.identity);

        for (int i = 0; i < 400; i++){

            if(i % 2 == 0){

                tree.gameObject.transform.GetChild(3).gameObject.SetActive(false);
                print("off");

            } else{

                tree.gameObject.transform.GetChild(3).gameObject.SetActive(true);
                 print("on");

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void make_some_trees(){

        instantiated_trees = new GameObject[num_of_trees];

        for (int i = 0; i < num_of_trees; i++){

            Vector3 position = new Vector3(i, 0, 0);
            instantiated_trees[i] = Instantiate(tree_prefabs, position, Quaternion.identity);


            if (i % 2 == 0){

                instantiated_trees[i].gameObject.transform.GetChild(3).gameObject.SetActive(false);

            }else if(i % 2 == 1){

                instantiated_trees[i].gameObject.transform.GetChild(3).gameObject.SetActive(true);

            }else{

                print("something went wrong");

            }

        }

    }

}
