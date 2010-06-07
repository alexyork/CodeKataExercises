using System;
using NUnit.Framework;

namespace TenPinBowling.Tests
{
    [TestFixture]
    public class TenPinBowlingTests
    {
        [Test]
        public void The_score_should_be_zero_for_all_players_in_a_new_game()
        {
            var game = new TenPinBowling("Alex", "Nico");

            string score = game.GetScore();

            Assert.AreEqual("Alex, 0. Nico, 0.", score);
        }

        [Test]
        public void The_score_should_print_the_players_names_correctly()
        {
            var game = new TenPinBowling("Dave", "Bill");

            string score = game.GetScore();

            Assert.AreEqual("Dave, 0. Bill, 0.", score);
        }

        [Test]
        public void The_score_for_player_1_should_be_updated_when_a_throw_is_made()
        {
            var game = new TenPinBowling("Dave", "Bill");

            game.ThrowBall("Dave", 7);
            string score = game.GetScore();

            Assert.AreEqual("Dave, 7. Bill, 0.", score);
        }

        [Test]
        public void The_score_for_player_2_should_be_updated_when_a_throw_is_made()
        {
            var game = new TenPinBowling("Dave", "Bill");

            game.ThrowBall("Bill", 7);
            string score = game.GetScore();

            Assert.AreEqual("Dave, 0. Bill, 7.", score);
        }

        //[Test]
        //[ExpectedException(typeof(Exception))]
        //public void Same_player_should_not_be_able_to_throw_three_times_in_a_row()
        //{
        //    var game = new TenPinBowling("Dave", "Bill");

        //    game.ThrowBall("Bill", 7);
        //    game.ThrowBall("Bill", 7);
        //    game.ThrowBall("Bill", 7);
        //}
    }
}
