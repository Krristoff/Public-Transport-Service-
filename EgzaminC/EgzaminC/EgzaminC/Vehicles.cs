using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminC
{
    public enum FuelTypeEnum { electric, gas , hybrid }
    public enum EnumTypStatus { needRepair,inOperation,forScrap }
    internal class Vehicles
    {
        int id; 
        string numPlate;
        int maxCapacity;
        FuelTypeEnum type;
        EnumTypStatus status;
        DateTime lastServiceDate;
        static int currentId = 1;

        public Vehicles( string numPlate, int maxCapacity, DateTime lastServiceDate)
        {
            Id = currentId;
            NumPlate = numPlate;
            MaxCapacity = maxCapacity;
            LastServiceDate = lastServiceDate;
            SpecifyState();
            CurrentId++;
        }

        public int Id { get => id; set => id = value; }
        public string NumPlate { get => numPlate; set => numPlate = value; }
        public int MaxCapacity { get => maxCapacity; set => maxCapacity = value; }
        public FuelTypeEnum Type { get => type; set => type = value; }
 
        public DateTime LastServiceDate { get => lastServiceDate; set => lastServiceDate = value; }
        public EnumTypStatus Status { get => status; set => status = value; }
        public static int CurrentId { get => currentId; set => currentId = value; }

        public virtual void SpecifyState()
        {
            DateTime today = DateTime.Now;
            TimeSpan difference = today - LastServiceDate;
            int daysSinceService = difference.Days;
            if (daysSinceService >= 37)
            {
                Status = EnumTypStatus.forScrap;

            }
            else if (daysSinceService >= 7)
            {
                Status = EnumTypStatus.needRepair;
            }
            else
            {
                Status = EnumTypStatus.inOperation;
            }
        }
            public override string ToString()
        {
            return $"Id: {id}, Number Plate: {NumPlate},: Max Capcity : {MaxCapacity}, Type: {type}";
        }
        }
    }

