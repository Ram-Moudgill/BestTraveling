﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_Model.AdminModel;

namespace BT.AdminRepository.IRepository
{
    public interface IRoleRepo
    {
        IQueryable<RoleModel> GetRoles();
        RoleModel GetRoleById(Guid RoleId);
        void AddRole(RoleModel model);
        void UpdateRole(RoleModel model);
        void RemoveRole(RoleModel model);
    }
}
