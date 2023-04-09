using Microsoft.EntityFrameworkCore.Migrations;

namespace Restoration_Project.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Topic",
                columns: table => new
                {
                    TopicId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TopicName = table.Column<string>(nullable: true),
                    BGColor = table.Column<string>(nullable: true),
                    DivColor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.TopicId);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    QuestionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TopicId = table.Column<int>(nullable: false),
                    FullQuestion = table.Column<string>(nullable: true),
                    PointValue = table.Column<int>(nullable: false),
                    Explanation = table.Column<string>(nullable: true),
                    Viewed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Question_Topic_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topic",
                        principalColumn: "TopicId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    AnswerId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QuestionId = table.Column<int>(nullable: false),
                    FullAnswer = table.Column<string>(nullable: true),
                    Corr_Wrong = table.Column<bool>(nullable: false),
                    AnswerNum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answer_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "TopicId", "BGColor", "DivColor", "TopicName" },
                values: new object[] { 1, "orangered", "peachpuff", "People's Influence" });

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "TopicId", "BGColor", "DivColor", "TopicName" },
                values: new object[] { 2, "orange", "lightseagreen", "A Man of Miracles" });

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "TopicId", "BGColor", "DivColor", "TopicName" },
                values: new object[] { 3, "peachpuff", "mediumblue", "Visions & Visitations" });

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "TopicId", "BGColor", "DivColor", "TopicName" },
                values: new object[] { 4, "lightseagreen", "orangered", "Joseph's Falacies" });

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "TopicId", "BGColor", "DivColor", "TopicName" },
                values: new object[] { 5, "mediumblue", "orange", "Trial By Fire" });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 1, "Alvin Smith was described as being 'serious and hardworking, and Joseph loved and admired him immensely.' Joseph looked to Alvin for advice and support and Alvin was happy to give it to him. Being one of the first people who believed Joseph’s accounts of his visions, he encouraged Joseph to do all he could to fulfill the will of God.", "Which family member was Joseph closest to and looked up to the most?", 100, 1, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 15, "People in the community and some in the church were so mad at Joseph’s claims that he had seen visions and was receiving extra knowledge from God. They banded together to drag Joseph out of his house in the middle of the night and tar and feather his body. This was a heart wrenching experience for Joseph and Emma. And on top of it, their son died about a week later due to the draft from the door opening when the men dragged him away.", "Julia and Joseph, twin babies of Emma and Joseph, suffered from measles as infants. However, what does Joseph blame for the death of his son (Joseph)?", 300, 5, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 10, "After an invasion of mob men to their prison room in Carthage Jail, Joseph and Hyrum were both shot bringing their service to the Lord on this earth to an end. Sealing their testimonies with their lives. The two other men in the prison with them, John Taylor and Willard Richards, survived the raid and gave their testimony of the event. It is because of these men's accounts of this day that we know the truthfulness of the events of June 27th, 1844.", "What were Joseph and Hyrum's final exclamations when they were killed?", 200, 5, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 5, "This preacher along with most other people in the community responded with contempt when Joseph told about his vision. They assumed he was a young boy trying to start trouble, or making himself look good, or confuse people, or that he had been possessed by the devil. None of them would believe that God had spoken to a teenage boy in a poor family. But this was the perfect person for God to speak to. He was humble, he was hungry for knowledge, and he was willing to do what it took to gain that knowledge. But the people refused to see this and mocked Joseph relentlessly for it.", "How did the local Methodist preacher respond after Joseph told him about his first vision?", 100, 5, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 24, "Joseph could see the hurt that could be caused by the practice of plural marriage, so he was hesitant to continue to follow and implement the revelation. And he was right, this was a hard revelation for many people at that time and even now. However, the Lord knew all the good that would come out of it. His purposes were higher and He knew what needed to be done in order to fulfill His plan of happiness. Therefore, when Joseph showed resistance, the Lord was stern with him to make sure he carried out this revelation.", "According to the many second-hand accounts, what happened to Joseph when he hesitated to implement the revelation of plural marriage?", 500, 4, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 19, "This statement in D&C 121:39 was written when Joseph was reflecting on the events of the past months. Many members had apostatized and were now fighting against the church, the Danites and other groups were forcing these people out, Sydney Rigdon had given a speech encouraging such action (the Salt Sermon), and Joseph had lashed out in rage at men that had betrayed him. This verse seems to imply that Joseph was rethinking his own actions and the actions of men he supported (like Sydney) and condeming these actions.", "In addition to the men that had betrayed Joseph and apostatized from the church, who else might Joseph have been speaking about in D&C 121:39? (look up the verse and think of historical context)", 400, 4, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 14, "Saints Vol. 1 records that right after Martin left, even before the pages were lost, Moroni appeared to take the interpreting tools away from Joseph. It was of course a tragedy that the pages were lost along with the teachings and story in those pages, but it was more tragic that Joseph had disobeyed God. This was an important lesson for Joseph to learn, but it was also very excruciating time for him, knowing that he had disobeyed and disappointed God.", "What happened to Joseph after Martin Harris left with the pages of the translated manuscript?", 300, 4, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 9, "Each time that Joseph came in the years before, the Lord knew he wasn't ready to protect the plates and use them only for the sacred purpose the were intended. The 1st time he went to obtain them, he thought of the worldly worth of the plates, was physically shocked, and could not obtain them. The 2nd time, when reaching for the plates, he thought of covering the other items there that might be valueable. He took his eyes off the plates for a second and they disappeared. He was not yet ready to protect the plates. The 3rd time, Joseph had been working as a 'money digger' (similar to a treasure hunter) and Moroni told him to quit this job before he could receive the plates. The fourth year, Joseph had been sufficiently prepared and he could then take the plates.", "What was the reason Joseph had to wait 4 years before he could obtain the plates?", 200, 4, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 4, "Before Joseph was able to receive any guidance from the Lord, he had to be sufficiently humble. This was the case when he first came to God to find the true church, when Moroni visited him to tell him about the plates, when he went to obtain the plates, and countless other times. Just like us, Joseph too had many things to repent of and much refining to go through. However, once he repented, the Lord’s trust was restored in Joseph, and he was again worthy to further the work.", "Joseph records that in his early encounters with God and other heavenly beings, he first had to _____ before receiving any further knowledge or instruction.", 100, 4, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 23, "Earlier, Joseph and Sydney had been contemplating the idea that God is so gracious to us on this earth to give us so many chances, why is it not like that in heaven? In this vision, they saw the three degrees of glory in the heavens, confirming their suspicions regarding God’s mercy. After the vision had finished, Sydney looked exhausted and pale and Joseph looked to him, smiled, and said ‘Sidney is not used to it as I am.’", "What vision did Sydney and Joseph have in the upstairs room of the Johnson house in 1832?", 500, 3, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 18, "After Joseph had chosen who the three witnesses were to be, he took them to the woods to pray to God to reveal the plates. They all prayed fervently, but nothing happened. Then Martin expressed that he felt he was the reason they weren’t receiving an answer, and he left their presence. Once he left, the other three were shown the vision of the plates. Once this vision was over, Joseph left Oliver and David and found Martin praying. He joined him and they too were able to see the same vision.", "What had to happen before Joseph Smith, David Whitmer, Martin Harris, and Oliver Cowdery (the 3 witnesses) were shown the vision of the plates?", 400, 3, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 20, "Emma was back and forth about the revelation of plural marriage most of her life. In a time when she was contemptuous of it, Emma saw an opportunity to fight against plural marriage. She used her station as president of the Relief Society to convince many women to sign a document saying the practice was adulterous. But this document only gave the enemies of Joseph (who were already mad about the practice of polygamy) fuel. Joseph Smith wrote, ‘I never had any fuss with these men until that Female Relief Society brought out the paper against adulterers and adulteresses.’", "What document did Joseph blame for the resistance of the men who led the mod that eventually killed him? And who wrote/commissioned this document?", 400, 5, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 13, "Although this vision may seem harsh, this was Moroni’s way of warning Joseph. ‘’Look,’ Moroni commanded. Another vision unfolded before Joseph, and he saw Satan surrounded by his numberless host. ‘All this is shown, the good and the evil, the holy and impure, the glory of God and the power of darkness,’ the angel declared, ‘that you may know hereafter the two powers and never be influenced or overcome by that wicked one.’’ (Saints vol.1, p26) This would prove to be an important lesson for Joseph to learn as Satan would do all he could to stop the work of the Lord.", "Who did Moroni show to Joseph in a vision the first time he found the plates and was rebuked for trying to take them for gain?", 300, 3, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 3, "In his lifetime, John the Baptist had authority and power from God known as the Aaronic Priesthood. This gave him the authority to baptize, the power of the ministering of angels, and more. Therefore, he was chosen to pass this power and authority on to Joseph and Oliver so that the work of salvation could move forward on this earth.", "Who visited Joseph and Oliver Cowdery to confer the Aaronic Priesthood on them and give them the authority to baptize?", 100, 3, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 22, "There is much we can learn from the life of Joseph Smith and much of his life that we can consider miracles. This could be the translation of the Book of Mormon, the times when his life was spared, a miracle of healing he performed, the miracle of the repentance of Joseph Smith, and more. Which is most impactful to you?", "Application Question: Which miracle of Joseph’s Smith life is most meaningful to you?", 500, 2, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 17, "Joseph and his various scribes experienced a lot of difficulties in trying to translate the Book of Mormon. Because of this, they were forced to hide the plates, translate sporadically, and translate quickly to get it completed and to protect the plates. Although it was about two years from the time Joseph received the plates to when they were finished being translated, the majority of this translation was done from April 1829 to June 1829. As Joseph declared, the only way this was possible, is through the power and gift of God.", "The majority of the Book of Mormon was translated in the span of how many months?", 400, 2, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 12, "Despite the fact that Joseph was a prisoner of those that he rebuked, he had had enough of their cruel speech. Parley P. Pratt, who was a fellow prisoner at this time, recorded Joseph’s rebuke. ‘SILENCE, ye fiends of the infernal pit. In the name of Jesus Christ I rebuke you, and command you to be still; I will not live another minute and hear such language. Cease such talk, or you or I die THIS INSTANT!’ This terrified their captors who then hid and begged for his pardon. However, it encouraged the other prisoners as they saw their leader stand as an angel, steadfast and dignified rebuking these men.", "While in jail in Richmond, Missouri, Joseph and other church leaders were tied up on the floor listening to their captors mock and speak cruelly against them and their fellow members. What did Joseph do in response to their mockery and filthy language?", 300, 2, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 7, "D&C 135:3 reads 'Joseph Smith, the Prophet and Seer of the Lord, has done more, save Jesus only, for the salvation of men in this world, than any other man that ever lived in it.' When we think of all the blessings that we as members of the church enjoy, we owe most of the restoration of these blessings to Joseph and the work he did on this earth. He in large part helped make it possible for all men to return to God.", "What does D&C 135 state that Joseph did for the salvation of men?", 200, 2, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 2, "The Smith family was stricken with poverty and could not afford the luxury of public education. This was not terribly uncommon for families in similar situations during the early 1800s. Though Joseph had very little formal education, he was able to translate an ancient record in a foreign language in just a few months. It seems that the odds were stacked against him. Therefore, this could only have been done through the gift and power of God. And Joseph did not claim to have translated it in any other way.", "What level of education did Joseph have when he began translating the Book of Mormon?", 100, 2, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 21, "Hyrum stayed by Joseph’s side. He was promised by the Lord that he would not be killed unless he chose to allow himself to die. When he rode off to Carthage with Joseph, Joseph told him to stay because he knew they would likely be killed. But Hyrum decided to go with him, sealing his testimony with his life that he chose to give up.", "Joseph had a loyal friend who was given the promise that his life would only be taken away from him if he chose. This friend chose to give us his life for the church. Who was his friend?", 500, 1, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 16, "Due to different controversial things President Brigham was involved in, his name is used to revile the Lord’s church.Unfortunately, even some members of the church look to Brigham Young with distaste and disdain.However, without the things that Brigham Young did for the church, all of the work of Joseph might have been lost. People thought that once Joseph was dead, the church would crumble. It is a common practice in history that in order to silence a religious sect, you take out its leader.This was especially evident in England during the Protestant Reformation. But Brigham Young was not going to let that happen. He made sure that the church thrived and continued with the vigor that Joseph had started it with.", "Moroni told Joseph that his name 'should be had for good and evil among all nations, kindreds, and tongues' (JSH 1:33). Who else did Joseph say this statement applied to?", 400, 1, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 11, "Like most young people, Joseph and his friends cared a lot about worldly wealth and gain. Accounting this time of his life, Joseph wrote ,’I was left to all kinds of temptations; and, mingling with all kinds of society, I frequently fell into many foolish errors, and displayed the weakness of youth.’ (JSH 1:28) This desire and focus on the vanities of the world would prove to be a hindrance for Joseph in the future in fulfilling the Lord's wishes.", "Who influenced Joseph as a young man to do foolish things and got him into trouble at times?", 300, 1, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 6, "The angel Moroni originally instructed Joseph to bring Alvin with him to obtain the plates. When Alvin died, Joseph didn't know who he would bring with him. But, Moroni assured him that he would know who he was to bring when the time was right. Throughout their life together, Emma became more than his wife. She also became his companion. They worked together as a team and took care of each other in love. ‘Like Alvin, she was someone who could help him become the man the Lord needed to carry out His work.’ (Saints v.1, p34)", "When Joseph was finally authorized to obtain the plates, who did he take with him?", 200, 1, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 8, "Moroni knew that Joseph’s father was a man of faith and that he would believe him when he told him about this vision. Moroni also knew that Joseph’s father could provide him with reassurance, support, and guidance. And that he did. When Joseph told his father about this vision, he began to weep and told Joseph that “It was a vision from God,” and to “Attend to it.”", "Joseph was working in the field the day after Moroni’s first visit. On his way home, Joseph collapsed due to exhaustion and was again visited by Moroni. In addition to rehearsing what he said the night before, what else did Moroni tell Joseph this time?", 200, 3, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 25, "This betrayal left Joseph furious. While in prison, he wrote a letter comparing these men to wicked men in the Bible and saying there were “too mean to mention and we had liked to have forgotten them”. And “whose hearts are full of corruption, whose cloak of hypocrisy was not sufficient to shield them or to hold them up in the hour of trouble”. These were men that he had put his full faith and trust in at one point, whom he once called friends. But, the adversary had gotten hold of their hearts and they no longer cared about the work of Lord.", "Who were the men who testified against Joseph after he was arrested for treason due to the battles between members and state men in Missouri?", 500, 5, false });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 1, 1, true, "Alvin Smith", 1 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 73, 1, true, "Himself and Sydney Rigdon", 19 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 56, 4, false, "He was less stressed with less pages to keep track of", 14 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 55, 3, false, "Emma told him that the plates would be lost", 14 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 54, 2, false, "He fainted", 14 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 53, 1, true, "Morori appeared and took the interpreting tools away from him", 14 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 36, 4, false, "He had to stop being mean to his mother and learn to treat her with respect.", 9 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 35, 3, false, "He had to work on the farm to help his family save money.", 9 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 34, 2, false, "He had to wait until he was strong enough to move the rock where the plates were hidden.", 9 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 33, 1, true, "He had to overcome his covetousness and his desire for worldly gain.", 9 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 16, 4, false, "Study", 4 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 15, 3, false, "Go to the woods", 4 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 14, 2, false, "Talk to his father", 4 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 13, 1, true, "Repent", 4 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 92, 4, false, "Marvel's Vision", 23 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 91, 3, false, "A vision of how Joseph would die", 23 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 90, 2, false, "God revealing the high priesthood", 23 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 89, 1, true, "A visions of the Plan of Salvation", 23 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 72, 4, false, "Oliver needed to sneeze", 18 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 71, 3, false, "Joseph needed to describe the plates to them", 18 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 70, 2, false, "They needed to repent of their sins", 18 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 69, 1, true, "Martin Harris needed to withdraw himself from the group", 18 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 74, 2, false, "Joseph Smith Sr", 19 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 52, 4, false, "His future family", 13 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 75, 3, false, "Martin Harris", 19 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 93, 1, true, "An angel appeared to him with a drawn sword to command him to implement the practice", 24 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 98, 2, false, "Oliver Cowdery, John Whitmer, and Martin Harris", 25 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 97, 1, true, "Thomas B. Marsh, W.W. Phelps, Orson Hyde, and John Whitmer", 25 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 80, 4, false, "The second-hand account of Joseph's First Vision written by Orson Hyde", 20 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 79, 3, false, "The 'Danite Manifesto' written by Joseph Knight", 20 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 78, 2, false, "The apology letter written by Martin Harris", 20 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 77, 1, true, "The 'Voice of Innocence' written by Emma Smith", 20 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 60, 4, false, "The lack of attention Joseph gave him because of his calling", 15 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 59, 3, false, "The Lord punishing Joseph for his disobedience", 15 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 58, 2, false, "The masacre at the Haun's Mill", 15 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 57, 1, true, "The cold air that came into the house when the mob took him to be tarred and feathered", 15 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 40, 4, false, "Hyrum: 'Please, protect them'   Joseph: 'Til we meet again'", 10 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 39, 3, false, "Hyrum: 'My God, my Savior'   Joseph: 'Lord, save me'", 10 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 38, 2, false, "Hyrum: 'Joseph, run!'   Joseph: 'We will be together with God'", 10 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 37, 1, true, "Hyrum: 'I'm a dead man'   Joseph: 'O Lord my God'", 10 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 20, 4, false, "He was confused, but continued to listen with respect and curiousity", 5 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 19, 3, false, "He kicked him out of his congregation", 5 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 18, 2, false, "He gave him a hug and told him he was proud of him", 5 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 17, 1, true, "THe told him the vision was of the devil", 5 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 96, 4, false, "The power of revelation was taken away from him for a time", 24 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 95, 3, false, "Emma worked to stop the practice all together", 24 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 94, 2, false, "Emma was so happy that she gave him a big hug and kiss", 24 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 76, 4, false, "Future Millenials", 19 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 51, 3, false, "Jesus Christ and the Father", 13 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 50, 2, false, "Moroni when he was burying the plates", 13 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 49, 1, true, "Satan and his numberless host", 13 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 6, 2, false, "Equivalent to a middle school level education", 2 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 5, 1, true, "Equivalent to an elementary level education", 2 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 84, 4, false, "Joseph Knight", 21 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 83, 3, false, "John Taylor", 21 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 82, 2, false, "Sydney Rigdon", 21 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 81, 1, true, "Hyrum Smith", 21 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 64, 4, false, "Sydney Rigdon", 16 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 63, 3, false, "Martin Harris", 16 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 62, 2, false, "Porter Rockwell", 16 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 61, 1, true, "Brigham Young", 16 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 44, 4, false, "The old lady accross the street", 11 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 43, 3, false, "The local preachers", 11 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 42, 2, false, "His brothers", 11 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 41, 1, true, "His friends", 11 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 24, 4, false, "Oliver Cowdery", 6 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 23, 3, false, "Hyrum Smith", 6 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 22, 2, false, "Martin Harris", 6 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 21, 1, true, "Emma Smith", 6 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 4, 4, false, "William Smith", 1 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 3, 3, false, "Hyrum Smith", 1 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 2, 2, false, "Lucy Smith", 1 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 7, 3, false, "Equivalent to a high school level education", 2 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 8, 4, false, "Equivalent to an college level education", 2 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 25, 1, true, "More, save Jesus only", 7 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 26, 2, false, "Restored priesthood keys", 7 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 32, 4, false, "He told him to find Martin Harris to be his scribe.", 8 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 31, 3, false, "He told Joseph to run home, because his mother had made pie.", 8 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 30, 2, false, "He told him to go and obtain the plates.", 8 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 29, 1, true, "He told him to tell his father about his vision.", 8 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 12, 4, false, "Jesus Christ", 3 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 11, 3, false, "Elijah", 3 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 10, 2, false, "Peter, James and John", 3 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 9, 1, true, "John the Baptist", 3 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 88, 4, false, "The person-behind-you's answer", 22 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 87, 3, false, "Your neighbor's answer", 22 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 99, 3, false, "W.W. Phelps, Oliver Cowdery, Joseph Knight, and John C. Bennett", 25 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 86, 2, false, "Prof Sweat's Answer", 22 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 68, 4, false, "10 months", 17 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 67, 3, false, "18 months", 17 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 66, 2, false, "5 months", 17 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 65, 1, true, "3 months", 17 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 48, 4, false, "He sqeezed Parley Pratt's hand and prayed for deliverance.", 12 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 47, 3, false, "He stood and attacked the men.", 12 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 46, 2, false, "He held his peace and said nothing.", 12 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 45, 1, true, "He stood and rebuked them.", 12 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 28, 4, false, "Initiated temple work for the dead", 7 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 27, 3, false, "Translated the Book of Mormon", 7 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 85, 1, true, "Your Answer", 22 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 100, 4, false, "John C. Bennett, Francis M. Higbee, and James Foster", 25 });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_TopicId",
                table: "Question",
                column: "TopicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Topic");
        }
    }
}
