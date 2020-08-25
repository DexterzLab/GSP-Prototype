using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DevTestScript : MonoBehaviour
{

    
    public Text nametxt;
    public Text stagetxt;
    public Text Occupation;
    public Text likestxt;
    public Text dislikestxt;
    public Text Projects;

    public string teacher = "jonbellion";
    public string stagetext = "STAGETEXT";

    //PART OF METHOD 3
    public TeachersScript jonbellion = new TeachersScript();

    //Part of mthod 4
    public TeachersScript travisMendes = new TeachersScript("travismendes", "travismendes","singer","donuts","laziness","EP1,EP2EP3");
    public TeachersScript jonbellion2 = new TeachersScript("Jon bellion", "jon bellion","singer/rapper","being in the pocket", "808 Drums", "TheDefinition, Seperation, TheHumanCondition, GlorySoundPrep");
    public TeachersScript mylon = new TeachersScript("marlon", "mylon", "producer", "classic/lofi samples", null, "TheDefinition, Seperation, TheHumanCondition, GlorySoundPrep");
    public TeachersScript Bkeyz = new TeachersScript("Hakkim", "B.keyz", "rapper", null, null, "HeistBox, TWIMC, TheDefinition, Seperation, TheHumanCondition, GlorySoundPrep");
    public TeachersScript Dxtr = new TeachersScript("Hakkim", "B.keyz", "Photographer", null, null, "TheDefinitionTour, SeperationTour, TheHumanConditionTour, GlorySoundPrepTour");



    private void Start()
    {
        jonbellion.name = "jonbellion";
        jonbellion.stageName = "STAGECLASSTEXT";
    }

    public void StoreInformation()
    {
        //METHOD 1
        //nametxt.text = "jonbellion";
        //stagetxt.text = "STAGETEXT";


        //METHOD 2
        // nametxt.text = teacher;
        //stagetxt.text = stagetext;

        




        //METHOD 3(WE WILL USE THIS WAY)
       // nametxt.gameObject.SetActive(true);
        nametxt.text = jonbellion.name;
        stagetxt.text = jonbellion.stageName;
        


    }

    //METHOD4 (advanced extension to 3)
    public void DisplayTeacher()
    {
        StoreInformation2(travisMendes);
    }

    //we can use this way, an we would/could put this function another script which strictly handles ui
    public void StoreInformation2(TeachersScript teacher)
    {
        nametxt.text = teacher.name;
        stagetxt.text = teacher.stageName;
        Occupation.text = teacher.Occupation;
        likestxt.text = teacher.Likes;
        dislikestxt.text = teacher.Dislikes;
        Projects.text = teacher.Projects;
    }

    public void RemoveInformation()
    {
       // nametxt.gameObject.SetActive(false);
        nametxt.text = null;
        stagetxt.text = null;
        Occupation.text = null;
        likestxt.text = null;
        dislikestxt.text = null;
        Projects.text = null;
    }
    



}
