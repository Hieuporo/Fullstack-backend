namespace StoreProject.Domain.Enums
{
    public enum PermissionList
    {
        // Category
        CreateCategory = 1,
        UpdateCategory = 2,
        DeleteCategory = 3,
        // Order
        ViewOrder = 4,
        UpdateOrder = 5,
        DeleteOrder = 6,
        // Product
        ViewProduct = 7,
        DeleteProduct = 8,
        UpdateProduct = 9,
        // User
        ViewUser = 10,
        UpdateUser = 11,
        DeleteUser = 12,
        CreateUser = 13,
        // Role
        CreateRole = 14,
        UpdateRole = 15,
        DeleteRole = 16,
        ViewRole = 17,
        // Permission
        ViewPermission = 18,
        UpdateRolePermission = 19,
        ViewRolePermission = 20,
        // Discount
        ViewDiscount = 21,
        UpdateDiscount = 22,
        DeleteDiscount = 23,
        // Shipping Method
        UpdateShippingMethod = 24,
        DeleteShippingMethod = 25,
        CreateShippingMethod = 26,
        // client and all user
        Client = 100,
        All = 101,
    }
}
  