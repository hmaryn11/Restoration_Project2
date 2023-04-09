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
                    TopicName = "Joseph's Fallacies",
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
                    Explanation = "Alvin Smith was described as being 'serious and hardworking, and Joseph loved and admired him immensely.' Joseph looked to Alvin for advice and support and Alvin was happy to give it to him. Being one of the first people who believed Joseph’s accounts of his visions, he encouraged Joseph to do all he could to fulfill the will of God.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 2,
                    TopicId = 2,
                    FullQuestion = "What level of education did Joseph have when he began translating the Book of Mormon?",
                    PointValue = 100,
                    Explanation = "The Smith family was stricken with poverty and could not afford the luxury of public education. This was not terribly uncommon for families in similar situations during the early 1800s. Though Joseph had very little formal education, he was able to translate an ancient record in a foreign language in just a few months. It seems that the odds were stacked against him. Therefore, this could only have been done through the gift and power of God. And Joseph did not claim to have translated it in any other way.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 3,
                    TopicId = 3,
                    FullQuestion = "Who visited Joseph and Oliver Cowdery to confer the Aaronic Priesthood on them and give them the authority to baptize?",
                    PointValue = 100,
                    Explanation = "In his lifetime, John the Baptist had authority and power from God known as the Aaronic Priesthood. This gave him the authority to baptize, the power of the ministering of angels, and more. Therefore, he was chosen to pass this power and authority on to Joseph and Oliver so that the work of salvation could move forward on this earth.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 4,
                    TopicId = 4,
                    FullQuestion = "Joseph records that in his early encounters with God and other heavenly beings, he first had to _____ before receiving any further knowledge or instruction.",
                    PointValue = 100,
                    Explanation = "Before Joseph was able to receive any guidance from the Lord, he had to be sufficiently humble. This was the case when he first came to God to find the true church, when Moroni visited him to tell him about the plates, when he went to obtain the plates, and countless other times. Just like us, Joseph too had many things to repent of and much refining to go through. However, once he repented, the Lord’s trust was restored in Joseph, and he was again worthy to further the work.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 5,
                    TopicId = 5,
                    FullQuestion = "How did the local Methodist preacher respond after Joseph told him about his first vision?",
                    PointValue = 100,
                    Explanation = "This preacher along with most other people in the community responded with contempt when Joseph told about his vision. They assumed he was a young boy trying to start trouble, or making himself look good, or confuse people, or that he had been possessed by the devil. None of them would believe that God had spoken to a teenage boy in a poor family. But this was the perfect person for God to speak to. He was humble, he was hungry for knowledge, and he was willing to do what it took to gain that knowledge. But the people refused to see this and mocked Joseph relentlessly for it.",
                    Viewed = false
                },
                ///////////////////// 200 : Q(6-10)
                new Question
                {
                    QuestionId = 6,
                    TopicId = 1,
                    FullQuestion = "When Joseph was finally authorized to obtain the plates, who did he take with him?",
                    PointValue = 200,
                    Explanation = "The angel Moroni originally instructed Joseph to bring Alvin with him to obtain the plates. When Alvin died, Joseph didn't know who he would bring with him. But, Moroni assured him that he would know who he was to bring when the time was right. Throughout their life together, Emma became more than his wife. She also became his companion. They worked together as a team and took care of each other in love. ‘Like Alvin, she was someone who could help him become the man the Lord needed to carry out His work.’ (Saints v.1, p34)",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 7,
                    TopicId = 2,
                    FullQuestion = "What does D&C 135 state that Joseph did for the salvation of men?",
                    PointValue = 200,
                    Explanation = "D&C 135:3 reads 'Joseph Smith, the Prophet and Seer of the Lord, has done more, save Jesus only, for the salvation of men in this world, than any other man that ever lived in it.' When we think of all the blessings that we as members of the church enjoy, we owe most of the restoration of these blessings to Joseph and the work he did on this earth. He in large part helped make it possible for all men to return to God.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 8,
                    TopicId = 3,
                    FullQuestion = "Joseph was working in the field the day after Moroni’s first visit. On his way home, Joseph collapsed due to exhaustion and was again visited by Moroni. In addition to rehearsing what he said the night before, what else did Moroni tell Joseph this time?",
                    PointValue = 200,
                    Explanation = "Moroni knew that Joseph’s father was a man of faith and that he would believe him when he told him about this vision. Moroni also knew that Joseph’s father could provide him with reassurance, support, and guidance. And that he did. When Joseph told his father about this vision, he began to weep and told Joseph that “It was a vision from God,” and to “Attend to it.”",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 9,
                    TopicId = 4,
                    FullQuestion = "What was the reason Joseph had to wait 4 years before he could obtain the plates?",
                    PointValue = 200,
                    Explanation = "Each time that Joseph came in the years before, the Lord knew he wasn't ready to protect the plates and use them only for the sacred purpose the were intended. The 1st time he went to obtain them, he thought of the worldly worth of the plates, was physically shocked, and could not obtain them. The 2nd time, when reaching for the plates, he thought of covering the other items there that might be valueable. He took his eyes off the plates for a second and they disappeared. He was not yet ready to protect the plates. The 3rd time, Joseph had been working as a 'money digger' (similar to a treasure hunter) and Moroni told him to quit this job before he could receive the plates. The fourth year, Joseph had been sufficiently prepared and he could then take the plates.",
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
                    Explanation = "Like most young people, Joseph and his friends cared a lot about worldly wealth and gain. Accounting this time of his life, Joseph wrote ,’I was left to all kinds of temptations; and, mingling with all kinds of society, I frequently fell into many foolish errors, and displayed the weakness of youth.’ (JSH 1:28) This desire and focus on the vanities of the world would prove to be a hindrance for Joseph in the future in fulfilling the Lord's wishes.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 12,
                    TopicId = 2,
                    FullQuestion = "While in jail in Richmond, Missouri, Joseph and other church leaders were tied up on the floor listening to their captors mock and speak cruelly against them and their fellow members. What did Joseph do in response to their mockery and filthy language?",
                    PointValue = 300,
                    Explanation = "Despite the fact that Joseph was a prisoner of those that he rebuked, he had had enough of their cruel speech. Parley P. Pratt, who was a fellow prisoner at this time, recorded Joseph’s rebuke. ‘SILENCE, ye fiends of the infernal pit. In the name of Jesus Christ I rebuke you, and command you to be still; I will not live another minute and hear such language. Cease such talk, or you or I die THIS INSTANT!’ This terrified their captors who then hid and begged for his pardon. However, it encouraged the other prisoners as they saw their leader stand as an angel, steadfast and dignified rebuking these men.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 13,
                    TopicId = 3,
                    FullQuestion = "Who did Moroni show to Joseph in a vision the first time he found the plates and was rebuked for trying to take them for gain?",
                    PointValue = 300,
                    Explanation = "Although this vision may seem harsh, this was Moroni’s way of warning Joseph. ‘’Look,’ Moroni commanded. Another vision unfolded before Joseph, and he saw Satan surrounded by his numberless host. ‘All this is shown, the good and the evil, the holy and impure, the glory of God and the power of darkness,’ the angel declared, ‘that you may know hereafter the two powers and never be influenced or overcome by that wicked one.’’ (Saints vol.1, p26) This would prove to be an important lesson for Joseph to learn as Satan would do all he could to stop the work of the Lord.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 14,
                    TopicId = 4,
                    FullQuestion = "What happened to Joseph after Martin Harris left with the pages of the translated manuscript?",
                    PointValue = 300,
                    Explanation = "Saints Vol. 1 records that right after Martin left, even before the pages were lost, Moroni appeared to take the interpreting tools away from Joseph. It was of course a tragedy that the pages were lost along with the teachings and story in those pages, but it was more tragic that Joseph had disobeyed God. This was an important lesson for Joseph to learn, but it was also very excruciating time for him, knowing that he had disobeyed and disappointed God.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 15,
                    TopicId = 5,
                    FullQuestion = "Julia and Joseph, twin babies of Emma and Joseph, suffered from measles as infants. However, what does Joseph blame for the death of his son (Joseph)?",
                    PointValue = 300,
                    Explanation = "People in the community and some in the church were so mad at Joseph’s claims that he had seen visions and was receiving extra knowledge from God. They banded together to drag Joseph out of his house in the middle of the night and tar and feather his body. This was a heart wrenching experience for Joseph and Emma. And on top of it, their son died about a week later due to the draft from the door opening when the men dragged him away.",
                    Viewed = false
                },
                ///////////////////// 400 : Q(16-20)
                new Question
                {
                    QuestionId = 16,
                    TopicId = 1,
                    FullQuestion = "Moroni told Joseph that his name 'should be had for good and evil among all nations, kindreds, and tongues' (JSH 1:33). Who else did Joseph say this statement applied to?",
                    PointValue = 400,
                    Explanation = "Due to different controversial things President Brigham was involved in, his name is used to revile the Lord’s church.Unfortunately, even some members of the church look to Brigham Young with distaste and disdain.However, without the things that Brigham Young did for the church, all of the work of Joseph might have been lost. People thought that once Joseph was dead, the church would crumble. It is a common practice in history that in order to silence a religious sect, you take out its leader.This was especially evident in England during the Protestant Reformation. But Brigham Young was not going to let that happen. He made sure that the church thrived and continued with the vigor that Joseph had started it with.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 17,
                    TopicId = 2,
                    FullQuestion = "The majority of the Book of Mormon was translated in the span of how many months?",
                    PointValue = 400,
                    Explanation = "Joseph and his various scribes experienced a lot of difficulties in trying to translate the Book of Mormon. Because of this, they were forced to hide the plates, translate sporadically, and translate quickly to get it completed and to protect the plates. Although it was about two years from the time Joseph received the plates to when they were finished being translated, the majority of this translation was done from April 1829 to June 1829. As Joseph declared, the only way this was possible, is through the power and gift of God.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 18,
                    TopicId = 3,
                    FullQuestion = "What had to happen before Joseph Smith, David Whitmer, Martin Harris, and Oliver Cowdery (the 3 witnesses) were shown the vision of the plates?",
                    PointValue = 400,
                    Explanation = "After Joseph had chosen who the three witnesses were to be, he took them to the woods to pray to God to reveal the plates. They all prayed fervently, but nothing happened. Then Martin expressed that he felt he was the reason they weren’t receiving an answer, and he left their presence. Once he left, the other three were shown the vision of the plates. Once this vision was over, Joseph left Oliver and David and found Martin praying. He joined him and they too were able to see the same vision.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 19,
                    TopicId = 4,
                    FullQuestion = "In addition to the men that had betrayed Joseph and apostatized from the church, who else might Joseph have been speaking about in D&C 121:39? (look up the verse and think of historical context)",
                    PointValue = 400,
                    Explanation = "This statement in D&C 121:39 was written when Joseph was reflecting on the events of the past months. Many members had apostatized and were now fighting against the church, the Danites and other groups were forcing these people out, Sydney Rigdon had given a speech encouraging such action (the Salt Sermon), and Joseph had lashed out in rage at men that had betrayed him. This verse seems to imply that Joseph was rethinking his own actions and the actions of men he supported (like Sydney) and condeming these actions.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 20,
                    TopicId = 5,
                    FullQuestion = "What document did Joseph blame for the resistance of the men who led the mod that eventually killed him? And who wrote/commissioned this document?",
                    PointValue = 400,
                    Explanation = "Emma was back and forth about the revelation of plural marriage most of her life. In a time when she was contemptuous of it, Emma saw an opportunity to fight against plural marriage. She used her station as president of the Relief Society to convince many women to sign a document saying the practice was adulterous. But this document only gave the enemies of Joseph (who were already mad about the practice of polygamy) fuel. Joseph Smith wrote, ‘I never had any fuss with these men until that Female Relief Society brought out the paper against adulterers and adulteresses.’",
                    Viewed = false
                },
                ///////////////////// 500 : Q(21-25)
                new Question
                {
                    QuestionId = 21,
                    TopicId = 1,
                    FullQuestion = "Joseph had a loyal friend who was given the promise that his life would only be taken away from him if he chose. This friend chose to give us his life for the church. Who was his friend?",
                    PointValue = 500,
                    Explanation = "Hyrum stayed by Joseph’s side. He was promised by the Lord that he would not be killed unless he chose to allow himself to die. When he rode off to Carthage with Joseph, Joseph told him to stay because he knew they would likely be killed. But Hyrum decided to go with him, sealing his testimony with his life that he chose to give up.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 22,
                    TopicId = 2,
                    FullQuestion = "Application Question: Which miracle of Joseph’s Smith life is most meaningful to you?",
                    PointValue = 500,
                    Explanation = "There is much we can learn from the life of Joseph Smith and much of his life that we can consider miracles. This could be the translation of the Book of Mormon, the times when his life was spared, a miracle of healing he performed, the miracle of the repentance of Joseph Smith, and more. Which is most impactful to you?",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 23,
                    TopicId = 3,
                    FullQuestion = "What vision did Sydney and Joseph have in the upstairs room of the Johnson house in 1832?",
                    PointValue = 500,
                    Explanation = "Earlier, Joseph and Sydney had been contemplating the idea that God is so gracious to us on this earth to give us so many chances, why is it not like that in heaven? In this vision, they saw the three degrees of glory in the heavens, confirming their suspicions regarding God’s mercy. After the vision had finished, Sydney looked exhausted and pale and Joseph looked to him, smiled, and said ‘Sidney is not used to it as I am.’",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 24,
                    TopicId = 4,
                    FullQuestion = "According to the many second-hand accounts, what happened to Joseph when he hesitated to implement the revelation of plural marriage?",
                    PointValue = 500,
                    Explanation = "Joseph could see the hurt that could be caused by the practice of plural marriage, so he was hesitant to continue to follow and implement the revelation. And he was right, this was a hard revelation for many people at that time and even now. However, the Lord knew all the good that would come out of it. His purposes were higher and He knew what needed to be done in order to fulfill His plan of happiness. Therefore, when Joseph showed resistance, the Lord was stern with him to make sure he carried out this revelation.",
                    Viewed = false
                },
                new Question
                {
                    QuestionId = 25,
                    TopicId = 5,
                    FullQuestion = "Who were the men who testified against Joseph after he was arrested for treason due to the battles between members and state men in Missouri?",
                    PointValue = 500,
                    Explanation = "This betrayal left Joseph furious. While in prison, he wrote a letter comparing these men to wicked men in the Bible and saying there were “too mean to mention and we had liked to have forgotten them”. And “whose hearts are full of corruption, whose cloak of hypocrisy was not sufficient to shield them or to hold them up in the hour of trouble”. These were men that he had put his full faith and trust in at one point, whom he once called friends. But, the adversary had gotten hold of their hearts and they no longer cared about the work of Lord.",
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
                    FullAnswer = "Equivalent to an elementary level education",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 6,
                    QuestionId = 2,
                    FullAnswer = "Equivalent to a middle school level education",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 7,
                    QuestionId = 2,
                    FullAnswer = "Equivalent to a high school level education",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 8,
                    QuestionId = 2,
                    FullAnswer = "Equivalent to an college level education",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T3 100 Q3 : A(9-12)
                new Answer
                {
                    AnswerId = 9,
                    QuestionId = 3,
                    FullAnswer = "John the Baptist",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 10,
                    QuestionId = 3,
                    FullAnswer = "Peter, James and John",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 11,
                    QuestionId = 3,
                    FullAnswer = "Elijah",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 12,
                    QuestionId = 3,
                    FullAnswer = "Jesus Christ",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T4 100 Q4 : A(13-16)
                new Answer
                {
                    AnswerId = 13,
                    QuestionId = 4,
                    FullAnswer = "Repent",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 14,
                    QuestionId = 4,
                    FullAnswer = "Talk to his father",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 15,
                    QuestionId = 4,
                    FullAnswer = "Go to the woods",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 16,
                    QuestionId = 4,
                    FullAnswer = "Study",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T5 100 Q5 : A(17-20)
                new Answer
                {
                    AnswerId = 17,
                    QuestionId = 5,
                    FullAnswer = "THe told him the vision was of the devil",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 18,
                    QuestionId = 5,
                    FullAnswer = "He gave him a hug and told him he was proud of him",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 19,
                    QuestionId = 5,
                    FullAnswer = "He kicked him out of his congregation",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 20,
                    QuestionId = 5,
                    FullAnswer = "He was confused, but continued to listen with respect and curiousity",
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
                    FullAnswer = "He stood and rebuked them.",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 46,
                    QuestionId = 12,
                    FullAnswer = "He held his peace and said nothing.",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 47,
                    QuestionId = 12,
                    FullAnswer = "He stood and attacked the men.",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 48,
                    QuestionId = 12,
                    FullAnswer = "He sqeezed Parley Pratt's hand and prayed for deliverance.",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T3 300 Q13 : A(49-52)
                new Answer
                {
                    AnswerId = 49,
                    QuestionId = 13,
                    FullAnswer = "Satan and his numberless host",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 50,
                    QuestionId = 13,
                    FullAnswer = "Moroni when he was burying the plates",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 51,
                    QuestionId = 13,
                    FullAnswer = "Jesus Christ and the Father",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 52,
                    QuestionId = 13,
                    FullAnswer = "His future family",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T4 300 Q14 : A(53-56)
                new Answer
                {
                    AnswerId = 53,
                    QuestionId = 14,
                    FullAnswer = "Morori appeared and took the interpreting tools away from him",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 54,
                    QuestionId = 14,
                    FullAnswer = "He fainted",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 55,
                    QuestionId = 14,
                    FullAnswer = "Emma told him that the plates would be lost",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 56,
                    QuestionId = 14,
                    FullAnswer = "He was less stressed with less pages to keep track of",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T5 300 Q15 : A(57-60)
                new Answer
                {
                    AnswerId = 57,
                    QuestionId = 15,
                    FullAnswer = "The cold air that came into the house when the mob took him to be tarred and feathered",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 58,
                    QuestionId = 15,
                    FullAnswer = "The masacre at the Haun's Mill",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 59,
                    QuestionId = 15,
                    FullAnswer = "The Lord punishing Joseph for his disobedience",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 60,
                    QuestionId = 15,
                    FullAnswer = "The lack of attention Joseph gave him because of his calling",
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
                    FullAnswer = "3 months",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 66,
                    QuestionId = 17,
                    FullAnswer = "5 months",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 67,
                    QuestionId = 17,
                    FullAnswer = "18 months",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 68,
                    QuestionId = 17,
                    FullAnswer = "10 months",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T3 400 Q18 : A(69-72)
                new Answer
                {
                    AnswerId = 69,
                    QuestionId = 18,
                    FullAnswer = "Martin Harris needed to withdraw himself from the group",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 70,
                    QuestionId = 18,
                    FullAnswer = "They needed to repent of their sins",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 71,
                    QuestionId = 18,
                    FullAnswer = "Joseph needed to describe the plates to them",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 72,
                    QuestionId = 18,
                    FullAnswer = "Oliver needed to sneeze",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T4 400 Q19 : A(73-76)
                new Answer
                {
                    AnswerId = 73,
                    QuestionId = 19,
                    FullAnswer = "Himself and Sydney Rigdon",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 74,
                    QuestionId = 19,
                    FullAnswer = "Joseph Smith Sr",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 75,
                    QuestionId = 19,
                    FullAnswer = "Martin Harris",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 76,
                    QuestionId = 19,
                    FullAnswer = "Future Millenials",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T5 400 Q20 : A(77-80)
                new Answer
                {
                    AnswerId = 77,
                    QuestionId = 20,
                    FullAnswer = "The 'Voice of Innocence' written by Emma Smith",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 78,
                    QuestionId = 20,
                    FullAnswer = "The apology letter written by Martin Harris",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 79,
                    QuestionId = 20,
                    FullAnswer = "The 'Danite Manifesto' written by Joseph Knight",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 80,
                    QuestionId = 20,
                    FullAnswer = "The second-hand account of Joseph's First Vision written by Orson Hyde",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },


                //------500------// Q(21-25)
                ///////////////////// T1 500 Q21 : A(81-84)
                new Answer
                {
                    AnswerId = 81,
                    QuestionId = 21,
                    FullAnswer = "Hyrum Smith",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 82,
                    QuestionId = 21,
                    FullAnswer = "Sydney Rigdon",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 83,
                    QuestionId = 21,
                    FullAnswer = "John Taylor",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 84,
                    QuestionId = 21,
                    FullAnswer = "Joseph Knight",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T2 500 Q22 : A(85-88)
                new Answer
                {
                    AnswerId = 85,
                    QuestionId = 22,
                    FullAnswer = "Your Answer",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 86,
                    QuestionId = 22,
                    FullAnswer = "Prof Sweat's Answer",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 87,
                    QuestionId = 22,
                    FullAnswer = "Your neighbor's answer",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 88,
                    QuestionId = 22,
                    FullAnswer = "The person-behind-you's answer",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T3 500 Q23 : A(89-92)
                new Answer
                {
                    AnswerId = 89,
                    QuestionId = 23,
                    FullAnswer = "A visions of the Plan of Salvation",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 90,
                    QuestionId = 23,
                    FullAnswer = "God revealing the high priesthood",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 91,
                    QuestionId = 23,
                    FullAnswer = "A vision of how Joseph would die",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 92,
                    QuestionId = 23,
                    FullAnswer = "Marvel's Vision",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T4 500 Q24 : A(93-96)
                new Answer
                {
                    AnswerId = 93,
                    QuestionId = 24,
                    FullAnswer = "An angel appeared to him with a drawn sword to command him to implement the practice",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 94,
                    QuestionId = 24,
                    FullAnswer = "Emma was so happy that she gave him a big hug and kiss",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 95,
                    QuestionId = 24,
                    FullAnswer = "Emma worked to stop the practice all together",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 96,
                    QuestionId = 24,
                    FullAnswer = "The power of revelation was taken away from him for a time",
                    Corr_Wrong = false,
                    AnswerNum = 4
                },
                ///////////////////// T5 500 Q25 : A(97-100)
                new Answer
                {
                    AnswerId = 97,
                    QuestionId = 25,
                    FullAnswer = "Thomas B. Marsh, W.W. Phelps, Orson Hyde, and John Whitmer",
                    Corr_Wrong = true,
                    AnswerNum = 1
                },
                new Answer
                {
                    AnswerId = 98,
                    QuestionId = 25,
                    FullAnswer = "Oliver Cowdery, John Whitmer, and Martin Harris",
                    Corr_Wrong = false,
                    AnswerNum = 2
                },
                new Answer
                {
                    AnswerId = 99,
                    QuestionId = 25,
                    FullAnswer = "W.W. Phelps, Oliver Cowdery, Joseph Knight, and John C. Bennett",
                    Corr_Wrong = false,
                    AnswerNum = 3
                },
                new Answer
                {
                    AnswerId = 100,
                    QuestionId = 25,
                    FullAnswer = "John C. Bennett, Francis M. Higbee, and James Foster",
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


