#Урок номер 6 по модулю Math

import math

print("Длина строки", len("123"))
print("Округление", round(8.6))
print("Число ПИ", math.pi)
print("Число эллера", math.e)
print("Возведение в степень", math.pow(2, 3)) # 2**3
print("Остаток от деления", math.fmod(7, 3)) # 7%3
x = 5
print("Проверка на число", math.isfinite(x))
print("Проверка на бесконечность", math.isinf(x))
print("Мантисса и экспонента", math.frexp(123.456))
print("Квадратный корень", math.sqrt(9))
print("Модуль", math.fabs(-20))
print("Модуль числа 1, со знаком числа 2", math.copysign(-10, 5))
print("Отделяет целую часть и дробную", math.modf(123.456))
print("Округление в большую", math.ceil(4.1))
print("Округление в меньшую", math.floor(4.9))
print("Отбрасывание дробной части", math.trunc(8.9))
print("Отбрасывание дробной части", math.trunc(8.9))
print("Косинус угла", math.cos(math.radians(60)))
print("Синус угла", math.sin(math.radians(30)))
print("Тангенс угла", math.tan(math.radians(45)))
print("Гипотенуза", math.hypot(3, 4))
print("Логaрифм", math.log(8, 2))
print("Логaрифм десятичный", math.log10(100))

input()