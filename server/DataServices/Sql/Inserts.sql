﻿USE [Keycost2023]
GO

INSERT INTO [Users]
           ([UserName],[CreateBy],[CreatedOn],[UpdatedOn])
     VALUES
           ("EmperorJohn","Hand","30/06/2022","30/06/2022"),
            ("Superman","Hand","30/06/2022","30/06/2022"),
             ("Batman","Hand","30/06/2022","30/06/2022"),
              ("Ironman","Hand","30/06/2022","30/06/2022"),
           ("Thor","Hand","30/06/2022","30/06/2022")
          

          INSERT INTO [UserCategory]
          ([Name],[Description],[CreatedOn],[UpdatedOn])
          VALUES
                ("Cleaning","House Car Cloths and Me","30/06/2022","30/06/2022"),
            ("Supermarket","Big Buy delivered","30/06/2022","30/06/2022"),
             ("Transport","Public Transport","30/06/2022","30/06/2022"),
              ("Telephone","SIM2","30/06/2022","30/06/2022"),
           ("Meals","Hand to mouth - on the move","30/06/2022","30/06/2022")


           INSERT INTO [CostAmount]
          ([Cost],[Description],[CreatedOn],[UpdatedOn])
          VALUES
                ("12","Paper Towls","30/06/2022","30/06/2022"),
            (22,"Fresh Vegatbles","30/06/2022","30/06/2022")
             