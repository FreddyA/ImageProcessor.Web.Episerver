﻿using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using ImageProcessor.Web.Episerver.UI.Business;

namespace ImageProcessor.Web.Episerver.UI.Models.Blocks
{
    [ContentType(DisplayName = "Tint",
        GUID = "6150367c-3f59-4e4d-b96b-68b0c6fc3a2d", 
        Description = "Tints the current image with the given color.", 
        GroupName = Global.GroupName, 
        Order = 29)]
    [Icon]
    public class TintBlock : ImageProcessorMethodBaseBlock
    {
        [Display(Name = "Color")]
        [UIHint("ColorPicker")]
        public virtual string Tint { get; set; }
    }
}