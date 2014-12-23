#region

using System;

#endregion

namespace LoLLauncher.RiotObjects.Platform.Game
{
    public class PlayerParticipant : Participant
    {
        public delegate void Callback(PlayerParticipant result);

        private readonly Callback _callback;
        private readonly string _type = "com.riotgames.platform.game.PlayerParticipant";

        public PlayerParticipant()
        {
        }

        public PlayerParticipant(Callback callback)
        {
            this._callback = callback;
        }

        public PlayerParticipant(TypedObject result)
        {
            SetFields(this, result);
        }

        public override string TypeName
        {
            get { return _type; }
        }

        [InternalName("timeAddedToQueue")]
        public object TimeAddedToQueue { get; set; }

        [InternalName("index")]
        public Int32 Index { get; set; }

        [InternalName("queueRating")]
        public Int32 QueueRating { get; set; }

        [InternalName("accountId")]
        public Double AccountId { get; set; }

        [InternalName("botDifficulty")]
        public String BotDifficulty { get; set; }

        [InternalName("originalAccountNumber")]
        public Double OriginalAccountNumber { get; set; }

        [InternalName("summonerInternalName")]
        public String SummonerInternalName { get; set; }

        [InternalName("minor")]
        public Boolean Minor { get; set; }

        [InternalName("locale")]
        public object Locale { get; set; }

        [InternalName("lastSelectedSkinIndex")]
        public Int32 LastSelectedSkinIndex { get; set; }

        [InternalName("partnerId")]
        public String PartnerId { get; set; }

        [InternalName("profileIconId")]
        public Int32 ProfileIconId { get; set; }

        [InternalName("teamOwner")]
        public Boolean TeamOwner { get; set; }

        [InternalName("summonerId")]
        public Double SummonerId { get; set; }

        [InternalName("badges")]
        public Int32 Badges { get; set; }

        [InternalName("pickTurn")]
        public Int32 PickTurn { get; set; }

        [InternalName("clientInSynch")]
        public Boolean ClientInSynch { get; set; }

        [InternalName("summonerName")]
        public String SummonerName { get; set; }

        [InternalName("pickMode")]
        public Int32 PickMode { get; set; }

        [InternalName("originalPlatformId")]
        public String OriginalPlatformId { get; set; }

        [InternalName("teamParticipantId")]
        public object TeamParticipantId { get; set; }

        public override void DoCallback(TypedObject result)
        {
            SetFields(this, result);
            _callback(this);
        }

        public override string ToString()
        {
            return SummonerName;
        }
    }
}