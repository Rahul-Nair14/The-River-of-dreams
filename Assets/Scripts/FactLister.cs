using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FactLister : MonoBehaviour
{

    
    int randomFactNum;
    Text fact;


    public float TransitionTime = 5f;
    

    public void Start()
    {

        fact = this.GetComponent<Text>();


        StartCoroutine(FactTransition());
    }

    public void FactLoader()
    {

        string[] Facts = new string[14]
        
        { 
            "Around 70% of the industrial waste is dumped into the water bodies where they pollute the usable water supply",
            "Globally, 80 percent of municipal wastewater is discharged into the environment untreated",
            "At least 320 million people in China do not have access to clean drinking water",
            "Fourteen billion pounds of garbage, mostly plastic, is dumped into the ocean every year",
            "80% of the water pollution is caused due to domestic sewage like throwing garbage on open ground and water bodies",
            "15 million children under the age of five die each year because of diseases caused by drinking water",
            "About 700 million people worldwide drink contaminated water",
            "An estimated 1000 children die every day in India due to polluted water",
            "Nitrate from agriculture is the most common chemical contaminant in the world’s groundwater aquifers",
            "Rivers in the Asian subcontinent are considered to be the most polluted",
            "Oil is more harmful to the ocean's ecosystem than waste and trash",
            "There are more microplastics in our oceans than stars in the Milky Way",
            "Plastics and water pollution kill more than a million seabirds and 100,000 marine mammals every year",
            "40,000 tons of plastics are currently floating on the oceans' surface"
        };



        randomFactNum = Random.Range(0, Facts.Length);


        fact.text = Facts[randomFactNum];

    }


    IEnumerator FactTransition()
    {
        while(true)
        {
            FactLoader();
            yield return new WaitForSeconds(TransitionTime);

        }
        

    }

}
