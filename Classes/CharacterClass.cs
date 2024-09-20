namespace CyberpunkRedCharacterCreator.Classes
{
    internal class CharacterClass
    {
        public string Kind { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public string Field6 { get; set; }
        public string Field7 { get; set; }
        public CharacterClass() { }


        //Exec and Medtech and Rockerboy and Fixer and Nomad
        public CharacterClass(string kind, string division, string ethics, string location, string enemy, string boss) 
        {
            this.Kind = kind;
            Field2 = division;
            Field3 = ethics;
            Field4 = location;
            Field5 = enemy;
            Field6 = boss;
            Field7 = null;
        }

        /*
        public CharacterClass(string kind, string workspace, string partner, string partner_who, string clients, string supplies)
        {
            this.Kind = kind;
            Field2 = partner;
            Field3 = partner_who;
            Field4 = clients;
            Field5 = supplies;
            Field6 = null;
            Field7 = null;
            Field8 = null;
            Field9 = null;
            Field10 = null;
        }
        */
        /*
         public CharacterClass(string kind, string group, string group_past, string leave_reason, string venue, string enemy)
        {
            this.Kind = Kind;
            Field2 = group;
            Field3 = group_past;
            Field4 = leave_reason;
            Field5 = enemy;
            Field6 = venue;
            Field7 = enemy;
            Field8 = null;
            Field9 = null;
            Field10 = null;
        }
         */
        /*
         public CharacterClass(string kind, string office, string partner, string partner_who, string clients, string enemy) 
        {
            this.Kind= kind;
            Field2 = office;
            Field3 = partner;
            Field4 = partner_who;
            Field5 = clients;
            Field6 = enemy;
            Field7 = null;
            Field8 = null;
            Field9 = null;
            Field10 = null;
        }
         */
        /*
         public CharacterClass(string kind, string territory, string group_goal, string role, string enemy, string philosophy) 
        {
            this.Kind= kind;
            Field2 = territory;
            Field3 = group_goal;
            Field4 = role;
            Field5 = enemy;
            Field6 = philosophy;
            Field7 = null;
            Field8 = null;
            Field9 = null;
            Field10 = null;
        }
         */

        //Lawman
        public CharacterClass(string kind, string jurisdiction, string corruption, string enemy, string target) 
        { 
            this.Kind= kind;
            Field2 = jurisdiction;
            Field3 = corruption;
            Field4 = enemy;
            Field5 = target;
            Field6 = null;
            Field7 = null;
        }

        //Media and Solo
        public CharacterClass(string kind, string ethics, string publicc, string stroies) 
        { 
            this.Kind = kind;
            Field2 = ethics;
            Field3 = publicc;
            Field4 = stroies;
            Field5 = null;
            Field6 = null;
            Field7 = null;
        }

        /*
         public CharacterClass(string kind, string territory, string enemy, string compass)
        {
            this.Kind = kind;
            Field2 = territory;
            Field3 = enemy;
            Field4 = compass;
            Field5 = null;
            Field6 = null;
            Field7 = null;
            Field8 = null;
            Field9 = null;
            Field10 = null;
        }
         */

        //Netrunner and Tech
        public CharacterClass(string kind, string partner, string partner_who, string workspace, string clients, string programs, string enemy)
        {
            this.Kind = Kind;
            Field2 = partner;
            Field3 = partner_who;
            Field4 = workspace;
            Field5 = clients;
            Field6 = programs;
            Field7 = enemy;
        }
        /*
        public CharacterClass(string kind, string partner, string partner_who, string workspace, string clients, string supplies, string enemy)
        {
            this.Kind = kind;
            Field2 = partner;
            Field3 = partner_who;
            Field4 = workspace;
            Field5 = clients;
            Field6 = supplies;
            Field7 = enemy;
            Field8 = null;
            Field9 = null;
            Field10 = null;
        }
        */        
    }
}
