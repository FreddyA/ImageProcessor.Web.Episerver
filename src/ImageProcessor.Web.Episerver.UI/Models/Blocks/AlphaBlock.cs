﻿using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using ImageProcessor.Web.Episerver.UI.Business;

namespace ImageProcessor.Web.Episerver.UI.Models.Blocks
{
    [ContentType(DisplayName = "Alpha",
        GUID = "438f850d-42e9-4806-986b-c01b9321a1f2",
        Description = "Adjusts the alpha transparency of images.",
        GroupName = Global.GroupName,
        Order = 1)]
    [Icon]
    public class AlphaBlock : ImageProcessorMethodBaseBlock
    {
        [Display(Name = "Percentage", Description = "The desired transparency percentage")]
        [Range(-99, 99)]
        public virtual int Alpha { get; set; }
    }
}