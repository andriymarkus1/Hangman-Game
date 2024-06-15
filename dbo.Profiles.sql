CREATE TABLE [dbo].[Profiles] (
    [Id]                  INT           IDENTITY (1, 1) NOT NULL DEFAULT 0,
    [Login]               NVARCHAR (50) DEFAULT (user_name()) NULL,
    [Password]            NVARCHAR (50) DEFAULT ((123)) NULL,
    [Numb_Of_Dashes]      INT           DEFAULT ((0)) NULL,
    [Is_Last_Login_in]    BIT           DEFAULT ((0)) NULL,
    [Is_Gallows_1_Bought] BIT           DEFAULT ((0)) NULL,
    [Is_Gallow_2_Bought]  BIT           DEFAULT ((0)) NULL,
    [Is_Skin_1_Bought]    BIT           DEFAULT ((0)) NULL,
    [Is_Skin_2_Bought]    BIT           DEFAULT ((0)) NULL,
    [Is_Gallows_1_Set]    BIT           DEFAULT ((0)) NULL,
    [Is_Gallows_2_Set]    BIT           DEFAULT ((0)) NULL,
    [Is_Skin_1_Set]       BIT           DEFAULT ((0)) NULL,
    [Is_Skin_2_Set]       BIT           DEFAULT ((0)) NULL,
    [Is_Gallows_0_Bought] BIT           DEFAULT ((1)) NULL,
    [Is_Skin_0_Bought]    BIT           DEFAULT ((1)) NULL,
    [Is_Gallows_0_Set]    BIT           DEFAULT ((1)) NULL,
    [Is_Skin_0_Set]       BIT           DEFAULT ((1)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

