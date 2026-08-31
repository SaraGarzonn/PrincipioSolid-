using PrincipioSolid_Dependencias;

ProcesadorCompra compra1 = new ProcesadorCompra(new PagoConTarjeta());
compra1.Pagar(150000);

ProcesadorCompra compra2 = new ProcesadorCompra(new PagoConPayPal());
compra2.Pagar(89990);