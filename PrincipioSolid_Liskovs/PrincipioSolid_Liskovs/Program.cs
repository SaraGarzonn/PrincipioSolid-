using PrincipioSolid_Liskovs;

TrabajadorFijo Ana = new TrabajadorFijo
{
    Nombre = "Gabriela Morales",
    SalarioBase = 2000000
};
Ana.MostrarRecibo();



TrabajadorComision Luis = new TrabajadorComision
{
    Nombre = "Luis",
    SalarioBase = 1800000,
    NumeroVentas = 20
};
Luis.MostrarRecibo();

