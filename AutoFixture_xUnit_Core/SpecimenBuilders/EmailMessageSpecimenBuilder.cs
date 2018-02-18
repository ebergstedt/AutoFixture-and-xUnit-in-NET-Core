using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using AutoFixture.Kernel;

namespace AutoFixture_xUnit_Core.SpecimenBuilders
{
    public class EmailMessageSpecimenBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            var propertyInfo = request as PropertyInfo;

            if (propertyInfo == null)
                return new NoSpecimen();

            var isBodyProperty = propertyInfo.Name == "Body" && propertyInfo.PropertyType == typeof(string);

            if (isBodyProperty)
            {
                return GetBodyValue();
            }

            return new NoSpecimen();
        }

        private string GetBodyValue()
        {
            return "BODY";
        }
    }
}
