using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using System.IO;
using UnityEditor.Experimental;
using UnityEditor;
using Unity.VisualScripting;
using System;

namespace InterDineMension
{
    using InterDineMension.Manager;
    using UnityEngine.SceneManagement;

    public class DialogueVariables
    {
        public Dictionary<string, Ink.Runtime.Object> variables {  get; private set; }

        internal Story globalVariablesStory;

        private const string saveVariablesKey = "INK_VARIABLES";

        
        

        
        public DialogueVariables(Story loadGlobalJSON)
        {
            //compiles the story
            globalVariablesStory = loadGlobalJSON;
            //Initialize dictionary

            if(PlayerPrefs.HasKey(saveVariablesKey))
            {
                string jsonState =PlayerPrefs.GetString(saveVariablesKey);
                globalVariablesStory.state.LoadJson(jsonState);
            }

            //variables = new Dictionary<string, Ink.Runtime.Object>();
            /*foreach(string name in globalVariablesStory.variablesState)
            {
                Ink.Runtime.Object value = globalVariablesStory.variablesState.GetVariableWithName(name);
                variables.Add(name, value);
                *//*Debug.Log("Initialized global Dialogue Variable: " + name + " = " + value);*//*
            }*/
        }

        public void PPSave()
        {
            Debug.Log("ppsave");
            PlayerPrefs.SetInt("dayVarT", PlayerPrefs.GetInt("dayVar"));
            PlayerPrefs.SetString("weekDayT", PlayerPrefs.GetString("weekDay"));
            PlayerPrefs.SetInt("aptUpgradeT", PlayerPrefs.GetInt("aptUpgrade"));


            PlayerPrefs.SetInt("convo_numberCST", PlayerPrefs.GetInt("convo_numberCS"));
            PlayerPrefs.SetInt("affectionCST", PlayerPrefs.GetInt("affectionCS"));
            PlayerPrefs.SetInt("chaosCST", PlayerPrefs.GetInt("chaosCS"));

            PlayerPrefs.SetInt("convo_numberNT", PlayerPrefs.GetInt("convo_numberN"));
            PlayerPrefs.SetInt("affectionNT", PlayerPrefs.GetInt("affectionN"));
            PlayerPrefs.SetInt("chaosNT", PlayerPrefs.GetInt("chaosN"));

            PlayerPrefs.SetInt("convo_numberCCT", PlayerPrefs.GetInt("convo_numberCC"));
            PlayerPrefs.SetInt("affectionCCT", PlayerPrefs.GetInt("affectionCC"));
            PlayerPrefs.SetInt("chaosCCT", PlayerPrefs.GetInt("chaosCC"));

            PlayerPrefs.SetInt("convo_numberMT", PlayerPrefs.GetInt("convo_numberM"));
            PlayerPrefs.SetInt("affectionMT", PlayerPrefs.GetInt("affectionM"));
            PlayerPrefs.SetInt("chaosMT", PlayerPrefs.GetInt("chaosM"));

            PlayerPrefs.SetInt("convo_numberGT", PlayerPrefs.GetInt("convo_numberG"));
            PlayerPrefs.SetInt("affectionGT", PlayerPrefs.GetInt("affectionG"));
            PlayerPrefs.SetInt("chaosGT", PlayerPrefs.GetInt("chaosG"));

            PlayerPrefs.SetInt("convo_numberFT", PlayerPrefs.GetInt("convo_numberF"));
            PlayerPrefs.SetInt("affectionFT", PlayerPrefs.GetInt("affectionF"));
            PlayerPrefs.SetInt("chaosFT", PlayerPrefs.GetInt("affectionF"));

            PlayerPrefs.SetInt("affectionORT", PlayerPrefs.GetInt("affectionOR"));
            PlayerPrefs.SetInt("chaosORT", PlayerPrefs.GetInt("chaosOR"));
            PlayerPrefs.SetInt("convo_numberORT", PlayerPrefs.GetInt("convo_numberOR"));

            PlayerPrefs.SetInt("BAMLevel", int.Parse(globalVariablesStory.variablesState["BAMLevel"].ToString()));
            PlayerPrefs.SetInt("TTMLevel", int.Parse(globalVariablesStory.variablesState["TTMLevel"].ToString()));
            PlayerPrefs.SetInt("TBMLevel", int.Parse(globalVariablesStory.variablesState["TBMLevel"].ToString()));

            PlayerPrefs.SetString("currentConvo", PlayerPrefs.GetString("currentConvo"));
        }
        public void QuickSaveVariables()
        {
            PlayerPrefs.SetInt("dayVarT", int.Parse(globalVariablesStory.variablesState["dayVar"].ToString()));
            PlayerPrefs.SetString("weekDayT", globalVariablesStory.variablesState["weekDay"].ToString());
            PlayerPrefs.SetInt("aptUpgradeT", int.Parse(globalVariablesStory.variablesState["aptUpgrade"].ToString()));


            PlayerPrefs.SetInt("convo_numberCST", int.Parse(globalVariablesStory.variablesState["convo_numberCS"].ToString()));
            PlayerPrefs.SetInt("affectionCST", int.Parse(globalVariablesStory.variablesState["affectionCS"].ToString()));
            PlayerPrefs.SetInt("chaosCST", int.Parse(globalVariablesStory.variablesState["chaosCS"].ToString()));

            PlayerPrefs.SetInt("convo_numberNT", int.Parse(globalVariablesStory.variablesState["convo_numberN"].ToString()));
            PlayerPrefs.SetInt("affectionNT", int.Parse(globalVariablesStory.variablesState["affectionN"].ToString()));
            PlayerPrefs.SetInt("chaosNT", int.Parse(globalVariablesStory.variablesState["chaosN"].ToString()));

            PlayerPrefs.SetInt("convo_numberCCT", int.Parse(globalVariablesStory.variablesState["convo_numberCC"].ToString()));
            PlayerPrefs.SetInt("affectionCCT", int.Parse(globalVariablesStory.variablesState["affectionCC"].ToString()));
            PlayerPrefs.SetInt("chaosCCT", int.Parse(globalVariablesStory.variablesState["chaosCC"].ToString()));

            PlayerPrefs.SetInt("convo_numberMT", int.Parse(globalVariablesStory.variablesState["convo_numberM"].ToString()));
            PlayerPrefs.SetInt("affectionMT", int.Parse(globalVariablesStory.variablesState["affectionM"].ToString()));
            PlayerPrefs.SetInt("chaosMT", int.Parse(globalVariablesStory.variablesState["chaosM"].ToString()));

            PlayerPrefs.SetInt("convo_numberGT", int.Parse(globalVariablesStory.variablesState["convo_numberG"].ToString()));
            PlayerPrefs.SetInt("affectionGT", int.Parse(globalVariablesStory.variablesState["affectionG"].ToString()));
            PlayerPrefs.SetInt("chaosGT", int.Parse(globalVariablesStory.variablesState["chaosG"].ToString()));

            PlayerPrefs.SetInt("convo_numberFT", int.Parse(globalVariablesStory.variablesState["convo_numberF"].ToString()));
            PlayerPrefs.SetInt("affectionFT", int.Parse(globalVariablesStory.variablesState["affectionF"].ToString()));
            PlayerPrefs.SetInt("chaosFT", int.Parse(globalVariablesStory.variablesState["chaosF"].ToString()));
            
            PlayerPrefs.SetInt("affectionORT", int.Parse(globalVariablesStory.variablesState["affectionOR"].ToString()));
            PlayerPrefs.SetInt("chaosORT", int.Parse(globalVariablesStory.variablesState["chaosOR"].ToString())); 
            PlayerPrefs.SetInt("convo_numberORT", int.Parse(globalVariablesStory.variablesState["convo_numberOR"].ToString()));

            PlayerPrefs.SetInt("BAMLevel", int.Parse(globalVariablesStory.variablesState["BAMLevel"].ToString()));
            PlayerPrefs.SetInt("TTMLevel", int.Parse(globalVariablesStory.variablesState["TTMLevel"].ToString()));
            PlayerPrefs.SetInt("TBMLevel", int.Parse(globalVariablesStory.variablesState["TBMLevel"].ToString()));

            PlayerPrefs.SetString("timeOfDay", globalVariablesStory.variablesState["timeOfDay"].ToString());
            PlayerPrefs.SetString("currentConvo", globalVariablesStory.variablesState["currentConvo"].ToString());





            PlayerPrefs.Save();
        }

        public void clearTempVars(VariableHolder vH)
        {
            PreventFarming(vH);
            PlayerPrefs.DeleteKey("newGame");

            PlayerPrefs.DeleteKey("winStatus");

            PlayerPrefs.DeleteKey("dayVarT");
            PlayerPrefs.DeleteKey("weekDayT");
            PlayerPrefs.DeleteKey("aptUpgradeT");


            PlayerPrefs.DeleteKey("convo_numberCST");
            PlayerPrefs.DeleteKey("affectionCST");
            PlayerPrefs.DeleteKey("chaosCST");

            PlayerPrefs.DeleteKey("convo_numberNT");
            PlayerPrefs.DeleteKey("affectionNT");
            PlayerPrefs.DeleteKey("chaosNT");

            PlayerPrefs.DeleteKey("convo_numberCCT");
            PlayerPrefs.DeleteKey("affectionCCT");
            PlayerPrefs.DeleteKey("chaosCCT");

            PlayerPrefs.DeleteKey("convo_numberMT");
            PlayerPrefs.DeleteKey("affectionMT");
            PlayerPrefs.DeleteKey("chaosMT");

            PlayerPrefs.DeleteKey("convo_numberGT");
            PlayerPrefs.DeleteKey("affectionGT");
            PlayerPrefs.DeleteKey("chaosGT");

            PlayerPrefs.DeleteKey("convo_numberFT");
            PlayerPrefs.DeleteKey("affectionFT");
            PlayerPrefs.DeleteKey("chaosFT");

            PlayerPrefs.DeleteKey("chaosORT");
            PlayerPrefs.DeleteKey("affectionORT");
            PlayerPrefs.DeleteKey("convo_numberORT");


            PlayerPrefs.DeleteKey("BAMLevel");
            PlayerPrefs.DeleteKey("TTMLevel");
            PlayerPrefs.DeleteKey("TBMLevel");

            PlayerPrefs.DeleteKey("currentConvo");
            PlayerPrefs.DeleteKey("winStatus");

            PlayerPrefs.SetString("timeOfDay", "morning");

            
        }

        private void PreventFarming(VariableHolder vH)
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(5))//prevents farming by quiting once appartment is loaded in. will force you to the next day. 
            {
                vH.dM.EnterDialogueMode(vH.preventFarming);
            }
            
        }

        public void SaveVariables()
        {
            if(globalVariablesStory != null)
            {
                /*VariablesToStory(globalVariablesStory);
                PlayerPrefs.SetString(saveVariablesKey, globalVariablesStory.state.ToJson());*/

                /* PlayerPrefs.SetInt("dayVar", PlayerPrefs.GetInt("dayVarT"));
                 PlayerPrefs.SetInt("aptUpgrade", PlayerPrefs.GetInt("aptUpgradeT"));
                 PlayerPrefs.SetString("weekDay", PlayerPrefs.GetString("weekDayT"));


                 PlayerPrefs.SetInt("convo_numberCS", PlayerPrefs.GetInt("convo_numberCST"));
                 PlayerPrefs.SetInt("affectionCS", PlayerPrefs.GetInt("affectionCST"));
                 PlayerPrefs.SetInt("chaosCS", PlayerPrefs.GetInt("chaosCST"));

                 PlayerPrefs.SetInt("convo_numberN", PlayerPrefs.GetInt("convo_numberNT"));
                 PlayerPrefs.SetInt("affectionN", PlayerPrefs.GetInt("affectionNT"));
                 PlayerPrefs.SetInt("chaosN", PlayerPrefs.GetInt("chaosNT"));

                 PlayerPrefs.SetInt("convo_numberCC", PlayerPrefs.GetInt("convo_numberCCT"));
                 PlayerPrefs.SetInt("affectionCC", PlayerPrefs.GetInt("affectionCCT"));
                 PlayerPrefs.SetInt("chaosCC", PlayerPrefs.GetInt("chaosCCT"));

                 PlayerPrefs.SetInt("convo_numberM", PlayerPrefs.GetInt("convo_numberMT"));
                 PlayerPrefs.SetInt("affectionM", PlayerPrefs.GetInt("affectionMT"));
                 PlayerPrefs.SetInt("chaosM", PlayerPrefs.GetInt("chaosMT"));

                 PlayerPrefs.SetInt("convo_numberG", PlayerPrefs.GetInt("convo_numberGT"));
                 PlayerPrefs.SetInt("affectionG", PlayerPrefs.GetInt("affectionGT"));
                 PlayerPrefs.SetInt("chaosG", PlayerPrefs.GetInt("chaosGT"));

                 PlayerPrefs.SetInt("convo_numberF", PlayerPrefs.GetInt("convo_numberFT"));
                 PlayerPrefs.SetInt("affectionF", PlayerPrefs.GetInt("affectionFT"));
                 PlayerPrefs.SetInt("chaosF", PlayerPrefs.GetInt("chaosFT"));

                 PlayerPrefs.SetInt("convo_numberOR", PlayerPrefs.GetInt("convo_numberORT"));
                 PlayerPrefs.SetInt("affectionOR", PlayerPrefs.GetInt("affectionORT"));
                 PlayerPrefs.SetInt("chaosOR", PlayerPrefs.GetInt("chaosORT"));*/

                PlayerPrefs.SetInt("dayVar", int.Parse(globalVariablesStory.variablesState["dayVar"].ToString()));
                PlayerPrefs.SetInt("aptUpgrade", int.Parse(globalVariablesStory.variablesState["aptUpgrade"].ToString()));
                PlayerPrefs.SetString("weekDay", globalVariablesStory.variablesState["weekDay"].ToString());
                PlayerPrefs.SetString("timeOfDay", globalVariablesStory.variablesState["timeOfDay"].ToString());


                PlayerPrefs.SetInt("convo_numberCS", int.Parse(globalVariablesStory.variablesState["convo_numberCS"].ToString()));
                PlayerPrefs.SetInt("affectionCS", int.Parse(globalVariablesStory.variablesState["affectionCS"].ToString()));
                PlayerPrefs.SetInt("chaosCS", int.Parse(globalVariablesStory.variablesState["chaosCS"].ToString()));

                PlayerPrefs.SetInt("convo_numberN", int.Parse(globalVariablesStory.variablesState["convo_numberN"].ToString()));
                PlayerPrefs.SetInt("affectionN", int.Parse(globalVariablesStory.variablesState["affectionN"].ToString()));
                PlayerPrefs.SetInt("chaosN", int.Parse(globalVariablesStory.variablesState["chaosN"].ToString()));

                PlayerPrefs.SetInt("convo_numberCC", int.Parse(globalVariablesStory.variablesState["convo_numberCC"].ToString()));
                PlayerPrefs.SetInt("affectionCC", int.Parse(globalVariablesStory.variablesState["affectionCC"].ToString()));
                PlayerPrefs.SetInt("chaosCC", int.Parse(globalVariablesStory.variablesState["chaosCC"].ToString()));

                PlayerPrefs.SetInt("convo_numberM", int.Parse(globalVariablesStory.variablesState["convo_numberM"].ToString()));
                PlayerPrefs.SetInt("affectionM", int.Parse(globalVariablesStory.variablesState["affectionM"].ToString()));
                PlayerPrefs.SetInt("chaosM", int.Parse(globalVariablesStory.variablesState["chaosM"].ToString()));

                PlayerPrefs.SetInt("convo_numberG", int.Parse(globalVariablesStory.variablesState["convo_numberG"].ToString()));
                PlayerPrefs.SetInt("affectionG", int.Parse(globalVariablesStory.variablesState["affectionG"].ToString()));
                PlayerPrefs.SetInt("chaosG", int.Parse(globalVariablesStory.variablesState["chaosG"].ToString()));

                PlayerPrefs.SetInt("convo_numberF", int.Parse(globalVariablesStory.variablesState["convo_numberF"].ToString()));
                PlayerPrefs.SetInt("affectionF", int.Parse(globalVariablesStory.variablesState["affectionF"].ToString()));
                PlayerPrefs.SetInt("chaosF", int.Parse(globalVariablesStory.variablesState["chaosF"].ToString()));

                PlayerPrefs.SetInt("affectionOR", int.Parse(globalVariablesStory.variablesState["affectionOR"].ToString()));
                PlayerPrefs.SetInt("chaosOR", int.Parse(globalVariablesStory.variablesState["chaosOR"].ToString()));
                PlayerPrefs.SetInt("convo_numberOR", int.Parse(globalVariablesStory.variablesState["convo_numberOR"].ToString()));

                QuickSaveVariables();



                PlayerPrefs.Save();
            }
            else
            {
                Debug.LogError("There is no instance of the globalVariablesStory");
            }
        }

        public void LoadVariables()
        {
            globalVariablesStory.variablesState["dayVar"] = PlayerPrefs.GetInt("dayVar");
            globalVariablesStory.variablesState["aptUpgrade"] = PlayerPrefs.GetInt("aptUpgrade");
            globalVariablesStory.variablesState["weekDay"] = PlayerPrefs.GetString("weekDay");
            globalVariablesStory.variablesState["timeOfDay"] = PlayerPrefs.GetString("timeOfDay");

            globalVariablesStory.variablesState["convo_numberCS"]=PlayerPrefs.GetInt("convo_numberCS");
            globalVariablesStory.variablesState["affectionCS"]=PlayerPrefs.GetInt("affectionCS");
            globalVariablesStory.variablesState["chaosCS"] = PlayerPrefs.GetInt("chaosCS");

            globalVariablesStory.variablesState["convo_numberN"] = PlayerPrefs.GetInt("convo_numberN");
            globalVariablesStory.variablesState["affectionN"] = PlayerPrefs.GetInt("affectionN");
            globalVariablesStory.variablesState["chaosN"] = PlayerPrefs.GetInt("chaosN");

            globalVariablesStory.variablesState["convo_numberCC"] = PlayerPrefs.GetInt("convo_numberCC");
            globalVariablesStory.variablesState["affectionCC"] = PlayerPrefs.GetInt("affectionCC");
            globalVariablesStory.variablesState["chaosCC"] = PlayerPrefs.GetInt("chaosCC");

            globalVariablesStory.variablesState["convo_numberM"] = PlayerPrefs.GetInt("convo_numberM");
            globalVariablesStory.variablesState["affectionM"] = PlayerPrefs.GetInt("affectionM");
            globalVariablesStory.variablesState["chaosM"] = PlayerPrefs.GetInt("chaosM");

            globalVariablesStory.variablesState["convo_numberG"] = PlayerPrefs.GetInt("convo_numberG");
            globalVariablesStory.variablesState["affectionG"] = PlayerPrefs.GetInt("affectionG");
            globalVariablesStory.variablesState["chaosG"] = PlayerPrefs.GetInt("chaosG"  );

            globalVariablesStory.variablesState["convo_numberF"] = PlayerPrefs.GetInt("convo_numberF");
            globalVariablesStory.variablesState["affectionF"] = PlayerPrefs.GetInt("affectionF");
            globalVariablesStory.variablesState["chaosF"] = PlayerPrefs.GetInt("chaosF");

            globalVariablesStory.variablesState["chaosOR"] = PlayerPrefs.GetInt("chaosOR");
            globalVariablesStory.variablesState["affectionOR"] = PlayerPrefs.GetInt("affectionOR");
            globalVariablesStory.variablesState["convo_numberOR"] = PlayerPrefs.GetInt("convo_numberOR");


        }
        public void QuickLoadVariables()
        {

            globalVariablesStory.variablesState["dayVar"] = PlayerPrefs.GetInt("dayVarT");
            globalVariablesStory.variablesState["aptUpgrade"] = PlayerPrefs.GetInt("aptUpgradeT");
            globalVariablesStory.variablesState["weekDay"] = PlayerPrefs.GetString("weekDayT");

            globalVariablesStory.variablesState["convo_numberCS"] = PlayerPrefs.GetInt("convo_numberCST");
            globalVariablesStory.variablesState["affectionCS"] = PlayerPrefs.GetInt("affectionCST");
            globalVariablesStory.variablesState["chaosCS"] = PlayerPrefs.GetInt("chaosCST");

            globalVariablesStory.variablesState["convo_numberN"] = PlayerPrefs.GetInt("convo_numberNT");
            globalVariablesStory.variablesState["affectionN"] = PlayerPrefs.GetInt("affectionNT");
            globalVariablesStory.variablesState["chaosN"] = PlayerPrefs.GetInt("chaosNT");

            globalVariablesStory.variablesState["convo_numberCC"] = PlayerPrefs.GetInt("convo_numberCCT");
            globalVariablesStory.variablesState["affectionCC"] = PlayerPrefs.GetInt("affectionCCT");
            globalVariablesStory.variablesState["chaosCC"] = PlayerPrefs.GetInt("chaosCCT");

            globalVariablesStory.variablesState["convo_numberM"] = PlayerPrefs.GetInt("convo_numberMT");
            globalVariablesStory.variablesState["affectionM"] = PlayerPrefs.GetInt("affectionMT");
            globalVariablesStory.variablesState["chaosM"] = PlayerPrefs.GetInt("chaosMT");

            globalVariablesStory.variablesState["convo_numberG"] = PlayerPrefs.GetInt("convo_numberGT");
            globalVariablesStory.variablesState["affectionG"] = PlayerPrefs.GetInt("affectionGT");
            globalVariablesStory.variablesState["chaosG"] = PlayerPrefs.GetInt("chaosGT");

            globalVariablesStory.variablesState["convo_numberF"] = PlayerPrefs.GetInt("convo_numberFT");
            globalVariablesStory.variablesState["affectionF"] = PlayerPrefs.GetInt("affectionFT");
            globalVariablesStory.variablesState["chaosF"] = PlayerPrefs.GetInt("chaosFT");

            globalVariablesStory.variablesState["chaosOR"] = PlayerPrefs.GetInt("chaosORT");
            globalVariablesStory.variablesState["affectionOR"] = PlayerPrefs.GetInt("affectionORT");
            globalVariablesStory.variablesState["convo_numberOR"] = PlayerPrefs.GetInt("convo_numberORT");

            globalVariablesStory.variablesState["BAMLevel"] = PlayerPrefs.GetInt("BAMLevel");
            globalVariablesStory.variablesState["TTMLevel"] = PlayerPrefs.GetInt("TTMLevel");
            globalVariablesStory.variablesState["TBMLevel"] = PlayerPrefs.GetInt("TBMLevel");

            globalVariablesStory.variablesState["currentConvo"] = PlayerPrefs.GetString("currentConvo");

            if (PlayerPrefs.GetString("winStatus") != null)
            {
                globalVariablesStory.variablesState["winState"] = PlayerPrefs.GetString("winStatus");
            }


        }

        
        public void StartListening(Story story)
        {
            //it is important that this is called before listener
            VariablesToStory(story);
            story.variablesState.variableChangedEvent += VariableChanged;
        }

        public void StopListening(Story story)
        {
            story.variablesState.variableChangedEvent -= VariableChanged;
        }

        private void VariableChanged(string name, Ink.Runtime.Object value)
        {
            /*Debug.Log("Variable changed: " + name + " = " + value);
            EditorApplication.isPaused = true;*/
            //only maintain variables that were initialized from the globals ink file
            if (variables.ContainsKey(name))
            {
                variables.Remove(name);
                variables.Add(name, value);
            }
        }

        internal void VariablesToStory(Story story)
        {
            foreach(KeyValuePair<string, Ink.Runtime.Object> variable in variables)
            {
                story.variablesState.SetGlobal(variable.Key, variable.Value);
            }
        }


    }
}
