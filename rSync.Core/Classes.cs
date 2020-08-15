using System;
using System.Collections.Generic;

namespace rSync.Core
{
    public class GameCollection
    {
        public Platforms Platform;
        public string PlatformName;
        public string GamePath;
        public string SavePath;
    }

    public class Console
    {
        public string Name;
        public string RootPath;
        public List<GameCollection> Collections;
        public ITransferInterface FileTransfer;
    }

    public enum Platforms
    {
        Unknown = 0,
        NDS,
        ThreeDS,
        GBA,
        PSP,
        GB,
        GBC
    }

    public class SaveFile
    {
        public string SaveFileName;
        public DateTime FileChanged;
    }

    public interface ITransferInterface
    {
        public virtual SaveFile[] GetSaveFileList() { return new SaveFile[0]; }

        public virtual void GetSaveFile(SaveFile sf) { }

        public virtual void PutSaveFile(SaveFile sf) { }
    }
}
