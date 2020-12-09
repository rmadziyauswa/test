using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoTestsInterview
{
    public class JustifyNewspaper
    {
        public string[] justifyNewspaperText(string[][]lines, string[] aligns, int width)
        {
            var result = new List<string>();
            //create starLine which is * mulitiplied by width + 2
            var starLine = string.Empty;
            for (int i = 0; i < width+2; i++)
            {
                starLine += "*";
            }

            //add first line which is starLine
            result.Add(starLine);

            //loop for each lines[i]
            //calculate length of lines[i] = count of the words + numSpaces(numWords-1)
            //if length is less than or equal to width
            //calculate whiteSPace = width - lengthOfLine
            //append whiteSpace to line either left or right based on align[i]
            //put * to start and end of line
            //add the line to the resultList
            //else lengthOfLine is more than width
            //call LengthOfLineGreaterThanWidth(line[i],width,align[i])
            for (int i = 0; i < lines.Length; i++)
            {
                var lineArray = lines[i];
                var lineToAdd = string.Empty;
                for (int j = 0; j < lineArray.Length; j++)
                {
                    if(string.IsNullOrEmpty(lineToAdd))
                    {
                        lineToAdd = lineArray[j];
                    }
                    else
                    {
                        lineToAdd += " " + lineArray[j];
                    }
                }

                var lengthOfLine = lineToAdd.Length;
                if (lengthOfLine <= width)
                {
                    lineToAdd = AddWhiteSpace(lineToAdd, width, aligns[i]);

                    lineToAdd = $"*{lineToAdd}*";
                    result.Add(lineToAdd);
                }
                else
                {
                    result.AddRange(LengthOfLineGreaterThanWidth(lines[i], width, aligns[i]));
                }

            }

            //finally add last line which is starLine
            result.Add(starLine);
            return result.ToArray();
        }

        //function for lengthOfLine greater than width
        private string[] LengthOfLineGreaterThanWidth(string[] s,int width,string align)
        {
            var result = new List<string>();
            //lop for each s[i]
            //create varS = s[i] + s[i+1] plus whitespaces
            //if varS is less than width
            //align varS and append * at start and end
            //add it to result
            //else
            // align s[i] and append * at start and end
            //add it to Result
            //create sNew = remove s[i] from s array
            //do result.Add(LengthOfLineGreaterThanWidth(sNew,width,align))
            if(s.Length > 1)
            {
                var sLength = s[0].Length + s[1].Length + 1;
                if (sLength < width)
                {
                    var ls = $"{s[0]} {s[1]}";
                    var lineToAdd = $"*{AddWhiteSpace(ls, width, align)}*";
                    result.Add(lineToAdd);
                }
                else
                {
                    var lineToAdd = $"*{AddWhiteSpace(s[0], width, align)}*";
                    result.Add(lineToAdd);
                    var sNew = s.Where((s, i) => i > 0).ToArray();
                    result.AddRange(LengthOfLineGreaterThanWidth(sNew, width, align));
                }

            }
            else
            {
                var lineToAdd = $"*{AddWhiteSpace(s[0], width, align)}*";
                result.Add(lineToAdd);
            }


            return result.ToArray();
        }

        private string AddWhiteSpace(string s, int width,string align)
        {
            var whiteSpaceCount = width - s.Length;
            var whiteSpaceString = string.Empty;
            for (int x = 0; x < whiteSpaceCount; x++)
            {
                whiteSpaceString += " ";
            }

            if (align.ToUpper().Equals("RIGHT"))
            {
                s = whiteSpaceString + s;
            }
            else
            {
                s = s + whiteSpaceString;
            }

            return s;
        }
    }
}
