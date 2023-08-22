# Find Prefabs with Script Tool

The "Find Prefabs with Script" tool is a custom utility for Unity Editor that enables you to locate prefabs containing a specific script. This tool provides a user-friendly interface within the Unity Editor to facilitate the search process.

## Unity Version

This project was created using Unity 2021.3.15f1 LTS.

## Usage
1. Open Unity Editor.
2. Navigate to the "Custom Tools" menu.<>
3. Select "Find Prefabs with Script" to open the tool's window.
4. In the window, you can do the following:

   - Choose a script: Use the "Script" field to select the script you want to search for.
   - Search in children (optional): Toggle the "Search In Children" option to include child objects in the search.
   - Find: Click the "Find" button to initiate the search.

5. The tool will display a list of prefabs that containing a specific script or scripts derived from it.<br />
![1](https://github.com/SonmezCankurt/FindPrefabsWithScript/assets/24636097/df9401ca-f077-484a-9bdf-07841185a890)
![2](https://github.com/SonmezCankurt/FindPrefabsWithScript/assets/24636097/cc3777ea-c74c-4fe8-a8f3-6dc993feb0a9)
![3](https://github.com/SonmezCankurt/FindPrefabsWithScript/assets/24636097/f03b4132-8d4b-4e74-86ca-c3d68ddb245e)
![4](https://github.com/SonmezCankurt/FindPrefabsWithScript/assets/24636097/68771b09-612c-4b0f-940f-9496ec930b23)


## Features

- Search for prefabs containing a specific script.
- Option to include child objects in the search.
- Visual representation of the search results in a scrollable window.

## Notes

- The tool relies on Unity's AssetDatabase to search for prefabs. It locates prefabs by scanning the project assets.
- The "Search In Children" option determines whether the search should include child objects of prefabs.
- The tool takes advantage of Unity's MonoBehaviour scripting framework.
