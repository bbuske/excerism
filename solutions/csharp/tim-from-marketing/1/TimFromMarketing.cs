static class Badge
{
    public static string Print(int? id, string name, string? department)
    {    
        string deptLabel = (department ?? "OWNER").ToUpper();
        
        if (id != null) {
            return $"[{id}] - {name} - {deptLabel}";
        }
        else
        {
            return $"{name} - {deptLabel}";
        }
    }
}
