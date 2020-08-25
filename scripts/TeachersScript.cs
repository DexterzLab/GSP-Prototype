using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TeachersScript
{

    public Image Portrait;
    public string name;
    public string stageName;
    public string Occupation;
    public string Likes;
    public string Dislikes;
    public string Projects;

    public TeachersScript(string name, string stage,string occupation, string likes, string dislikes, string projects)
    {
        this.name = name;
        this.stageName = stage;
        this.Occupation = occupation;
        this.Likes = likes;
        this.Dislikes = dislikes;
        this.Projects = projects;


    }
    
    public TeachersScript()
    {
        this.name = null;
        this.stageName = null;
        this.Occupation = null;
        this.Likes = null;
        this.Dislikes = null;
        this.Projects = null;
    }




}
