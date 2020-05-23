using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Assignment.Core
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class AtLeastOneAttribute: ValidationAttribute
    {
        public List<string> PropertiesInGroup { get; set; }
        public AtLeastOneAttribute(params string[] props)
        {
            PropertiesInGroup = new List<string>(props);
        }
        public override bool IsValid(object value)
        {
            bool HasFilledProps = PropertiesInGroup.Exists(propName => {
                PropertyInfo prop = value.GetType().GetProperty(propName);
                return prop != null && prop.GetValue(value, null) != null;
            });
            
            return HasFilledProps;
        }
    }

}