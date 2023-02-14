using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuartzTypeLib;

namespace mook_MP3
{
    public enum Player_Status
    {
        None,
        Stopped,
        Paused,
        Running,
    }

    class MP3Play
    {
        FilgraphManager Filtergraph;
        FilgraphManager FiltergraphTemp;
        IMediaControl MediaControl;
        IMediaPosition MediaPosition;
        IMediaPosition MediaPositionTemp;
        IBasicAudio BasicAudio;
        public object playStatus = Player_Status.None;

        public string OpenFile(string StrFilePath)
        {
            string strFileLen = "";
            FiltergraphTemp = new FilgraphManager();
            FiltergraphTemp.RenderFile(StrFilePath);

            MediaPositionTemp = (IMediaPosition)FiltergraphTemp;
            strFileLen = Convert_Position_To_Time(Convert.ToInt32(MediaPositionTemp.Duration));
            if (!(MediaPositionTemp == null))
            {
                MediaPositionTemp = null;
            }
            if (!(FiltergraphTemp == null))
            {
                FiltergraphTemp = null;
            }
            return strFileLen;
        }
        public string Convert_Position_To_Time(int iPostion)
        {
            string strTimeLen = "";
            int iHour = iPostion / 3600;
            int iMinute = (int)((iPostion - (iHour * 3600)) / 60);
            int iSecond = (int)(iPostion - (iHour * 3600 + iMinute * 60));
            strTimeLen = String.Format("{0:D2}:{1:D2}:{2:D2}", iHour, iMinute, iSecond);
            
            return strTimeLen;
        }
        public void Play(string strMP3FilePath)
        {
            try
            {
                Filtergraph = new FilgraphManager();
                Filtergraph.RenderFile(strMP3FilePath);
                MediaPosition = (IMediaPosition)Filtergraph;
                MediaControl = (IMediaControl)Filtergraph;
                playStatus = Player_Status.Running;
                MediaControl.Run();
            }
            catch { }
        }
        public void PlayStop()
        {
            if (MediaControl == null) return;
            MediaControl.Stop();
            playStatus = Player_Status.Stopped;
        }
        public void PlayPause()
        {
            if (MediaControl == null) return;
            MediaControl.Pause();
            playStatus = Player_Status.Paused;
        }
        public double Get_CurPosition()
        {
            if (!(playStatus.Equals(Player_Status.Running)))
                return 0;
            else
                return MediaPosition.CurrentPosition;  //현재 재생 포지션 반환
        }
        public void Set_CurPosition(double trackCurPostion)
        {
            if (playStatus.Equals(Player_Status.Running))
                MediaPosition.CurrentPosition = trackCurPostion; //트랙 바 위치와 재생 시점을 동기화 함
            else
                return;
        }
        public double Get_TotalDuration()
        {
            if (!(playStatus.Equals(Player_Status.Running)))
                return 0;
            else
                return MediaPosition.Duration; //미디어 파일 재생 길이
        }
        public void Set_AudioVolume(long vol)
        {
            BasicAudio = (IBasicAudio)Filtergraph;
            BasicAudio.Volume = (int)vol; //볼륨 설정
        }
        public void Set_AudioBalance(long bal)
        {
            BasicAudio = (IBasicAudio)Filtergraph;
            BasicAudio.Balance = (int)bal; //좌우 밸런스 설정
        }
    }
}
