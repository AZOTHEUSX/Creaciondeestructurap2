using system;
static public abstract class Miembrodelacomunidad
{
    public int id {get; set}
    public string nombre {get; set}
    public string apellido {get; set}
    public string ocupacion {get; set}
    public string correo {get; set}
    public ? int fecha {get; set}
    public ? int telefono {get; set}
    abstract save();
    virtual get()
    {}
}
static public virtual class Empleado: Miembrodelacomunidad
{
    static override void get()
    {
        base.get();
    }
    static override void save()
    {
        throw new System.NotImplementedException();
    }
}

static public virtual class Estudiante: Miembrodelacomunidad
{
    static override void get()
    {
        base.get();
    }
    static override void save()
    {
        throw new System.NotImplementedException();
    }
}
static public virtual class ExAlumno: Miembrodelacomunidad
{
    static override void get()
    {
        base.get();
    }
    static override void save()
    {
        throw new System.NotImplementedException();
    }
}
static public virtual class Docente: Empleado
{
    static override void get()
    {
        base.get();
    }
    static override void save()
    {
        throw new System.NotImplementedException();
    }
}
static public virtual class Administrativo: Empleado
{
    static override void get()
    {
        base.get();
    }
    static override void save()
    {
        throw new System.NotImplementedException();
    }
}
static public virtual class Administrador: Docente
{
    static override void get()
    {
        base.get();
    }
    static override void save()
    {
        throw new System.NotImplementedException();
    }
}
static public virtual class Maestro: Docente
{
    static override void get()
    {
        base.get();
    }
    static override void save()
    {
        throw new System.NotImplementedException();
    }
}
