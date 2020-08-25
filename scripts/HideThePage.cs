using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideThePage : MonoBehaviour
{


    public GameObject[] Teacherport;

    public Text nametxt;
    public Text stagetxt;
    public Text Occupation;
    public Text likestxt;
    public Text dislikestxt;
    public Text Projects;
    public GameObject Display;
    public GameObject Scene;

    public AudioSource PageBG;
    public AudioClip mylonBG;
    public AudioClip jonBG;
    public AudioClip TravisBG;
    public AudioClip KeyzBG;




    //public TeachersScript[] Teachers;
    public TeachersScript travisMendes = new TeachersScript("TravisMendes", "TravisMendes", "Singer", null, null, "ThePhlyTape, AlteredState, Do Over, NoMore, EyeToEye, Closure, Cocaine & Diamonds, TheHumanCondition");

    public TeachersScript jonbellion2 = new TeachersScript("Jon Bellion", "Jon Bellion", "Singer/rapper", null, null, "TranslationThroughSpeakers, TheDefinition, Seperation, TheHumanCondition, GlorySoundPrep");

    public TeachersScript mylon = new TeachersScript("Marlon", "Mylon", "Producer", null, null, "Tape.Squid, PhlyTape TheDefinition, Seperation, TheHumanCondition, GlorySoundPrep, ");

    public TeachersScript Bkeyz = new TeachersScript("Hakkim", "B.keyz", "Rapper", null, null, "HeistBox, TWIMC, TheDefinition, Seperation, TheHumanCondition, GlorySoundPrep");

    public TeachersScript Dxtr = new TeachersScript(" DexterFindley", "Dxtr", "Photographer", null, null, "TheDefinitionTour, SeperationTour, TheHumanConditionTour, GlorySoundPrepTour");



    // Start is called before the first frame update
    void Start()
    {
        PageBG = FindObjectOfType<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayJon()
    {
        
        Scene.SetActive(false);
        Display.SetActive(true);
        Teacherport[0].SetActive(true);
        PageBG.clip = jonBG;
        PageBG.Play();
        StoreInformation2(jonbellion2);
    }

    public void DisplayKeyz()
    {
        
        Scene.SetActive(false);
        Display.SetActive(true);
        Teacherport[4].SetActive(true);
        PageBG.clip = KeyzBG;
        PageBG.Play();
        StoreInformation2(Bkeyz);
    }

    public void DisplayMylon()
    {
        Scene.SetActive(false);
        Display.SetActive(true);
        Teacherport[2].SetActive(true);
        PageBG.clip = mylonBG;
        PageBG.Play();
        StoreInformation2(mylon);

    }

    public void DisplayDexter()
    {
        Scene.SetActive(false);
        Display.SetActive(true);
        Teacherport[3].SetActive(true);
        StoreInformation2(Dxtr);
    }

    public void DisplayTravis()
    {
        Scene.SetActive(false);
        Display.SetActive(true);
        Teacherport[1].SetActive(true);
        PageBG.clip = TravisBG;
        PageBG.Play();
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
        Scene.SetActive(true);
        Display.SetActive(false);

        Teacherport[0].SetActive(false);
        Teacherport[1].SetActive(false);
        Teacherport[3].SetActive(false);
        Teacherport[4].SetActive(false);
        Teacherport[2].SetActive(false);
        // nametxt.gameObject.SetActive(false);
        nametxt.text = null;
        stagetxt.text = null;
        Occupation.text = null;
        likestxt.text = null;
        dislikestxt.text = null;
        Projects.text = null;
    }

}
