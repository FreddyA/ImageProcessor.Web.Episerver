﻿using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using ImageProcessor.Web.Episerver.UI.Business;

namespace ImageProcessor.Web.Episerver.UI.Models.Blocks
{
    [ContentType(DisplayName = "Sharpen",
        GUID = "b47901f9-d24b-4d4e-a9f2-8b3e0caf8ebf", 
        Description = "Uses a Gaussian kernel to sharpen the current image.", 
        GroupName = Global.GroupName, 
        Order = 28)]
    [Icon]
    public class SharpenBlock : ImageProcessorMethodBaseBlock
    {
        public virtual int Kernelsize { get; set; }
        public virtual double Sigma { get; set; }
        public virtual int Threshold { get; set; }
    }
}