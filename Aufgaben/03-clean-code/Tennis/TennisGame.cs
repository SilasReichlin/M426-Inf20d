using System.Net.Http.Headers;
using static System.Formats.Asn1.AsnWriter;

namespace Tennis
{
    public class TennisGame
    {
        private int _playerOnePoint = 0;
        private int _playerTwoPoint = 0;
        private string _playerOneRes = string.Empty;
        private string _playerTwoRes = string.Empty;
        private string _playerOneName = string.Empty;
        private string _playerTwoName = string.Empty;

        public TennisGame(string playerOneName, string playerTwoName)
        {
            this._playerOneName = playerOneName;
            this._playerTwoName = playerTwoName;
        }

        public string ScoreGetter()
        {
            var score = string.Empty;

            if (_playerOnePoint == _playerTwoPoint && _playerOnePoint < 3)
            {
                score = CalculateScore(_playerOnePoint);
                score += "-All";
            }

            if (_playerOnePoint == _playerTwoPoint && _playerOnePoint > 2)
            {
                score = "Deuce";
            }

            if (_playerOnePoint > 0 && _playerTwoPoint == 0)
            {
                _playerOneRes = CalculateScore(_playerOnePoint);
                _playerTwoRes = "Love";
                score = _playerOneRes + "-" + _playerTwoRes;
            }

            if (_playerTwoPoint > 0 && _playerOnePoint == 0)
            {
                _playerTwoRes = CalculateScore(_playerTwoPoint);
                _playerOneRes = "Love";
                score = _playerOneRes + "-" + _playerTwoRes;
            }

            if (_playerOnePoint > _playerTwoPoint && _playerOnePoint < 4)
            {
                if (_playerOnePoint == 2)
                    _playerOneRes = "Thirty";
                if (_playerOnePoint == 3)
                    _playerOneRes = "Forty";

                if (_playerTwoPoint == 1)
                    _playerTwoRes = "Fifteen";
                if (_playerTwoPoint == 2)
                    _playerTwoRes = "Thirty";

                score = _playerOneRes + "-" + _playerTwoRes;
            }

            if (_playerTwoPoint > _playerOnePoint && _playerTwoPoint < 4)
            {
                if (_playerTwoPoint == 2)
                    _playerTwoRes = "Thirty";
                if (_playerTwoPoint == 3)
                    _playerTwoRes = "Forty";

                if (_playerOnePoint == 1)
                    _playerOneRes = "Fifteen";
                if (_playerOnePoint == 2)
                    _playerOneRes = "Thirty";

                score = _playerOneRes + "-" + _playerTwoRes;
            }

            if (_playerOnePoint > _playerTwoPoint && _playerTwoPoint >= 3)
            {
                score = "Advantage player1";
            }

            if (_playerTwoPoint > _playerOnePoint && _playerOnePoint >= 3)
            {
                score = "Advantage player2";
            }

            score = Win(score, _playerOnePoint, _playerTwoPoint);

            return score;
        }

        private string CalculateScore(int playerPoints)
        {
            string score = string.Empty;

            switch(playerPoints)
            {
                case 0:
                    score = "Love";
                    break;
                case 1:
                    score = "Fifteen";
                    break;
                case 2:
                    score = "Thirty";
                    break;
                case 3:
                    score = "Forty";
                    break;
            }

            return score;
        }

        public string Win(string score, int playerOneScore, int playerTwoScore)
        {
            if (playerOneScore >= 4 && playerTwoScore >= 0 && (playerOneScore - playerTwoScore) >= 2)
            {
                return "Win for" + _playerOneName;
            }

            if (playerTwoScore >= 4 && playerOneScore >= 0 && (playerTwoScore - playerOneScore) >= 2)
            {
                return "Win for" + _playerTwoName;
            }

            return score;
        }

        public void WonPoint(string player)
        {
            if (player == _playerOneName)
                _playerOnePoint++;
              else
                _playerTwoPoint++;
        }
    }
}

