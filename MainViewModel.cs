using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace antibiotikerkarte
{

    public class MainViewModel
    {
        private Infection _oldInfection;

        public ObservableCollection<Infection> Infections { set; get; }
        public MainViewModel()
        {
            Infections = new ObservableCollection<Infection>
         {
              new Infection
                {
                    InfectionName = "Fieber ohne klaren Fokus, <3 Monate",
                    Meds ="Ampicillin i.v. 150 mg/kg/Tag in 3 ED plus Tobramycin i.v. 4mg/kg/Tag in ED als KI",
                    IsVisible = false
                },
              new Infection
                {
                    InfectionName = "Fieber ohne klaren Fokus, >3 Monate",
                    Meds ="Cefotaxim i.v. 100 mg/kg/Tag in 3 ED",
                    IsVisible = false
                },
              new Infection
                {
                    InfectionName = "Fieber in Neutropenie",
                    Meds ="Piperacillin-Tazobactam i.v. 300 mg/kg/Tag in 3 ED (max. 4 g/ED)",
                    IsVisible = false
                },
              new Infection
                {
                    InfectionName = "ZNS: Meningoencephalitis",
                    Meds ="Aciclovir i.v. < 1 Jahr 60 mg/kg/Tag in 3 ED; > 1 Jahr 45 mg/kg/Tag in 3 ED plus Cefotaxim 200 mg/kg/Tag in 3 ED",
                    IsVisible = false
              },
              new Infection
              {
                  InfectionName = "ZNS: Meningitis <3 Monate",
                  Meds = "Ampicillin i.v. 300 mg/kg/Tag in 3 ED plus Tobramycin i.v. 4mg/kg/Tag als ED plus Cefotaxim i.v. 200 mg/kg/Tag in 3 ED (ggf. Aciclovir i.v. (s.o.) bis HSV neg.)",
                  Color = "#EF233C"
              },
              new Infection
              {
                  InfectionName = "ZNS: Meningitis  >3 Monate",
                  Meds = "Cefotaxim i.v. 200 mg/kg/Tag in 3 ED",
                  Color = "#EF233C"
              },
              new Infection
                {
                    InfectionName = "Pneumonie: Neugeborenes",
                    Meds ="Ampicillin i.v. 150 mg/kg/Tag in 3 ED plus Cefotaxim i.v. 150 mg/kg/Tag in 3 ED",
                    IsVisible = false
              },
              new Infection
                {
                    InfectionName = "Pneumonie: ambulant erworben 4 Wochen bis 6 Monate",
                    Meds ="Cefuroxim i.v. 120 mg/kg/Tag in 3 ED",
                    IsVisible = false
              },
              new Infection
                {
                    InfectionName = "Pneumonie: ambulant erworben  >6 Monate",
                    Meds ="Ampicillin i.v. 150 mg/kg/Tag in 3 ED (max. 2 /ED) oder Amoxicillin p.os 90 mg/kg/Tag in 3 ED (max. 1,5 g/ED)",
                    IsVisible = false
              },
              new Infection
                {
                    InfectionName = "Pneumonie: atypisch",
                    Meds ="Clarithromycin p.os 15 mg/kg/Tag in 2 ED (max. 500 mg/ED), ab 8. Ljahr Doxycyclin 3 mg/kg p.os in 1 ED",
                    IsVisible = false
              },
              new Infection
                {
                    InfectionName = "Pneumonie: noskomial",
                    Meds ="Piperacillin-Tazobactam i.v. 300 mg/kg/Tag in 3 ED (max. 4 g/ED)",
                    IsVisible = false
              },
              new Infection
              {
                  InfectionName = "HNO: Tonsillitis/Pharyngitis",
                  Meds = "Antibiotikum nicht erste Wahl! \nbei Strept. A positiv: Penicillin V p.os 100.000 IE/kg/Tag in 3 ED (max. 2 Mio. IE/ED) für 7 Tage",
                  Color = "#EF233C"
              },
              new Infection
              {
                  InfectionName = "HNO: akute Otitis media/ akute Sinusitis",
                  Meds = "Antibiotikum nicht erste Wahl! \nAmoxicillin p.os 90 mg/KG/Tag in 3 ED",
                  Color = "#EF233C"
              },
              new Infection
              {
                  InfectionName = "HNO: maligne Otitis externa",
                  Meds = "Ceftazidim i.v. 150 mg/kg/Tag in 3 ED (max. 1,5 g/ED) plus lokal Ciprofloxacin Ohrentropfen",
                  Color = "#EF233C"
              },
              new Infection
              {
                  InfectionName = "HWI: Zystitis",
                  Meds = "Amoxicillin-Clavulansäure p.os 60/15 mg/kg/Tag in 3 ED (max. 1000/250 mg/ED)",
                  Color = "#EF233C"
              },
              new Infection
              {
                  InfectionName = "HWI: Pyelonephritis < 4 Wochen",
                  Meds = "Ampicillin i.v. 150 mg/kg/Tag in 3 ED plus Tobramycin i.v. 4 mg/kg/Tag in ED als KI, mind. 7 d i.v., gesamt 10 - 14 d",
                  Color = "#EF233C"
              },
              new Infection
              {
                  InfectionName = "HWI: Pyelonephritis 2. bis 6. Monate oder kompliziert (vorbestehende Nierenerkrankung)",
                  Meds = "Ampicillin i.v. 150 mg/kg/Tag in 3 ED und Ceftazidim i.v. 150 mg/kg/Tag in 3 ED, Dauer bis 2 Tage nach Entfiebern, dann oral, insgesamt 10 Tage. Alternativ: Pip/Taz i.v.",
                  Color = "#EF233C"
              },
              new Infection
              {
                  InfectionName = "HWI: Pyelonephritis ab 7. Monat und unkompliziert",
                  Meds = "Amoxicillin-Clavulansäure p.os 60/15 mgkg/Tag in 3 ED (max. 1000/250 mg/ED)  für 7 - 10 Tage insgesamt; alternativ oral, initial ggf. i.v.: Cefotaxim 100 mg/kg/Tag in 3 ED (max. 6 g/Tag)",
                  Color = "#EF233C"
              },
              new Infection
              {
                  InfectionName = "HWI Prophylaxe: bis einschl. 6. Woche",
                  Meds = "Cefaclor p.os 10 mg/kg ED abends",
                  Color = "#EF233C"
              },
              new Infection
              {
                  InfectionName = "HWI Prophylaxe: > 7. Woche",
                  Meds = "Trimetoprim p.os 1 -2 mg/kg ED abends",
                  Color = "#EF233C"
              },
              new Infection
              {
                  InfectionName = "HWI Prophylaxe: > 4. Monat",
                  Meds = "Nitrofurantoin p.os 1 -2 mg/kg ED abends",
                  Color = "#EF233C"
              },
              new Infection
              {
                  InfectionName = "GI Trakt: Peritonitis",
                  Meds = "Piperacillin-Tazobactam i.v. 300 mg/kg/Tag in 3 ED (max. 4 g/ED)",
                  Color = "#EF233C"
              },
              new Infection
              {
                  InfectionName = "Osteomyelitis/sept. Arthritis",
                  Meds = "Cefuroxim i.v. 150 mg/kg/Tag in 3 ED plus Clindamycin i.v. 40 mg/kg/Tag in 3 ED",
                  Color = "#EF233C"
              },
              new Infection
              {
                  InfectionName = "Lymphadenitis",
                  Meds = "Ampicillin/Sulbactam i.v. 150 mg/kg/Tag in 3 ED (max. 4g) Umstellen auf Amoxicillin-Clavulansäure p.os 60/15 mg/kg/Tag in 3 ED (max. 1000/250 mg/ED)",
                  Color = "#EF233C"
              },
              new Infection
              {
                  InfectionName = "Cellulitis",
                  Meds = "Ampicillin/Sulbactam i.v. 150 mg/kg/Tag in 3 ED",
                  Color = "#EF233C"
              },
              new Infection
              {
                  InfectionName = "Impetigo",
                  Meds = " Flucloxacillin i.v. 200 mg/kg/Tag in 3 ED, pro 100 mg/kg/Tag",
                  Color = "#EF233C-"
              },
              new Infection
              {
                  InfectionName = "Periorbitalphlegmone",
                  Meds = "> 1 Monat: Cefotaxim i.v. 100 mg/kg/Tag in 3 ED plus Flucloxacillin i.v. 200 mg/kg in 4 ED (max. 2g/ED)",
                  Color = "#EF233C"
              },
              new Infection
              {
                  InfectionName = "Lidphlegmone",
                  Meds = "Ampicillin/Sulbactam i.v. 150 mg/kg/Tag in 3 ED (max.4g) Umstellen auf Amoxicillin-Clavulansäure p.os 60/15 mg/kg/Tag in 3 ED (max. 1000/250 mg/ED)",
                  Color = "#EF233C"
              }
         };
        }

        internal void HideOrShowInfection(Infection infection)
        {
            if (_oldInfection == infection)
            {
                //click twice on the same item will hide it
                infection.IsVisible = !infection.IsVisible;

                UpdateInfections(infection);
            }
            else
            {
                if (_oldInfection != null)
                {
                    //hide previos selected item 
                    _oldInfection.IsVisible = false;
                    UpdateInfections(_oldInfection);
                }
                //show selected item
                infection.IsVisible = true;


                UpdateInfections(infection);

            }
            _oldInfection = infection;

        }

        private void UpdateInfections(Infection infection)
        {
            var index = Infections.IndexOf(infection);
            Infections.Remove(infection);
            Infections.Insert(index, infection);

        }
    }
}
