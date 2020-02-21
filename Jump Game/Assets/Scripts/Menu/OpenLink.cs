using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void Website(){	
        Application.OpenURL("https://nicecat.wgi.fi");
    }
    
    public void Website_GamePage(){
        Application.OpenURL("https://nicecat.wgi.fi/jump-game/");
    }
    
    public void GitRepositories_Github(){
        Application.OpenURL("https://github.com/nicecat-studios/jump-game");
    }
    
    public void GitRepositories_Gitlab(){
        Application.OpenURL("https://gitlab.com/nicecat-studios/jump-game");
    }
    
}
