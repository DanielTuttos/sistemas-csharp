using System;

namespace AccesoDato
{
  public sealed class conexion
  {
    public static string LeerCC
    {
      get { return @"server=USERTUDENT; database = agenda; integrated security = True;"; }
    }
  }
}
