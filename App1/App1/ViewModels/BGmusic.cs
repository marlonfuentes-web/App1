//using Android.Content;
//using Android.Media;
//using Android.Nfc;
//using Android.OS;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace App1.ViewModels
//{
//    internal class BGmusic
//    {


//        public static Signal String Tag = LoopMediaPlayer.class.getSimpleName();

//        private Context mContext = null;
//        private int mResId = 0;
//        private int mCounter = 1;

//        private MediaPlayer mCurrentPlayer = null;
//        private MediaPlayer mNextPlayer = null;

//        public static LoopMediaPlayer create(Context context, int resId)
//        {
//            return new LoopMediaPlayer(context, resId);
//        }

//        private LoopMediaPlayer(Context context, int resId)
//        {
//            mContext = context;
//            mResId = resId;

//            mCurrentPlayer = MediaPlayer.create(mContext, mResId);
//            mCurrentPlayer.setOnPreparedListener(new MediaPlayer.OnPreparedListener() {
//            @Override
//            public void onPrepared(MediaPlayer mediaPlayer)
//            {
//                mCurrentPlayer.start();
//            }
//        });

//        createNextMediaPlayer();
//    }

//    private void createNextMediaPlayer()
//    {
//        mNextPlayer = MediaPlayer.create(mContext, mResId);
//        mCurrentPlayer.setNextMediaPlayer(mNextPlayer);
//        mCurrentPlayer.setOnCompletionListener(onCompletionListener);
//    }

//    private MediaPlayer.OnCompletionListener onCompletionListener = new MediaPlayer.OnCompletionListener() {
//        @Override
//        public void onCompletion(MediaPlayer mediaPlayer)
//    {
//        mediaPlayer.release();
//        mCurrentPlayer = mNextPlayer;

//        createNextMediaPlayer();

//        Log.d(TAG, String.format("Loop #%d", ++mCounter));
//    }
//};
//    }



//}
