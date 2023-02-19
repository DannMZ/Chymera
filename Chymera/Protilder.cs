using Chymera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chymera
{
    public interface Someone
    {
        string Get_Info_Of_This_One();
        void Set_Name_For_Character(string name);
        void Set_Gender_For_Character(string gender);
        void Set_Image_For_Character(Image Some_Picture);
    }
    public abstract class As : Someone
    {
        public string Job_Of_Character { get; protected set; }
        public abstract void Set_Some_Info(string name,string gender,Image Some_Picture);
        public string Name_Of_Character { get; protected set; }
        public string Gender_Of_Character { get; protected set; }
        protected Image Vyhljad;

        public As() { Name_Of_Character = ""; Gender_Of_Character = "";  }
        public As(As DNA)
        {
            this.Name_Of_Character = DNA.Name_Of_Character;
            this.Gender_Of_Character = DNA.Gender_Of_Character;
            this.Vyhljad = DNA.Jak_Vony_Tam();
            this.Job_Of_Character = DNA.Job_Of_Character;
        }
        public string Get_Info_Of_This_One()
        {
            string Info = "";
            if (Name_Of_Character != ""){Info += "Name: " + Name_Of_Character;
                if (Gender_Of_Character != "") { Info += "\nGender: " + Gender_Of_Character; }}
            else { if (Gender_Of_Character != "") {Info +="Gender: "+ Gender_Of_Character; }}
            return Info;
        }
        public Image Jak_Vony_Tam() {return Vyhljad; }
        public abstract void Set_Name_For_Character(string name);
        public abstract void Set_Gender_For_Character(string gender);
        public abstract void Set_Image_For_Character(Image Some_Picture);
        public abstract As Clone_this_Character();
    }

    public class Hotman : As
    {
        public override void Set_Some_Info(string name, string gender, Image Some_Picture)
        {
            Job_Of_Character = "Hotman";
            Name_Of_Character = name;
            Gender_Of_Character = gender;
            Vyhljad = Some_Picture;
        }
        public Hotman()
        {
            Job_Of_Character = "Hotman";
        }
        public Hotman(Hotman DNA) : base(DNA)
        {
            Job_Of_Character = "Hotman";
        }
        public override void Set_Name_For_Character(string name) { Name_Of_Character = name; }
        public override void Set_Gender_For_Character(string gender) { Gender_Of_Character = gender; }
        public override void Set_Image_For_Character(Image Some_Picture) { Vyhljad = Some_Picture; }
        public override As Clone_this_Character() { return new Hotman(this); }
    }
    public class Weallman : As
    {
        public override void Set_Some_Info(string name, string gender, Image Some_Picture)
        {
            Job_Of_Character = "Weallman";
            Name_Of_Character = name;
            Gender_Of_Character = gender;
            Vyhljad = Some_Picture;
        }
        public Weallman()
        {
            Job_Of_Character = "Weallman";
        }
        public Weallman(Weallman DNA) : base(DNA)
        {
            Job_Of_Character = "Weallman";
        }
        public override void Set_Name_For_Character(string name) { Name_Of_Character = name; }
        public override void Set_Gender_For_Character(string gender) { Gender_Of_Character = gender; }
        public override void Set_Image_For_Character(Image Some_Picture) { Vyhljad = Some_Picture; }
        public override As Clone_this_Character() { return new Weallman(this); }
    }


}
