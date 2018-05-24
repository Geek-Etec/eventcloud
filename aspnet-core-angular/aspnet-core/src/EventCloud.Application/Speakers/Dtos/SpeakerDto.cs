﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EventCloud.Speakers.Dtos
{
    using Abp.Application.Services.Dto;
    using Abp.AutoMapper;

    [AutoMapFrom(typeof(Speaker))]
    public class SpeakerDto : FullAuditedEntityDto<Guid>
    {
        public const int MaxTitleLength = 128;
        public const int MaxDescriptionLength = 2048;

        public virtual string profilePic { get; set; }

        [Required]
        [StringLength(MaxTitleLength)]
        public virtual string Name { get; set; }

        [Required]
        [StringLength(MaxTitleLength)]
        public virtual string Title { get; set; }

        [Required]
        [StringLength(MaxDescriptionLength)]
        public virtual string About { get; set; }

        [StringLength(MaxDescriptionLength)]
        public virtual string Twitter { get; set; }

        [StringLength(MaxDescriptionLength)]
        public virtual string GitHub { get; set; }

        [StringLength(MaxDescriptionLength)]
        public virtual string Instagram { get; set; }

        [Required]
        public virtual bool IsActive { get; set; }
    }
}
