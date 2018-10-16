using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Drawing;
using System.Windows.Forms;

namespace DooGame
{
    class CScene
    {
        public List<Image> theImages;
        //        public List<String> theSubscriptions;
        public List<String> theTexts;
        public List<String> theNextScenes;
        public List<String> STexts;
        public List<String> Textbox;

        public String theID;

        public int theTextIndex;

        public CScene(String aID)
        {
            theID = aID;
            theTextIndex = 0;

            theImages = new List<Image>();
            theTexts = new List<string>();
            theNextScenes = new List<string>();
            STexts = new List<string>();
            Textbox = new List<string>();
        }

        public void NextWord()
        {
            theTextIndex++;
        }

        public string GetCurrentText()
        {
            return (STexts[theTextIndex]);
        }

        public void AddImageAndText(Image aImage)
        {
            theImages.Add(aImage);
        }

        public void AddButton(String aText, String aSceneID)
        {
            theTexts.Add(aText);
            theNextScenes.Add(aSceneID);
        }

        public void AddText(String Texts)
        {
            STexts.Add(Texts);
        }

        public void AddTextbox(String Texts)
        {
            Textbox.Add(Texts);
        }

        public Boolean VisibleCheck(Boolean check)
        {
            return check;
        }

        public virtual void CheckNextWord()
        {

        }


        public virtual void CheckNextScene()
        {

        }

    }
}
