﻿using System.Collections.Generic;

namespace Tanks
{
    class Shooting
    {
        private Shot shot;
        private Bang bang;
        private Crater crater;
        private float delta;

        //Расчет стрельбы
        public void ActShot(List<ListUnit> ListParty, ListShot listShot)
        {
            //Расчет пуль
            for (int i = 0; i < listShot.listShot.Count; i++)
            {
                shot = listShot.listShot[i];
                shot.MoveShot();

                if (shot.Delta(shot.position, shot.target) < 17 || shot.speed < 5)
                {
                    //Расчет дамажа
                    foreach (ListUnit party in ListParty)
                        foreach (dynamic unit in party.listUnits)
                        {
                            if (unit.act != Act.DEAD)
                            {
                                delta = unit.Delta(shot.position, unit.position);
                                if (delta < 30)
                                    unit.life -= 50/delta;
                            }
                        }

                    listShot.RemoveShot(shot);
                }
            }

            //Расчет взрывов
            for (int i = 0; i < listShot.listBang.Count; i++)
            {
                bang = listShot.listBang[i];
                if (bang.time > 96)
                    listShot.RemoveBang(bang);
                else
                    bang.time += 11;
            }

            //Расчет воронок
            for (int i = 0; i < listShot.listCrater.Count; i++)
            {
                crater = listShot.listCrater[i];
                if (crater.time > 300)
                    listShot.RemoveCrater(crater);
                else
                    crater.time++;
            }
        }
    }
}
