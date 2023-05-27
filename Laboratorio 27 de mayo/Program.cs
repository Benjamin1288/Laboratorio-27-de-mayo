using Laboratorio_27_de_mayo;
//GestorEmpleados nose = new GestorEmpleados("c:\\tmp\\Empleados.db");
//nose.CrearTabla();
GestorEmpleados nose3 = new GestorEmpleados("c:\\tmp\\Empleados2.db");
nose3.CrearTabla();
//Empleado mojojo = new Empleado(21, "Benjamin", "Hernández", 18, "Estudiante",5000);
//Empleado mojojo1 = new Empleado(22, "Melki", "Ortiz", 18, "Estudiante",2000);
//Empleado mojojo2 = new Empleado(16, "Yonathan", "Obed", 19, "Secretario",3000);
//Empleado mojojo3 = new Empleado(09, "Yefri", "Castillo", 19, "Entrenador",2000);
//Empleado mojojo4 = new Empleado(15, "Luis", "Fernando", 22, "Limpieza",1000);
Empleado em1 = new Empleado(21, "Benjamin", "Hernández", 18, "Estudiante", "5000");
Empleado em2 = new Empleado(22, "Melki", "Ortiz", 18, "Estudiante", "2000");
Empleado em3 = new Empleado(16, "Yonathan", "Obed", 19, "Secretario", "3000");
Empleado em4 = new Empleado(09, "Yefri", "Castillo", 19, "Entrenador", "2000");
Empleado em5 = new Empleado(15, "Luis", "Fernando", 22, "Limpieza", "1000");

nose3.AgregarEmpleado(em2);
nose3.AgregarEmpleado(em3);
nose3.AgregarEmpleado(em4);
nose3.AgregarEmpleado(em5);


nose3.ObtenerEmpleados().ForEach(e => Console.WriteLine(e.Nombre+" Sueldo: "+e.Sueldo));


