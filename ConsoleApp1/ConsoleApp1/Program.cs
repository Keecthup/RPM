#region 12 var
string ryk = "Нету";
dynamic orga = new System.Dynamic.ExpandoObject();
Console.Write("Название организации:");
orga.nazvanie = Console.ReadLine() ?? "Не указано";
Console.Write("Юридический адресс:");
orga.yradress = Console.ReadLine() ?? "Не указан";
Console.Write("Фактический адресс:");
orga.facadress = Console.ReadLine() ?? orga.yradress;
Console.Write("Руководитель:");
orga.rykovod = ryk;
#endregion
#region 11 var
dynamic podrazd = new System.Dynamic.ExpandoObject();
Console.Write("Подразделение:");
podrazd.nazvanie = Console.ReadLine();
Console.Write("Рукводитель:");
podrazd.rykovod = ryk;
podrazd.organizovan = orga.nazvanie;

#endregion
#region 10 var
dynamic rabota = new System.Dynamic.ExpandoObject();
Console.Write("Название должности:");
rabota.nazvanie = Console.ReadLine() ?? "Не указано";
Console.Write("Оклад:");
rabota.oklad = Console.ReadLine() ?? "Не указан";
Console.Write("Подразделение:");
rabota.podrozd = podrazd.nazvanie ?? "Не указано";
#endregion
#region 9 var
dynamic sotrudnik = new System.Dynamic.ExpandoObject();
Console.Write("Введите фамилию:");
sotrudnik.Familia = Console.ReadLine()??"Не указана";
Console.Write("Введите имя:");
sotrudnik.Imya = Console.ReadLine()??"Не указано";
Console.Write("Введите отчество:");
sotrudnik.otchestvo = Console.ReadLine() ?? "Не указано";
sotrudnik.doljnost = rabota.nazvanie;
Console.WriteLine("Является руководителем?");
orga.ryk = Console.ReadLine();
if (orga.ryk == "Да")
    ryk = sotrudnik.Familia + sotrudnik.Imya + sotrudnik.otchestvo;
else
{
    Console.WriteLine("Введите ФИО Руководителя");
    ryk = Console.ReadLine();
}
#endregion
Console.Write($"Название: {rabota.nazvanie}, Оклад: {rabota.oklad}, Подразделение: {rabota.podrozd} \n ФИО:{sotrudnik.Familia} {sotrudnik.Imya} {sotrudnik.otchestvo}, Должность: {sotrudnik.doljnost}\n Название: {orga.nazvanie}, Юридический адресс: {orga.yracadress} Фактический адресс: {orga.facadress}, Руководитель: {ryk} \n Название: {podrazd.nazvanie}, Руководитель: {ryk} Организация: {podrazd.organizovan}\n");