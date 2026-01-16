using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLogic
{
    //If it only can be applied on field
    //[AttributeUsage(AttributeTargets.Field)]
    //It shows where it will be applied
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method, AllowMultiple =true)]
    public class DoctorAttribute : Attribute
    {
        #region properties
        public string Name { get; set; }
        public string CheckedOnDate { get; set; }
        #endregion
    }
}