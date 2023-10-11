using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Proyecto_MauroMur.Domain
{
    internal class DatabaseBackupManagerModel
    {
        private DatabaseBackupManager backupManager = new DatabaseBackupManager();

        public bool RealizarBackUp(string backupPath)
        {
            return backupManager.RealizarBackup("bd_virtualBiblio", backupPath);
        }

    }
}
