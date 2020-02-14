## Memento
Memento is a project to assits dementia patients using VR and memory games to treat the lost of memory.


## Developers Guide
This guide is to download the repository and colaborate with the project, there are some rules and steps 
that must be followed before you can commit a change.

### Setup
For Windows users:

1. Download git https://git-scm.com/downloads
2. Create a public github account 
3. Go to 
https://github.com/MCV-Univalle/MementoVR and fork the repository.
4. Create a Unity Project in any local 
folder. Example: C:\Users\myuser\Documents\Unity\repository\memento
5. Switch to Visible 
Meta Files in **Edit** → **Project Settings** → **Editor** → **Version Control Mode** → Visible Meta 
Files
6. Switch to Force Text in **Edit** → **Project Settings** → **Editor** → **Asset Serialization 
Mode** → Force Text 
7. Open git bash (From step 1). 
8. ``` cd "C:\Users\myuser\Documents\Unity\repository" ```
9. ``` git init ```
10. ``` git remote add origin https://github.com/MCV-Univalle/MementoVR.git ```
11. ``` git remote add fork https://github.com/<YOUR GIT HUB USER HERE>/MementoVR.git ```
12. ``` git fetch --all ``` Note: This will take a while until all objects are downloaded.
13. ``` git reset --hard origin/master ``` This will discard all your local changes and just overwrite everything with a copy from the remote branch
