CREATE DATABASE PROJECT_COMPROG;
GO


USE PROJECT_COMPROG;
GO


CREATE TABLE CHARACTER_SELECTION (
    characterId        INT           IDENTITY(1,1) NOT NULL,
    characterName      NVARCHAR(50)  NOT NULL,
    gender             NVARCHAR(20)  NOT NULL,
    age                NVARCHAR(20)  NOT NULL,
    origin             NVARCHAR(50)  NOT NULL,
    skinColor          NVARCHAR(50)  NULL,
    hairStyle          NVARCHAR(50)  NULL,
    hairColor          NVARCHAR(50)  NULL,
    eyeColor           NVARCHAR(50)  NULL,
    bodySize           NVARCHAR(50)  NULL,
    height             NVARCHAR(50)  NULL,
    overall            NVARCHAR(50)  NULL,
    tops               NVARCHAR(50)  NULL,
    bottoms            NVARCHAR(50)  NULL,
    shoes              NVARCHAR(50)  NULL,
    faceAccessories    NVARCHAR(50)  NULL,
    wristAccessories   NVARCHAR(50)  NULL,
    backAccessories    NVARCHAR(50)  NULL,
    neckAccessories    NVARCHAR(50)  NULL,
    headAccessories    NVARCHAR(50)  NULL,
    skinAccessories    NVARCHAR(50)  NULL,
    armor              NVARCHAR(50)  NULL,
    weapons            NVARCHAR(50)  NULL,
    idlePosture        NVARCHAR(50)  NULL,
    fightingStyle      NVARCHAR(50)  NULL,
    splashBackground   NVARCHAR(50)  NULL,
    voiceType          NVARCHAR(50)  NULL,
    emotes             NVARCHAR(50)  NULL,
    entranceAnimation  NVARCHAR(50)  NULL,
    victoryAnimation   NVARCHAR(50)  NULL,
    defeatAnimation    NVARCHAR(50)  NULL,
    facialHair         BIT           NULL,
    arms               INT           NULL,
    heads              INT           NULL,
    eyes               INT           NULL,
    legs               INT           NULL,
    PRIMARY KEY CLUSTERED (characterId ASC)
);
GO