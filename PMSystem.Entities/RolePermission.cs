namespace PMSystem.Entities
{
    public class RolePermission
    {
        public RolePermission(int permissionId, int projectId, string roleName, string permissionName, string permissionKey)
        {
            PermissionId = permissionId;
            PermissionName = permissionName;
            PermissionKey = permissionKey;
            RoleName = roleName;
            ProjectId = projectId;
        }

        public int PermissionId { get; private set; }

        public int ProjectId { get; private set; }

        public string RoleName { get; private set; }

        public string PermissionName { get; private set; }

        public string PermissionKey { get; private set; }

    }
}
