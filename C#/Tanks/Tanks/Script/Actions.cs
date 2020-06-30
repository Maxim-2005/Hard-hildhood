﻿using System.Collections.Generic;
using System.Drawing;

namespace Tanks
{
    class Actions
    {
        private List<ListUnit> ListParty;
        private ListShot listShot;

        //Перебор всех юнитов
        public void ActUnit(List<ListUnit> ListParty, ListShot listShot)
        {
            this.ListParty = ListParty;
            this.listShot = listShot;

            foreach (ListUnit party in ListParty)
                foreach (dynamic unit in party.listUnits)
                    if (unit.act != Act.DEAD)
                        Logic(unit);
        }

        //Логига действий
        private void Logic(dynamic unit)
        {
            {
                switch (unit.act)
                {
                    case Act.WAIT:
                        ActWait(unit);
                        break;

                    case Act.FIND:
                        ActFind(unit);
                        break;

                    case Act.MOVE:
                        ActMove(unit);
                        break;

                    case Act.FIRE:
                        ActFire(unit);
                        break;

                    default:
                        unit.act = Act.WAIT;
                        break;
                }
            }
        }

        //Процесс ожидания
        private void ActWait(dynamic unit)
        {
            //Если танк мёртв
            if (unit.life <= 0)
                KillUnit(unit);

            //Поиск цели
            else
            {
                unit.target = FindTarget(unit);
                unit.act = Act.FIRE;
            }      
        }

        //Процесс поиска
        private void ActFind(dynamic unit)
        {
            //Юнит едет, башня прямо, через 1 секунду Wait
        }

        //Процесс перемещения
        private void ActMove(dynamic unit)
        {
            //Юнит едет, башня на цель, пока не сможет стрелять Act FIRE когда можно стрелять
        }

        //Процесс атаки
        private void ActFire(dynamic unit)
        {
            unit.PositionUnit();
            unit.vector = unit.Vector(unit.vector, unit.speed);

            unit.timeShot++;
            if (unit.timeShot > 60)
            {
                listShot.NewShot(unit);
                unit.timeShot = 0;
                unit.act = Act.WAIT;
            }
        }

        //Поиск цели
        private PointF FindTarget(dynamic unit)
        {
            float findDelta = unit.vision, minDelta = unit.vision;

            foreach (ListUnit party in ListParty)
                foreach (dynamic findUnit in party.listUnits)
                {
                    if (findUnit.act != Act.DEAD && findUnit.color != unit.color)
                        findDelta = unit.Delta(unit.position, findUnit.position);

                    if (findDelta < minDelta)
                    {
                        minDelta = findDelta;
                        unit.target = findUnit.position;
                    }
                }
            return unit.target;
        }

        //Убийство танка
        private void KillUnit(dynamic unit)
        {
            unit.act = Act.DEAD;
            unit.speed = 0.0f;
            unit.life = 0.0f;
            unit.color = Color.Black;
        }
    }
}