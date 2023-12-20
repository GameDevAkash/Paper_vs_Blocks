//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;
//using Utility;
//namespace TerrorityTycoons
//{
//    public class MiniGames : State
//    {
//        public MiniGames(string name, SubGameMode a_aSubgameMode = SubGameMode.classic) : base(name, a_aSubgameMode)
//        {
//        }
//        public MiniGames(SubGameMode mode) : base(mode) { }
//        public override void InitializeComponents()
//        {
//            //UiHandler.m_UiHandlerInstance.gameObject.SetActive(false);
//            // base.InitializeComponents();
//        }
//        public override void OnPopped()
//        {
//            UiHandler.m_UiHandlerInstance.GameModeInvoke?.Invoke(false);
//            base.OnPopped();
//        }
//        public override void OnPushed()
//        {
//            switch (m_SubMode)
//            {
//                case SubGameMode.PaperVSBlocks:
//                    SceneManager.LoadScene("Paper_vs_Blocks");
//                    break;
//                case SubGameMode.Christmas:
//                    SceneManager.LoadScene("TerrorityTycoonsChristmas");
//                    break;
//                case SubGameMode.ClassicLabryanith:
//                    SceneManager.LoadScene("Labyrinth");
//                    break;
//            }
//        }
//        public override void OnSceneLoaded(Scene a_scne, LoadSceneMode a_mode)
//        {
//            InitializeComponents();
//            UiHandler.m_UiHandlerInstance.GameModeInvoke?.Invoke(true);
//        }
//        public override void OnTop()
//        {
//            base.OnTop();
//        }
//        public override void OnUpdate()
//        {
//            base.OnUpdate();
//        }
//        public override void PlayAgain()
//        {
//            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
//        }

//        public override SubGameMode GetSubGameMode()
//        {
//            throw new System.NotImplementedException();
//        }
//    }
//}
