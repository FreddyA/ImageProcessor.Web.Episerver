﻿using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using ImageProcessor.Web.Episerver.UI.Business;

namespace ImageProcessor.Web.Episerver.UI.Models.Blocks
{
    [ContentType(DisplayName = "Mask", 
        GUID = "fdc324b5-b3b6-4ad7-b19e-b8b70712dc06", 
        Description = "Applies the given image mask to the current image.", 
        GroupName = Global.GroupName, 
        Order = 17)]
    [Icon]
    public class MaskBlock : ImageProcessorMethodBaseBlock
    {
        public virtual int X { get; set; }
        public virtual int Y { get; set; }
        [Display(Name = "Mask Image")]
        public virtual string Mask { get; set; }
    }
}