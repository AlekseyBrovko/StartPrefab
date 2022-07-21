using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Leopotam.EcsLite;
//using DG.Tweening;
//using Lofelt.NiceVibrations;

namespace Client
{
    public class SettingsPanelBahaviorMB : MonoBehaviour
    {
        /*
        #region ECS
        private EcsWorld _world;
        private GameState _state;
        private EcsPool<VibrationEvent> _vibrationEvent;

        public void Init(GameState state)
        {
            var world = state.EcsWorld;
            _world = world;
            _state = state;
            _vibrationEvent = world.GetPool<VibrationEvent>();
        }

        #endregion
        */
        [SerializeField] private float _speed;
        private Vector2 _startPos;
        [SerializeField] private Vector2 _activePos;
        [SerializeField] private RectTransform _thisPanel;
        private bool _wasClicked = false;
        [SerializeField] private Image _musicButton;
        [SerializeField] private Image _vibroButton;
        [SerializeField] private Image _soundsButton;
        [SerializeField] private Sprite _musicOnImage;
        [SerializeField] private Sprite _musicOffImage;
        [SerializeField] private Sprite _vibroOnImage;
        [SerializeField] private Sprite _vibroOffImage;
        [SerializeField] private Sprite _soundOnImage;
        [SerializeField] private Sprite _soundOffImage;
        //[SerializeField] private AudioBehavior _audioBehavior;

        void Awake()
        {
            _startPos = new Vector2 (_thisPanel.anchoredPosition.x, _thisPanel.anchoredPosition.y);            
        }

        public void MoveSettingsPanel()
        {/*
            LightVibration();            
            if(!_wasClicked)
            {
                _thisPanel.DOAnchorPosX(_activePos.x, _speed, false);
                _wasClicked = true;
            }
            else
            {
                _thisPanel.DOAnchorPosX(_startPos.x, _speed, false);
                _wasClicked = false;
            }*/
        }

        public void ChangeVibration()
        {/*
            LightVibration();
            switch (_state.Vibration)
            {
                case true:
                    _state.Vibration = false;
                    break;
                case false:
                    _state.Vibration = true;
                    break;
            }
            //_vibroButton.sprite = GetVibroButtonSprite(_state.Vibration);*/
        }

        public void ChangeMusic()
        {/*
            LightVibration();
            switch (_state.Music)
            {
                case true:
                    _state.Music = false;
                    _audioBehavior.OffMusicVol();
                    break;
                case false:
                    _state.Music = true;
                    _audioBehavior.OnMusicVol();
                    break;
            }
            //_musicButton.sprite = GetMusicButtonSprite(_state.Music);
            */
        }

        public void ChangeSound()
        {/*
            LightVibration();
            switch (_state.Sounds)
            {
                case true:
                    _state.Sounds = false;
                    _audioBehavior.OffSoundsVol();
                    break;
                case false:
                    _state.Sounds = true;
                    _audioBehavior.OnSoundsVol();
                    break;
            }
            //_soundsButton.sprite = GetSoundsButtonSprite(_state.Sounds);
            */
        }
        
        public void GetOnStartButtonSprite()
        {
            /*
            _vibroButton.sprite = GetVibroButtonSprite(_state.Vibration);
            _soundsButton.sprite = GetSoundsButtonSprite(_state.Sounds);
            _musicButton.sprite = GetMusicButtonSprite(_state.Music);
            */
        }
        private Sprite GetSoundsButtonSprite(bool value)
        {
            Sprite sprite = null;
            switch(value)
            {
                case true:
                    sprite = _soundOnImage;
                    break;
                case false:
                    sprite = _soundOffImage;
                    break;
            }
            return sprite;
        }

        private Sprite GetMusicButtonSprite(bool value)
        {
            Sprite sprite = null;
            switch(value)
            {
                case true:
                    sprite = _musicOnImage;
                    break;
                case false:
                    sprite = _musicOffImage;
                    break;
            }
            return sprite;
        }

        private Sprite GetVibroButtonSprite(bool value)
        {
            Sprite sprite = null;
            switch(value)
            {
                case true:
                    sprite = _vibroOnImage;
                    break;
                case false:
                    sprite = _vibroOffImage;
                    break;
            }
            return sprite;
        }
        /*private void LightVibration()
        {
            if(!_vibrationEvent.Has(_state.VibrationEntity))
            {
                ref var vibroComp = ref _vibrationEvent.Add(_state.VibrationEntity);
                vibroComp.Vibration = VibrationEvent.VibrationType.LightImpack;
            }
        }*/
    }
}
