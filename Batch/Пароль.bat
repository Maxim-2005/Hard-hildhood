@echo off
chcp 1251
cls
color 0a
title ������
:1
set /p Pass=������:
if %Pass%==120461 (goto 2) else (echo ������ �������� && goto 1)
:2
start D:\������������\Lot\Index.html