using PrincipioSOLID_Interface;

LibroFisico fisico = new LibroFisico { Titulo = "CIEN AÑOS DE SOLEDAD" };
fisico.Leer(45);
Console.WriteLine("");
AudioLibro audio = new AudioLibro { Titulo = "EL PRINCIPITO" };
audio.Escuchar(12);
audio.CambiarVelocidad(1.5);
Console.WriteLine("");
LibroElectronico digital = new LibroElectronico { Titulo = "HASTA EL ULTIMO HOMBRE" };
digital.Leer(80);
digital.Escuchar(5);