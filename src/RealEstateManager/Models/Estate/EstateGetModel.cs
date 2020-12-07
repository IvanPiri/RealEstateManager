﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealEstateManager.Properties;
using System.ComponentModel.DataAnnotations;
using RealEstateManager.Models.Data;
using RealEstateManager.Models.BuildingInfo;

namespace RealEstateManager.Models.Estate
{
    public class EstateGetModel
    {
        public Guid Id { get; set; }

        [Display(
            Name = "EstateModel_Name",
            ResourceType = typeof(Resources))]
        public string Name { get; set; }

        [Display(
            Name = "EstateModel_Type",
            ResourceType = typeof(Resources))]
        public EstateType Type { get; set; }

        [Display(
            Name = "EstateModel_Price",
            ResourceType = typeof(Resources))]
        public decimal Price { get; set; }

        [Display(
            Name = "EstateModel_Status",
            ResourceType = typeof(Resources))]
        public EstateStatusType Status { get; set; }

        [Display(
            Name = "EstateModel_Address",
            ResourceType = typeof(Resources))]
        public string Address { get; set; }

        [Display(
            Name = "EstateModel_PublicDescription",
            ResourceType = typeof(Resources))]
        public string PublicDescription { get; set; }

        [Display(
            Name = "EstateModel_PublicDescription",
            ResourceType = typeof(Resources))]
        public string PrivateDescription { get; set; }

        [Display(
            Name = "EstateModel_Area",
            ResourceType = typeof(Resources))]
        public double Area { get; set; }

        public Data.BuildingInfo BuildingInfo { get; set; }

        public BuildingInfoGetModel getBuildingInfoModel()
        {
            return new BuildingInfoGetModel
            {
                Act16 = BuildingInfo.Act16,
                View = BuildingInfo.View,
                Floors = BuildingInfo.Floors,
                Bedrooms = BuildingInfo.Bedrooms,
                Bathrooms = BuildingInfo.Bathrooms,
                Balconies = BuildingInfo.Balconies,
                Garages = BuildingInfo.Garages
            };
        }
    }
}