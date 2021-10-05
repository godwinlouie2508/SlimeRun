using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    Animation a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r;
    public GameObject a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12,a13,a14,a15,a16,a17,a18;
    public float animSpeed = 1f;

    //18 Animations
    
    
    void Start()
    {
        a = a1.GetComponent<Animation>();
        b = a2.GetComponent<Animation>();
        c = a3.GetComponent<Animation>();
        d = a4.GetComponent<Animation>();
        e = a5.GetComponent<Animation>();
        f = a6.GetComponent<Animation>();
        j = a7.GetComponent<Animation>();
        h = a8.GetComponent<Animation>();
        i = a9.GetComponent<Animation>();
        j = a10.GetComponent<Animation>();
        k = a11.GetComponent<Animation>();
        l = a12.GetComponent<Animation>();
        m = a13.GetComponent<Animation>();
        n = a14.GetComponent<Animation>();
        o = a15.GetComponent<Animation>();
        p = a16.GetComponent<Animation>();
        q = a17.GetComponent<Animation>();
        r = a18.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        a["name of animation"].speed = animSpeed;
        b["name of animation"].speed = animSpeed;
        c["name of animation"].speed = animSpeed;
        d["name of animation"].speed = animSpeed;
        e["name of animation"].speed = animSpeed;
        f["name of animation"].speed = animSpeed;
        g["name of animation"].speed = animSpeed;
        h["name of animation"].speed = animSpeed;
        i["name of animation"].speed = animSpeed;
        j["name of animation"].speed = animSpeed;
        k["name of animation"].speed = animSpeed;
        l["name of animation"].speed = animSpeed;
        m["name of animation"].speed = animSpeed;
        n["name of animation"].speed = animSpeed;
        o["name of animation"].speed = animSpeed;
        p["name of animation"].speed = animSpeed;
        q["name of animation"].speed = animSpeed;
        r["name of animation"].speed = animSpeed;
    }
}
