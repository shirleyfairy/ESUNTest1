CREATE TABLE [dbo].[MarriageInfo] (
    [statistic_yyy] NVARCHAR (50) NOT NULL,
    [according]     NVARCHAR (50) NOT NULL,
    [site_id]       NVARCHAR (50) NOT NULL,
    [marriage_type] NVARCHAR (50) NOT NULL,
    [female_age]    NVARCHAR (50) NOT NULL,
    [male_age]      NVARCHAR (50) NOT NULL,
    [marry_pair]    NVARCHAR (50) NULL,
    CONSTRAINT [PK_MarriageInfo] PRIMARY KEY CLUSTERED ([marriage_type] ASC, [statistic_yyy] ASC, [according] ASC, [site_id] ASC, [female_age] ASC, [male_age] ASC)
);

