using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace MultipleViews.Models

{
    /// <summary>
    /// This is the new .NET 3.5 method where each Business Object has its own validation
    /// using the IDataErrorInfo interface
    /// </summary>
    public class Person : IDataErrorInfo
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person()
        {
            this.Age = 0;
            this.Name = "Name";
        }

        #region IDataErrorInfo Members

        public string Error
        {
            get
            {
                return null;
            }
        }


        /// <summary>
        /// Examines the property that was changed and provides the
        /// correct error message based on some rules
        /// </summary>
        /// <param name="name">The property that changed</param>
        /// <returns>a error message string</returns>
        public string this[string name]
        {
            get
            {
                string result = null;

                //basically we need one of these blocks for each property you wish to validate
                switch (name)
                {
                    case "Age":
                        if (this.Age < 0 || this.Age > 150)
                        {
                            result = "Age must not be less than 0 or greater than 150.";
                        }
                        break;

                    case "Name":
                        if (this.Name == string.Empty)
                        {
                            result = "Name can't be empty";
                        }
                        if (this.Name.Length > 5)
                        {
                            result = "Name can't be more than 5 characters";
                        }
                        break;
                }


                return result;
            }
        }
        #endregion

    }
}
