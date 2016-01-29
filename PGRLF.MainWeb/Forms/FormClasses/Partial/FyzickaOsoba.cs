﻿using Foolproof;
using PGRLF.MainWeb.Forms.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace PGRLF.MainWeb.Forms.FormClasses.Partial
{
    public class FyzickaOsoba
    {

        public FyzickaOsoba()
        {
            TitulPredJmenem = null;
            Jmeno = null;
            Prijmeni = null;
            TitulZaJmenem = null;
            DatumNarozeni = null;
            RodneCislo = null;
            IC = null;
            DIC = null;
        }

        //Osobní údaje

        [Display(GroupName = "fyzickaOsoba", ResourceType = typeof(FormResources), Name = "TitulPredJmenem")]
        public string TitulPredJmenem { get; set; }

        [Display(GroupName = "fyzickaOsoba", ResourceType = typeof(FormResources), Name = "KrestniJmeno")]
        [Required(ErrorMessageResourceType = typeof(FormResources), ErrorMessageResourceName = "Nevyplneno_Jmeno")]
        public string Jmeno { get; set; }

        [Display(GroupName = "fyzickaOsoba", ResourceType = typeof(FormResources), Name = "Prijmeni")]
        [Required(ErrorMessageResourceType = typeof(FormResources), ErrorMessageResourceName = "Nevyplneno_Prijmeni")]
        public string Prijmeni { get; set; }

        [Display(GroupName = "fyzickaOsoba", ResourceType = typeof(FormResources), Name = "TitulZaJmenem")]
        public string TitulZaJmenem { get; set; }

        [Display(GroupName = "fyzickaOsoba", ResourceType = typeof(FormResources), Name = "DatumNarozeni")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(FormResources), ErrorMessageResourceName = "Chyba_DatumNarozeni")]
        [Required(ErrorMessageResourceType = typeof(FormResources), ErrorMessageResourceName = "Nevyplneno_DatumNarozeni")]
        public DateTime? DatumNarozeni { get; set; }

        [Display(GroupName = "fyzickaOsoba", ResourceType = typeof(FormResources), Name = "RodneCislo")]
        [DisplayFormat(NullDisplayText = "------/--", ConvertEmptyStringToNull = true)]
        [RegularExpression("(\\d)(\\d)(\\d)(\\d)(\\d)(\\d)(\\/)(\\d)(\\d)(\\d)(\\d)?",
            ErrorMessageResourceType = typeof(FormResources),
            ErrorMessageResourceName = "Chyba_RodneCislo")]
        [Required(ErrorMessageResourceType = typeof(FormResources), ErrorMessageResourceName = "Nevyplneno_RodneCislo")]
        public string RodneCislo { get; set; }

        [Display(GroupName = "fyzickaOsoba", ResourceType = typeof(FormResources), Name = "IC")]
        [Required(ErrorMessageResourceType = typeof(FormResources), ErrorMessageResourceName = "Nevyplneno_IC")]
        public string IC { get; set; }

        [Display(GroupName = "fyzickaOsoba", ResourceType = typeof(FormResources), Name = "DIC")]
        [Required(ErrorMessageResourceType = typeof(FormResources), ErrorMessageResourceName = "Nevyplneno_DIC")]
        public string DIC { get; set; }

        public Adresa TrvalyPobyt { get; set; }

        public bool FOJeMistoPodnikaniStejne { get; set; }

        public Adresa MistoPodnikani { get; set; }

        /*public void nastavMistoPodnikani()
        {
            if (FOJeMistoPodnikaniStejne)
            {
                MistoPodnikani.Ulice = TrvalyPobyt.Ulice;
                MistoPodnikani.CisloPopisne = TrvalyPobyt.CisloPopisne;
                MistoPodnikani.CisloOrientacni = TrvalyPobyt.CisloOrientacni;
                MistoPodnikani.Obec = TrvalyPobyt.Obec;
                MistoPodnikani.PSC = TrvalyPobyt.PSC;
                MistoPodnikani.Kraj = TrvalyPobyt.Kraj;
            }
        }*/
    }
}