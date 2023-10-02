using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using System.IO;
namespace InterDineMension
{
    public class DialogueVariables
    {
        public Dictionary<string, Ink.Runtime.Object> variables {  get; private set; }

        public DialogueVariables(string globalsFilePath)
        {
            //compiles the story
            string inkFileContents=File.ReadAllText(globalsFilePath);
            Ink.Compiler compiler=new Ink.Compiler(inkFileContents);
            Story globalVarialbesStory = compiler.Compile();

            //Initialize dictionary
            variables = new Dictionary<string, Ink.Runtime.Object>();
            foreach(string name in globalVarialbesStory.variablesState)
            {
                Ink.Runtime.Object value = globalVarialbesStory.variablesState.GetVariableWithName(name);
                variables.Add(name, value);
                Debug.Log("Initialized global Dialogue Variable: " + name + " = " + value);
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
            Debug.Log("Variable changed: " + name + " = " + value);
            //only maintain variables that were initialized from the globals ink file
            if (variables.ContainsKey(name))
            {
                variables.Remove(name);
                variables.Add(name, value);
            }
        }

        private void VariablesToStory(Story story)
        {
            foreach(KeyValuePair<string, Ink.Runtime.Object> variable in variables)
            {
                story.variablesState.SetGlobal(variable.Key, variable.Value);
            }
        }
    }
}
