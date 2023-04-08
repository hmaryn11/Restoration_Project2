using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoration_Project.Models
{
    public class JosephJeopardyContext : DbContext
    {
        public JosephJeopardyContext(DbContextOptions<JosephJeopardyContext> options) : base(options)
        {
            //leave blank
        }

        public DbSet<Topic> Topic { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Answer> Answer { get; set; }

        protected override void OnModelCreating(ModelBuilder mb) //seeding the db
        {
            //------------------------------------
            //-----------Topic seeds--------------
            //------------------------------------
            mb.Entity<Topic>().HasData(
                new Topic
                {
                    TopicId = 1,
                    TopicName = "People's Influence",
                    BGColor = "orangered",
                    DivColor = "peachpuff"
                },
                new Topic
                {
                    TopicId = 2,
                    TopicName = "A Man of Miracles",
                    BGColor = "orange",
                    DivColor = "lightseagreen"
                },
                new Topic
                {
                    TopicId = 3,
                    TopicName = "Visions & Visitations",
                    BGColor = "peachpuff",
                    DivColor = "mediumblue"
                },
                new Topic
                {
                    TopicId = 4,
                    TopicName = "Joseph's Falacies",
                    BGColor = "lightseagreen",
                    DivColor = "orangered"
                },
                new Topic
                {
                    TopicId = 5, 
                    TopicName = "Trial By Fire",
                    BGColor = "mediumblue",
                    DivColor = "orange"
                }
            );
            //----------------------------------------
            //------------Question seed---------------
            //----------------------------------------
            mb.Entity<Question>().HasData(
                ///////////////////// 100 : Q(1-5)
                new Question
                {
                    QuestionId = 1,
                    TopicId = 1,
                    FullQuestion = "Which family member was Joseph closest to and looked up to the most?",
                    PointValue = 100,
                    Explanation = "Alvin was described as being 'serious and hardworking, and Joseph loved and admired him immensely.' Alvin was one of the first people to believe Joseph about the visions he had been having and he encouraged Joseph to do all he could to fulfill the will of God.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 2,
                    TopicId = 2,
                    FullQuestion = "T2 100",
                    PointValue = 100,
                    Explanation = "Question 2",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 3,
                    TopicId = 3,
                    FullQuestion = "T3 100",
                    PointValue = 100,
                    Explanation = "Question 3",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 4,
                    TopicId = 4,
                    FullQuestion = " T4 100",
                    PointValue = 100,
                    Explanation = "Question 4",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 5,
                    TopicId = 5,
                    FullQuestion = "T5 100",
                    PointValue = 100,
                    Explanation = "Question 5",
                    Viewed = false
                },
                ///////////////////// 200 : Q(6-10)
                new Question
                {
                    QuestionId = 6,
                    TopicId = 1,
                    FullQuestion = "When Joseph was finally authorized to obtain the plates, who did he take with him?",
                    PointValue = 200,
                    Explanation = "The angel Moroni originally instructed Joseph to bring Alvin with him to obtain the plates. When Alvin dies, Joseph didn't know who he would bring with him. But, Moroni assured him that he would know who he was to bring when the time was right. Emma became more than his wife, she also became his companion. They worked together as a team and took care of each other in love.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 7,
                    TopicId = 2,
                    FullQuestion = "What does D&C 135 state that Joseph did for the salvation of men?",
                    PointValue = 200,
                    Explanation = "D&C 135:3 states 'Joseph Smith, the Prophet and Seer of the Lord, has done more, save Jesus only, for the salvation of men in this world, than any other man that ever lived in it.' When we think of all the blessings that we as members of the church enjoy, we owe most of the restoation of these blessings to Joseph and the work he did on this earth. He helped in the work to make it possible for all men, not only those who are members in this life, to return to God.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 8,
                    TopicId = 3,
                    FullQuestion = "Joseph was working in the field the day after Moroni’s first visit. On his way home, Joseph collapsed due to exhaustion and was again visited by Moroni. In addition to rehearsing what he said the night before, what else did Moroni tell Joseph this time?",
                    PointValue = 200,
                    Explanation = "Moroni visited him",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 9,
                    TopicId = 4,
                    FullQuestion = "What was the reason Joseph had to wait 4 years before he could obtain the plates?",
                    PointValue = 200,
                    Explanation = "Each time that Joseph came in the years before, the Lord knew he wasn't ready to protect the plates and use them only for the sacred purpose the were intended. The 1st time he went to obtain them, he thought of the worldly worth of the plates, was physically shocked, and could not obtain them. The 2nd time, when reaching for the plates, he thought of covering the other items there that might be valueable. He took his eyes off the plates for a second and they disappeared. He was not yet ready to protect the plates. The 3rd time, Joseph had been working as a 'money digger' (similar to a treasure hunter) and Moroni told him to quit this job before he could receive the plates. The fourth year, Joseph had been sufficiently prepared and he could then take the plates. ",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 10,
                    TopicId = 5,
                    FullQuestion = "What were Joseph and Hyrum's final exclamations when they were killed?",
                    PointValue = 200,
                    Explanation = "After an invasion of mob men to their prison room in Carthage Jail, Joseph and Hyrum were both shot bringing their service to the Lord on this earth to an end. Sealing their testimonies with their lives. The two other men in the prison with them, John Taylor and Willard Richards, survived the raid and gave their testimony of the event. It is because of these men's accounts of this day that we know the truthfulness of the events of June 27th, 1844.",
                    Viewed = false
                },
                ///////////////////// 300 : Q(11-15)
                new Question
                {
                    QuestionId = 11,
                    TopicId = 1,
                    FullQuestion = "Who influenced Joseph as a young man to do foolish things and got him into trouble at times?",
                    PointValue = 300,
                    Explanation = "Like most young people, Joseph and his friends cared a lot about worldly wealth and in particular, treasure. They would often search for it together. This desire and focus on getting gain would be a problem for Joseph in the future in fulfilling the Lord's wishes.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 12,
                    TopicId = 2,
                    FullQuestion = "T2 300",
                    PointValue = 300,
                    Explanation = "Question 12",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 13,
                    TopicId = 3,
                    FullQuestion = "T3 300",
                    PointValue = 300,
                    Explanation = "Question 13",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 14,
                    TopicId = 4,
                    FullQuestion = " T4 300",
                    PointValue = 300,
                    Explanation = "Question 14",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 15,
                    TopicId = 5,
                    FullQuestion = "T5 300",
                    PointValue = 300,
                    Explanation = "Question 15",
                    Viewed = false
                },
                ///////////////////// 400 : Q(16-20)
                new Question
                {
                    QuestionId = 16,
                    TopicId = 1,
                    FullQuestion = "Moroni told Joseph that his name 'should be had for good and evil among all nations, kindreds, and tongues' (JSH 1:33). Who else did Joseph say this prophecy applied to?",
                    PointValue = 400,
                    Explanation = "People thought that once Joseph was dead, the church would crumble. But thanks to Brigham Young, this was not the case. He made sure that the church thrived and continued with the vigor that Joseph had started it with. Unfortunately, people today, even some members of the church, look to President Young with distaste and distain due to things he did that some perceive as sinful. However, without the work that Brigham Young did for the church, all of the work of Joseph might have been lost. President Young was able to keep the fire of the church burning and we have much to thank him for.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 17,
                    TopicId = 2,
                    FullQuestion = "T2 400",
                    PointValue = 400,
                    Explanation = "Question 17",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 18,
                    TopicId = 3,
                    FullQuestion = "T3 400",
                    PointValue = 400,
                    Explanation = "Question 18",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 19,
                    TopicId = 4,
                    FullQuestion = "T4 400",
                    PointValue = 400,
                    Explanation = "Question 19",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 20,
                    TopicId = 5,
                    FullQuestion = "T5 400",
                    PointValue = 400,
                    Explanation = "Question 20",
                    Viewed = false
                },
                ///////////////////// 500 : Q(21-25)
                new Question
                {
                    QuestionId = 21,
                    TopicId = 1,
                    FullQuestion = "T1 500",
                    PointValue = 500,
                    Explanation = "Question 21",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 22,
                    TopicId = 2,
                    FullQuestion = "T2 500",
                    PointValue = 500,
                    Explanation = "Question 22",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 23,
                    TopicId = 3,
                    FullQuestion = "T3 500",
                    PointValue = 500,
                    Explanation = "Question 23",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 24,
                    TopicId = 4,
                    FullQuestion = " T4 500",
                    PointValue = 500,
                    Explanation = "Question 24",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 25,
                    TopicId = 5,
                    FullQuestion = "T5 500",
                    PointValue = 500,
                    Explanation = "Question 25",
                    Viewed = false
                }
            );
            //-------------------------------------
            //------------Answer seed--------------
            //-------------------------------------
            mb.Entity<Answer>().HasData(

                //------100------// Q(1-5) 
                ///////////////////// T1 100 Q1 : A(1-4)
                new Answer
                {
                    AnswerId = 1,
                    QuestionId = 1,
                    FullAnswer = "Alvin Smith",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 2,
                    QuestionId = 1,
                    FullAnswer = "Lucy Smith",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 3,
                    QuestionId = 1,
                    FullAnswer = "Hyrum Smith",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 4,
                    QuestionId = 1,
                    FullAnswer = "William Smith",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T2 100 Q2 : A(5-8)
                new Answer
                {
                    AnswerId = 5,
                    QuestionId = 2,
                    FullAnswer = "T2 100 Q2 1",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 6,
                    QuestionId = 2,
                    FullAnswer = "T2 100 Q2 2",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 7,
                    QuestionId = 2,
                    FullAnswer = "T2 100 Q2 3",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 8,
                    QuestionId = 2,
                    FullAnswer = "T2 100 Q2 4",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T3 100 Q3 : A(9-12)
                new Answer
                {
                    AnswerId = 9,
                    QuestionId = 3,
                    FullAnswer = "T3 100 Q3 1",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 10,
                    QuestionId = 3,
                    FullAnswer = "T3 100 Q3 2",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 11,
                    QuestionId = 3,
                    FullAnswer = "T3 100 Q3 3",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 12,
                    QuestionId = 3,
                    FullAnswer = "T3 100 Q3 4",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T4 100 Q4 : A(13-16)
                new Answer
                {
                    AnswerId = 13,
                    QuestionId = 4,
                    FullAnswer = "T4 100 Q4 1",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 14,
                    QuestionId = 4,
                    FullAnswer = "T4 100 Q4 2",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 15,
                    QuestionId = 4,
                    FullAnswer = "T4 100 Q4 3",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 16,
                    QuestionId = 4,
                    FullAnswer = "T4 100 Q4 4",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T5 100 Q5 : A(17-20)
                new Answer
                {
                    AnswerId = 17,
                    QuestionId = 5,
                    FullAnswer = "T5 100 Q5 1",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 18,
                    QuestionId = 5,
                    FullAnswer = "T5 100 Q5 2",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 19,
                    QuestionId = 5,
                    FullAnswer = "T5 100 Q5 3",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 20,
                    QuestionId = 5,
                    FullAnswer = "T5 100 Q5 4",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },


                //------200------// Q(6-10)
                ///////////////////// T1 200 Q6 : A(21-24)
                new Answer
                {
                    AnswerId = 21,
                    QuestionId = 6,
                    FullAnswer = "Emma Smith",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 22,
                    QuestionId = 6,
                    FullAnswer = "Martin Harris",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 23,
                    QuestionId = 6,
                    FullAnswer = "Hyrum Smith",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 24,
                    QuestionId = 6,
                    FullAnswer = "Oliver Cowdery",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T2 200 Q7 : A(25-28)
                new Answer
                {
                    AnswerId = 25,
                    QuestionId = 7,
                    FullAnswer = "More, save Jesus only",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 26,
                    QuestionId = 7,
                    FullAnswer = "Restored priesthood keys",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 27,
                    QuestionId = 7,
                    FullAnswer = "Translated the Book of Mormon",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 28,
                    QuestionId = 7,
                    FullAnswer = "Initiated temple work for the dead",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T3 200 Q8 : A(29-32)
                new Answer
                {
                    AnswerId = 29,
                    QuestionId = 8,
                    FullAnswer = "He told him to tell his father about his vision.",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 30,
                    QuestionId = 8,
                    FullAnswer = "He told him to go and obtain the plates.",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 31,
                    QuestionId = 8,
                    FullAnswer = "He told Joseph to run home, because his mother had made pie.",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 32,
                    QuestionId = 8,
                    FullAnswer = "He told him to find Martin Harris to be his scribe.",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T4 200 Q9 : A(33-36)
                new Answer
                {
                    AnswerId = 33,
                    QuestionId = 9,
                    FullAnswer = "He had to overcome his covetousness and his desire for worldly gain.",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 34,
                    QuestionId = 9,
                    FullAnswer = "He had to wait until he was strong enough to move the rock where the plates were hidden.",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 35,
                    QuestionId = 9,
                    FullAnswer = "He had to work on the farm to help his family save money.",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 36,
                    QuestionId = 9,
                    FullAnswer = "He had to stop being mean to his mother and learn to treat her with respect.",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T5 200 Q10 : A(37-40)
                new Answer
                {
                    AnswerId = 37,
                    QuestionId = 10,
                    FullAnswer = "Hyrum: 'I'm a dead man'   Joseph: 'O Lord my God'",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 38,
                    QuestionId = 10,
                    FullAnswer = "Hyrum: 'Joseph, run!'   Joseph: 'We will be together with God'",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 39,
                    QuestionId = 10,
                    FullAnswer = "Hyrum: 'My God, my Savior'   Joseph: 'Lord, save me'",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 40,
                    QuestionId = 10,
                    FullAnswer = "Hyrum: 'Please, protect them'   Joseph: 'Til we meet again'",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },


                //------300------// Q(11-15)
                ///////////////////// T1 300 Q11 : A(41-44)
                new Answer
                {
                    AnswerId = 41,
                    QuestionId = 11,
                    FullAnswer = "His friends",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 42,
                    QuestionId = 11,
                    FullAnswer = "His brothers",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 43,
                    QuestionId = 11,
                    FullAnswer = "The local preachers",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 44,
                    QuestionId = 11,
                    FullAnswer = "The old lady accross the street",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T2 300 Q12 : A(45-48)
                new Answer
                {
                    AnswerId = 45,
                    QuestionId = 12,
                    FullAnswer = "T2 300 Q12 1",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 46,
                    QuestionId = 12,
                    FullAnswer = "T2 300 Q12 2",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 47,
                    QuestionId = 12,
                    FullAnswer = "T2 300 Q12 3",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 48,
                    QuestionId = 12,
                    FullAnswer = "T2 300 Q12 4",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T3 300 Q13 : A(49-52)
                new Answer
                {
                    AnswerId = 49,
                    QuestionId = 13,
                    FullAnswer = "T3 300 Q13 1",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 50,
                    QuestionId = 13,
                    FullAnswer = "T3 300 Q13 2",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 51,
                    QuestionId = 13,
                    FullAnswer = "T3 300 Q13 3",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 52,
                    QuestionId = 13,
                    FullAnswer = "T3 300 Q13 4",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T4 300 Q14 : A(53-56)
                new Answer
                {
                    AnswerId = 53,
                    QuestionId = 14,
                    FullAnswer = "T4 300 Q14 1",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 54,
                    QuestionId = 14,
                    FullAnswer = "T4 300 Q14 2",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 55,
                    QuestionId = 14,
                    FullAnswer = "T4 300 Q14 3",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 56,
                    QuestionId = 14,
                    FullAnswer = "T4 300 Q14 4",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T5 300 Q15 : A(57-60)
                new Answer
                {
                    AnswerId = 57,
                    QuestionId = 15,
                    FullAnswer = "T5 300 Q15 1",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 58,
                    QuestionId = 15,
                    FullAnswer = "T5 300 Q15 2",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 59,
                    QuestionId = 15,
                    FullAnswer = "T5 300 Q15 3",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 60,
                    QuestionId = 15,
                    FullAnswer = "T5 300 Q15 4",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },


                //------400------// Q(16-20)
                ///////////////////// T1 400 Q16 : A(61-64)
                new Answer
                {
                    AnswerId = 61,
                    QuestionId = 16,
                    FullAnswer = "Brigham Young",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 62,
                    QuestionId = 16,
                    FullAnswer = "Porter Rockwell",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 63,
                    QuestionId = 16,
                    FullAnswer = "Martin Harris",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 64,
                    QuestionId = 16,
                    FullAnswer = "Sydney Rigdon",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T2 400 Q17 : A(65-68)
                new Answer
                {
                    AnswerId = 65,
                    QuestionId = 17,
                    FullAnswer = "T2 400 Q17 1",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 66,
                    QuestionId = 17,
                    FullAnswer = "T2 400 Q17 2",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 67,
                    QuestionId = 17,
                    FullAnswer = "T2 400 Q17 3",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 68,
                    QuestionId = 17,
                    FullAnswer = "T2 400 Q17 4",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T3 400 Q18 : A(69-72)
                new Answer
                {
                    AnswerId = 69,
                    QuestionId = 18,
                    FullAnswer = "T3 400 Q18 1",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 70,
                    QuestionId = 18,
                    FullAnswer = "T3 400 Q18 2",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 71,
                    QuestionId = 18,
                    FullAnswer = "T3 400 Q18 3",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 72,
                    QuestionId = 18,
                    FullAnswer = "T3 400 Q18 4",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T4 400 Q19 : A(73-76)
                new Answer
                {
                    AnswerId = 73,
                    QuestionId = 19,
                    FullAnswer = "T4 400 Q19 1",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 74,
                    QuestionId = 19,
                    FullAnswer = "T4 400 Q19 2",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 75,
                    QuestionId = 19,
                    FullAnswer = "T4 400 Q19 3",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 76,
                    QuestionId = 19,
                    FullAnswer = "T4 400 Q19 4",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T5 400 Q20 : A(77-80)
                new Answer
                {
                    AnswerId = 77,
                    QuestionId = 20,
                    FullAnswer = "T5 400 Q20 1",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 78,
                    QuestionId = 20,
                    FullAnswer = "T5 400 Q20 2",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 79,
                    QuestionId = 20,
                    FullAnswer = "T5 400 Q20 3",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 80,
                    QuestionId = 20,
                    FullAnswer = "T5 400 Q20 4",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },


                //------500------// Q(21-25)
                ///////////////////// T1 500 Q21 : A(81-84)
                new Answer
                {
                    AnswerId = 81,
                    QuestionId = 21,
                    FullAnswer = "T1 500 Q21 1",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 82,
                    QuestionId = 21,
                    FullAnswer = "T1 500 Q21 2",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 83,
                    QuestionId = 21,
                    FullAnswer = "T1 500 Q21 3",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 84,
                    QuestionId = 21,
                    FullAnswer = "T1 500 Q21 4",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T2 500 Q22 : A(85-88)
                new Answer
                {
                    AnswerId = 85,
                    QuestionId = 22,
                    FullAnswer = "T2 500 Q22 1",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 86,
                    QuestionId = 22,
                    FullAnswer = "T2 500 Q22 2",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 87,
                    QuestionId = 22,
                    FullAnswer = "T2 500 Q22 3",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 88,
                    QuestionId = 22,
                    FullAnswer = "T2 500 Q22 4",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T3 500 Q23 : A(89-92)
                new Answer
                {
                    AnswerId = 89,
                    QuestionId = 23,
                    FullAnswer = "T3 500 Q23 1",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 90,
                    QuestionId = 23,
                    FullAnswer = "T3 500 Q23 2",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 91,
                    QuestionId = 23,
                    FullAnswer = "T3 500 Q23 3",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 92,
                    QuestionId = 23,
                    FullAnswer = "T3 500 Q23 4",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T4 500 Q24 : A(93-96)
                new Answer
                {
                    AnswerId = 93,
                    QuestionId = 24,
                    FullAnswer = "T4 500 Q24 1",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 94,
                    QuestionId = 24,
                    FullAnswer = "T4 500 Q24 2",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 95,
                    QuestionId = 24,
                    FullAnswer = "T4 500 Q24 3",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 96,
                    QuestionId = 24,
                    FullAnswer = "T4 500 Q24 4",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T5 500 Q25 : A(97-100)
                new Answer
                {
                    AnswerId = 97,
                    QuestionId = 25,
                    FullAnswer = "T5 500 Q25 1",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 98,
                    QuestionId = 25,
                    FullAnswer = "T5 500 Q25 2",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 99,
                    QuestionId = 25,
                    FullAnswer = "T5 500 Q25 3",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 100,
                    QuestionId = 25,
                    FullAnswer = "T5 500 Q25 4",
                    Corr_Wrong = false,
                    AnswerNum = 4
                }
            );
        }
    }
}



//================================//
//------------Key-----------------//
//================================//

//"T#" = Topic Number -- according to TopicId
//"Q#" = Question Number -- according to QuestionId
//"#00" = Point Value
//"Q(#-#)" = The range of questions in that section -- according to QuestionId
//"A(#-#)" = The range of answers in that section -- according to AnswerId


//================================//
//-------Table Columns Names------//
//================================//

//----TOPIC-------
//TopicId
//TopicName
//BGColor
//DivColor


//----QUESTION----
//QuestionId
//TopicId
//FullQuestion
//PointValue
//Explanation
//Viewed


//-----ANSWER-------
//AnswerId
//QuestionId
//FullAnswer
//Corr_Wrong
//AnswerNum


