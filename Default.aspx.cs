using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{

  public static string[] arrayForBoard = new string[211];
  public static string[] arrayForNewPiece = new string[35];

  public static int[] arrayForTetrominoes = new int[5];
  public static int[] arrayForNewTetromino = new int[5];

  public static Random newRandom = new Random();
  public static Random newRandomForNextPiece = new Random();

  public static int tetroShape;
  public static int nextTetroShape;

  public static int score;

  public static bool checkForDown = false;
  public static int filledCellsInThisRow = 0;

  public static bool rotationNotAllowed = false;


    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BUTTON_Start_Click(object sender, EventArgs e)
    {

      BUTTON_Down.Visible = true;
      BUTTON_Left.Visible = true;
      BUTTON_Right.Visible = true;
      BUTTON_Up.Visible = true;
      BUTTON_Start.Visible = true;

      score = 0;
      LABEL_Board.Text = "";
      LABEL_Board.Text += " Score: " + score.ToString() + "  ";

      TEXTBOX_Board.Text = "";
      TEXTBOXforNextPiece.Text = "";

      for (int i = 1; i < 211; i++)
      {
        if (i < 201) { arrayForBoard[i] = "[ ]"; }
        else { arrayForBoard[i] = "[x]"; }
      }

      for (int i = 1; i < 35; i++) { arrayForNewPiece[i] = "[ ]"; }

      tetroShape = newRandom.Next(0, 7);

      switch (tetroShape)
      {
        case 0:   /* o */
          arrayForTetrominoes[1] = 1;
          arrayForTetrominoes[2] = 2;
          arrayForTetrominoes[3] = 11;
          arrayForTetrominoes[4] = 12;

          for (int i = 1; i < arrayForTetrominoes.Length; i++)
          { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

        case 1:   /* i */
          arrayForTetrominoes[1] = 1;
          arrayForTetrominoes[2] = 2;
          arrayForTetrominoes[3] = 3;
          arrayForTetrominoes[4] = 4;

          for (int i = 1; i < arrayForTetrominoes.Length; i++)
          { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

        case 2:   /* L */
          arrayForTetrominoes[1] = 1;
          arrayForTetrominoes[2] = 2;
          arrayForTetrominoes[3] = 3;
          arrayForTetrominoes[4] = 11;

          for (int i = 1; i < arrayForTetrominoes.Length; i++)
          { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

        case 3:   /* T */
          arrayForTetrominoes[1] = 1;
          arrayForTetrominoes[2] = 2;
          arrayForTetrominoes[3] = 3;
          arrayForTetrominoes[4] = 12;

          for (int i = 1; i < arrayForTetrominoes.Length; i++)
          { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

        case 4:   /* J */
          arrayForTetrominoes[1] = 1;
          arrayForTetrominoes[2] = 2;
          arrayForTetrominoes[3] = 3;
          arrayForTetrominoes[4] = 13;

          for (int i = 1; i < arrayForTetrominoes.Length; i++)
          { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

        case 5:   /* S */
          arrayForTetrominoes[1] = 2;
          arrayForTetrominoes[2] = 3;
          arrayForTetrominoes[3] = 11;
          arrayForTetrominoes[4] = 12;

          for (int i = 1; i < arrayForTetrominoes.Length; i++)
          { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

        case 6:   /* Z */
          arrayForTetrominoes[1] = 1;
          arrayForTetrominoes[2] = 2;
          arrayForTetrominoes[3] = 12;
          arrayForTetrominoes[4] = 13;

          for (int i = 1; i < arrayForTetrominoes.Length; i++)
          { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

      }

      nextTetroShape = newRandom.Next(0, 7);

      switch (nextTetroShape)
      {
        case 0:   /* o */
          arrayForNewTetromino[1] = 1;
          arrayForNewTetromino[2] = 2;
          arrayForNewTetromino[3] = 11;
          arrayForNewTetromino[4] = 12;

          for (int i = 1; i < arrayForNewTetromino.Length; i++)
          { arrayForNewPiece[arrayForNewTetromino[i]] = "[o]"; } break;

        case 1:   /* i */
          arrayForNewTetromino[1] = 1;
          arrayForNewTetromino[2] = 2;
          arrayForNewTetromino[3] = 3;
          arrayForNewTetromino[4] = 4;

          for (int i = 1; i < arrayForNewTetromino.Length; i++)
          { arrayForNewPiece[arrayForNewTetromino[i]] = "[o]"; } break;

        case 2:   /* L */
          arrayForNewTetromino[1] = 1;
          arrayForNewTetromino[2] = 2;
          arrayForNewTetromino[3] = 3;
          arrayForNewTetromino[4] = 11;

          for (int i = 1; i < arrayForNewTetromino.Length; i++)
          { arrayForNewPiece[arrayForNewTetromino[i]] = "[o]"; } break;

        case 3:   /* T */
          arrayForNewTetromino[1] = 1;
          arrayForNewTetromino[2] = 2;
          arrayForNewTetromino[3] = 3;
          arrayForNewTetromino[4] = 12;

          for (int i = 1; i < arrayForNewTetromino.Length; i++)
          { arrayForNewPiece[arrayForNewTetromino[i]] = "[o]"; } break;

        case 4:   /* J */
          arrayForNewTetromino[1] = 1;
          arrayForNewTetromino[2] = 2;
          arrayForNewTetromino[3] = 3;
          arrayForNewTetromino[4] = 13;

          for (int i = 1; i < arrayForNewTetromino.Length; i++)
          { arrayForNewPiece[arrayForNewTetromino[i]] = "[o]"; } break;

        case 5:   /* S */
          arrayForNewTetromino[1] = 2;
          arrayForNewTetromino[2] = 3;
          arrayForNewTetromino[3] = 11;
          arrayForNewTetromino[4] = 12;

          for (int i = 1; i < arrayForNewTetromino.Length; i++)
          { arrayForNewPiece[arrayForNewTetromino[i]] = "[o]"; } break;

        case 6:   /* Z */
          arrayForNewTetromino[1] = 1;
          arrayForNewTetromino[2] = 2;
          arrayForNewTetromino[3] = 12;
          arrayForNewTetromino[4] = 13;

          for (int i = 1; i < arrayForNewTetromino.Length; i++)
          { arrayForNewPiece[arrayForNewTetromino[i]] = "[o]"; } break;

      }




      for (int i = 1; i < 5; i++) { TEXTBOXforNextPiece.Text += arrayForNewPiece[i]; }
      for (int i = 11; i < 15; i++) { TEXTBOXforNextPiece.Text += arrayForNewPiece[i]; }
      for (int i = 21; i < 25; i++) { TEXTBOXforNextPiece.Text += arrayForNewPiece[i]; }
      for (int i = 31; i < 35; i++) { TEXTBOXforNextPiece.Text += arrayForNewPiece[i]; }


      for (int i = 1; i < 201; i++)
      { TEXTBOX_Board.Text += arrayForBoard[i]; }


    }
    protected void BUTTON_Up_Click(object sender, EventArgs e)
    {
      TEXTBOX_Board.Text = "";

      /* let's implement Rotation */

      switch (tetroShape)
      {

        case 1:

          rotationNotAllowed = false;

          for (int i = 161; i < 201; i++) { if (arrayForTetrominoes[1] == i) { rotationNotAllowed = true; } }

          if (rotationNotAllowed == true) { LABEL_Board.Text = "This rotation is not allowed."; break; }

          else
          {
            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

            arrayForTetrominoes[4] -= 3; arrayForTetrominoes[4] += 30;
            arrayForTetrominoes[3] -= 2; arrayForTetrominoes[3] += 20;
            arrayForTetrominoes[2] -= 1; arrayForTetrominoes[2] += 10;
            arrayForTetrominoes[1] -= 0; arrayForTetrominoes[1] += 00;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

            tetroShape = 11;
            break;
          }





        case 11:

          rotationNotAllowed = false;

          for (int i = 0; i < 18; i++)
          {
            if (arrayForTetrominoes[1] == 10 * i + 8 ||
               arrayForTetrominoes[1] == 10 * i + 9 ||
               arrayForTetrominoes[1] == 10 * i + 10)
            { rotationNotAllowed = true; }
          }


          if (rotationNotAllowed == true)
          { LABEL_Board.Text = "Rotation not allowed. Please move this piece to the left."; break; }

          else
          {

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

            arrayForTetrominoes[4] += 3; arrayForTetrominoes[4] -= 30;
            arrayForTetrominoes[3] += 2; arrayForTetrominoes[3] -= 20;
            arrayForTetrominoes[2] += 1; arrayForTetrominoes[2] -= 10;
            arrayForTetrominoes[1] += 0; arrayForTetrominoes[1] -= 00;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

            tetroShape = 1;
            break;

          }

        case 2:

          rotationNotAllowed = false;

          for (int i = 171; i < 201; i++) { if (arrayForTetrominoes[1] == i) { rotationNotAllowed = true; } }

          if (rotationNotAllowed == true) { LABEL_Board.Text = "This rotation is not allowed."; break; }

          else
          {

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

            arrayForTetrominoes[3] += 10; arrayForTetrominoes[3] += 10;
            arrayForTetrominoes[2] += 01; arrayForTetrominoes[2] += 10;
            arrayForTetrominoes[1] += 01; arrayForTetrominoes[1] += 01;
            arrayForTetrominoes[4] -= 10; arrayForTetrominoes[4] += 01;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

            tetroShape = 21;
            break;
          }





        case 21:


          rotationNotAllowed = false;

          for (int i = 0; i < 18; i++)
          {
            if (arrayForTetrominoes[1] == 10 * i + 1 ||
               arrayForTetrominoes[1] == 10 * i + 2)
            { rotationNotAllowed = true; }
          }

          if (rotationNotAllowed == true) { LABEL_Board.Text = "This rotation is not allowed. Please move this piece to the right."; break; }

          else
          {
            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

            arrayForTetrominoes[3] -= 01; arrayForTetrominoes[3] -= 01;
            arrayForTetrominoes[2] += 10; arrayForTetrominoes[2] -= 01;
            arrayForTetrominoes[1] += 10; arrayForTetrominoes[1] += 10;
            arrayForTetrominoes[4] += 01; arrayForTetrominoes[4] += 10;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

            tetroShape = 22;
            break;
          }



        case 22:

          for (int i = 1; i < arrayForTetrominoes.Length; i++)
          { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

          arrayForTetrominoes[3] -= 10; arrayForTetrominoes[3] -= 10;
          arrayForTetrominoes[2] -= 01; arrayForTetrominoes[2] -= 10;
          arrayForTetrominoes[1] -= 01; arrayForTetrominoes[1] -= 01;
          arrayForTetrominoes[4] += 10; arrayForTetrominoes[4] -= 01;

          for (int i = 1; i < arrayForTetrominoes.Length; i++)
          { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

          tetroShape = 23;
          break;

        case 23:

          rotationNotAllowed = false;

          for (int i = 0; i < 18; i++)
          {
            if (arrayForTetrominoes[1] == 10 * i + 10 ||
               arrayForTetrominoes[1] == 10 * i + 9)
            { rotationNotAllowed = true; }
          }

          if (rotationNotAllowed == true) { LABEL_Board.Text = "This rotation is not allowed. Please move this piece to the left."; break; }

          else
          {

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

            arrayForTetrominoes[3] += 01; arrayForTetrominoes[3] += 01;
            arrayForTetrominoes[2] -= 10; arrayForTetrominoes[2] += 01;
            arrayForTetrominoes[1] -= 10; arrayForTetrominoes[1] -= 10;
            arrayForTetrominoes[4] -= 01; arrayForTetrominoes[4] -= 10;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

            tetroShape = 2;
            break;   /* end of case 2 / 21/ 22/ 23 */

          }

        case 3:

          rotationNotAllowed = false;

          for (int i = 171; i < 201; i++) { if (arrayForTetrominoes[1] == i) { rotationNotAllowed = true; } }

          if (rotationNotAllowed == true) { LABEL_Board.Text = "This rotation is not allowed."; break; }

          else
          {

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }


            arrayForTetrominoes[3] += 10; arrayForTetrominoes[3] += 10;
            arrayForTetrominoes[2] += 01; arrayForTetrominoes[2] += 10;
            arrayForTetrominoes[1] += 01; arrayForTetrominoes[1] += 01;
            arrayForTetrominoes[4] += 00; arrayForTetrominoes[4] += 00;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

            tetroShape = 31;
            break;
          }


        case 31:


          rotationNotAllowed = false;

          for (int i = 0; i < 18; i++)
          {
            if (arrayForTetrominoes[1] == 10 * i + 1 ||
               arrayForTetrominoes[1] == 10 * i + 2)
            { rotationNotAllowed = true; }
          }

          if (rotationNotAllowed == true) { LABEL_Board.Text = "This rotation is not allowed. Please move this piece to the right."; break; }

          else
          {

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

            arrayForTetrominoes[3] -= 01; arrayForTetrominoes[3] -= 01;
            arrayForTetrominoes[2] += 10; arrayForTetrominoes[2] -= 01;
            arrayForTetrominoes[1] += 10; arrayForTetrominoes[1] += 10;
            arrayForTetrominoes[4] += 00; arrayForTetrominoes[4] += 00;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

            tetroShape = 32;
            break;

          }


        case 32:

          for (int i = 1; i < arrayForTetrominoes.Length; i++)
          { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

          arrayForTetrominoes[3] -= 10; arrayForTetrominoes[3] -= 10;
          arrayForTetrominoes[2] -= 01; arrayForTetrominoes[2] -= 10;
          arrayForTetrominoes[1] -= 01; arrayForTetrominoes[1] -= 01;
          arrayForTetrominoes[4] += 00; arrayForTetrominoes[4] += 00;

          for (int i = 1; i < arrayForTetrominoes.Length; i++)
          { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

          tetroShape = 33;
          break;

        case 33:

          rotationNotAllowed = false;

          for (int i = 0; i < 18; i++)
          {
            if (arrayForTetrominoes[1] == 10 * i + 10 ||
               arrayForTetrominoes[1] == 10 * i + 9)
            { rotationNotAllowed = true; }
          }

          if (rotationNotAllowed == true) { LABEL_Board.Text = "This rotation is not allowed. Please move this piece to the left."; break; }

          else
          {

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

            arrayForTetrominoes[3] += 01; arrayForTetrominoes[3] += 01;
            arrayForTetrominoes[2] -= 10; arrayForTetrominoes[2] += 01;
            arrayForTetrominoes[1] -= 10; arrayForTetrominoes[1] -= 10;
            arrayForTetrominoes[4] += 00; arrayForTetrominoes[4] += 00;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

            tetroShape = 3;
            break;   /* end of case 3 / 31/ 32/ 33 */

          }

        case 4:


          for (int i = 171; i < 201; i++) { if (arrayForTetrominoes[1] == i) { rotationNotAllowed = true; } }

          if (rotationNotAllowed == true) { LABEL_Board.Text = "This rotation is not allowed."; break; }

          else
          {

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

            arrayForTetrominoes[4] += 10; arrayForTetrominoes[4] -= 01;
            arrayForTetrominoes[3] += 10; arrayForTetrominoes[3] += 10;
            arrayForTetrominoes[2] += 01; arrayForTetrominoes[2] += 10;
            arrayForTetrominoes[1] += 01; arrayForTetrominoes[1] += 01;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

            tetroShape = 41;
            break;
          }



        case 41:


          rotationNotAllowed = false;

          for (int i = 0; i < 18; i++)
          {
            if (arrayForTetrominoes[1] == 10 * i + 1 ||
               arrayForTetrominoes[1] == 10 * i + 2)
            { rotationNotAllowed = true; }
          }

          if (rotationNotAllowed == true) { LABEL_Board.Text = "This rotation is not allowed. Please move this piece to the right."; break; }

          else
          {

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

            arrayForTetrominoes[4] -= 01; arrayForTetrominoes[4] -= 10;
            arrayForTetrominoes[3] -= 01; arrayForTetrominoes[3] -= 01;
            arrayForTetrominoes[2] += 10; arrayForTetrominoes[2] -= 01;
            arrayForTetrominoes[1] += 10; arrayForTetrominoes[1] += 10;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

            tetroShape = 42;
            break;

          }

        case 42:

          for (int i = 1; i < arrayForTetrominoes.Length; i++)
          { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

          arrayForTetrominoes[4] -= 10; arrayForTetrominoes[4] += 01;
          arrayForTetrominoes[3] -= 10; arrayForTetrominoes[3] -= 10;
          arrayForTetrominoes[2] -= 01; arrayForTetrominoes[2] -= 10;
          arrayForTetrominoes[1] -= 01; arrayForTetrominoes[1] -= 01;

          for (int i = 1; i < arrayForTetrominoes.Length; i++)
          { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

          tetroShape = 43;
          break;

        case 43:

          rotationNotAllowed = false;

          for (int i = 0; i < 18; i++)
          {
            if (arrayForTetrominoes[1] == 10 * i + 10 ||
               arrayForTetrominoes[1] == 10 * i + 9)
            { rotationNotAllowed = true; }
          }

          if (rotationNotAllowed == true) { LABEL_Board.Text = "This rotation is not allowed. Please move this piece to the left."; break; }

          else
          {

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

            arrayForTetrominoes[4] += 01; arrayForTetrominoes[4] += 10;
            arrayForTetrominoes[3] += 01; arrayForTetrominoes[3] += 01;
            arrayForTetrominoes[2] -= 10; arrayForTetrominoes[2] += 01;
            arrayForTetrominoes[1] -= 10; arrayForTetrominoes[1] -= 10;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

            tetroShape = 4;
            break;   /* end of case 4 / 41/ 42/ 43 */

          }


        case 5:

          rotationNotAllowed = false;

          for (int i = 171; i < 181; i++)
          {
            if (arrayForTetrominoes[1] == i)
            { rotationNotAllowed = true; }
          }

          if (rotationNotAllowed == true) { LABEL_Board.Text = "This rotation is not allowed. "; break; }

          else
          {

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

            arrayForTetrominoes[1] += 10;
            arrayForTetrominoes[2] -= 1; arrayForTetrominoes[2] += (2 * 10);
            arrayForTetrominoes[3] += 0;
            arrayForTetrominoes[4] -= 10; arrayForTetrominoes[4] -= 1;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

            tetroShape = 51;
            break;
          }
        case 51:

          rotationNotAllowed = false;

          for (int i = 0; i < 18; i++)
          {
            if (arrayForTetrominoes[1] == 10 * i + 10)
            { rotationNotAllowed = true; }
          }

          if (rotationNotAllowed == true) { LABEL_Board.Text = "This rotation is not allowed. Please move this piece to the left."; break; }

          else
          {

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

            arrayForTetrominoes[1] -= 10;
            arrayForTetrominoes[2] -= 1 * -1; arrayForTetrominoes[2] += (2 * 10 * -1);
            arrayForTetrominoes[3] += 0;
            arrayForTetrominoes[4] += 10; arrayForTetrominoes[4] += 1;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

            tetroShape = 5;
            break;             /* end of case 5 / 51 */
          }

        case 6:

          rotationNotAllowed = false;

          for (int i = 171; i < 181; i++)
          {
            if (arrayForTetrominoes[1] == i)
            { rotationNotAllowed = true; }
          }

          if (rotationNotAllowed == true) { LABEL_Board.Text = "This rotation is not allowed. "; break; }

          else
          {

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

            arrayForTetrominoes[1] += 1;
            arrayForTetrominoes[2] += 10;
            arrayForTetrominoes[3] -= 1;
            arrayForTetrominoes[4] -= 2; arrayForTetrominoes[4] += 10;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

            tetroShape = 61;
            break;

          }

        case 61:

          rotationNotAllowed = false;

          for (int i = 0; i < 18; i++)
          {
            if (arrayForTetrominoes[1] == 10 * i + 10)
            { rotationNotAllowed = true; }
          }

          if (rotationNotAllowed == true) { LABEL_Board.Text = "This rotation is not allowed. Please move this piece to the left."; break; }

          else
          {

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

            arrayForTetrominoes[1] -= 1;
            arrayForTetrominoes[2] -= 10;
            arrayForTetrominoes[3] += 1;
            arrayForTetrominoes[4] += 2; arrayForTetrominoes[4] -= 10;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

            tetroShape = 6;
            break;
          }          /* end of case 6 / 61 */

      }  /* end of Switch(TetroShape) */

      for (int i = 1; i < 201; i++)
      { TEXTBOX_Board.Text += arrayForBoard[i]; }
    }
    protected void BUTTON_Down_Click(object sender, EventArgs e)
    {
      /* let's implement line clearing */

      TEXTBOX_Board.Text = "";
      checkForDown = false;
      filledCellsInThisRow = 0;

      for (int i = 1; i < arrayForTetrominoes.Length; i++)
      { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

      arrayForTetrominoes[1] += 10;
      arrayForTetrominoes[2] += 10;
      arrayForTetrominoes[3] += 10;
      arrayForTetrominoes[4] += 10;

      for (int i = 1; i < arrayForTetrominoes.Length; i++)
      { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }



      if (arrayForBoard[arrayForTetrominoes[1] + 10] == "[x]" || arrayForBoard[arrayForTetrominoes[2] + 10] == "[x]" ||
          arrayForBoard[arrayForTetrominoes[3] + 10] == "[x]" || arrayForBoard[arrayForTetrominoes[4] + 10] == "[x]")
      {
        arrayForBoard[arrayForTetrominoes[1]] = "[x]";
        arrayForBoard[arrayForTetrominoes[2]] = "[x]";
        arrayForBoard[arrayForTetrominoes[3]] = "[x]";
        arrayForBoard[arrayForTetrominoes[4]] = "[x]";

        /******/

        checkForDown = true;

        for (int i = 1; i < 20; i++)
        {
          filledCellsInThisRow = 0;
          for (int j = 1; j < 11; j++)
          {
            if (arrayForBoard[10 * i + j] == "[x]")
            {
              filledCellsInThisRow++;
              if (checkForDown == true && filledCellsInThisRow == 10)
              {
                for (int k = 10 * i + j; k > 10; k--) { arrayForBoard[k] = arrayForBoard[k - 10]; }

                score++;
              }
            }
          }
        }


        /**************/

        LABEL_Board.Text = "";
        LABEL_Board.Text += " Score: " + score.ToString() + " ";

        /**************/

        tetroShape = nextTetroShape;

        switch (tetroShape)
        {
          case 0:   /* oooo */
            arrayForTetrominoes[1] = 1;
            arrayForTetrominoes[2] = 2;
            arrayForTetrominoes[3] = 11;
            arrayForTetrominoes[4] = 12;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

          case 1:   /* oooo */
            arrayForTetrominoes[1] = 1;
            arrayForTetrominoes[2] = 2;
            arrayForTetrominoes[3] = 3;
            arrayForTetrominoes[4] = 4;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

          case 2:   /* oooo */
            arrayForTetrominoes[1] = 1;
            arrayForTetrominoes[2] = 2;
            arrayForTetrominoes[3] = 3;
            arrayForTetrominoes[4] = 11;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

          case 3:   /* oooo */
            arrayForTetrominoes[1] = 1;
            arrayForTetrominoes[2] = 2;
            arrayForTetrominoes[3] = 3;
            arrayForTetrominoes[4] = 12;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

          case 4:   /* oooo */
            arrayForTetrominoes[1] = 1;
            arrayForTetrominoes[2] = 2;
            arrayForTetrominoes[3] = 3;
            arrayForTetrominoes[4] = 13;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

          case 5:   /* oooo */
            arrayForTetrominoes[1] = 2;
            arrayForTetrominoes[2] = 3;
            arrayForTetrominoes[3] = 11;
            arrayForTetrominoes[4] = 12;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

          case 6:   /* oooo */
            arrayForTetrominoes[1] = 1;
            arrayForTetrominoes[2] = 2;
            arrayForTetrominoes[3] = 12;
            arrayForTetrominoes[4] = 13;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

        }

        for (int i = 1; i < 35; i++) { arrayForNewPiece[i] = "[ ]"; }

        nextTetroShape = newRandom.Next(0, 7);

        switch (nextTetroShape)
        {
          case 0:   /* o */
            arrayForNewTetromino[1] = 1;
            arrayForNewTetromino[2] = 2;
            arrayForNewTetromino[3] = 11;
            arrayForNewTetromino[4] = 12;

            for (int i = 1; i < arrayForNewTetromino.Length; i++)
            { arrayForNewPiece[arrayForNewTetromino[i]] = "[o]"; } break;

          case 1:   /* i */
            arrayForNewTetromino[1] = 1;
            arrayForNewTetromino[2] = 2;
            arrayForNewTetromino[3] = 3;
            arrayForNewTetromino[4] = 4;

            for (int i = 1; i < arrayForNewTetromino.Length; i++)
            { arrayForNewPiece[arrayForNewTetromino[i]] = "[o]"; } break;

          case 2:   /* L */
            arrayForNewTetromino[1] = 1;
            arrayForNewTetromino[2] = 2;
            arrayForNewTetromino[3] = 3;
            arrayForNewTetromino[4] = 11;

            for (int i = 1; i < arrayForNewTetromino.Length; i++)
            { arrayForNewPiece[arrayForNewTetromino[i]] = "[o]"; } break;

          case 3:   /* T */
            arrayForNewTetromino[1] = 1;
            arrayForNewTetromino[2] = 2;
            arrayForNewTetromino[3] = 3;
            arrayForNewTetromino[4] = 12;

            for (int i = 1; i < arrayForNewTetromino.Length; i++)
            { arrayForNewPiece[arrayForNewTetromino[i]] = "[o]"; } break;

          case 4:   /* J */
            arrayForNewTetromino[1] = 1;
            arrayForNewTetromino[2] = 2;
            arrayForNewTetromino[3] = 3;
            arrayForNewTetromino[4] = 13;

            for (int i = 1; i < arrayForNewTetromino.Length; i++)
            { arrayForNewPiece[arrayForNewTetromino[i]] = "[o]"; } break;

          case 5:   /* S */
            arrayForNewTetromino[1] = 2;
            arrayForNewTetromino[2] = 3;
            arrayForNewTetromino[3] = 11;
            arrayForNewTetromino[4] = 12;

            for (int i = 1; i < arrayForNewTetromino.Length; i++)
            { arrayForNewPiece[arrayForNewTetromino[i]] = "[o]"; } break;

          case 6:   /* Z */
            arrayForNewTetromino[1] = 1;
            arrayForNewTetromino[2] = 2;
            arrayForNewTetromino[3] = 12;
            arrayForNewTetromino[4] = 13;

            for (int i = 1; i < arrayForNewTetromino.Length; i++)
            { arrayForNewPiece[arrayForNewTetromino[i]] = "[o]"; } break;


          /**/





        }  /* end of if(afb[aft[i]] == "[x]") */

        TEXTBOXforNextPiece.Text = "";



        for (int i = 1; i < 5; i++) { TEXTBOXforNextPiece.Text += arrayForNewPiece[i]; }
        for (int i = 11; i < 15; i++) { TEXTBOXforNextPiece.Text += arrayForNewPiece[i]; }
        for (int i = 21; i < 25; i++) { TEXTBOXforNextPiece.Text += arrayForNewPiece[i]; }
        for (int i = 31; i < 35; i++) { TEXTBOXforNextPiece.Text += arrayForNewPiece[i]; }

      }

      TEXTBOX_Board.Text = "";

      for (int i = 1; i < 201; i++)
      { TEXTBOX_Board.Text += arrayForBoard[i]; }

     
    }
    protected void BUTTON_Left_Click(object sender, EventArgs e)
    {
      TEXTBOX_Board.Text = "";

      for (int i = 0; i < 20; i++)
      {
        if (arrayForTetrominoes[1] == 10 * i + 1 || arrayForTetrominoes[2] == 10 * i + 1 ||
            arrayForTetrominoes[3] == 10 * i + 1 || arrayForTetrominoes[4] == 10 * i + 1 ||
  arrayForBoard[arrayForTetrominoes[1] - 1] == "[x]" || arrayForBoard[arrayForTetrominoes[2] - 1] == "[x]" ||
  arrayForBoard[arrayForTetrominoes[3] - 1] == "[x]" || arrayForBoard[arrayForTetrominoes[4] - 1] == "[x]")
        {
          for (int j = 1; j < arrayForTetrominoes.Length; j++)
          {
            arrayForTetrominoes[j] += 1;
            arrayForBoard[arrayForTetrominoes[j]] = "[o]"; ;
          }
        }
      } /* end of Test for Collision */

      for (int i = 1; i < arrayForTetrominoes.Length; i++)
      { arrayForBoard[arrayForTetrominoes[i]] = "[ ]"; }

      arrayForTetrominoes[1] -= 1;
      arrayForTetrominoes[2] -= 1;
      arrayForTetrominoes[3] -= 1;
      arrayForTetrominoes[4] -= 1;

      for (int i = 1; i < arrayForTetrominoes.Length; i++)
      { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; }

      /* testing for collision */

      if (arrayForBoard[arrayForTetrominoes[1] + 10] == "[x]" || arrayForBoard[arrayForTetrominoes[2] + 10] == "[x]" ||
          arrayForBoard[arrayForTetrominoes[3] + 10] == "[x]" || arrayForBoard[arrayForTetrominoes[4] + 10] == "[x]")
      {
        arrayForBoard[arrayForTetrominoes[1]] = "[x]";
        arrayForBoard[arrayForTetrominoes[2]] = "[x]";
        arrayForBoard[arrayForTetrominoes[3]] = "[x]";
        arrayForBoard[arrayForTetrominoes[4]] = "[x]";

        tetroShape = newRandom.Next(0, 7);

        switch (tetroShape)
        {
          case 0:   /* oooo */
            arrayForTetrominoes[1] = 1;
            arrayForTetrominoes[2] = 2;
            arrayForTetrominoes[3] = 11;
            arrayForTetrominoes[4] = 12;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

          case 1:   /* oooo */
            arrayForTetrominoes[1] = 1;
            arrayForTetrominoes[2] = 2;
            arrayForTetrominoes[3] = 3;
            arrayForTetrominoes[4] = 4;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

          case 2:   /* oooo */
            arrayForTetrominoes[1] = 1;
            arrayForTetrominoes[2] = 2;
            arrayForTetrominoes[3] = 3;
            arrayForTetrominoes[4] = 11;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

          case 3:   /* oooo */
            arrayForTetrominoes[1] = 1;
            arrayForTetrominoes[2] = 2;
            arrayForTetrominoes[3] = 3;
            arrayForTetrominoes[4] = 12;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

          case 4:   /* oooo */
            arrayForTetrominoes[1] = 1;
            arrayForTetrominoes[2] = 2;
            arrayForTetrominoes[3] = 3;
            arrayForTetrominoes[4] = 13;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

          case 5:   /* oooo */
            arrayForTetrominoes[1] = 2;
            arrayForTetrominoes[2] = 3;
            arrayForTetrominoes[3] = 11;
            arrayForTetrominoes[4] = 12;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

          case 6:   /* oooo */
            arrayForTetrominoes[1] = 1;
            arrayForTetrominoes[2] = 2;
            arrayForTetrominoes[3] = 12;
            arrayForTetrominoes[4] = 13;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

        }
      }  /* end of if(afb[aft[i]] == "[x]") */

      for (int i = 1; i < 201; i++)
      { TEXTBOX_Board.Text += arrayForBoard[i]; }
    }
 
 protected void BUTTON_Right_Click(object sender, EventArgs e)
    {
      TEXTBOX_Board.Text = "";

      for (int i = 0; i < 20; i++)
      {
        if (arrayForTetrominoes[1] == 10 * i || arrayForTetrominoes[2] == 10 * i ||
            arrayForTetrominoes[3] == 10 * i || arrayForTetrominoes[4] == 10 * i ||
  arrayForBoard[arrayForTetrominoes[1] + 1] == "[x]" || arrayForBoard[arrayForTetrominoes[2] + 1] == "[x]" ||
  arrayForBoard[arrayForTetrominoes[3] + 1] == "[x]" || arrayForBoard[arrayForTetrominoes[4] + 1] == "[x]")
        {
          for (int j = 1; j < arrayForTetrominoes.Length; j++)
          {
            arrayForTetrominoes[j] -= 1;
            arrayForBoard[arrayForTetrominoes[j]] = "[o]"; ;
          }
        }
      }

      for (int i = 1; i < arrayForTetrominoes.Length; i++) 
      {
        arrayForBoard[arrayForTetrominoes[i]] = "[ ]";
      }

      arrayForTetrominoes[4] += 1;
      arrayForTetrominoes[3] += 1;
      arrayForTetrominoes[2] += 1;
      arrayForTetrominoes[1] += 1;

      for (int i = 1; i < arrayForTetrominoes.Length; i++)
      {
        arrayForBoard[arrayForTetrominoes[i]] = "[o]"; ;
      }

      /* testing for collision */

      if (arrayForBoard[arrayForTetrominoes[1] + 10] == "[x]" || arrayForBoard[arrayForTetrominoes[2] + 10] == "[x]" ||
          arrayForBoard[arrayForTetrominoes[3] + 10] == "[x]" || arrayForBoard[arrayForTetrominoes[4] + 10] == "[x]")
      {
        arrayForBoard[arrayForTetrominoes[1]] = "[x]";
        arrayForBoard[arrayForTetrominoes[2]] = "[x]";
        arrayForBoard[arrayForTetrominoes[3]] = "[x]";
        arrayForBoard[arrayForTetrominoes[4]] = "[x]";

        tetroShape = newRandom.Next(0, 7);

        switch (tetroShape)
        {
          case 0:   /* oooo */
            arrayForTetrominoes[1] = 1;
            arrayForTetrominoes[2] = 2;
            arrayForTetrominoes[3] = 11;
            arrayForTetrominoes[4] = 12;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

          case 1:   /* oooo */
            arrayForTetrominoes[1] = 1;
            arrayForTetrominoes[2] = 2;
            arrayForTetrominoes[3] = 3;
            arrayForTetrominoes[4] = 4;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

          case 2:   /* oooo */
            arrayForTetrominoes[1] = 1;
            arrayForTetrominoes[2] = 2;
            arrayForTetrominoes[3] = 3;
            arrayForTetrominoes[4] = 11;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

          case 3:   /* oooo */
            arrayForTetrominoes[1] = 1;
            arrayForTetrominoes[2] = 2;
            arrayForTetrominoes[3] = 3;
            arrayForTetrominoes[4] = 12;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

          case 4:   /* oooo */
            arrayForTetrominoes[1] = 1;
            arrayForTetrominoes[2] = 2;
            arrayForTetrominoes[3] = 3;
            arrayForTetrominoes[4] = 13;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

          case 5:   /* oooo */
            arrayForTetrominoes[1] = 2;
            arrayForTetrominoes[2] = 3;
            arrayForTetrominoes[3] = 11;
            arrayForTetrominoes[4] = 12;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

          case 6:   /* oooo */
            arrayForTetrominoes[1] = 1;
            arrayForTetrominoes[2] = 2;
            arrayForTetrominoes[3] = 12;
            arrayForTetrominoes[4] = 13;

            for (int i = 1; i < arrayForTetrominoes.Length; i++)
            { arrayForBoard[arrayForTetrominoes[i]] = "[o]"; } break;

        }
      }  /* end of if(afb[aft[i]] == "[x]") */

      for (int i = 1; i < 201; i++)
      { TEXTBOX_Board.Text += arrayForBoard[i]; }
    }
    
}