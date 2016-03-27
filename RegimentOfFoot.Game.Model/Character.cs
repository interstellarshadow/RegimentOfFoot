using System;
using System.ComponentModel;
using System.Dynamic;
using Newtonsoft.Json;
using System.Runtime.Serialization;


namespace RegimentOfFoot.Game.Model
{
    public class Character : INotifyPropertyChanged, ISerializable
    {
        #region ISerializable implementation

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        private int age;
        private Date dob;

        private string firstname;
        private string lastname;
        private double renown;

        //Innate Stats
        private double intellect;
        private double physicality;
        private double charisma;

        //Aqcuired Stats
        private double learning;
        private double organization;
        private double strength;
        private double agility;
        private double leadership;
        private double diplomacy;

        private Personaility personality;

        #region Stat Properties

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }

        public Date Dob
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
                OnPropertyChanged("Dob");
            }
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
                OnPropertyChanged("Firstname");
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
                OnPropertyChanged("Lastname");
            }
        }

        public double Renown
        {
            get
            {
                return renown;
            }
            set
            {
                renown = value;
                OnPropertyChanged("Renown");
            }
        }

        public double Intellect
        {
            get
            {
                return intellect;
            }
            set
            {
                intellect = value;
                OnPropertyChanged("Intellect");
            }
        }

        public double Physicality
        {
            get
            {
                return physicality;
            }
            set
            {
                physicality = value;
                OnPropertyChanged("Physicality");
            }
        }

        public double Charisma
        {
            get
            {
                return charisma;
            }
            set
            {
                charisma = value;
                OnPropertyChanged("Charisma");
            }
        }

        public double Learning
        {
            get
            {
                return learning;
            }
            set
            {
                learning = value;
                OnPropertyChanged("Learning");
            }
        }

        public double Organization
        {
            get
            {
                return organization;
            }
            set
            {
                organization = value;
                OnPropertyChanged("Organization")
            }
        }

        public double Strength
        {
            get
            {
                return strength;
            }
            set
            {
                strength = value;
                OnPropertyChanged("Strength");
            }
        }

        public double Agility
        {
            get
            {
                return agility;
            }
            set
            {
                agility = value;
                OnPropertyChanged("Agility");
            }
        }

        public double Leadership
        {
            get
            {
                return leadership;
            }
            set
            {
                leadership = value;
                OnPropertyChanged("Leadership");
            }
        }

        public double Diplomacy
        {
            get
            {
                return diplomacy;
            }
            set
            {
                diplomacy = value;
                OnPropertyChanged("Diplomacy");
            }
        }

        #endregion

        public Character()
        {
            
        }
    }
}

