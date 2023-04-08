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
                values: new object[] { 1, "Alvin was described as being 'serious and hardworking, and Joseph loved and admired him immensely.' Alvin was one of the first people to believe Joseph about the visions he had been having and he encouraged Joseph to do all he could to fulfill the will of God.", "Which family member was Joseph closest to and looked up to the most?", 100, 1, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 15, "Question 15", "T5 300", 300, 5, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 10, "After an invasion of mob men to their prison room in Carthage Jail, Joseph and Hyrum were both shot bringing their service to the Lord on this earth to an end. Sealing their testimonies with their lives. The two other men in the prison with them, John Taylor and Willard Richards, survived the raid and gave their testimony of the event. It is because of these men's accounts of this day that we know the truthfulness of the events of June 27th, 1844.", "What were Joseph and Hyrum's final exclamations when they were killed?", 200, 5, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 5, "Question 5", "T5 100", 100, 5, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 24, "Question 24", " T4 500", 500, 4, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 19, "Question 19", "T4 400", 400, 4, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 14, "Question 14", " T4 300", 300, 4, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 9, "Each time that Joseph came in the years before, the Lord knew he wasn't ready to protect the plates and use them only for the sacred purpose the were intended. The 1st time he went to obtain them, he thought of the worldly worth of the plates, was physically shocked, and could not obtain them. The 2nd time, when reaching for the plates, he thought of covering the other items there that might be valueable. He took his eyes off the plates for a second and they disappeared. He was not yet ready to protect the plates. The 3rd time, Joseph had been working as a 'money digger' (similar to a treasure hunter) and Moroni told him to quit this job before he could receive the plates. The fourth year, Joseph had been sufficiently prepared and he could then take the plates. ", "What was the reason Joseph had to wait 4 years before he could obtain the plates?", 200, 4, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 4, "Question 4", " T4 100", 100, 4, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 23, "Question 23", "T3 500", 500, 3, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 18, "Question 18", "T3 400", 400, 3, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 20, "Question 20", "T5 400", 400, 5, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 13, "Question 13", "T3 300", 300, 3, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 3, "Question 3", "T3 100", 100, 3, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 22, "Question 22", "T2 500", 500, 2, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 17, "Question 17", "T2 400", 400, 2, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 12, "Question 12", "T2 300", 300, 2, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 7, "D&C 135:3 states 'Joseph Smith, the Prophet and Seer of the Lord, has done more, save Jesus only, for the salvation of men in this world, than any other man that ever lived in it.' When we think of all the blessings that we as members of the church enjoy, we owe most of the restoation of these blessings to Joseph and the work he did on this earth. He helped in the work to make it possible for all men, not only those who are members in this life, to return to God.", "What does D&C 135 state that Joseph did for the salvation of men?", 200, 2, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 2, "Question 2", "T2 100", 100, 2, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 21, "Question 21", "T1 500", 500, 1, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 16, "People thought that once Joseph was dead, the church would crumble. But thanks to Brigham Young, this was not the case. He made sure that the church thrived and continued with the vigor that Joseph had started it with. Unfortunately, people today, even some members of the church, look to President Young with distaste and distain due to things he did that some perceive as sinful. However, without the work that Brigham Young did for the church, all of the work of Joseph might have been lost. President Young was able to keep the fire of the church burning and we have much to thank him for.", "Moroni told Joseph that his name 'should be had for good and evil among all nations, kindreds, and tongues' (JSH 1:33). Who else did Joseph say this prophecy applied to?", 400, 1, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 11, "Like most young people, Joseph and his friends cared a lot about worldly wealth and in particular, treasure. They would often search for it together. This desire and focus on getting gain would be a problem for Joseph in the future in fulfilling the Lord's wishes.", "Who influenced Joseph as a young man to do foolish things and got him into trouble at times?", 300, 1, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 6, "The angel Moroni originally instructed Joseph to bring Alvin with him to obtain the plates. When Alvin dies, Joseph didn't know who he would bring with him. But, Moroni assured him that he would know who he was to bring when the time was right. Emma became more than his wife, she also became his companion. They worked together as a team and took care of each other in love.", "When Joseph was finally authorized to obtain the plates, who did he take with him?", 200, 1, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 8, "Moroni visited him", "Joseph was working in the field the day after Moroni’s first visit. On his way home, Joseph collapsed due to exhaustion and was again visited by Moroni. In addition to rehearsing what he said the night before, what else did Moroni tell Joseph this time?", 200, 3, false });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "Explanation", "FullQuestion", "PointValue", "TopicId", "Viewed" },
                values: new object[] { 25, "Question 25", "T5 500", 500, 5, false });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 1, 1, true, "Alvin Smith", 1 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 73, 1, true, "T4 400 Q19 1", 19 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 56, 4, false, "T4 300 Q14 4", 14 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 55, 3, false, "T4 300 Q14 3", 14 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 54, 2, false, "T4 300 Q14 2", 14 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 53, 1, true, "T4 300 Q14 1", 14 });

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
                values: new object[] { 16, 4, false, "T4 100 Q4 4", 4 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 15, 3, false, "T4 100 Q4 3", 4 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 14, 2, false, "T4 100 Q4 2", 4 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 13, 1, true, "T4 100 Q4 1", 4 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 92, 4, false, "T3 500 Q23 4", 23 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 91, 3, false, "T3 500 Q23 3", 23 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 90, 2, false, "T3 500 Q23 2", 23 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 89, 1, true, "T3 500 Q23 1", 23 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 72, 4, false, "T3 400 Q18 4", 18 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 71, 3, false, "T3 400 Q18 3", 18 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 70, 2, false, "T3 400 Q18 2", 18 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 69, 1, true, "T3 400 Q18 1", 18 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 74, 2, false, "T4 400 Q19 2", 19 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 52, 4, false, "T3 300 Q13 4", 13 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 75, 3, false, "T4 400 Q19 3", 19 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 93, 1, true, "T4 500 Q24 1", 24 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 98, 2, false, "T5 500 Q25 2", 25 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 97, 1, true, "T5 500 Q25 1", 25 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 80, 4, false, "T5 400 Q20 4", 20 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 79, 3, false, "T5 400 Q20 3", 20 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 78, 2, false, "T5 400 Q20 2", 20 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 77, 1, true, "T5 400 Q20 1", 20 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 60, 4, false, "T5 300 Q15 4", 15 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 59, 3, false, "T5 300 Q15 3", 15 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 58, 2, false, "T5 300 Q15 2", 15 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 57, 1, true, "T5 300 Q15 1", 15 });

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
                values: new object[] { 20, 4, false, "T5 100 Q5 4", 5 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 19, 3, false, "T5 100 Q5 3", 5 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 18, 2, false, "T5 100 Q5 2", 5 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 17, 1, true, "T5 100 Q5 1", 5 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 96, 4, false, "T4 500 Q24 4", 24 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 95, 3, false, "T4 500 Q24 3", 24 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 94, 2, false, "T4 500 Q24 2", 24 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 76, 4, false, "T4 400 Q19 4", 19 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 51, 3, false, "T3 300 Q13 3", 13 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 50, 2, false, "T3 300 Q13 2", 13 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 49, 1, true, "T3 300 Q13 1", 13 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 6, 2, false, "T2 100 Q2 2", 2 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 5, 1, true, "T2 100 Q2 1", 2 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 84, 4, false, "T1 500 Q21 4", 21 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 83, 3, false, "T1 500 Q21 3", 21 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 82, 2, false, "T1 500 Q21 2", 21 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 81, 1, true, "T1 500 Q21 1", 21 });

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
                values: new object[] { 7, 3, false, "T2 100 Q2 3", 2 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 8, 4, false, "T2 100 Q2 4", 2 });

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
                values: new object[] { 12, 4, false, "T3 100 Q3 4", 3 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 11, 3, false, "T3 100 Q3 3", 3 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 10, 2, false, "T3 100 Q3 2", 3 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 9, 1, true, "T3 100 Q3 1", 3 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 88, 4, false, "T2 500 Q22 4", 22 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 87, 3, false, "T2 500 Q22 3", 22 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 99, 3, false, "T5 500 Q25 3", 25 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 86, 2, false, "T2 500 Q22 2", 22 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 68, 4, false, "T2 400 Q17 4", 17 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 67, 3, false, "T2 400 Q17 3", 17 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 66, 2, false, "T2 400 Q17 2", 17 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 65, 1, true, "T2 400 Q17 1", 17 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 48, 4, false, "T2 300 Q12 4", 12 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 47, 3, false, "T2 300 Q12 3", 12 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 46, 2, false, "T2 300 Q12 2", 12 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 45, 1, true, "T2 300 Q12 1", 12 });

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
                values: new object[] { 85, 1, true, "T2 500 Q22 1", 22 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "AnswerId", "AnswerNum", "Corr_Wrong", "FullAnswer", "QuestionId" },
                values: new object[] { 100, 4, false, "T5 500 Q25 4", 25 });

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
