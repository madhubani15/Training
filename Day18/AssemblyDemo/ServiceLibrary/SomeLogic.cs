using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ServiceLibrary
{
    public class SomeLogic
    {
        //Defining Attriutes
        #region Attributes
        int id;
        string name;
        string addr;
        #endregion

        //Defining Properties (CLR Properties)
        #region Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Addr
        {
            get { return addr; }
            set { addr = value; }
        }
        #endregion

        public SomeLogic()
        {

        }
        public SomeLogic(int yourID, string yourName, string yourAddress)
        {

        }
        #region Methods

        public int AddMe(int num1, int num2)
        {
            return num1 + num2;
        }
        public List<Object> ShowAll()
        {
            return new List<Object>();
        }

        public List<Player> ShowAllPlayers()
        {
            return new List<Player>()
            {
                new Player(){PlayerID = 1,PlayerName="Virat",Skills=new List<string>{"Batsmen","Fielder"}},
                new Player(){PlayerID = 2,PlayerName="Rohit",Skills=new List<string>{"Batsmen","Fielder"}},
                new Player(){PlayerID = 3,PlayerName="Bumrah",Skills=new List<string>{"Fast Bowler","Fielder"}},

            };
        }
        #endregion
    }
}