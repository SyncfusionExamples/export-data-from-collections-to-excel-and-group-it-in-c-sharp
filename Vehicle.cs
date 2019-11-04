#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ImportNestedCollection
{
    #region Import Classes

    [XmlRootAttribute("BrandObjects")]
    public class BrandObjects
    {
        [XmlElement("BrandObject")]
        public BrandObject[] BrandObject { get; set; }
    }
    public class BrandObject
    {
        public string BrandName { get; set; }
        public string VehicleType { get; set; }
        public string ModelName { get; set; }
    }

    //Parent Class
    public class Brand
    {
        private string m_brandName;
        [DisplayNameAttribute("Brand")]
        public string BrandName
        {
            get { return m_brandName; }
            set { m_brandName = value; }
        }

        //Vehicle Type Collection
        private IList<VehicleType> m_vehicleTypes;
        public IList<VehicleType> VehicleTypes
        {
            get { return m_vehicleTypes; }
            set { m_vehicleTypes = value; }
        }

        public Brand(string brandName)
        {
            m_brandName = brandName;
        }
    }

    //Child Class
    public class VehicleType
    {
        private string m_vehicleName;
        [DisplayNameAttribute("Vehicle Type")]
        public string VehicleName
        {
            get { return m_vehicleName; }
            set { m_vehicleName = value; }
        }

        //Models collection
        private IList<Model> m_models;
        public IList<Model> Models
        {
            get { return m_models; }
            set { m_models = value; }
        }

        public VehicleType(string vehicle)
        {
            m_vehicleName = vehicle;
        }
    }

    //Sub-child Class
    public class Model
    {
        private string m_modelName;
        [DisplayNameAttribute("Model")]
        public string ModelName
        {
            get { return m_modelName; }
            set { m_modelName = value; }
        }

        public Model(string name)
        {
            m_modelName = name;
        }
    }
    #endregion

}
