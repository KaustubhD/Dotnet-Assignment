using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Assignment.Core
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class AtLeastOneAttribute: ValidationAttribute
    {
        public string[] PropertiesInGroup { get; set; }
        public AtLeastOneAttribute(params string[] props)
        {
            PropertiesInGroup = props;
        }
        public override bool IsValid(object value)
        {
            foreach(string PropName in PropertiesInGroup)
            {
                PropertyInfo prop = value.GetType().GetProperty(PropName);
                if(prop != null && prop.GetValue(value, null) != null)
                {
                    return true;
                }
            }
            return false;
        }
    }

}