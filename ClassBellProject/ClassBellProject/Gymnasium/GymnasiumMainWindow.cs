using ClassBellProject.Primary;
using System.Data;
using System.Data.SqlClient;
using System.Media;

namespace ClassBellProject.Gymnasium
{
    public partial class GymnasiumMainWindow : Form
    {
        public GymnasiumMainWindow()
        {
            InitializeComponent();
            foreach (string format in formats)
            {
                comboBoxStartFormatInterval1.Items.Add(format);
                comboBoxStartFormatInterval2.Items.Add(format);
                comboBoxStartFormatInterval3.Items.Add(format);
                comboBoxStartFormatInterval4.Items.Add(format);
                comboBoxStartFormatInterval5.Items.Add(format);
                comboBoxStartFormatInterval6.Items.Add(format);
                comboBoxStartFormatInterval7.Items.Add(format);
                comboBoxStartFormatInterval8.Items.Add(format);
                comboBoxStartFormatInterval9.Items.Add(format);
                comboBoxStartFormatInterval10.Items.Add(format);
            }
            foreach (string format in formats)
            {
                comboBoxStopFormatInterval1.Items.Add(format);
                comboBoxStopFormatInterval2.Items.Add(format);
                comboBoxStopFormatInterval3.Items.Add(format);
                comboBoxStopFormatInterval4.Items.Add(format);
                comboBoxStopFormatInterval5.Items.Add(format);
                comboBoxStopFormatInterval6.Items.Add(format);
                comboBoxStopFormatInterval7.Items.Add(format);
                comboBoxStopFormatInterval8.Items.Add(format);
                comboBoxStopFormatInterval9.Items.Add(format);
                comboBoxStopFormatInterval10.Items.Add(format);
            }
            foreach (string hour in hours)
            {
                comboBoxStartHourInterval1.Items.Add(hour);
                comboBoxStartHourInterval2.Items.Add(hour);
                comboBoxStartHourInterval3.Items.Add(hour);
                comboBoxStartHourInterval4.Items.Add(hour);
                comboBoxStartHourInterval5.Items.Add(hour);
                comboBoxStartHourInterval6.Items.Add(hour);
                comboBoxStartHourInterval7.Items.Add(hour);
                comboBoxStartHourInterval8.Items.Add(hour);
                comboBoxStartHourInterval9.Items.Add(hour);
                comboBoxStartHourInterval10.Items.Add(hour);
            }
            foreach (string hour in hours)
            {
                comboBoxStopHourInterval1.Items.Add(hour);
                comboBoxStopHourInterval2.Items.Add(hour);
                comboBoxStopHourInterval3.Items.Add(hour);
                comboBoxStopHourInterval4.Items.Add(hour);
                comboBoxStopHourInterval5.Items.Add(hour);
                comboBoxStopHourInterval6.Items.Add(hour);
                comboBoxStopHourInterval7.Items.Add(hour);
                comboBoxStopHourInterval8.Items.Add(hour);
                comboBoxStopHourInterval9.Items.Add(hour);
                comboBoxStopHourInterval10.Items.Add(hour);
            }
            foreach (string minute in minutes)
            {
                comboBoxStartMinuteInterval1.Items.Add(minute);
                comboBoxStartMinuteInterval2.Items.Add(minute);
                comboBoxStartMinuteInterval3.Items.Add(minute);
                comboBoxStartMinuteInterval4.Items.Add(minute);
                comboBoxStartMinuteInterval5.Items.Add(minute);
                comboBoxStartMinuteInterval6.Items.Add(minute);
                comboBoxStartMinuteInterval7.Items.Add(minute);
                comboBoxStartMinuteInterval8.Items.Add(minute);
                comboBoxStartMinuteInterval9.Items.Add(minute);
                comboBoxStartMinuteInterval10.Items.Add(minute);
            }
            foreach (string minute in minutes)
            {
                comboBoxStopMinuteInterval1.Items.Add(minute);
                comboBoxStopMinuteInterval2.Items.Add(minute);
                comboBoxStopMinuteInterval3.Items.Add(minute);
                comboBoxStopMinuteInterval4.Items.Add(minute);
                comboBoxStopMinuteInterval5.Items.Add(minute);
                comboBoxStopMinuteInterval6.Items.Add(minute);
                comboBoxStopMinuteInterval7.Items.Add(minute);
                comboBoxStopMinuteInterval8.Items.Add(minute);
                comboBoxStopMinuteInterval9.Items.Add(minute);
                comboBoxStopMinuteInterval10.Items.Add(minute);
            }
        }

        List<string> hours = new List<string>()
        {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"
        };
        List<string> minutes = new List<string>()
        {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"
        };
        List<string> formats = new List<string>()
        {
            "AM",
            "PM"
        };

        public List<string> KeepDaysSelected()
        {
            List<string> daysChecked = new List<string>();

            List<string> days = checkedListBoxDaysGymnasium.Items.Cast<string>().ToList();

            foreach (string day in days)
            {
                if (checkedListBoxDaysGymnasium.CheckedItems.Contains(day))
                {
                    switch (day)
                    {
                        case "Luni":
                            daysChecked.Add(DayOfWeek.Monday.ToString());
                            break;
                        case "Marti":
                            daysChecked.Add(DayOfWeek.Tuesday.ToString());
                            break;
                        case "Miercuri":
                            daysChecked.Add(DayOfWeek.Wednesday.ToString());
                            break;
                        case "Joi":
                            daysChecked.Add(DayOfWeek.Thursday.ToString());
                            break;
                        case "Vineri":
                            daysChecked.Add(DayOfWeek.Friday.ToString());
                            break;
                        case "Sambata":
                            daysChecked.Add(DayOfWeek.Saturday.ToString());
                            break;
                        case "Duminica":
                            daysChecked.Add(DayOfWeek.Sunday.ToString());
                            break;
                    }
                }
            }

            return daysChecked;
        }

        public async Task StartSongsAndTonesByIntervalsAndDaysGymnasiumAsync(CancellationToken cancellationTokenParameter)
        {
            Dictionary<int, string> indexesAndDays = new Dictionary<int, string>()
            {
                {1,  "Monday"},
                {2,  "Tuesday"},
                {3,  "Wednesday"},
                {4,  "Thursday"},
                {5,  "Friday"},
                {6,  "Saturday"},
                {7,  "Sunday"}
            };
            List<string> daysSelected = KeepDaysSelected();

            if (daysSelected.Count == 0)
            {
                return;
            }
            else
            {
                while (!cancellationTokenParameter.IsCancellationRequested)
                {
                    for (int i = 0; i < daysSelected.Count; i++)
                    {
                        if (daysSelected[i] == DateTime.Now.DayOfWeek.ToString())
                        {
                            int[] shuffleSongsGymnasium = ShuffleAllSongsGymnasium();
                            int songCursor = 0;
                            int indexNumber = 0;
                            int actualDayKeyForIntervalsAndChecks = indexesAndDays.FirstOrDefault(x => x.Value == daysSelected[i]).Key;
                            List<IntervalsAndChecksGymnasium> actualIntervalsAndChecksByDayId = GetAllIntervalsAndChecksGymnasiumByDayId(actualDayKeyForIntervalsAndChecks);

                            if (indexNumber < actualIntervalsAndChecksByDayId.Count)
                            {
                                if (actualIntervalsAndChecksByDayId[0].Start != "" && actualIntervalsAndChecksByDayId[0].Stop != "" &&
                                    DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[0].Stop))
                                {
                                    if (actualIntervalsAndChecksByDayId[0].HoldOn == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[0].Start)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[0].ExitTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(1);
                                    }
                                    if (actualIntervalsAndChecksByDayId[0].HoldCourse == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[0].Stop)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[0].HoldMusic == true)
                                    {
                                        while (DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[0].Stop))
                                        {
                                            await StartASongByPositionAndTimeGymnasiumAsync(shuffleSongsGymnasium[songCursor], DateTime.Parse(actualIntervalsAndChecksByDayId[0].Stop));
                                            songCursor++;
                                        }
                                    }
                                    if (actualIntervalsAndChecksByDayId[0].EntranceTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(0);
                                    }
                                }
                            }
                            indexNumber++;

                            if (indexNumber < actualIntervalsAndChecksByDayId.Count)
                            {
                                if (actualIntervalsAndChecksByDayId[1].Start != "" && actualIntervalsAndChecksByDayId[1].Stop != "" &&
                                    DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[1].Stop))
                                {
                                    if (actualIntervalsAndChecksByDayId[1].HoldOn == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[1].Start)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[1].ExitTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(1);
                                    }
                                    if (actualIntervalsAndChecksByDayId[1].HoldCourse == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[1].Stop)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[1].HoldMusic == true)
                                    {
                                        while (DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[1].Stop))
                                        {
                                            await StartASongByPositionAndTimeGymnasiumAsync(shuffleSongsGymnasium[songCursor], DateTime.Parse(actualIntervalsAndChecksByDayId[1].Stop));
                                            songCursor++;
                                        }
                                    }
                                    if (actualIntervalsAndChecksByDayId[1].EntranceTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(0);
                                    }
                                }
                            }
                            indexNumber++;

                            if (indexNumber < actualIntervalsAndChecksByDayId.Count)
                            {
                                if (actualIntervalsAndChecksByDayId[2].Start != "" && actualIntervalsAndChecksByDayId[2].Stop != "" &&
                                    DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[2].Stop))
                                {
                                    if (actualIntervalsAndChecksByDayId[2].HoldOn == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[2].Start)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[2].ExitTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(1);
                                    }
                                    if (actualIntervalsAndChecksByDayId[2].HoldCourse == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[2].Stop)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[2].HoldMusic == true)
                                    {
                                        while (DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[2].Stop))
                                        {
                                            await StartASongByPositionAndTimeGymnasiumAsync(shuffleSongsGymnasium[songCursor], DateTime.Parse(actualIntervalsAndChecksByDayId[2].Stop));
                                            songCursor++;
                                        }
                                    }
                                    if (actualIntervalsAndChecksByDayId[2].EntranceTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(0);
                                    }
                                }
                            }
                            indexNumber++;

                            if (indexNumber < actualIntervalsAndChecksByDayId.Count)
                            {
                                if (actualIntervalsAndChecksByDayId[3].Start != "" && actualIntervalsAndChecksByDayId[3].Stop != "" &&
                                    DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[3].Stop))
                                {
                                    if (actualIntervalsAndChecksByDayId[3].HoldOn == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[3].Start)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[3].ExitTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(1);
                                    }
                                    if (actualIntervalsAndChecksByDayId[3].HoldCourse == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[3].Stop)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[3].HoldMusic == true)
                                    {
                                        while (DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[3].Stop))
                                        {
                                            await StartASongByPositionAndTimeGymnasiumAsync(shuffleSongsGymnasium[songCursor], DateTime.Parse(actualIntervalsAndChecksByDayId[3].Stop));
                                            songCursor++;
                                        }
                                    }
                                    if (actualIntervalsAndChecksByDayId[3].EntranceTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(0);
                                    }
                                }
                            }
                            indexNumber++;

                            if (indexNumber < actualIntervalsAndChecksByDayId.Count)
                            {
                                if (actualIntervalsAndChecksByDayId[4].Start != "" && actualIntervalsAndChecksByDayId[4].Stop != "" &&
                                    DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[4].Stop))
                                {
                                    if (actualIntervalsAndChecksByDayId[4].HoldOn == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[4].Start)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[4].ExitTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(1);
                                    }
                                    if (actualIntervalsAndChecksByDayId[4].HoldCourse == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[4].Stop)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[4].HoldMusic == true)
                                    {
                                        while (DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[4].Stop))
                                        {
                                            await StartASongByPositionAndTimeGymnasiumAsync(shuffleSongsGymnasium[songCursor], DateTime.Parse(actualIntervalsAndChecksByDayId[4].Stop));
                                            songCursor++;
                                        }
                                    }
                                    if (actualIntervalsAndChecksByDayId[4].EntranceTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(0);
                                    }
                                }
                            }
                            indexNumber++;

                            if (indexNumber < actualIntervalsAndChecksByDayId.Count)
                            {
                                if (actualIntervalsAndChecksByDayId[5].Start != "" && actualIntervalsAndChecksByDayId[5].Stop != "" &&
                                    DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[5].Stop))
                                {
                                    if (actualIntervalsAndChecksByDayId[5].HoldOn == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[5].Start)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[5].ExitTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(1);
                                    }
                                    if (actualIntervalsAndChecksByDayId[5].HoldCourse == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[5].Stop)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[5].HoldMusic == true)
                                    {
                                        while (DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[5].Stop))
                                        {
                                            await StartASongByPositionAndTimeGymnasiumAsync(shuffleSongsGymnasium[songCursor], DateTime.Parse(actualIntervalsAndChecksByDayId[5].Stop));
                                            songCursor++;
                                        }
                                    }
                                    if (actualIntervalsAndChecksByDayId[5].EntranceTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(0);
                                    }
                                }
                            }
                            indexNumber++;

                            if (indexNumber < actualIntervalsAndChecksByDayId.Count)
                            {
                                if (actualIntervalsAndChecksByDayId[6].Start != "" && actualIntervalsAndChecksByDayId[6].Stop != "" &&
                                    DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[6].Stop))
                                {
                                    if (actualIntervalsAndChecksByDayId[6].HoldOn == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[6].Start)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[6].ExitTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(1);
                                    }
                                    if (actualIntervalsAndChecksByDayId[6].HoldCourse == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[6].Stop)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[6].HoldMusic == true)
                                    {
                                        while (DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[6].Stop))
                                        {
                                            await StartASongByPositionAndTimeGymnasiumAsync(shuffleSongsGymnasium[songCursor], DateTime.Parse(actualIntervalsAndChecksByDayId[6].Stop));
                                            songCursor++;
                                        }
                                    }
                                    if (actualIntervalsAndChecksByDayId[6].EntranceTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(0);
                                    }
                                }
                            }
                            indexNumber++;

                            if (indexNumber < actualIntervalsAndChecksByDayId.Count)
                            {
                                if (actualIntervalsAndChecksByDayId[7].Start != "" && actualIntervalsAndChecksByDayId[7].Stop != "" &&
                                    DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[7].Stop))
                                {
                                    if (actualIntervalsAndChecksByDayId[7].HoldOn == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[7].Start)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[7].ExitTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(1);
                                    }
                                    if (actualIntervalsAndChecksByDayId[7].HoldCourse == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[7].Stop)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[7].HoldMusic == true)
                                    {
                                        while (DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[7].Stop))
                                        {
                                            await StartASongByPositionAndTimeGymnasiumAsync(shuffleSongsGymnasium[songCursor], DateTime.Parse(actualIntervalsAndChecksByDayId[7].Stop));
                                            songCursor++;
                                        }
                                    }
                                    if (actualIntervalsAndChecksByDayId[7].EntranceTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(0);
                                    }
                                }
                            }
                            indexNumber++;

                            if (indexNumber < actualIntervalsAndChecksByDayId.Count)
                            {
                                if (actualIntervalsAndChecksByDayId[8].Start != "" && actualIntervalsAndChecksByDayId[8].Stop != "" &&
                                    DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[8].Stop))
                                {
                                    if (actualIntervalsAndChecksByDayId[8].HoldOn == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[8].Start)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[8].ExitTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(1);
                                    }
                                    if (actualIntervalsAndChecksByDayId[8].HoldCourse == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[8].Stop)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[8].HoldMusic == true)
                                    {
                                        while (DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[8].Stop))
                                        {
                                            await StartASongByPositionAndTimeGymnasiumAsync(shuffleSongsGymnasium[songCursor], DateTime.Parse(actualIntervalsAndChecksByDayId[8].Stop));
                                            songCursor++;
                                        }
                                    }
                                    if (actualIntervalsAndChecksByDayId[8].EntranceTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(0);
                                    }
                                }
                            }
                            indexNumber++;

                            if (indexNumber < actualIntervalsAndChecksByDayId.Count)
                            {
                                if (actualIntervalsAndChecksByDayId[9].Start != "" && actualIntervalsAndChecksByDayId[9].Stop != "" &&
                                    DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[9].Stop))
                                {
                                    if (actualIntervalsAndChecksByDayId[9].HoldOn == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[9].Start)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[9].ExitTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(1);
                                    }
                                    if (actualIntervalsAndChecksByDayId[9].HoldCourse == true)
                                    {
                                        await Task.Delay((int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(actualIntervalsAndChecksByDayId[9].Stop)).TotalMilliseconds));
                                    }
                                    if (actualIntervalsAndChecksByDayId[9].HoldMusic == true)
                                    {
                                        while (DateTime.Parse(DateTime.Now.ToLongTimeString()) < DateTime.Parse(actualIntervalsAndChecksByDayId[9].Stop))
                                        {
                                            await StartASongByPositionAndTimeGymnasiumAsync(shuffleSongsGymnasium[songCursor], DateTime.Parse(actualIntervalsAndChecksByDayId[9].Stop));
                                            songCursor++;
                                        }
                                    }
                                    if (actualIntervalsAndChecksByDayId[9].EntranceTone == true)
                                    {
                                        await StartAToneByPositionGymnasiumAsync(0);
                                    }
                                }
                            }
                            indexNumber++;
                        }
                        else
                        {
                            List<IntervalsAndChecksPrimary> intervalsAndChecksPrimary = GetAllIntervalsAndChecksPrimaryByDayId(indexesAndDays.FirstOrDefault(x => x.Value == daysSelected[i]).Key);
                            if (daysSelected.Count == 1)
                            {
                                int timeToWait = (int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(intervalsAndChecksPrimary[i].Start)).TotalMilliseconds) + ((indexesAndDays.FirstOrDefault(x => x.Value == DateTime.Now.DayOfWeek.ToString()).Key + 1) * 86400000);
                                await Task.Delay(timeToWait);
                            }
                            if (daysSelected.Count == 1)
                            {
                                int timeToWait = (int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(intervalsAndChecksPrimary[i].Start)).TotalMilliseconds) + ((indexesAndDays.FirstOrDefault(x => x.Value == DateTime.Now.DayOfWeek.ToString()).Key + 1) * 86400000);
                                await Task.Delay(timeToWait);
                            }
                            else if (daysSelected.Count > 1 && (7 - indexesAndDays.FirstOrDefault(x => x.Value == DateTime.Now.DayOfWeek.ToString()).Key) < 1)
                            {
                                string nextDayInterval = intervalsAndChecksPrimary[indexesAndDays.FirstOrDefault(x => x.Value == daysSelected[i + 1]).Key].Start;
                                int timeToWait = (int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(nextDayInterval)).TotalMilliseconds);
                                await Task.Delay(timeToWait);
                            }
                            else if (daysSelected.Count > 1 && (7 - indexesAndDays.FirstOrDefault(x => x.Value == DateTime.Now.DayOfWeek.ToString()).Key) == 1)
                            {
                                string nextDayInterval = intervalsAndChecksPrimary[indexesAndDays.FirstOrDefault(x => x.Value == daysSelected[i + 1]).Key].Start;
                                int timeToWait = (int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(nextDayInterval)).TotalMilliseconds) + 86400000;
                                await Task.Delay(timeToWait);
                            }
                            else if (daysSelected.Count > 1 && (7 - indexesAndDays.FirstOrDefault(x => x.Value == DateTime.Now.DayOfWeek.ToString()).Key) > 1)
                            {
                                //string nextDayInterval = intervalsAndChecksPrimary[indexesAndDays.FirstOrDefault(x => x.Value == daysSelected[i]).Key].Start;
                                int timeToWait = (int)Math.Abs(DateTime.Now.Subtract(DateTime.Parse(intervalsAndChecksPrimary[i].Start)).TotalMilliseconds) + ((7 - indexesAndDays.FirstOrDefault(x => x.Value == DateTime.Now.DayOfWeek.ToString()).Key + 1) * 86400000);
                                await Task.Delay(timeToWait);
                            }
                        }
                    }
                }
            }
        }

        public string GetStartIntervalPrimaryByDayId(int dayId)
        {
            string startIntervalPrimary = string.Empty;
            PrimaryMainWindow primaryMainWindow = new PrimaryMainWindow();
            List<IntervalsAndChecksPrimary> intervalsAndChecksPrimary = primaryMainWindow.ReadIntervalsAndChecksPrimaryFromDatabase();
            for (int iterator = 0; iterator < intervalsAndChecksPrimary.Count; iterator++)
            {
                if (intervalsAndChecksPrimary[iterator].DayPrimaryId == dayId &&
                    intervalsAndChecksPrimary[iterator].Start != "" &&
                    intervalsAndChecksPrimary[iterator].Stop != "")
                {
                    startIntervalPrimary = intervalsAndChecksPrimary[iterator].Start;
                    break;
                }
            }

            return startIntervalPrimary;
        }

        public List<IntervalsAndChecksGymnasium> GetAllIntervalsAndChecksGymnasiumByDayId(int dayId)
        {
            List<IntervalsAndChecksGymnasium> intervalsAndChecksGymnasiumToReturn = new List<IntervalsAndChecksGymnasium>();
            List<IntervalsAndChecksGymnasium> intervalsAndChecksGymnasium = ReadIntervalsAndChecksGymnasiumFromDatabase();
            for (int iterator = 0; iterator < intervalsAndChecksGymnasium.Count; iterator++)
            {
                if (intervalsAndChecksGymnasium[iterator].DayGymnasiumId == dayId &&
                    intervalsAndChecksGymnasium[iterator].Start != "" &&
                    intervalsAndChecksGymnasium[iterator].Stop != "")
                {
                    intervalsAndChecksGymnasiumToReturn.Add(intervalsAndChecksGymnasium[iterator]);
                }
            }

            return intervalsAndChecksGymnasiumToReturn;
        }

        public string[] GetAllSongsGymnasium()
        {
            string[] names = Directory.GetCurrentDirectory().Split("\\");
            string namesComposed = string.Empty;
            foreach (string name in names)
            {
                if (name.Contains("bin"))
                {
                    break;
                }
                namesComposed = namesComposed + name + "\\";
            }
            namesComposed = namesComposed + "Songs Gymnasium";
            string[] files = Directory.GetFiles(namesComposed);

            return files;
        }

        public string[] GetAllTonesGymnasium()
        {
            string[] names = Directory.GetCurrentDirectory().Split("\\");
            string namesComposed = string.Empty;
            foreach (string name in names)
            {
                if (name.Contains("bin"))
                {
                    break;
                }
                namesComposed = namesComposed + name + "\\";
            }
            namesComposed = namesComposed + "Tones Gymnasium";
            string[] files = Directory.GetFiles(namesComposed);

            return files;
        }

        public decimal GetNumberOfSecondsOfASongGymnasium(string songLength)
        {
            FileInfo fileInfo = new FileInfo(songLength);
            int sample_rate = 44100;
            int bit_depth = 16;
            int channels = 2;
            long file_size = fileInfo.Length;
            decimal duration = file_size / (sample_rate * (bit_depth / 8) * channels);
            decimal result = Math.Round(duration);

            return result;
        }

        public decimal GetNumberOfSecondsOfAToneGymnasium(string toneLength)
        {
            FileInfo fileInfo = new FileInfo(toneLength);
            int sample_rate = 44100;
            int bit_depth = 16;
            int channels = 2;
            long file_size = fileInfo.Length;
            decimal duration = file_size / (sample_rate * (bit_depth / 8) * channels);
            decimal result = Math.Round(duration);

            return result;
        }

        public async Task StartASongByPositionAndTimeGymnasiumAsync(int position, DateTime dateTime)
        {
            using SoundPlayer soundPlayerForASongGymnasium = new SoundPlayer();
            string[] songsGymnasium = GetAllSongsGymnasium();
            soundPlayerForASongGymnasium.SoundLocation = songsGymnasium[position];
            decimal songDuration = GetNumberOfSecondsOfASongGymnasium(songsGymnasium[position]);
            int interval = (int)(songDuration * 1000);
            if (dateTime.Subtract(DateTime.Now).TotalMilliseconds > interval)
            {
                soundPlayerForASongGymnasium.Play();
                await Task.Delay(interval);
            }
            else
            {
                soundPlayerForASongGymnasium.Play();
                await Task.Delay((int)Math.Abs(dateTime.Subtract(DateTime.Now).TotalMilliseconds));
            }
        }

        public async Task StartAToneByPositionGymnasiumAsync(int position)
        {
            using SoundPlayer soundPlayerForAToneGymnasium = new SoundPlayer();
            string[] tonesGymnasium = GetAllTonesGymnasium();
            soundPlayerForAToneGymnasium.SoundLocation = tonesGymnasium[position];
            decimal songDuration = GetNumberOfSecondsOfAToneGymnasium(tonesGymnasium[position]);
            int interval = (int)(songDuration * 1000);
            soundPlayerForAToneGymnasium.Play();
            await Task.Delay(interval);
        }

        public int[] ShuffleAllSongsGymnasium()
        {
            string[] songsGymnasium = GetAllSongsGymnasium();
            int[] indexes = new int[songsGymnasium.Length];
            for (int i = 0; i < indexes.Length; i++)
            {
                indexes[i] = -1;
            }
            Random random = new Random();
            int iterator = 0;
            while (iterator < songsGymnasium.Length)
            {
                int number = random.Next(0, songsGymnasium.Length);
                if (!indexes.Contains(number))
                {
                    indexes[iterator] = number;
                    iterator++;
                }
            }

            return indexes;
        }

        public void UpdateTableIntervalsAndChecksGymnasiumForACertainDayInDatabase()
        {
            string connectionString = @"Data Source=MIHAIFLORIN\SQLEXPRESS;Initial Catalog=ClassBellProject;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand;
            List<IntervalsAndChecksGymnasium> intervalsAndChecksGymnasium = new List<IntervalsAndChecksGymnasium>();

            string dayChecked = listBoxSelectDayGymnasium.SelectedItem.ToString();
            switch (dayChecked)
            {
                case "Luni":
                    if ((comboBoxStartHourInterval1.Text != "" || comboBoxStartHourInterval1.Text == "") &&
                        (comboBoxStartMinuteInterval1.Text != "" || comboBoxStartMinuteInterval1.Text == "") &&
                        (comboBoxStartFormatInterval1.Text != "" && comboBoxStartFormatInterval1.Text == "") &&
                        (comboBoxStopHourInterval1.Text != "" || comboBoxStopHourInterval1.Text == "") &&
                        (comboBoxStopMinuteInterval1.Text != "" || comboBoxStopMinuteInterval1.Text == "") &&
                        (comboBoxStopFormatInterval1.Text != "" || comboBoxStartFormatInterval1.Text == "") &&
                        (checkBoxExitTone1.Checked == false || checkBoxExitTone1.Checked == true) &&
                        (checkBoxEntranceTone1.Checked == false || checkBoxEntranceTone1.Checked == true) &&
                        (checkBoxHoldMusic1.Checked == false || checkBoxHoldMusic1.Checked == true) &&
                        (checkBoxHoldOn1.Checked == false || checkBoxHoldOn1.Checked == true) &&
                        (checkBoxHoldCourse1.Checked == false || checkBoxHoldCourse1.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 1,
                            Start = comboBoxStartHourInterval1.Text + ":" + comboBoxStartMinuteInterval1.Text + ":" + "00" + " " + comboBoxStartFormatInterval1.Text,
                            Stop = comboBoxStopHourInterval1.Text + ":" + comboBoxStopMinuteInterval1.Text + ":" + "00" + " " + comboBoxStopFormatInterval1.Text,
                            EntranceTone = checkBoxEntranceTone1.Checked,
                            ExitTone = checkBoxExitTone1.Checked,
                            HoldMusic = checkBoxHoldMusic1.Checked,
                            HoldOn = checkBoxHoldOn1.Checked,
                            HoldCourse = checkBoxHoldCourse1.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval2.Text != "" || comboBoxStartHourInterval2.Text == "") &&
                        (comboBoxStartMinuteInterval2.Text != "" || comboBoxStartMinuteInterval2.Text == "") &&
                        (comboBoxStartFormatInterval2.Text != "" || comboBoxStartFormatInterval2.Text == "") &&
                        (comboBoxStopHourInterval2.Text != "" || comboBoxStopHourInterval2.Text == "") &&
                        (comboBoxStopMinuteInterval2.Text != "" || comboBoxStopMinuteInterval2.Text != "") &&
                        (comboBoxStopFormatInterval2.Text != "" || comboBoxStopFormatInterval2.Text != "") &&
                        (checkBoxEntranceTone2.Checked == false || checkBoxEntranceTone2.Checked == true) &&
                        (checkBoxExitTone2.Checked == false || checkBoxExitTone2.Checked == true) &&
                        (checkBoxHoldMusic2.Checked == false || checkBoxHoldMusic2.Checked == true) &&
                        (checkBoxHoldOn2.Checked == false || checkBoxHoldOn2.Checked == true) &&
                        (checkBoxHoldCourse2.Checked == false || checkBoxHoldCourse2.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 2,
                            Start = comboBoxStartHourInterval2.Text + ":" + comboBoxStartMinuteInterval2.Text + ":" + "00" + " " + comboBoxStartFormatInterval2.Text,
                            Stop = comboBoxStopHourInterval2.Text + ":" + comboBoxStopMinuteInterval2.Text + ":" + "00" + " " + comboBoxStopFormatInterval2.Text,
                            EntranceTone = checkBoxEntranceTone2.Checked,
                            ExitTone = checkBoxExitTone2.Checked,
                            HoldMusic = checkBoxHoldMusic2.Checked,
                            HoldOn = checkBoxHoldOn2.Checked,
                            HoldCourse = checkBoxHoldCourse2.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval3.Text != "" || comboBoxStartHourInterval3.Text == "") &&
                        (comboBoxStartMinuteInterval3.Text != "" || comboBoxStartMinuteInterval3.Text == "") &&
                        (comboBoxStartFormatInterval3.Text != "" || comboBoxStartMinuteInterval3.Text == "") &&
                        (comboBoxStopHourInterval3.Text != "" || comboBoxStopHourInterval3.Text == "") &&
                        (comboBoxStopMinuteInterval3.Text != "" || comboBoxStopMinuteInterval3.Text == "") &&
                        (comboBoxStopFormatInterval3.Text != "" || comboBoxStopFormatInterval3.Text == "") &&
                        (checkBoxEntranceTone3.Checked == false || checkBoxEntranceTone3.Checked == true) &&
                        (checkBoxExitTone3.Checked == false || checkBoxExitTone3.Checked == true) &&
                        (checkBoxHoldMusic3.Checked == false || checkBoxHoldMusic3.Checked == true) &&
                        (checkBoxHoldOn3.Checked == false || checkBoxHoldOn3.Checked == true) &&
                        (checkBoxHoldCourse3.Checked == false || checkBoxHoldCourse3.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 3,
                            Start = comboBoxStartHourInterval3.Text + ":" + comboBoxStartMinuteInterval3.Text + ":" + "00" + " " + comboBoxStartFormatInterval3.Text,
                            Stop = comboBoxStopHourInterval3.Text + ":" + comboBoxStopMinuteInterval3.Text + ":" + "00" + " " + comboBoxStopFormatInterval3.Text,
                            EntranceTone = checkBoxEntranceTone3.Checked,
                            ExitTone = checkBoxExitTone3.Checked,
                            HoldMusic = checkBoxHoldMusic3.Checked,
                            HoldOn = checkBoxHoldOn3.Checked,
                            HoldCourse = checkBoxHoldCourse3.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval4.Text != "" || comboBoxStartHourInterval4.Text == "") &&
                        (comboBoxStartMinuteInterval4.Text != "" || comboBoxStartMinuteInterval4.Text == "") &&
                        (comboBoxStartFormatInterval4.Text != "" || comboBoxStartFormatInterval4.Text == "") &&
                        (comboBoxStopHourInterval4.Text != "" || comboBoxStopHourInterval4.Text == "") &&
                        (comboBoxStopMinuteInterval4.Text != "" || comboBoxStopMinuteInterval4.Text == "") &&
                        (comboBoxStopFormatInterval4.Text != "" || comboBoxStopFormatInterval4.Text == "") &&
                        (checkBoxEntranceTone4.Checked == false || checkBoxEntranceTone4.Checked == true) &&
                        (checkBoxExitTone4.Checked == false || checkBoxExitTone4.Checked == true) &&
                        (checkBoxHoldMusic4.Checked == false || checkBoxHoldMusic4.Checked == true) &&
                        (checkBoxHoldOn4.Checked == false || checkBoxHoldOn4.Checked == true) &&
                        (checkBoxHoldCourse4.Checked == false || checkBoxHoldCourse4.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 4,
                            Start = comboBoxStartHourInterval4.Text + ":" + comboBoxStartMinuteInterval4.Text + ":" + "00" + " " + comboBoxStartFormatInterval4.Text,
                            Stop = comboBoxStopHourInterval4.Text + ":" + comboBoxStopMinuteInterval4.Text + ":" + "00" + " " + comboBoxStopFormatInterval4.Text,
                            EntranceTone = checkBoxEntranceTone4.Checked,
                            ExitTone = checkBoxExitTone4.Checked,
                            HoldMusic = checkBoxHoldMusic4.Checked,
                            HoldOn = checkBoxHoldOn4.Checked,
                            HoldCourse = checkBoxHoldCourse4.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval5.Text != "" || comboBoxStartHourInterval5.Text == "") &&
                        (comboBoxStartMinuteInterval5.Text != "" || comboBoxStartMinuteInterval5.Text == "") &&
                        (comboBoxStartFormatInterval5.Text != "" || comboBoxStartFormatInterval5.Text == "") &&
                        (comboBoxStopHourInterval5.Text != "" || comboBoxStopHourInterval5.Text == "") &&
                        (comboBoxStopMinuteInterval5.Text != "" || comboBoxStopMinuteInterval5.Text == "") &&
                        (comboBoxStopFormatInterval5.Text != "" || comboBoxStopFormatInterval5.Text == "") &&
                        (checkBoxEntranceTone5.Checked == false || checkBoxEntranceTone5.Checked == true) &&
                        (checkBoxExitTone5.Checked == false || checkBoxExitTone5.Checked == true) &&
                        (checkBoxHoldMusic5.Checked == false || checkBoxHoldMusic5.Checked == true) &&
                        (checkBoxHoldOn5.Checked == false || checkBoxHoldOn5.Checked == true) &&
                        (checkBoxHoldCourse5.Checked == false || checkBoxHoldCourse5.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 5,
                            Start = comboBoxStartHourInterval5.Text + ":" + comboBoxStartMinuteInterval5.Text + ":" + "00" + " " + comboBoxStartFormatInterval5.Text,
                            Stop = comboBoxStopHourInterval5.Text + ":" + comboBoxStopMinuteInterval5.Text + ":" + "00" + " " + comboBoxStopFormatInterval5.Text,
                            EntranceTone = checkBoxEntranceTone5.Checked,
                            ExitTone = checkBoxExitTone5.Checked,
                            HoldMusic = checkBoxHoldMusic5.Checked,
                            HoldOn = checkBoxHoldOn5.Checked,
                            HoldCourse = checkBoxHoldCourse5.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval6.Text != "" || comboBoxStartHourInterval6.Text == "") &&
                        (comboBoxStartMinuteInterval6.Text != "" || comboBoxStartMinuteInterval6.Text == "") &&
                        (comboBoxStartFormatInterval6.Text != "" || comboBoxStartFormatInterval6.Text == "") &&
                        (comboBoxStopHourInterval6.Text != "" || comboBoxStopHourInterval6.Text == "") && 
                        (comboBoxStopMinuteInterval6.Text != "" || comboBoxStopMinuteInterval6.Text == "") && 
                        (comboBoxStopFormatInterval6.Text != "" || comboBoxStopFormatInterval6.Text == "") &&
                        (checkBoxEntranceTone6.Checked == false || checkBoxEntranceTone6.Checked == true) &&
                        (checkBoxExitTone6.Checked == false || checkBoxExitTone6.Checked == true) &&
                        (checkBoxHoldMusic6.Checked == false || checkBoxHoldMusic6.Checked == true) &&
                        (checkBoxHoldOn6.Checked == false || checkBoxHoldOn6.Checked == true) &&
                        (checkBoxHoldCourse6.Checked == false || checkBoxHoldCourse6.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 6,
                            Start = comboBoxStartHourInterval6.Text + ":" + comboBoxStartMinuteInterval6.Text + ":" + "00" + " " + comboBoxStartFormatInterval6.Text,
                            Stop = comboBoxStopHourInterval6.Text + ":" + comboBoxStopMinuteInterval6.Text + ":" + "00" + " " + comboBoxStopFormatInterval6.Text,
                            EntranceTone = checkBoxEntranceTone6.Checked,
                            ExitTone = checkBoxExitTone6.Checked,
                            HoldMusic = checkBoxHoldMusic6.Checked,
                            HoldOn = checkBoxHoldOn6.Checked,
                            HoldCourse = checkBoxHoldCourse6.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval7.Text != "" || comboBoxStartHourInterval7.Text == "") && 
                        (comboBoxStartMinuteInterval7.Text != "" || comboBoxStartMinuteInterval7.Text == "") && 
                        (comboBoxStartFormatInterval7.Text != "" || comboBoxStartFormatInterval7.Text == "") &&
                        (comboBoxStopHourInterval7.Text != "" || comboBoxStopHourInterval7.Text == "") && 
                        (comboBoxStopMinuteInterval7.Text != "" || comboBoxStopMinuteInterval7.Text == "") && 
                        (comboBoxStopFormatInterval7.Text != "" || comboBoxStopFormatInterval7.Text == "") &&
                        (checkBoxEntranceTone7.Checked == false || checkBoxEntranceTone7.Checked == true) &&
                        (checkBoxExitTone7.Checked == false || checkBoxExitTone7.Checked == true) &&
                        (checkBoxHoldMusic7.Checked == false || checkBoxHoldMusic7.Checked == true) &&
                        (checkBoxHoldOn7.Checked == false || checkBoxHoldOn7.Checked == true) &&
                        (checkBoxHoldCourse7.Checked == false || checkBoxHoldCourse7.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 7,
                            Start = comboBoxStartHourInterval7.Text + ":" + comboBoxStartMinuteInterval7.Text + ":" + "00" + " " + comboBoxStartFormatInterval7.Text,
                            Stop = comboBoxStopHourInterval7.Text + ":" + comboBoxStopMinuteInterval7.Text + ":" + "00" + " " + comboBoxStopFormatInterval7.Text,
                            EntranceTone = checkBoxEntranceTone7.Checked,
                            ExitTone = checkBoxExitTone7.Checked,
                            HoldMusic = checkBoxHoldMusic7.Checked,
                            HoldOn = checkBoxHoldOn7.Checked,
                            HoldCourse = checkBoxHoldCourse7.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval8.Text != "" || comboBoxStartHourInterval8.Text == "") && 
                        (comboBoxStartMinuteInterval8.Text != "" || comboBoxStartMinuteInterval8.Text == "") && 
                        (comboBoxStartFormatInterval8.Text != "" || comboBoxStartFormatInterval8.Text == "") &&
                        (comboBoxStopHourInterval8.Text != "" || comboBoxStopHourInterval8.Text == "") && 
                        (comboBoxStopMinuteInterval8.Text != "" || comboBoxStopMinuteInterval8.Text == "") && 
                        (comboBoxStopFormatInterval8.Text != "" || comboBoxStopFormatInterval8.Text == "") &&
                        (checkBoxEntranceTone8.Checked == false || checkBoxEntranceTone8.Checked == true) &&
                        (checkBoxExitTone8.Checked == false || checkBoxExitTone8.Checked == true) &&
                        (checkBoxHoldMusic8.Checked == false || checkBoxHoldMusic8.Checked == true) &&
                        (checkBoxHoldOn8.Checked == false || checkBoxHoldOn8.Checked == true) &&
                        (checkBoxHoldCourse8.Checked == false || checkBoxHoldCourse8.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 8,
                            Start = comboBoxStartHourInterval8.Text + ":" + comboBoxStartMinuteInterval8.Text + ":" + "00" + " " + comboBoxStartFormatInterval8.Text,
                            Stop = comboBoxStopHourInterval8.Text + ":" + comboBoxStopMinuteInterval8.Text + ":" + "00" + " " + comboBoxStopFormatInterval8.Text,
                            EntranceTone = checkBoxEntranceTone8.Checked,
                            ExitTone = checkBoxExitTone8.Checked,
                            HoldMusic = checkBoxHoldMusic8.Checked,
                            HoldOn = checkBoxHoldOn8.Checked,
                            HoldCourse = checkBoxHoldCourse8.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval9.Text != "" || comboBoxStartHourInterval9.Text == "") && 
                        (comboBoxStartMinuteInterval9.Text != "" || comboBoxStartMinuteInterval9.Text == "") && 
                        (comboBoxStartFormatInterval9.Text != "" || comboBoxStartFormatInterval9.Text == "") &&
                        (comboBoxStopHourInterval9.Text != "" || comboBoxStopHourInterval9.Text == "") && 
                        (comboBoxStopMinuteInterval9.Text != "" || comboBoxStopMinuteInterval9.Text == "") && 
                        (comboBoxStopFormatInterval9.Text != "" || comboBoxStopFormatInterval9.Text == "") &&
                        (checkBoxEntranceTone9.Checked == false || checkBoxEntranceTone9.Checked == true) &&
                        (checkBoxExitTone9.Checked == false || checkBoxExitTone9.Checked == true) &&
                        (checkBoxHoldMusic9.Checked == false || checkBoxHoldMusic9.Checked == true) &&
                        (checkBoxHoldOn9.Checked == false || checkBoxHoldOn9.Checked == true) &&
                        (checkBoxHoldCourse9.Checked == false || checkBoxHoldCourse9.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 9,
                            Start = comboBoxStartHourInterval9.Text + ":" + comboBoxStartMinuteInterval9.Text + ":" + "00" + " " + comboBoxStartFormatInterval9.Text,
                            Stop = comboBoxStopHourInterval9.Text + ":" + comboBoxStopMinuteInterval9.Text + ":" + "00" + " " + comboBoxStopFormatInterval9.Text,
                            EntranceTone = checkBoxEntranceTone9.Checked,
                            ExitTone = checkBoxExitTone9.Checked,
                            HoldMusic = checkBoxHoldMusic9.Checked,
                            HoldOn = checkBoxHoldOn9.Checked,
                            HoldCourse = checkBoxHoldCourse9.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval10.Text != "" || comboBoxStartHourInterval10.Text == "") && 
                        (comboBoxStartMinuteInterval10.Text != "" || comboBoxStartMinuteInterval10.Text == "") && 
                        (comboBoxStartFormatInterval10.Text != "" || comboBoxStartFormatInterval10.Text == "") &&
                        (comboBoxStopHourInterval10.Text != "" || comboBoxStopHourInterval10.Text == "") && 
                        (comboBoxStopMinuteInterval10.Text != "" || comboBoxStopMinuteInterval10.Text == "") && 
                        (comboBoxStopFormatInterval10.Text != "" || comboBoxStopFormatInterval10.Text == "") &&
                        (checkBoxEntranceTone10.Checked == false || checkBoxEntranceTone10.Checked == true) &&
                        (checkBoxExitTone10.Checked == false || checkBoxExitTone10.Checked == true) &&
                        (checkBoxHoldMusic10.Checked == false || checkBoxHoldMusic10.Checked == true) &&
                        (checkBoxHoldOn10.Checked == false || checkBoxHoldOn10.Checked == true) &&
                        (checkBoxHoldCourse10.Checked == false || checkBoxHoldCourse10.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 10,
                            Start = comboBoxStartHourInterval10.Text + ":" + comboBoxStartMinuteInterval10.Text + ":" + "00" + " " + comboBoxStartFormatInterval10.Text,
                            Stop = comboBoxStopHourInterval10.Text + ":" + comboBoxStopMinuteInterval10.Text + ":" + "00" + " " + comboBoxStopFormatInterval10.Text,
                            EntranceTone = checkBoxEntranceTone10.Checked,
                            ExitTone = checkBoxExitTone10.Checked,
                            HoldMusic = checkBoxHoldMusic10.Checked,
                            HoldOn = checkBoxHoldOn10.Checked,
                            HoldCourse = checkBoxHoldCourse10.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    break;

                case "Marti":
                    if ((comboBoxStartHourInterval1.Text != "" && comboBoxStartMinuteInterval1.Text != "" && comboBoxStartFormatInterval1.Text != "") &&
                        (comboBoxStopHourInterval1.Text != "" && comboBoxStopMinuteInterval1.Text != "" && comboBoxStopFormatInterval1.Text != "") &&
                        (checkBoxExitTone1.Checked == false || checkBoxExitTone1.Checked == true) &&
                        (checkBoxEntranceTone1.Checked == false || checkBoxEntranceTone1.Checked == true) &&
                        (checkBoxHoldMusic1.Checked == false || checkBoxHoldMusic1.Checked == true) &&
                        (checkBoxHoldOn1.Checked == false || checkBoxHoldOn1.Checked == true) &&
                        (checkBoxHoldCourse1.Checked == false || checkBoxHoldCourse1.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 11,
                            Start = comboBoxStartHourInterval1.Text + ":" + comboBoxStartMinuteInterval1.Text + ":" + "00" + " " + comboBoxStartFormatInterval1.Text,
                            Stop = comboBoxStopHourInterval1.Text + ":" + comboBoxStopMinuteInterval1.Text + ":" + "00" + " " + comboBoxStopFormatInterval1.Text,
                            EntranceTone = checkBoxEntranceTone1.Checked,
                            ExitTone = checkBoxExitTone1.Checked,
                            HoldMusic = checkBoxHoldMusic1.Checked,
                            HoldOn = checkBoxHoldOn1.Checked,
                            HoldCourse = checkBoxHoldCourse1.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval2.Text != "" && comboBoxStartMinuteInterval2.Text != "" && comboBoxStartFormatInterval2.Text != "") &&
                        (comboBoxStopHourInterval2.Text != "" && comboBoxStopMinuteInterval2.Text != "" && comboBoxStopFormatInterval2.Text != "") &&
                        (checkBoxEntranceTone2.Checked == false || checkBoxEntranceTone2.Checked == true) &&
                        (checkBoxExitTone2.Checked == false || checkBoxExitTone2.Checked == true) &&
                        (checkBoxHoldMusic2.Checked == false || checkBoxHoldMusic2.Checked == true) &&
                        (checkBoxHoldOn2.Checked == false || checkBoxHoldOn2.Checked == true) &&
                        (checkBoxHoldCourse2.Checked == false || checkBoxHoldCourse2.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 12,
                            Start = comboBoxStartHourInterval2.Text + ":" + comboBoxStartMinuteInterval2.Text + ":" + "00" + " " + comboBoxStartFormatInterval2.Text,
                            Stop = comboBoxStopHourInterval2.Text + ":" + comboBoxStopMinuteInterval2.Text + ":" + "00" + " " + comboBoxStopFormatInterval2.Text,
                            EntranceTone = checkBoxEntranceTone2.Checked,
                            ExitTone = checkBoxExitTone2.Checked,
                            HoldMusic = checkBoxHoldMusic2.Checked,
                            HoldOn = checkBoxHoldOn2.Checked,
                            HoldCourse = checkBoxHoldCourse2.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval3.Text != "" && comboBoxStartMinuteInterval3.Text != "" && comboBoxStartFormatInterval3.Text != "") &&
                        (comboBoxStopHourInterval3.Text != "" && comboBoxStopMinuteInterval3.Text != "" && comboBoxStopFormatInterval3.Text != "") &&
                        (checkBoxEntranceTone3.Checked == false || checkBoxEntranceTone3.Checked == true) &&
                        (checkBoxExitTone3.Checked == false || checkBoxExitTone3.Checked == true) &&
                        (checkBoxHoldMusic3.Checked == false || checkBoxHoldMusic3.Checked == true) &&
                        (checkBoxHoldOn3.Checked == false || checkBoxHoldOn3.Checked == true) &&
                        (checkBoxHoldCourse3.Checked == false || checkBoxHoldCourse3.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 13,
                            Start = comboBoxStartHourInterval3.Text + ":" + comboBoxStartMinuteInterval3.Text + ":" + "00" + " " + comboBoxStartFormatInterval3.Text,
                            Stop = comboBoxStopHourInterval3.Text + ":" + comboBoxStopMinuteInterval3.Text + ":" + "00" + " " + comboBoxStopFormatInterval3.Text,
                            EntranceTone = checkBoxEntranceTone3.Checked,
                            ExitTone = checkBoxExitTone3.Checked,
                            HoldMusic = checkBoxHoldMusic3.Checked,
                            HoldOn = checkBoxHoldOn3.Checked,
                            HoldCourse = checkBoxHoldCourse3.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval4.Text != "" && comboBoxStartMinuteInterval4.Text != "" && comboBoxStartFormatInterval4.Text != "") &&
                        (comboBoxStopHourInterval4.Text != "" && comboBoxStopMinuteInterval4.Text != "" && comboBoxStopFormatInterval4.Text != "") &&
                        (checkBoxEntranceTone4.Checked == false || checkBoxEntranceTone4.Checked == true) &&
                        (checkBoxExitTone4.Checked == false || checkBoxExitTone4.Checked == true) &&
                        (checkBoxHoldMusic4.Checked == false || checkBoxHoldMusic4.Checked == true) &&
                        (checkBoxHoldOn4.Checked == false || checkBoxHoldOn4.Checked == true) &&
                        (checkBoxHoldCourse4.Checked == false || checkBoxHoldCourse4.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 14,
                            Start = comboBoxStartHourInterval4.Text + ":" + comboBoxStartMinuteInterval4.Text + ":" + "00" + " " + comboBoxStartFormatInterval4.Text,
                            Stop = comboBoxStopHourInterval4.Text + ":" + comboBoxStopMinuteInterval4.Text + ":" + "00" + " " + comboBoxStopFormatInterval4.Text,
                            EntranceTone = checkBoxEntranceTone4.Checked,
                            ExitTone = checkBoxExitTone4.Checked,
                            HoldMusic = checkBoxHoldMusic4.Checked,
                            HoldOn = checkBoxHoldOn4.Checked,
                            HoldCourse = checkBoxHoldCourse4.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval5.Text != "" && comboBoxStartMinuteInterval5.Text != "" && comboBoxStartFormatInterval5.Text != "") &&
                        (comboBoxStopHourInterval5.Text != "" && comboBoxStopMinuteInterval5.Text != "" && comboBoxStopFormatInterval5.Text != "") &&
                        (checkBoxEntranceTone5.Checked == false || checkBoxEntranceTone5.Checked == true) &&
                        (checkBoxExitTone5.Checked == false || checkBoxExitTone5.Checked == true) &&
                        (checkBoxHoldMusic5.Checked == false || checkBoxHoldMusic5.Checked == true) &&
                        (checkBoxHoldOn5.Checked == false || checkBoxHoldOn5.Checked == true) &&
                        (checkBoxHoldCourse5.Checked == false || checkBoxHoldCourse5.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 15,
                            Start = comboBoxStartHourInterval5.Text + ":" + comboBoxStartMinuteInterval5.Text + ":" + "00" + " " + comboBoxStartFormatInterval5.Text,
                            Stop = comboBoxStopHourInterval5.Text + ":" + comboBoxStopMinuteInterval5.Text + ":" + "00" + " " + comboBoxStopFormatInterval5.Text,
                            EntranceTone = checkBoxEntranceTone5.Checked,
                            ExitTone = checkBoxExitTone5.Checked,
                            HoldMusic = checkBoxHoldMusic5.Checked,
                            HoldOn = checkBoxHoldOn5.Checked,
                            HoldCourse = checkBoxHoldCourse5.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval6.Text != "" && comboBoxStartMinuteInterval6.Text != "" && comboBoxStartFormatInterval6.Text != "") &&
                        (comboBoxStopHourInterval6.Text != "" && comboBoxStopMinuteInterval6.Text != "" && comboBoxStopFormatInterval6.Text != "") &&
                        (checkBoxEntranceTone6.Checked == false || checkBoxEntranceTone6.Checked == true) &&
                        (checkBoxExitTone6.Checked == false || checkBoxExitTone6.Checked == true) &&
                        (checkBoxHoldMusic6.Checked == false || checkBoxHoldMusic6.Checked == true) &&
                        (checkBoxHoldOn6.Checked == false || checkBoxHoldOn6.Checked == true) &&
                        (checkBoxHoldCourse6.Checked == false || checkBoxHoldCourse6.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 16,
                            Start = comboBoxStartHourInterval6.Text + ":" + comboBoxStartMinuteInterval6.Text + ":" + "00" + " " + comboBoxStartFormatInterval6.Text,
                            Stop = comboBoxStopHourInterval6.Text + ":" + comboBoxStopMinuteInterval6.Text + ":" + "00" + " " + comboBoxStopFormatInterval6.Text,
                            EntranceTone = checkBoxEntranceTone6.Checked,
                            ExitTone = checkBoxExitTone6.Checked,
                            HoldMusic = checkBoxHoldMusic6.Checked,
                            HoldOn = checkBoxHoldOn6.Checked,
                            HoldCourse = checkBoxHoldCourse6.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval7.Text != "" && comboBoxStartMinuteInterval7.Text != "" && comboBoxStartFormatInterval7.Text != "") &&
                        (comboBoxStopHourInterval7.Text != "" && comboBoxStopMinuteInterval7.Text != "" && comboBoxStopFormatInterval7.Text != "") &&
                        (checkBoxEntranceTone7.Checked == false || checkBoxEntranceTone7.Checked == true) &&
                        (checkBoxExitTone7.Checked == false || checkBoxExitTone7.Checked == true) &&
                        (checkBoxHoldMusic7.Checked == false || checkBoxHoldMusic7.Checked == true) &&
                        (checkBoxHoldOn7.Checked == false || checkBoxHoldOn7.Checked == true) &&
                        (checkBoxHoldCourse7.Checked == false || checkBoxHoldCourse7.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 17,
                            Start = comboBoxStartHourInterval7.Text + ":" + comboBoxStartMinuteInterval7.Text + ":" + "00" + " " + comboBoxStartFormatInterval7.Text,
                            Stop = comboBoxStopHourInterval7.Text + ":" + comboBoxStopMinuteInterval7.Text + ":" + "00" + " " + comboBoxStopFormatInterval7.Text,
                            EntranceTone = checkBoxEntranceTone7.Checked,
                            ExitTone = checkBoxExitTone7.Checked,
                            HoldMusic = checkBoxHoldMusic7.Checked,
                            HoldOn = checkBoxHoldOn7.Checked,
                            HoldCourse = checkBoxHoldCourse7.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval8.Text != "" && comboBoxStartMinuteInterval8.Text != "" && comboBoxStartFormatInterval8.Text != "") &&
                        (comboBoxStopHourInterval8.Text != "" && comboBoxStopMinuteInterval8.Text != "" && comboBoxStopFormatInterval8.Text != "") &&
                        (checkBoxEntranceTone8.Checked == false || checkBoxEntranceTone8.Checked == true) &&
                        (checkBoxExitTone8.Checked == false || checkBoxExitTone8.Checked == true) &&
                        (checkBoxHoldMusic8.Checked == false || checkBoxHoldMusic8.Checked == true) &&
                        (checkBoxHoldOn8.Checked == false || checkBoxHoldOn8.Checked == true) &&
                        (checkBoxHoldCourse8.Checked == false || checkBoxHoldCourse8.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 18,
                            Start = comboBoxStartHourInterval8.Text + ":" + comboBoxStartMinuteInterval8.Text + ":" + "00" + " " + comboBoxStartFormatInterval8.Text,
                            Stop = comboBoxStopHourInterval8.Text + ":" + comboBoxStopMinuteInterval8.Text + ":" + "00" + " " + comboBoxStopFormatInterval8.Text,
                            EntranceTone = checkBoxEntranceTone8.Checked,
                            ExitTone = checkBoxExitTone8.Checked,
                            HoldMusic = checkBoxHoldMusic8.Checked,
                            HoldOn = checkBoxHoldOn8.Checked,
                            HoldCourse = checkBoxHoldCourse8.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval9.Text != "" && comboBoxStartMinuteInterval9.Text != "" && comboBoxStartFormatInterval9.Text != "") &&
                        (comboBoxStopHourInterval9.Text != "" && comboBoxStopMinuteInterval9.Text != "" && comboBoxStopFormatInterval9.Text != "") &&
                        (checkBoxEntranceTone9.Checked == false || checkBoxEntranceTone9.Checked == true) &&
                        (checkBoxExitTone9.Checked == false || checkBoxExitTone9.Checked == true) &&
                        (checkBoxHoldMusic9.Checked == false || checkBoxHoldMusic9.Checked == true) &&
                        (checkBoxHoldOn9.Checked == false || checkBoxHoldOn9.Checked == true) &&
                        (checkBoxHoldCourse9.Checked == false || checkBoxHoldCourse9.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 19,
                            Start = comboBoxStartHourInterval9.Text + ":" + comboBoxStartMinuteInterval9.Text + ":" + "00" + " " + comboBoxStartFormatInterval9.Text,
                            Stop = comboBoxStopHourInterval9.Text + ":" + comboBoxStopMinuteInterval9.Text + ":" + "00" + " " + comboBoxStopFormatInterval9.Text,
                            EntranceTone = checkBoxEntranceTone9.Checked,
                            ExitTone = checkBoxExitTone9.Checked,
                            HoldMusic = checkBoxHoldMusic9.Checked,
                            HoldOn = checkBoxHoldOn9.Checked,
                            HoldCourse = checkBoxHoldCourse9.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval10.Text != "" && comboBoxStartMinuteInterval10.Text != "" && comboBoxStartFormatInterval10.Text != "") &&
                        (comboBoxStopHourInterval10.Text != "" && comboBoxStopMinuteInterval10.Text != "" && comboBoxStopFormatInterval10.Text != "") &&
                        (checkBoxEntranceTone10.Checked == false || checkBoxEntranceTone10.Checked == true) &&
                        (checkBoxExitTone10.Checked == false || checkBoxExitTone10.Checked == true) &&
                        (checkBoxHoldMusic10.Checked == false || checkBoxHoldMusic10.Checked == true) &&
                        (checkBoxHoldOn10.Checked == false || checkBoxHoldOn10.Checked == true) &&
                        (checkBoxHoldCourse10.Checked == false || checkBoxHoldCourse10.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 20,
                            Start = comboBoxStartHourInterval10.Text + ":" + comboBoxStartMinuteInterval10.Text + ":" + "00" + " " + comboBoxStartFormatInterval10.Text,
                            Stop = comboBoxStopHourInterval10.Text + ":" + comboBoxStopMinuteInterval10.Text + ":" + "00" + " " + comboBoxStopFormatInterval10.Text,
                            EntranceTone = checkBoxEntranceTone10.Checked,
                            ExitTone = checkBoxExitTone10.Checked,
                            HoldMusic = checkBoxHoldMusic10.Checked,
                            HoldOn = checkBoxHoldOn10.Checked,
                            HoldCourse = checkBoxHoldCourse10.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    break;

                case "Miercuri":
                    if ((comboBoxStartHourInterval1.Text != "" && comboBoxStartMinuteInterval1.Text != "" && comboBoxStartFormatInterval1.Text != "") &&
                    (comboBoxStopHourInterval1.Text != "" && comboBoxStopMinuteInterval1.Text != "" && comboBoxStopFormatInterval1.Text != "") &&
                    (checkBoxExitTone1.Checked == false || checkBoxExitTone1.Checked == true) &&
                    (checkBoxEntranceTone1.Checked == false || checkBoxEntranceTone1.Checked == true) &&
                    (checkBoxHoldMusic1.Checked == false || checkBoxHoldMusic1.Checked == true) &&
                    (checkBoxHoldOn1.Checked == false || checkBoxHoldOn1.Checked == true) &&
                    (checkBoxHoldCourse1.Checked == false || checkBoxHoldCourse1.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 21,
                            Start = comboBoxStartHourInterval1.Text + ":" + comboBoxStartMinuteInterval1.Text + ":" + "00" + " " + comboBoxStartFormatInterval1.Text,
                            Stop = comboBoxStopHourInterval1.Text + ":" + comboBoxStopMinuteInterval1.Text + ":" + "00" + " " + comboBoxStopFormatInterval1.Text,
                            EntranceTone = checkBoxEntranceTone1.Checked,
                            ExitTone = checkBoxExitTone1.Checked,
                            HoldMusic = checkBoxHoldMusic1.Checked,
                            HoldOn = checkBoxHoldOn1.Checked,
                            HoldCourse = checkBoxHoldCourse1.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval2.Text != "" && comboBoxStartMinuteInterval2.Text != "" && comboBoxStartFormatInterval2.Text != "") &&
                        (comboBoxStopHourInterval2.Text != "" && comboBoxStopMinuteInterval2.Text != "" && comboBoxStopFormatInterval2.Text != "") &&
                        (checkBoxEntranceTone2.Checked == false || checkBoxEntranceTone2.Checked == true) &&
                        (checkBoxExitTone2.Checked == false || checkBoxExitTone2.Checked == true) &&
                        (checkBoxHoldMusic2.Checked == false || checkBoxHoldMusic2.Checked == true) &&
                        (checkBoxHoldOn2.Checked == false || checkBoxHoldOn2.Checked == true) &&
                        (checkBoxHoldCourse2.Checked == false || checkBoxHoldCourse2.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 22,
                            Start = comboBoxStartHourInterval2.Text + ":" + comboBoxStartMinuteInterval2.Text + ":" + "00" + " " + comboBoxStartFormatInterval2.Text,
                            Stop = comboBoxStopHourInterval2.Text + ":" + comboBoxStopMinuteInterval2.Text + ":" + "00" + " " + comboBoxStopFormatInterval2.Text,
                            EntranceTone = checkBoxEntranceTone2.Checked,
                            ExitTone = checkBoxExitTone2.Checked,
                            HoldMusic = checkBoxHoldMusic2.Checked,
                            HoldOn = checkBoxHoldOn2.Checked,
                            HoldCourse = checkBoxHoldCourse2.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval3.Text != "" && comboBoxStartMinuteInterval3.Text != "" && comboBoxStartFormatInterval3.Text != "") &&
                        (comboBoxStopHourInterval3.Text != "" && comboBoxStopMinuteInterval3.Text != "" && comboBoxStopFormatInterval3.Text != "") &&
                        (checkBoxEntranceTone3.Checked == false || checkBoxEntranceTone3.Checked == true) &&
                        (checkBoxExitTone3.Checked == false || checkBoxExitTone3.Checked == true) &&
                        (checkBoxHoldMusic3.Checked == false || checkBoxHoldMusic3.Checked == true) &&
                        (checkBoxHoldOn3.Checked == false || checkBoxHoldOn3.Checked == true) &&
                        (checkBoxHoldCourse3.Checked == false || checkBoxHoldCourse3.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 23,
                            Start = comboBoxStartHourInterval3.Text + ":" + comboBoxStartMinuteInterval3.Text + ":" + "00" + " " + comboBoxStartFormatInterval3.Text,
                            Stop = comboBoxStopHourInterval3.Text + ":" + comboBoxStopMinuteInterval3.Text + ":" + "00" + " " + comboBoxStopFormatInterval3.Text,
                            EntranceTone = checkBoxEntranceTone3.Checked,
                            ExitTone = checkBoxExitTone3.Checked,
                            HoldMusic = checkBoxHoldMusic3.Checked,
                            HoldOn = checkBoxHoldOn3.Checked,
                            HoldCourse = checkBoxHoldCourse3.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval4.Text != "" && comboBoxStartMinuteInterval4.Text != "" && comboBoxStartFormatInterval4.Text != "") &&
                        (comboBoxStopHourInterval4.Text != "" && comboBoxStopMinuteInterval4.Text != "" && comboBoxStopFormatInterval4.Text != "") &&
                        (checkBoxEntranceTone4.Checked == false || checkBoxEntranceTone4.Checked == true) &&
                        (checkBoxExitTone4.Checked == false || checkBoxExitTone4.Checked == true) &&
                        (checkBoxHoldMusic4.Checked == false || checkBoxHoldMusic4.Checked == true) &&
                        (checkBoxHoldOn4.Checked == false || checkBoxHoldOn4.Checked == true) &&
                        (checkBoxHoldCourse4.Checked == false || checkBoxHoldCourse4.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 24,
                            Start = comboBoxStartHourInterval4.Text + ":" + comboBoxStartMinuteInterval4.Text + ":" + "00" + " " + comboBoxStartFormatInterval4.Text,
                            Stop = comboBoxStopHourInterval4.Text + ":" + comboBoxStopMinuteInterval4.Text + ":" + "00" + " " + comboBoxStopFormatInterval4.Text,
                            EntranceTone = checkBoxEntranceTone4.Checked,
                            ExitTone = checkBoxExitTone4.Checked,
                            HoldMusic = checkBoxHoldMusic4.Checked,
                            HoldOn = checkBoxHoldOn4.Checked,
                            HoldCourse = checkBoxHoldCourse4.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval5.Text != "" && comboBoxStartMinuteInterval5.Text != "" && comboBoxStartFormatInterval5.Text != "") &&
                        (comboBoxStopHourInterval5.Text != "" && comboBoxStopMinuteInterval5.Text != "" && comboBoxStopFormatInterval5.Text != "") &&
                        (checkBoxEntranceTone5.Checked == false || checkBoxEntranceTone5.Checked == true) &&
                        (checkBoxExitTone5.Checked == false || checkBoxExitTone5.Checked == true) &&
                        (checkBoxHoldMusic5.Checked == false || checkBoxHoldMusic5.Checked == true) &&
                        (checkBoxHoldOn5.Checked == false || checkBoxHoldOn5.Checked == true) &&
                        (checkBoxHoldCourse5.Checked == false || checkBoxHoldCourse5.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 25,
                            Start = comboBoxStartHourInterval5.Text + ":" + comboBoxStartMinuteInterval5.Text + ":" + "00" + " " + comboBoxStartFormatInterval5.Text,
                            Stop = comboBoxStopHourInterval5.Text + ":" + comboBoxStopMinuteInterval5.Text + ":" + "00" + " " + comboBoxStopFormatInterval5.Text,
                            EntranceTone = checkBoxEntranceTone5.Checked,
                            ExitTone = checkBoxExitTone5.Checked,
                            HoldMusic = checkBoxHoldMusic5.Checked,
                            HoldOn = checkBoxHoldOn5.Checked,
                            HoldCourse = checkBoxHoldCourse5.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval6.Text != "" && comboBoxStartMinuteInterval6.Text != "" && comboBoxStartFormatInterval6.Text != "") &&
                        (comboBoxStopHourInterval6.Text != "" && comboBoxStopMinuteInterval6.Text != "" && comboBoxStopFormatInterval6.Text != "") &&
                        (checkBoxEntranceTone6.Checked == false || checkBoxEntranceTone6.Checked == true) &&
                        (checkBoxExitTone6.Checked == false || checkBoxExitTone6.Checked == true) &&
                        (checkBoxHoldMusic6.Checked == false || checkBoxHoldMusic6.Checked == true) &&
                        (checkBoxHoldOn6.Checked == false || checkBoxHoldOn6.Checked == true) &&
                        (checkBoxHoldCourse6.Checked == false || checkBoxHoldCourse6.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 26,
                            Start = comboBoxStartHourInterval6.Text + ":" + comboBoxStartMinuteInterval6.Text + ":" + "00" + " " + comboBoxStartFormatInterval6.Text,
                            Stop = comboBoxStopHourInterval6.Text + ":" + comboBoxStopMinuteInterval6.Text + ":" + "00" + " " + comboBoxStopFormatInterval6.Text,
                            EntranceTone = checkBoxEntranceTone6.Checked,
                            ExitTone = checkBoxExitTone6.Checked,
                            HoldMusic = checkBoxHoldMusic6.Checked,
                            HoldOn = checkBoxHoldOn6.Checked,
                            HoldCourse = checkBoxHoldCourse6.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval7.Text != "" && comboBoxStartMinuteInterval7.Text != "" && comboBoxStartFormatInterval7.Text != "") &&
                        (comboBoxStopHourInterval7.Text != "" && comboBoxStopMinuteInterval7.Text != "" && comboBoxStopFormatInterval7.Text != "") &&
                        (checkBoxEntranceTone7.Checked == false || checkBoxEntranceTone7.Checked == true) &&
                        (checkBoxExitTone7.Checked == false || checkBoxExitTone7.Checked == true) &&
                        (checkBoxHoldMusic7.Checked == false || checkBoxHoldMusic7.Checked == true) &&
                        (checkBoxHoldOn7.Checked == false || checkBoxHoldOn7.Checked == true) &&
                        (checkBoxHoldCourse7.Checked == false || checkBoxHoldCourse7.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 27,
                            Start = comboBoxStartHourInterval7.Text + ":" + comboBoxStartMinuteInterval7.Text + ":" + "00" + " " + comboBoxStartFormatInterval7.Text,
                            Stop = comboBoxStopHourInterval7.Text + ":" + comboBoxStopMinuteInterval7.Text + ":" + "00" + " " + comboBoxStopFormatInterval7.Text,
                            EntranceTone = checkBoxEntranceTone7.Checked,
                            ExitTone = checkBoxExitTone7.Checked,
                            HoldMusic = checkBoxHoldMusic7.Checked,
                            HoldOn = checkBoxHoldOn7.Checked,
                            HoldCourse = checkBoxHoldCourse7.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval8.Text != "" && comboBoxStartMinuteInterval8.Text != "" && comboBoxStartFormatInterval8.Text != "") &&
                        (comboBoxStopHourInterval8.Text != "" && comboBoxStopMinuteInterval8.Text != "" && comboBoxStopFormatInterval8.Text != "") &&
                        (checkBoxEntranceTone8.Checked == false || checkBoxEntranceTone8.Checked == true) &&
                        (checkBoxExitTone8.Checked == false || checkBoxExitTone8.Checked == true) &&
                        (checkBoxHoldMusic8.Checked == false || checkBoxHoldMusic8.Checked == true) &&
                        (checkBoxHoldOn8.Checked == false || checkBoxHoldOn8.Checked == true) &&
                        (checkBoxHoldCourse8.Checked == false || checkBoxHoldCourse8.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 28,
                            Start = comboBoxStartHourInterval8.Text + ":" + comboBoxStartMinuteInterval8.Text + ":" + "00" + " " + comboBoxStartFormatInterval8.Text,
                            Stop = comboBoxStopHourInterval8.Text + ":" + comboBoxStopMinuteInterval8.Text + ":" + "00" + " " + comboBoxStopFormatInterval8.Text,
                            EntranceTone = checkBoxEntranceTone8.Checked,
                            ExitTone = checkBoxExitTone8.Checked,
                            HoldMusic = checkBoxHoldMusic8.Checked,
                            HoldOn = checkBoxHoldOn8.Checked,
                            HoldCourse = checkBoxHoldCourse8.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval9.Text != "" && comboBoxStartMinuteInterval9.Text != "" && comboBoxStartFormatInterval9.Text != "") &&
                        (comboBoxStopHourInterval9.Text != "" && comboBoxStopMinuteInterval9.Text != "" && comboBoxStopFormatInterval9.Text != "") &&
                        (checkBoxEntranceTone9.Checked == false || checkBoxEntranceTone9.Checked == true) &&
                        (checkBoxExitTone9.Checked == false || checkBoxExitTone9.Checked == true) &&
                        (checkBoxHoldMusic9.Checked == false || checkBoxHoldMusic9.Checked == true) &&
                        (checkBoxHoldOn9.Checked == false || checkBoxHoldOn9.Checked == true) &&
                        (checkBoxHoldCourse9.Checked == false || checkBoxHoldCourse9.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 29,
                            Start = comboBoxStartHourInterval9.Text + ":" + comboBoxStartMinuteInterval9.Text + ":" + "00" + " " + comboBoxStartFormatInterval9.Text,
                            Stop = comboBoxStopHourInterval9.Text + ":" + comboBoxStopMinuteInterval9.Text + ":" + "00" + " " + comboBoxStopFormatInterval9.Text,
                            EntranceTone = checkBoxEntranceTone9.Checked,
                            ExitTone = checkBoxExitTone9.Checked,
                            HoldMusic = checkBoxHoldMusic9.Checked,
                            HoldOn = checkBoxHoldOn9.Checked,
                            HoldCourse = checkBoxHoldCourse9.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval10.Text != "" && comboBoxStartMinuteInterval10.Text != "" && comboBoxStartFormatInterval10.Text != "") &&
                        (comboBoxStopHourInterval10.Text != "" && comboBoxStopMinuteInterval10.Text != "" && comboBoxStopFormatInterval10.Text != "") &&
                        (checkBoxEntranceTone10.Checked == false || checkBoxEntranceTone10.Checked == true) &&
                        (checkBoxExitTone10.Checked == false || checkBoxExitTone10.Checked == true) &&
                        (checkBoxHoldMusic10.Checked == false || checkBoxHoldMusic10.Checked == true) &&
                        (checkBoxHoldOn10.Checked == false || checkBoxHoldOn10.Checked == true) &&
                        (checkBoxHoldCourse10.Checked == false || checkBoxHoldCourse10.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 30,
                            Start = comboBoxStartHourInterval10.Text + ":" + comboBoxStartMinuteInterval10.Text + ":" + "00" + " " + comboBoxStartFormatInterval10.Text,
                            Stop = comboBoxStopHourInterval10.Text + ":" + comboBoxStopMinuteInterval10.Text + ":" + "00" + " " + comboBoxStopFormatInterval10.Text,
                            EntranceTone = checkBoxEntranceTone10.Checked,
                            ExitTone = checkBoxExitTone10.Checked,
                            HoldMusic = checkBoxHoldMusic10.Checked,
                            HoldOn = checkBoxHoldOn10.Checked,
                            HoldCourse = checkBoxHoldCourse10.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    break;

                case "Joi":
                    if ((comboBoxStartHourInterval1.Text != "" && comboBoxStartMinuteInterval1.Text != "" && comboBoxStartFormatInterval1.Text != "") &&
                    (comboBoxStopHourInterval1.Text != "" && comboBoxStopMinuteInterval1.Text != "" && comboBoxStopFormatInterval1.Text != "") &&
                    (checkBoxExitTone1.Checked == false || checkBoxExitTone1.Checked == true) &&
                    (checkBoxEntranceTone1.Checked == false || checkBoxEntranceTone1.Checked == true) &&
                    (checkBoxHoldMusic1.Checked == false || checkBoxHoldMusic1.Checked == true) &&
                    (checkBoxHoldOn1.Checked == false || checkBoxHoldOn1.Checked == true) &&
                    (checkBoxHoldCourse1.Checked == false || checkBoxHoldCourse1.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 31,
                            Start = comboBoxStartHourInterval1.Text + ":" + comboBoxStartMinuteInterval1.Text + ":" + "00" + " " + comboBoxStartFormatInterval1.Text,
                            Stop = comboBoxStopHourInterval1.Text + ":" + comboBoxStopMinuteInterval1.Text + ":" + "00" + " " + comboBoxStopFormatInterval1.Text,
                            EntranceTone = checkBoxEntranceTone1.Checked,
                            ExitTone = checkBoxExitTone1.Checked,
                            HoldMusic = checkBoxHoldMusic1.Checked,
                            HoldOn = checkBoxHoldOn1.Checked,
                            HoldCourse = checkBoxHoldCourse1.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval2.Text != "" && comboBoxStartMinuteInterval2.Text != "" && comboBoxStartFormatInterval2.Text != "") &&
                        (comboBoxStopHourInterval2.Text != "" && comboBoxStopMinuteInterval2.Text != "" && comboBoxStopFormatInterval2.Text != "") &&
                        (checkBoxEntranceTone2.Checked == false || checkBoxEntranceTone2.Checked == true) &&
                        (checkBoxExitTone2.Checked == false || checkBoxExitTone2.Checked == true) &&
                        (checkBoxHoldMusic2.Checked == false || checkBoxHoldMusic2.Checked == true) &&
                        (checkBoxHoldOn2.Checked == false || checkBoxHoldOn2.Checked == true) &&
                        (checkBoxHoldCourse2.Checked == false || checkBoxHoldCourse2.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 32,
                            Start = comboBoxStartHourInterval2.Text + ":" + comboBoxStartMinuteInterval2.Text + ":" + "00" + " " + comboBoxStartFormatInterval2.Text,
                            Stop = comboBoxStopHourInterval2.Text + ":" + comboBoxStopMinuteInterval2.Text + ":" + "00" + " " + comboBoxStopFormatInterval2.Text,
                            EntranceTone = checkBoxEntranceTone2.Checked,
                            ExitTone = checkBoxExitTone2.Checked,
                            HoldMusic = checkBoxHoldMusic2.Checked,
                            HoldOn = checkBoxHoldOn2.Checked,
                            HoldCourse = checkBoxHoldCourse2.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval3.Text != "" && comboBoxStartMinuteInterval3.Text != "" && comboBoxStartFormatInterval3.Text != "") &&
                        (comboBoxStopHourInterval3.Text != "" && comboBoxStopMinuteInterval3.Text != "" && comboBoxStopFormatInterval3.Text != "") &&
                        (checkBoxEntranceTone3.Checked == false || checkBoxEntranceTone3.Checked == true) &&
                        (checkBoxExitTone3.Checked == false || checkBoxExitTone3.Checked == true) &&
                        (checkBoxHoldMusic3.Checked == false || checkBoxHoldMusic3.Checked == true) &&
                        (checkBoxHoldOn3.Checked == false || checkBoxHoldOn3.Checked == true) &&
                        (checkBoxHoldCourse3.Checked == false || checkBoxHoldCourse3.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 33,
                            Start = comboBoxStartHourInterval3.Text + ":" + comboBoxStartMinuteInterval3.Text + ":" + "00" + " " + comboBoxStartFormatInterval3.Text,
                            Stop = comboBoxStopHourInterval3.Text + ":" + comboBoxStopMinuteInterval3.Text + ":" + "00" + " " + comboBoxStopFormatInterval3.Text,
                            EntranceTone = checkBoxEntranceTone3.Checked,
                            ExitTone = checkBoxExitTone3.Checked,
                            HoldMusic = checkBoxHoldMusic3.Checked,
                            HoldOn = checkBoxHoldOn3.Checked,
                            HoldCourse = checkBoxHoldCourse3.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval4.Text != "" && comboBoxStartMinuteInterval4.Text != "" && comboBoxStartFormatInterval4.Text != "") &&
                        (comboBoxStopHourInterval4.Text != "" && comboBoxStopMinuteInterval4.Text != "" && comboBoxStopFormatInterval4.Text != "") &&
                        (checkBoxEntranceTone4.Checked == false || checkBoxEntranceTone4.Checked == true) &&
                        (checkBoxExitTone4.Checked == false || checkBoxExitTone4.Checked == true) &&
                        (checkBoxHoldMusic4.Checked == false || checkBoxHoldMusic4.Checked == true) &&
                        (checkBoxHoldOn4.Checked == false || checkBoxHoldOn4.Checked == true) &&
                        (checkBoxHoldCourse4.Checked == false || checkBoxHoldCourse4.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 34,
                            Start = comboBoxStartHourInterval4.Text + ":" + comboBoxStartMinuteInterval4.Text + ":" + "00" + " " + comboBoxStartFormatInterval4.Text,
                            Stop = comboBoxStopHourInterval4.Text + ":" + comboBoxStopMinuteInterval4.Text + ":" + "00" + " " + comboBoxStopFormatInterval4.Text,
                            EntranceTone = checkBoxEntranceTone4.Checked,
                            ExitTone = checkBoxExitTone4.Checked,
                            HoldMusic = checkBoxHoldMusic4.Checked,
                            HoldOn = checkBoxHoldOn4.Checked,
                            HoldCourse = checkBoxHoldCourse4.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval5.Text != "" && comboBoxStartMinuteInterval5.Text != "" && comboBoxStartFormatInterval5.Text != "") &&
                        (comboBoxStopHourInterval5.Text != "" && comboBoxStopMinuteInterval5.Text != "" && comboBoxStopFormatInterval5.Text != "") &&
                        (checkBoxEntranceTone5.Checked == false || checkBoxEntranceTone5.Checked == true) &&
                        (checkBoxExitTone5.Checked == false || checkBoxExitTone5.Checked == true) &&
                        (checkBoxHoldMusic5.Checked == false || checkBoxHoldMusic5.Checked == true) &&
                        (checkBoxHoldOn5.Checked == false || checkBoxHoldOn5.Checked == true) &&
                        (checkBoxHoldCourse5.Checked == false || checkBoxHoldCourse5.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 35,
                            Start = comboBoxStartHourInterval5.Text + ":" + comboBoxStartMinuteInterval5.Text + ":" + "00" + " " + comboBoxStartFormatInterval5.Text,
                            Stop = comboBoxStopHourInterval5.Text + ":" + comboBoxStopMinuteInterval5.Text + ":" + "00" + " " + comboBoxStopFormatInterval5.Text,
                            EntranceTone = checkBoxEntranceTone5.Checked,
                            ExitTone = checkBoxExitTone5.Checked,
                            HoldMusic = checkBoxHoldMusic5.Checked,
                            HoldOn = checkBoxHoldOn5.Checked,
                            HoldCourse = checkBoxHoldCourse5.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval6.Text != "" && comboBoxStartMinuteInterval6.Text != "" && comboBoxStartFormatInterval6.Text != "") &&
                        (comboBoxStopHourInterval6.Text != "" && comboBoxStopMinuteInterval6.Text != "" && comboBoxStopFormatInterval6.Text != "") &&
                        (checkBoxEntranceTone6.Checked == false || checkBoxEntranceTone6.Checked == true) &&
                        (checkBoxExitTone6.Checked == false || checkBoxExitTone6.Checked == true) &&
                        (checkBoxHoldMusic6.Checked == false || checkBoxHoldMusic6.Checked == true) &&
                        (checkBoxHoldOn6.Checked == false || checkBoxHoldOn6.Checked == true) &&
                        (checkBoxHoldCourse6.Checked == false || checkBoxHoldCourse6.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 36,
                            Start = comboBoxStartHourInterval6.Text + ":" + comboBoxStartMinuteInterval6.Text + ":" + "00" + " " + comboBoxStartFormatInterval6.Text,
                            Stop = comboBoxStopHourInterval6.Text + ":" + comboBoxStopMinuteInterval6.Text + ":" + "00" + " " + comboBoxStopFormatInterval6.Text,
                            EntranceTone = checkBoxEntranceTone6.Checked,
                            ExitTone = checkBoxExitTone6.Checked,
                            HoldMusic = checkBoxHoldMusic6.Checked,
                            HoldOn = checkBoxHoldOn6.Checked,
                            HoldCourse = checkBoxHoldCourse6.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval7.Text != "" && comboBoxStartMinuteInterval7.Text != "" && comboBoxStartFormatInterval7.Text != "") &&
                        (comboBoxStopHourInterval7.Text != "" && comboBoxStopMinuteInterval7.Text != "" && comboBoxStopFormatInterval7.Text != "") &&
                        (checkBoxEntranceTone7.Checked == false || checkBoxEntranceTone7.Checked == true) &&
                        (checkBoxExitTone7.Checked == false || checkBoxExitTone7.Checked == true) &&
                        (checkBoxHoldMusic7.Checked == false || checkBoxHoldMusic7.Checked == true) &&
                        (checkBoxHoldOn7.Checked == false || checkBoxHoldOn7.Checked == true) &&
                        (checkBoxHoldCourse7.Checked == false || checkBoxHoldCourse7.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 37,
                            Start = comboBoxStartHourInterval7.Text + ":" + comboBoxStartMinuteInterval7.Text + ":" + "00" + " " + comboBoxStartFormatInterval7.Text,
                            Stop = comboBoxStopHourInterval7.Text + ":" + comboBoxStopMinuteInterval7.Text + ":" + "00" + " " + comboBoxStopFormatInterval7.Text,
                            EntranceTone = checkBoxEntranceTone7.Checked,
                            ExitTone = checkBoxExitTone7.Checked,
                            HoldMusic = checkBoxHoldMusic7.Checked,
                            HoldOn = checkBoxHoldOn7.Checked,
                            HoldCourse = checkBoxHoldCourse7.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval8.Text != "" && comboBoxStartMinuteInterval8.Text != "" && comboBoxStartFormatInterval8.Text != "") &&
                        (comboBoxStopHourInterval8.Text != "" && comboBoxStopMinuteInterval8.Text != "" && comboBoxStopFormatInterval8.Text != "") &&
                        (checkBoxEntranceTone8.Checked == false || checkBoxEntranceTone8.Checked == true) &&
                        (checkBoxExitTone8.Checked == false || checkBoxExitTone8.Checked == true) &&
                        (checkBoxHoldMusic8.Checked == false || checkBoxHoldMusic8.Checked == true) &&
                        (checkBoxHoldOn8.Checked == false || checkBoxHoldOn8.Checked == true) &&
                        (checkBoxHoldCourse8.Checked == false || checkBoxHoldCourse8.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 38,
                            Start = comboBoxStartHourInterval8.Text + ":" + comboBoxStartMinuteInterval8.Text + ":" + "00" + " " + comboBoxStartFormatInterval8.Text,
                            Stop = comboBoxStopHourInterval8.Text + ":" + comboBoxStopMinuteInterval8.Text + ":" + "00" + " " + comboBoxStopFormatInterval8.Text,
                            EntranceTone = checkBoxEntranceTone8.Checked,
                            ExitTone = checkBoxExitTone8.Checked,
                            HoldMusic = checkBoxHoldMusic8.Checked,
                            HoldOn = checkBoxHoldOn8.Checked,
                            HoldCourse = checkBoxHoldCourse8.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval9.Text != "" && comboBoxStartMinuteInterval9.Text != "" && comboBoxStartFormatInterval9.Text != "") &&
                        (comboBoxStopHourInterval9.Text != "" && comboBoxStopMinuteInterval9.Text != "" && comboBoxStopFormatInterval9.Text != "") &&
                        (checkBoxEntranceTone9.Checked == false || checkBoxEntranceTone9.Checked == true) &&
                        (checkBoxExitTone9.Checked == false || checkBoxExitTone9.Checked == true) &&
                        (checkBoxHoldMusic9.Checked == false || checkBoxHoldMusic9.Checked == true) &&
                        (checkBoxHoldOn9.Checked == false || checkBoxHoldOn9.Checked == true) &&
                        (checkBoxHoldCourse9.Checked == false || checkBoxHoldCourse9.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 39,
                            Start = comboBoxStartHourInterval9.Text + ":" + comboBoxStartMinuteInterval9.Text + ":" + "00" + " " + comboBoxStartFormatInterval9.Text,
                            Stop = comboBoxStopHourInterval9.Text + ":" + comboBoxStopMinuteInterval9.Text + ":" + "00" + " " + comboBoxStopFormatInterval9.Text,
                            EntranceTone = checkBoxEntranceTone9.Checked,
                            ExitTone = checkBoxExitTone9.Checked,
                            HoldMusic = checkBoxHoldMusic9.Checked,
                            HoldOn = checkBoxHoldOn9.Checked,
                            HoldCourse = checkBoxHoldCourse9.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval10.Text != "" && comboBoxStartMinuteInterval10.Text != "" && comboBoxStartFormatInterval10.Text != "") &&
                        (comboBoxStopHourInterval10.Text != "" && comboBoxStopMinuteInterval10.Text != "" && comboBoxStopFormatInterval10.Text != "") &&
                        (checkBoxEntranceTone10.Checked == false || checkBoxEntranceTone10.Checked == true) &&
                        (checkBoxExitTone10.Checked == false || checkBoxExitTone10.Checked == true) &&
                        (checkBoxHoldMusic10.Checked == false || checkBoxHoldMusic10.Checked == true) &&
                        (checkBoxHoldOn10.Checked == false || checkBoxHoldOn10.Checked == true) &&
                        (checkBoxHoldCourse10.Checked == false || checkBoxHoldCourse10.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 40,
                            Start = comboBoxStartHourInterval10.Text + ":" + comboBoxStartMinuteInterval10.Text + ":" + "00" + " " + comboBoxStartFormatInterval10.Text,
                            Stop = comboBoxStopHourInterval10.Text + ":" + comboBoxStopMinuteInterval10.Text + ":" + "00" + " " + comboBoxStopFormatInterval10.Text,
                            EntranceTone = checkBoxEntranceTone10.Checked,
                            ExitTone = checkBoxExitTone10.Checked,
                            HoldMusic = checkBoxHoldMusic10.Checked,
                            HoldOn = checkBoxHoldOn10.Checked,
                            HoldCourse = checkBoxHoldCourse10.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    break;

                case "Vineri":
                    if ((comboBoxStartHourInterval1.Text != "" && comboBoxStartMinuteInterval1.Text != "" && comboBoxStartFormatInterval1.Text != "") &&
                    (comboBoxStopHourInterval1.Text != "" && comboBoxStopMinuteInterval1.Text != "" && comboBoxStopFormatInterval1.Text != "") &&
                    (checkBoxExitTone1.Checked == false || checkBoxExitTone1.Checked == true) &&
                    (checkBoxEntranceTone1.Checked == false || checkBoxEntranceTone1.Checked == true) &&
                    (checkBoxHoldMusic1.Checked == false || checkBoxHoldMusic1.Checked == true) &&
                    (checkBoxHoldOn1.Checked == false || checkBoxHoldOn1.Checked == true) &&
                    (checkBoxHoldCourse1.Checked == false || checkBoxHoldCourse1.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 41,
                            Start = comboBoxStartHourInterval1.Text + ":" + comboBoxStartMinuteInterval1.Text + ":" + "00" + " " + comboBoxStartFormatInterval1.Text,
                            Stop = comboBoxStopHourInterval1.Text + ":" + comboBoxStopMinuteInterval1.Text + ":" + "00" + " " + comboBoxStopFormatInterval1.Text,
                            EntranceTone = checkBoxEntranceTone1.Checked,
                            ExitTone = checkBoxExitTone1.Checked,
                            HoldMusic = checkBoxHoldMusic1.Checked,
                            HoldOn = checkBoxHoldOn1.Checked,
                            HoldCourse = checkBoxHoldCourse1.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval2.Text != "" && comboBoxStartMinuteInterval2.Text != "" && comboBoxStartFormatInterval2.Text != "") &&
                        (comboBoxStopHourInterval2.Text != "" && comboBoxStopMinuteInterval2.Text != "" && comboBoxStopFormatInterval2.Text != "") &&
                        (checkBoxEntranceTone2.Checked == false || checkBoxEntranceTone2.Checked == true) &&
                        (checkBoxExitTone2.Checked == false || checkBoxExitTone2.Checked == true) &&
                        (checkBoxHoldMusic2.Checked == false || checkBoxHoldMusic2.Checked == true) &&
                        (checkBoxHoldOn2.Checked == false || checkBoxHoldOn2.Checked == true) &&
                        (checkBoxHoldCourse2.Checked == false || checkBoxHoldCourse2.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 42,
                            Start = comboBoxStartHourInterval2.Text + ":" + comboBoxStartMinuteInterval2.Text + ":" + "00" + " " + comboBoxStartFormatInterval2.Text,
                            Stop = comboBoxStopHourInterval2.Text + ":" + comboBoxStopMinuteInterval2.Text + ":" + "00" + " " + comboBoxStopFormatInterval2.Text,
                            EntranceTone = checkBoxEntranceTone2.Checked,
                            ExitTone = checkBoxExitTone2.Checked,
                            HoldMusic = checkBoxHoldMusic2.Checked,
                            HoldOn = checkBoxHoldOn2.Checked,
                            HoldCourse = checkBoxHoldCourse2.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval3.Text != "" && comboBoxStartMinuteInterval3.Text != "" && comboBoxStartFormatInterval3.Text != "") &&
                        (comboBoxStopHourInterval3.Text != "" && comboBoxStopMinuteInterval3.Text != "" && comboBoxStopFormatInterval3.Text != "") &&
                        (checkBoxEntranceTone3.Checked == false || checkBoxEntranceTone3.Checked == true) &&
                        (checkBoxExitTone3.Checked == false || checkBoxExitTone3.Checked == true) &&
                        (checkBoxHoldMusic3.Checked == false || checkBoxHoldMusic3.Checked == true) &&
                        (checkBoxHoldOn3.Checked == false || checkBoxHoldOn3.Checked == true) &&
                        (checkBoxHoldCourse3.Checked == false || checkBoxHoldCourse3.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 43,
                            Start = comboBoxStartHourInterval3.Text + ":" + comboBoxStartMinuteInterval3.Text + ":" + "00" + " " + comboBoxStartFormatInterval3.Text,
                            Stop = comboBoxStopHourInterval3.Text + ":" + comboBoxStopMinuteInterval3.Text + ":" + "00" + " " + comboBoxStopFormatInterval3.Text,
                            EntranceTone = checkBoxEntranceTone3.Checked,
                            ExitTone = checkBoxExitTone3.Checked,
                            HoldMusic = checkBoxHoldMusic3.Checked,
                            HoldOn = checkBoxHoldOn3.Checked,
                            HoldCourse = checkBoxHoldCourse3.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval4.Text != "" && comboBoxStartMinuteInterval4.Text != "" && comboBoxStartFormatInterval4.Text != "") &&
                        (comboBoxStopHourInterval4.Text != "" && comboBoxStopMinuteInterval4.Text != "" && comboBoxStopFormatInterval4.Text != "") &&
                        (checkBoxEntranceTone4.Checked == false || checkBoxEntranceTone4.Checked == true) &&
                        (checkBoxExitTone4.Checked == false || checkBoxExitTone4.Checked == true) &&
                        (checkBoxHoldMusic4.Checked == false || checkBoxHoldMusic4.Checked == true) &&
                        (checkBoxHoldOn4.Checked == false || checkBoxHoldOn4.Checked == true) &&
                        (checkBoxHoldCourse4.Checked == false || checkBoxHoldCourse4.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 44,
                            Start = comboBoxStartHourInterval4.Text + ":" + comboBoxStartMinuteInterval4.Text + ":" + "00" + " " + comboBoxStartFormatInterval4.Text,
                            Stop = comboBoxStopHourInterval4.Text + ":" + comboBoxStopMinuteInterval4.Text + ":" + "00" + " " + comboBoxStopFormatInterval4.Text,
                            EntranceTone = checkBoxEntranceTone4.Checked,
                            ExitTone = checkBoxExitTone4.Checked,
                            HoldMusic = checkBoxHoldMusic4.Checked,
                            HoldOn = checkBoxHoldOn4.Checked,
                            HoldCourse = checkBoxHoldCourse4.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval5.Text != "" && comboBoxStartMinuteInterval5.Text != "" && comboBoxStartFormatInterval5.Text != "") &&
                        (comboBoxStopHourInterval5.Text != "" && comboBoxStopMinuteInterval5.Text != "" && comboBoxStopFormatInterval5.Text != "") &&
                        (checkBoxEntranceTone5.Checked == false || checkBoxEntranceTone5.Checked == true) &&
                        (checkBoxExitTone5.Checked == false || checkBoxExitTone5.Checked == true) &&
                        (checkBoxHoldMusic5.Checked == false || checkBoxHoldMusic5.Checked == true) &&
                        (checkBoxHoldOn5.Checked == false || checkBoxHoldOn5.Checked == true) &&
                        (checkBoxHoldCourse5.Checked == false || checkBoxHoldCourse5.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 45,
                            Start = comboBoxStartHourInterval5.Text + ":" + comboBoxStartMinuteInterval5.Text + ":" + "00" + " " + comboBoxStartFormatInterval5.Text,
                            Stop = comboBoxStopHourInterval5.Text + ":" + comboBoxStopMinuteInterval5.Text + ":" + "00" + " " + comboBoxStopFormatInterval5.Text,
                            EntranceTone = checkBoxEntranceTone5.Checked,
                            ExitTone = checkBoxExitTone5.Checked,
                            HoldMusic = checkBoxHoldMusic5.Checked,
                            HoldOn = checkBoxHoldOn5.Checked,
                            HoldCourse = checkBoxHoldCourse5.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval6.Text != "" && comboBoxStartMinuteInterval6.Text != "" && comboBoxStartFormatInterval6.Text != "") &&
                        (comboBoxStopHourInterval6.Text != "" && comboBoxStopMinuteInterval6.Text != "" && comboBoxStopFormatInterval6.Text != "") &&
                        (checkBoxEntranceTone6.Checked == false || checkBoxEntranceTone6.Checked == true) &&
                        (checkBoxExitTone6.Checked == false || checkBoxExitTone6.Checked == true) &&
                        (checkBoxHoldMusic6.Checked == false || checkBoxHoldMusic6.Checked == true) &&
                        (checkBoxHoldOn6.Checked == false || checkBoxHoldOn6.Checked == true) &&
                        (checkBoxHoldCourse6.Checked == false || checkBoxHoldCourse6.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 46,
                            Start = comboBoxStartHourInterval6.Text + ":" + comboBoxStartMinuteInterval6.Text + ":" + "00" + " " + comboBoxStartFormatInterval6.Text,
                            Stop = comboBoxStopHourInterval6.Text + ":" + comboBoxStopMinuteInterval6.Text + ":" + "00" + " " + comboBoxStopFormatInterval6.Text,
                            EntranceTone = checkBoxEntranceTone6.Checked,
                            ExitTone = checkBoxExitTone6.Checked,
                            HoldMusic = checkBoxHoldMusic6.Checked,
                            HoldOn = checkBoxHoldOn6.Checked,
                            HoldCourse = checkBoxHoldCourse6.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval7.Text != "" && comboBoxStartMinuteInterval7.Text != "" && comboBoxStartFormatInterval7.Text != "") &&
                        (comboBoxStopHourInterval7.Text != "" && comboBoxStopMinuteInterval7.Text != "" && comboBoxStopFormatInterval7.Text != "") &&
                        (checkBoxEntranceTone7.Checked == false || checkBoxEntranceTone7.Checked == true) &&
                        (checkBoxExitTone7.Checked == false || checkBoxExitTone7.Checked == true) &&
                        (checkBoxHoldMusic7.Checked == false || checkBoxHoldMusic7.Checked == true) &&
                        (checkBoxHoldOn7.Checked == false || checkBoxHoldOn7.Checked == true) &&
                        (checkBoxHoldCourse7.Checked == false || checkBoxHoldCourse7.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 47,
                            Start = comboBoxStartHourInterval7.Text + ":" + comboBoxStartMinuteInterval7.Text + ":" + "00" + " " + comboBoxStartFormatInterval7.Text,
                            Stop = comboBoxStopHourInterval7.Text + ":" + comboBoxStopMinuteInterval7.Text + ":" + "00" + " " + comboBoxStopFormatInterval7.Text,
                            EntranceTone = checkBoxEntranceTone7.Checked,
                            ExitTone = checkBoxExitTone7.Checked,
                            HoldMusic = checkBoxHoldMusic7.Checked,
                            HoldOn = checkBoxHoldOn7.Checked,
                            HoldCourse = checkBoxHoldCourse7.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval8.Text != "" && comboBoxStartMinuteInterval8.Text != "" && comboBoxStartFormatInterval8.Text != "") &&
                        (comboBoxStopHourInterval8.Text != "" && comboBoxStopMinuteInterval8.Text != "" && comboBoxStopFormatInterval8.Text != "") &&
                        (checkBoxEntranceTone8.Checked == false || checkBoxEntranceTone8.Checked == true) &&
                        (checkBoxExitTone8.Checked == false || checkBoxExitTone8.Checked == true) &&
                        (checkBoxHoldMusic8.Checked == false || checkBoxHoldMusic8.Checked == true) &&
                        (checkBoxHoldOn8.Checked == false || checkBoxHoldOn8.Checked == true) &&
                        (checkBoxHoldCourse8.Checked == false || checkBoxHoldCourse8.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 48,
                            Start = comboBoxStartHourInterval8.Text + ":" + comboBoxStartMinuteInterval8.Text + ":" + "00" + " " + comboBoxStartFormatInterval8.Text,
                            Stop = comboBoxStopHourInterval8.Text + ":" + comboBoxStopMinuteInterval8.Text + ":" + "00" + " " + comboBoxStopFormatInterval8.Text,
                            EntranceTone = checkBoxEntranceTone8.Checked,
                            ExitTone = checkBoxExitTone8.Checked,
                            HoldMusic = checkBoxHoldMusic8.Checked,
                            HoldOn = checkBoxHoldOn8.Checked,
                            HoldCourse = checkBoxHoldCourse8.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval9.Text != "" && comboBoxStartMinuteInterval9.Text != "" && comboBoxStartFormatInterval9.Text != "") &&
                        (comboBoxStopHourInterval9.Text != "" && comboBoxStopMinuteInterval9.Text != "" && comboBoxStopFormatInterval9.Text != "") &&
                        (checkBoxEntranceTone9.Checked == false || checkBoxEntranceTone9.Checked == true) &&
                        (checkBoxExitTone9.Checked == false || checkBoxExitTone9.Checked == true) &&
                        (checkBoxHoldMusic9.Checked == false || checkBoxHoldMusic9.Checked == true) &&
                        (checkBoxHoldOn9.Checked == false || checkBoxHoldOn9.Checked == true) &&
                        (checkBoxHoldCourse9.Checked == false || checkBoxHoldCourse9.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 49,
                            Start = comboBoxStartHourInterval9.Text + ":" + comboBoxStartMinuteInterval9.Text + ":" + "00" + " " + comboBoxStartFormatInterval9.Text,
                            Stop = comboBoxStopHourInterval9.Text + ":" + comboBoxStopMinuteInterval9.Text + ":" + "00" + " " + comboBoxStopFormatInterval9.Text,
                            EntranceTone = checkBoxEntranceTone9.Checked,
                            ExitTone = checkBoxExitTone9.Checked,
                            HoldMusic = checkBoxHoldMusic9.Checked,
                            HoldOn = checkBoxHoldOn9.Checked,
                            HoldCourse = checkBoxHoldCourse9.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval10.Text != "" && comboBoxStartMinuteInterval10.Text != "" && comboBoxStartFormatInterval10.Text != "") &&
                        (comboBoxStopHourInterval10.Text != "" && comboBoxStopMinuteInterval10.Text != "" && comboBoxStopFormatInterval10.Text != "") &&
                        (checkBoxEntranceTone10.Checked == false || checkBoxEntranceTone10.Checked == true) &&
                        (checkBoxExitTone10.Checked == false || checkBoxExitTone10.Checked == true) &&
                        (checkBoxHoldMusic10.Checked == false || checkBoxHoldMusic10.Checked == true) &&
                        (checkBoxHoldOn10.Checked == false || checkBoxHoldOn10.Checked == true) &&
                        (checkBoxHoldCourse10.Checked == false || checkBoxHoldCourse10.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 50,
                            Start = comboBoxStartHourInterval10.Text + ":" + comboBoxStartMinuteInterval10.Text + ":" + "00" + " " + comboBoxStartFormatInterval10.Text,
                            Stop = comboBoxStopHourInterval10.Text + ":" + comboBoxStopMinuteInterval10.Text + ":" + "00" + " " + comboBoxStopFormatInterval10.Text,
                            EntranceTone = checkBoxEntranceTone10.Checked,
                            ExitTone = checkBoxExitTone10.Checked,
                            HoldMusic = checkBoxHoldMusic10.Checked,
                            HoldOn = checkBoxHoldOn10.Checked,
                            HoldCourse = checkBoxHoldCourse10.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    break;

                case "Sambata":
                    if ((comboBoxStartHourInterval1.Text != "" && comboBoxStartMinuteInterval1.Text != "" && comboBoxStartFormatInterval1.Text != "") &&
                    (comboBoxStopHourInterval1.Text != "" && comboBoxStopMinuteInterval1.Text != "" && comboBoxStopFormatInterval1.Text != "") &&
                    (checkBoxExitTone1.Checked == false || checkBoxExitTone1.Checked == true) &&
                    (checkBoxEntranceTone1.Checked == false || checkBoxEntranceTone1.Checked == true) &&
                    (checkBoxHoldMusic1.Checked == false || checkBoxHoldMusic1.Checked == true) &&
                    (checkBoxHoldOn1.Checked == false || checkBoxHoldOn1.Checked == true) &&
                    (checkBoxHoldCourse1.Checked == false || checkBoxHoldCourse1.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 51,
                            Start = comboBoxStartHourInterval1.Text + ":" + comboBoxStartMinuteInterval1.Text + ":" + "00" + " " + comboBoxStartFormatInterval1.Text,
                            Stop = comboBoxStopHourInterval1.Text + ":" + comboBoxStopMinuteInterval1.Text + ":" + "00" + " " + comboBoxStopFormatInterval1.Text,
                            EntranceTone = checkBoxEntranceTone1.Checked,
                            ExitTone = checkBoxExitTone1.Checked,
                            HoldMusic = checkBoxHoldMusic1.Checked,
                            HoldOn = checkBoxHoldOn1.Checked,
                            HoldCourse = checkBoxHoldCourse1.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval2.Text != "" && comboBoxStartMinuteInterval2.Text != "" && comboBoxStartFormatInterval2.Text != "") &&
                        (comboBoxStopHourInterval2.Text != "" && comboBoxStopMinuteInterval2.Text != "" && comboBoxStopFormatInterval2.Text != "") &&
                        (checkBoxEntranceTone2.Checked == false || checkBoxEntranceTone2.Checked == true) &&
                        (checkBoxExitTone2.Checked == false || checkBoxExitTone2.Checked == true) &&
                        (checkBoxHoldMusic2.Checked == false || checkBoxHoldMusic2.Checked == true) &&
                        (checkBoxHoldOn2.Checked == false || checkBoxHoldOn2.Checked == true) &&
                        (checkBoxHoldCourse2.Checked == false || checkBoxHoldCourse2.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 52,
                            Start = comboBoxStartHourInterval2.Text + ":" + comboBoxStartMinuteInterval2.Text + ":" + "00" + " " + comboBoxStartFormatInterval2.Text,
                            Stop = comboBoxStopHourInterval2.Text + ":" + comboBoxStopMinuteInterval2.Text + ":" + "00" + " " + comboBoxStopFormatInterval2.Text,
                            EntranceTone = checkBoxEntranceTone2.Checked,
                            ExitTone = checkBoxExitTone2.Checked,
                            HoldMusic = checkBoxHoldMusic2.Checked,
                            HoldOn = checkBoxHoldOn2.Checked,
                            HoldCourse = checkBoxHoldCourse2.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval3.Text != "" && comboBoxStartMinuteInterval3.Text != "" && comboBoxStartFormatInterval3.Text != "") &&
                        (comboBoxStopHourInterval3.Text != "" && comboBoxStopMinuteInterval3.Text != "" && comboBoxStopFormatInterval3.Text != "") &&
                        (checkBoxEntranceTone3.Checked == false || checkBoxEntranceTone3.Checked == true) &&
                        (checkBoxExitTone3.Checked == false || checkBoxExitTone3.Checked == true) &&
                        (checkBoxHoldMusic3.Checked == false || checkBoxHoldMusic3.Checked == true) &&
                        (checkBoxHoldOn3.Checked == false || checkBoxHoldOn3.Checked == true) &&
                        (checkBoxHoldCourse3.Checked == false || checkBoxHoldCourse3.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 53,
                            Start = comboBoxStartHourInterval3.Text + ":" + comboBoxStartMinuteInterval3.Text + ":" + "00" + " " + comboBoxStartFormatInterval3.Text,
                            Stop = comboBoxStopHourInterval3.Text + ":" + comboBoxStopMinuteInterval3.Text + ":" + "00" + " " + comboBoxStopFormatInterval3.Text,
                            EntranceTone = checkBoxEntranceTone3.Checked,
                            ExitTone = checkBoxExitTone3.Checked,
                            HoldMusic = checkBoxHoldMusic3.Checked,
                            HoldOn = checkBoxHoldOn3.Checked,
                            HoldCourse = checkBoxHoldCourse3.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval4.Text != "" && comboBoxStartMinuteInterval4.Text != "" && comboBoxStartFormatInterval4.Text != "") &&
                        (comboBoxStopHourInterval4.Text != "" && comboBoxStopMinuteInterval4.Text != "" && comboBoxStopFormatInterval4.Text != "") &&
                        (checkBoxEntranceTone4.Checked == false || checkBoxEntranceTone4.Checked == true) &&
                        (checkBoxExitTone4.Checked == false || checkBoxExitTone4.Checked == true) &&
                        (checkBoxHoldMusic4.Checked == false || checkBoxHoldMusic4.Checked == true) &&
                        (checkBoxHoldOn4.Checked == false || checkBoxHoldOn4.Checked == true) &&
                        (checkBoxHoldCourse4.Checked == false || checkBoxHoldCourse4.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 54,
                            Start = comboBoxStartHourInterval4.Text + ":" + comboBoxStartMinuteInterval4.Text + ":" + "00" + " " + comboBoxStartFormatInterval4.Text,
                            Stop = comboBoxStopHourInterval4.Text + ":" + comboBoxStopMinuteInterval4.Text + ":" + "00" + " " + comboBoxStopFormatInterval4.Text,
                            EntranceTone = checkBoxEntranceTone4.Checked,
                            ExitTone = checkBoxExitTone4.Checked,
                            HoldMusic = checkBoxHoldMusic4.Checked,
                            HoldOn = checkBoxHoldOn4.Checked,
                            HoldCourse = checkBoxHoldCourse4.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval5.Text != "" && comboBoxStartMinuteInterval5.Text != "" && comboBoxStartFormatInterval5.Text != "") &&
                        (comboBoxStopHourInterval5.Text != "" && comboBoxStopMinuteInterval5.Text != "" && comboBoxStopFormatInterval5.Text != "") &&
                        (checkBoxEntranceTone5.Checked == false || checkBoxEntranceTone5.Checked == true) &&
                        (checkBoxExitTone5.Checked == false || checkBoxExitTone5.Checked == true) &&
                        (checkBoxHoldMusic5.Checked == false || checkBoxHoldMusic5.Checked == true) &&
                        (checkBoxHoldOn5.Checked == false || checkBoxHoldOn5.Checked == true) &&
                        (checkBoxHoldCourse5.Checked == false || checkBoxHoldCourse5.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 55,
                            Start = comboBoxStartHourInterval5.Text + ":" + comboBoxStartMinuteInterval5.Text + ":" + "00" + " " + comboBoxStartFormatInterval5.Text,
                            Stop = comboBoxStopHourInterval5.Text + ":" + comboBoxStopMinuteInterval5.Text + ":" + "00" + " " + comboBoxStopFormatInterval5.Text,
                            EntranceTone = checkBoxEntranceTone5.Checked,
                            ExitTone = checkBoxExitTone5.Checked,
                            HoldMusic = checkBoxHoldMusic5.Checked,
                            HoldOn = checkBoxHoldOn5.Checked,
                            HoldCourse = checkBoxHoldCourse5.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval6.Text != "" && comboBoxStartMinuteInterval6.Text != "" && comboBoxStartFormatInterval6.Text != "") &&
                        (comboBoxStopHourInterval6.Text != "" && comboBoxStopMinuteInterval6.Text != "" && comboBoxStopFormatInterval6.Text != "") &&
                        (checkBoxEntranceTone6.Checked == false || checkBoxEntranceTone6.Checked == true) &&
                        (checkBoxExitTone6.Checked == false || checkBoxExitTone6.Checked == true) &&
                        (checkBoxHoldMusic6.Checked == false || checkBoxHoldMusic6.Checked == true) &&
                        (checkBoxHoldOn6.Checked == false || checkBoxHoldOn6.Checked == true) &&
                        (checkBoxHoldCourse6.Checked == false || checkBoxHoldCourse6.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 56,
                            Start = comboBoxStartHourInterval6.Text + ":" + comboBoxStartMinuteInterval6.Text + ":" + "00" + " " + comboBoxStartFormatInterval6.Text,
                            Stop = comboBoxStopHourInterval6.Text + ":" + comboBoxStopMinuteInterval6.Text + ":" + "00" + " " + comboBoxStopFormatInterval6.Text,
                            EntranceTone = checkBoxEntranceTone6.Checked,
                            ExitTone = checkBoxExitTone6.Checked,
                            HoldMusic = checkBoxHoldMusic6.Checked,
                            HoldOn = checkBoxHoldOn6.Checked,
                            HoldCourse = checkBoxHoldCourse6.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval7.Text != "" && comboBoxStartMinuteInterval7.Text != "" && comboBoxStartFormatInterval7.Text != "") &&
                        (comboBoxStopHourInterval7.Text != "" && comboBoxStopMinuteInterval7.Text != "" && comboBoxStopFormatInterval7.Text != "") &&
                        (checkBoxEntranceTone7.Checked == false || checkBoxEntranceTone7.Checked == true) &&
                        (checkBoxExitTone7.Checked == false || checkBoxExitTone7.Checked == true) &&
                        (checkBoxHoldMusic7.Checked == false || checkBoxHoldMusic7.Checked == true) &&
                        (checkBoxHoldOn7.Checked == false || checkBoxHoldOn7.Checked == true) &&
                        (checkBoxHoldCourse7.Checked == false || checkBoxHoldCourse7.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 57,
                            Start = comboBoxStartHourInterval7.Text + ":" + comboBoxStartMinuteInterval7.Text + ":" + "00" + " " + comboBoxStartFormatInterval7.Text,
                            Stop = comboBoxStopHourInterval7.Text + ":" + comboBoxStopMinuteInterval7.Text + ":" + "00" + " " + comboBoxStopFormatInterval7.Text,
                            EntranceTone = checkBoxEntranceTone7.Checked,
                            ExitTone = checkBoxExitTone7.Checked,
                            HoldMusic = checkBoxHoldMusic7.Checked,
                            HoldOn = checkBoxHoldOn7.Checked,
                            HoldCourse = checkBoxHoldCourse7.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval8.Text != "" && comboBoxStartMinuteInterval8.Text != "" && comboBoxStartFormatInterval8.Text != "") &&
                        (comboBoxStopHourInterval8.Text != "" && comboBoxStopMinuteInterval8.Text != "" && comboBoxStopFormatInterval8.Text != "") &&
                        (checkBoxEntranceTone8.Checked == false || checkBoxEntranceTone8.Checked == true) &&
                        (checkBoxExitTone8.Checked == false || checkBoxExitTone8.Checked == true) &&
                        (checkBoxHoldMusic8.Checked == false || checkBoxHoldMusic8.Checked == true) &&
                        (checkBoxHoldOn8.Checked == false || checkBoxHoldOn8.Checked == true) &&
                        (checkBoxHoldCourse8.Checked == false || checkBoxHoldCourse8.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 58,
                            Start = comboBoxStartHourInterval8.Text + ":" + comboBoxStartMinuteInterval8.Text + ":" + "00" + " " + comboBoxStartFormatInterval8.Text,
                            Stop = comboBoxStopHourInterval8.Text + ":" + comboBoxStopMinuteInterval8.Text + ":" + "00" + " " + comboBoxStopFormatInterval8.Text,
                            EntranceTone = checkBoxEntranceTone8.Checked,
                            ExitTone = checkBoxExitTone8.Checked,
                            HoldMusic = checkBoxHoldMusic8.Checked,
                            HoldOn = checkBoxHoldOn8.Checked,
                            HoldCourse = checkBoxHoldCourse8.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval9.Text != "" && comboBoxStartMinuteInterval9.Text != "" && comboBoxStartFormatInterval9.Text != "") &&
                        (comboBoxStopHourInterval9.Text != "" && comboBoxStopMinuteInterval9.Text != "" && comboBoxStopFormatInterval9.Text != "") &&
                        (checkBoxEntranceTone9.Checked == false || checkBoxEntranceTone9.Checked == true) &&
                        (checkBoxExitTone9.Checked == false || checkBoxExitTone9.Checked == true) &&
                        (checkBoxHoldMusic9.Checked == false || checkBoxHoldMusic9.Checked == true) &&
                        (checkBoxHoldOn9.Checked == false || checkBoxHoldOn9.Checked == true) &&
                        (checkBoxHoldCourse9.Checked == false || checkBoxHoldCourse9.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 59,
                            Start = comboBoxStartHourInterval9.Text + ":" + comboBoxStartMinuteInterval9.Text + ":" + "00" + " " + comboBoxStartFormatInterval9.Text,
                            Stop = comboBoxStopHourInterval9.Text + ":" + comboBoxStopMinuteInterval9.Text + ":" + "00" + " " + comboBoxStopFormatInterval9.Text,
                            EntranceTone = checkBoxEntranceTone9.Checked,
                            ExitTone = checkBoxExitTone9.Checked,
                            HoldMusic = checkBoxHoldMusic9.Checked,
                            HoldOn = checkBoxHoldOn9.Checked,
                            HoldCourse = checkBoxHoldCourse9.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval10.Text != "" && comboBoxStartMinuteInterval10.Text != "" && comboBoxStartFormatInterval10.Text != "") &&
                        (comboBoxStopHourInterval10.Text != "" && comboBoxStopMinuteInterval10.Text != "" && comboBoxStopFormatInterval10.Text != "") &&
                        (checkBoxEntranceTone10.Checked == false || checkBoxEntranceTone10.Checked == true) &&
                        (checkBoxExitTone10.Checked == false || checkBoxExitTone10.Checked == true) &&
                        (checkBoxHoldMusic10.Checked == false || checkBoxHoldMusic10.Checked == true) &&
                        (checkBoxHoldOn10.Checked == false || checkBoxHoldOn10.Checked == true) &&
                        (checkBoxHoldCourse10.Checked == false || checkBoxHoldCourse10.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 60,
                            Start = comboBoxStartHourInterval10.Text + ":" + comboBoxStartMinuteInterval10.Text + ":" + "00" + " " + comboBoxStartFormatInterval10.Text,
                            Stop = comboBoxStopHourInterval10.Text + ":" + comboBoxStopMinuteInterval10.Text + ":" + "00" + " " + comboBoxStopFormatInterval10.Text,
                            EntranceTone = checkBoxEntranceTone10.Checked,
                            ExitTone = checkBoxExitTone10.Checked,
                            HoldMusic = checkBoxHoldMusic10.Checked,
                            HoldOn = checkBoxHoldOn10.Checked,
                            HoldCourse = checkBoxHoldCourse10.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    break;

                case "Duminica":
                    if ((comboBoxStartHourInterval1.Text != "" && comboBoxStartMinuteInterval1.Text != "" && comboBoxStartFormatInterval1.Text != "") &&
                    (comboBoxStopHourInterval1.Text != "" && comboBoxStopMinuteInterval1.Text != "" && comboBoxStopFormatInterval1.Text != "") &&
                    (checkBoxExitTone1.Checked == false || checkBoxExitTone1.Checked == true) &&
                    (checkBoxEntranceTone1.Checked == false || checkBoxEntranceTone1.Checked == true) &&
                    (checkBoxHoldMusic1.Checked == false || checkBoxHoldMusic1.Checked == true) &&
                    (checkBoxHoldOn1.Checked == false || checkBoxHoldOn1.Checked == true) &&
                    (checkBoxHoldCourse1.Checked == false || checkBoxHoldCourse1.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 61,
                            Start = comboBoxStartHourInterval1.Text + ":" + comboBoxStartMinuteInterval1.Text + ":" + "00" + " " + comboBoxStartFormatInterval1.Text,
                            Stop = comboBoxStopHourInterval1.Text + ":" + comboBoxStopMinuteInterval1.Text + ":" + "00" + " " + comboBoxStopFormatInterval1.Text,
                            EntranceTone = checkBoxEntranceTone1.Checked,
                            ExitTone = checkBoxExitTone1.Checked,
                            HoldMusic = checkBoxHoldMusic1.Checked,
                            HoldOn = checkBoxHoldOn1.Checked,
                            HoldCourse = checkBoxHoldCourse1.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval2.Text != "" && comboBoxStartMinuteInterval2.Text != "" && comboBoxStartFormatInterval2.Text != "") &&
                        (comboBoxStopHourInterval2.Text != "" && comboBoxStopMinuteInterval2.Text != "" && comboBoxStopFormatInterval2.Text != "") &&
                        (checkBoxEntranceTone2.Checked == false || checkBoxEntranceTone2.Checked == true) &&
                        (checkBoxExitTone2.Checked == false || checkBoxExitTone2.Checked == true) &&
                        (checkBoxHoldMusic2.Checked == false || checkBoxHoldMusic2.Checked == true) &&
                        (checkBoxHoldOn2.Checked == false || checkBoxHoldOn2.Checked == true) &&
                        (checkBoxHoldCourse2.Checked == false || checkBoxHoldCourse2.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 62,
                            Start = comboBoxStartHourInterval2.Text + ":" + comboBoxStartMinuteInterval2.Text + ":" + "00" + " " + comboBoxStartFormatInterval2.Text,
                            Stop = comboBoxStopHourInterval2.Text + ":" + comboBoxStopMinuteInterval2.Text + ":" + "00" + " " + comboBoxStopFormatInterval2.Text,
                            EntranceTone = checkBoxEntranceTone2.Checked,
                            ExitTone = checkBoxExitTone2.Checked,
                            HoldMusic = checkBoxHoldMusic2.Checked,
                            HoldOn = checkBoxHoldOn2.Checked,
                            HoldCourse = checkBoxHoldCourse2.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval3.Text != "" && comboBoxStartMinuteInterval3.Text != "" && comboBoxStartFormatInterval3.Text != "") &&
                        (comboBoxStopHourInterval3.Text != "" && comboBoxStopMinuteInterval3.Text != "" && comboBoxStopFormatInterval3.Text != "") &&
                        (checkBoxEntranceTone3.Checked == false || checkBoxEntranceTone3.Checked == true) &&
                        (checkBoxExitTone3.Checked == false || checkBoxExitTone3.Checked == true) &&
                        (checkBoxHoldMusic3.Checked == false || checkBoxHoldMusic3.Checked == true) &&
                        (checkBoxHoldOn3.Checked == false || checkBoxHoldOn3.Checked == true) &&
                        (checkBoxHoldCourse3.Checked == false || checkBoxHoldCourse3.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 63,
                            Start = comboBoxStartHourInterval3.Text + ":" + comboBoxStartMinuteInterval3.Text + ":" + "00" + " " + comboBoxStartFormatInterval3.Text,
                            Stop = comboBoxStopHourInterval3.Text + ":" + comboBoxStopMinuteInterval3.Text + ":" + "00" + " " + comboBoxStopFormatInterval3.Text,
                            EntranceTone = checkBoxEntranceTone3.Checked,
                            ExitTone = checkBoxExitTone3.Checked,
                            HoldMusic = checkBoxHoldMusic3.Checked,
                            HoldOn = checkBoxHoldOn3.Checked,
                            HoldCourse = checkBoxHoldCourse3.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval4.Text != "" && comboBoxStartMinuteInterval4.Text != "" && comboBoxStartFormatInterval4.Text != "") &&
                        (comboBoxStopHourInterval4.Text != "" && comboBoxStopMinuteInterval4.Text != "" && comboBoxStopFormatInterval4.Text != "") &&
                        (checkBoxEntranceTone4.Checked == false || checkBoxEntranceTone4.Checked == true) &&
                        (checkBoxExitTone4.Checked == false || checkBoxExitTone4.Checked == true) &&
                        (checkBoxHoldMusic4.Checked == false || checkBoxHoldMusic4.Checked == true) &&
                        (checkBoxHoldOn4.Checked == false || checkBoxHoldOn4.Checked == true) &&
                        (checkBoxHoldCourse4.Checked == false || checkBoxHoldCourse4.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 64,
                            Start = comboBoxStartHourInterval4.Text + ":" + comboBoxStartMinuteInterval4.Text + ":" + "00" + " " + comboBoxStartFormatInterval4.Text,
                            Stop = comboBoxStopHourInterval4.Text + ":" + comboBoxStopMinuteInterval4.Text + ":" + "00" + " " + comboBoxStopFormatInterval4.Text,
                            EntranceTone = checkBoxEntranceTone4.Checked,
                            ExitTone = checkBoxExitTone4.Checked,
                            HoldMusic = checkBoxHoldMusic4.Checked,
                            HoldOn = checkBoxHoldOn4.Checked,
                            HoldCourse = checkBoxHoldCourse4.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval5.Text != "" && comboBoxStartMinuteInterval5.Text != "" && comboBoxStartFormatInterval5.Text != "") &&
                        (comboBoxStopHourInterval5.Text != "" && comboBoxStopMinuteInterval5.Text != "" && comboBoxStopFormatInterval5.Text != "") &&
                        (checkBoxEntranceTone5.Checked == false || checkBoxEntranceTone5.Checked == true) &&
                        (checkBoxExitTone5.Checked == false || checkBoxExitTone5.Checked == true) &&
                        (checkBoxHoldMusic5.Checked == false || checkBoxHoldMusic5.Checked == true) &&
                        (checkBoxHoldOn5.Checked == false || checkBoxHoldOn5.Checked == true) &&
                        (checkBoxHoldCourse5.Checked == false || checkBoxHoldCourse5.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 65,
                            Start = comboBoxStartHourInterval5.Text + ":" + comboBoxStartMinuteInterval5.Text + ":" + "00" + " " + comboBoxStartFormatInterval5.Text,
                            Stop = comboBoxStopHourInterval5.Text + ":" + comboBoxStopMinuteInterval5.Text + ":" + "00" + " " + comboBoxStopFormatInterval5.Text,
                            EntranceTone = checkBoxEntranceTone5.Checked,
                            ExitTone = checkBoxExitTone5.Checked,
                            HoldMusic = checkBoxHoldMusic5.Checked,
                            HoldOn = checkBoxHoldOn5.Checked,
                            HoldCourse = checkBoxHoldCourse5.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval6.Text != "" && comboBoxStartMinuteInterval6.Text != "" && comboBoxStartFormatInterval6.Text != "") &&
                        (comboBoxStopHourInterval6.Text != "" && comboBoxStopMinuteInterval6.Text != "" && comboBoxStopFormatInterval6.Text != "") &&
                        (checkBoxEntranceTone6.Checked == false || checkBoxEntranceTone6.Checked == true) &&
                        (checkBoxExitTone6.Checked == false || checkBoxExitTone6.Checked == true) &&
                        (checkBoxHoldMusic6.Checked == false || checkBoxHoldMusic6.Checked == true) &&
                        (checkBoxHoldOn6.Checked == false || checkBoxHoldOn6.Checked == true) &&
                        (checkBoxHoldCourse6.Checked == false || checkBoxHoldCourse6.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 66,
                            Start = comboBoxStartHourInterval6.Text + ":" + comboBoxStartMinuteInterval6.Text + ":" + "00" + " " + comboBoxStartFormatInterval6.Text,
                            Stop = comboBoxStopHourInterval6.Text + ":" + comboBoxStopMinuteInterval6.Text + ":" + "00" + " " + comboBoxStopFormatInterval6.Text,
                            EntranceTone = checkBoxEntranceTone6.Checked,
                            ExitTone = checkBoxExitTone6.Checked,
                            HoldMusic = checkBoxHoldMusic6.Checked,
                            HoldOn = checkBoxHoldOn6.Checked,
                            HoldCourse = checkBoxHoldCourse6.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval7.Text != "" && comboBoxStartMinuteInterval7.Text != "" && comboBoxStartFormatInterval7.Text != "") &&
                        (comboBoxStopHourInterval7.Text != "" && comboBoxStopMinuteInterval7.Text != "" && comboBoxStopFormatInterval7.Text != "") &&
                        (checkBoxEntranceTone7.Checked == false || checkBoxEntranceTone7.Checked == true) &&
                        (checkBoxExitTone7.Checked == false || checkBoxExitTone7.Checked == true) &&
                        (checkBoxHoldMusic7.Checked == false || checkBoxHoldMusic7.Checked == true) &&
                        (checkBoxHoldOn7.Checked == false || checkBoxHoldOn7.Checked == true) &&
                        (checkBoxHoldCourse7.Checked == false || checkBoxHoldCourse7.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 67,
                            Start = comboBoxStartHourInterval7.Text + ":" + comboBoxStartMinuteInterval7.Text + ":" + "00" + " " + comboBoxStartFormatInterval7.Text,
                            Stop = comboBoxStopHourInterval7.Text + ":" + comboBoxStopMinuteInterval7.Text + ":" + "00" + " " + comboBoxStopFormatInterval7.Text,
                            EntranceTone = checkBoxEntranceTone7.Checked,
                            ExitTone = checkBoxExitTone7.Checked,
                            HoldMusic = checkBoxHoldMusic7.Checked,
                            HoldOn = checkBoxHoldOn7.Checked,
                            HoldCourse = checkBoxHoldCourse7.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval8.Text != "" && comboBoxStartMinuteInterval8.Text != "" && comboBoxStartFormatInterval8.Text != "") &&
                        (comboBoxStopHourInterval8.Text != "" && comboBoxStopMinuteInterval8.Text != "" && comboBoxStopFormatInterval8.Text != "") &&
                        (checkBoxEntranceTone8.Checked == false || checkBoxEntranceTone8.Checked == true) &&
                        (checkBoxExitTone8.Checked == false || checkBoxExitTone8.Checked == true) &&
                        (checkBoxHoldMusic8.Checked == false || checkBoxHoldMusic8.Checked == true) &&
                        (checkBoxHoldOn8.Checked == false || checkBoxHoldOn8.Checked == true) &&
                        (checkBoxHoldCourse8.Checked == false || checkBoxHoldCourse8.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 68,
                            Start = comboBoxStartHourInterval8.Text + ":" + comboBoxStartMinuteInterval8.Text + ":" + "00" + " " + comboBoxStartFormatInterval8.Text,
                            Stop = comboBoxStopHourInterval8.Text + ":" + comboBoxStopMinuteInterval8.Text + ":" + "00" + " " + comboBoxStopFormatInterval8.Text,
                            EntranceTone = checkBoxEntranceTone8.Checked,
                            ExitTone = checkBoxExitTone8.Checked,
                            HoldMusic = checkBoxHoldMusic8.Checked,
                            HoldOn = checkBoxHoldOn8.Checked,
                            HoldCourse = checkBoxHoldCourse8.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval9.Text != "" && comboBoxStartMinuteInterval9.Text != "" && comboBoxStartFormatInterval9.Text != "") &&
                        (comboBoxStopHourInterval9.Text != "" && comboBoxStopMinuteInterval9.Text != "" && comboBoxStopFormatInterval9.Text != "") &&
                        (checkBoxEntranceTone9.Checked == false || checkBoxEntranceTone9.Checked == true) &&
                        (checkBoxExitTone9.Checked == false || checkBoxExitTone9.Checked == true) &&
                        (checkBoxHoldMusic9.Checked == false || checkBoxHoldMusic9.Checked == true) &&
                        (checkBoxHoldOn9.Checked == false || checkBoxHoldOn9.Checked == true) &&
                        (checkBoxHoldCourse9.Checked == false || checkBoxHoldCourse9.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 69,
                            Start = comboBoxStartHourInterval9.Text + ":" + comboBoxStartMinuteInterval9.Text + ":" + "00" + " " + comboBoxStartFormatInterval9.Text,
                            Stop = comboBoxStopHourInterval9.Text + ":" + comboBoxStopMinuteInterval9.Text + ":" + "00" + " " + comboBoxStopFormatInterval9.Text,
                            EntranceTone = checkBoxEntranceTone9.Checked,
                            ExitTone = checkBoxExitTone9.Checked,
                            HoldMusic = checkBoxHoldMusic9.Checked,
                            HoldOn = checkBoxHoldOn9.Checked,
                            HoldCourse = checkBoxHoldCourse9.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    if ((comboBoxStartHourInterval10.Text != "" && comboBoxStartMinuteInterval10.Text != "" && comboBoxStartFormatInterval10.Text != "") &&
                        (comboBoxStopHourInterval10.Text != "" && comboBoxStopMinuteInterval10.Text != "" && comboBoxStopFormatInterval10.Text != "") &&
                        (checkBoxEntranceTone10.Checked == false || checkBoxEntranceTone10.Checked == true) &&
                        (checkBoxExitTone10.Checked == false || checkBoxExitTone10.Checked == true) &&
                        (checkBoxHoldMusic10.Checked == false || checkBoxHoldMusic10.Checked == true) &&
                        (checkBoxHoldOn10.Checked == false || checkBoxHoldOn10.Checked == true) &&
                        (checkBoxHoldCourse10.Checked == false || checkBoxHoldCourse10.Checked == true))
                    {
                        IntervalsAndChecksGymnasium intervalsAndChecksGymnasiumObject = new IntervalsAndChecksGymnasium()
                        {
                            Id = 70,
                            Start = comboBoxStartHourInterval10.Text + ":" + comboBoxStartMinuteInterval10.Text + ":" + "00" + " " + comboBoxStartFormatInterval10.Text,
                            Stop = comboBoxStopHourInterval10.Text + ":" + comboBoxStopMinuteInterval10.Text + ":" + "00" + " " + comboBoxStopFormatInterval10.Text,
                            EntranceTone = checkBoxEntranceTone10.Checked,
                            ExitTone = checkBoxExitTone10.Checked,
                            HoldMusic = checkBoxHoldMusic10.Checked,
                            HoldOn = checkBoxHoldOn10.Checked,
                            HoldCourse = checkBoxHoldCourse10.Checked
                        };
                        intervalsAndChecksGymnasium.Add(intervalsAndChecksGymnasiumObject);
                        sqlCommand = new SqlCommand(
                            "update IntervalsAndChecksGymnasium" +
                            " set " + "Start" + " = " + "@Start" + ", " +
                                      "Stop" + " = " + "@Stop" + ", " +
                                      "ExitTone" + " = " + "@ExitTone" + ", " +
                                      "EntranceTone" + " = " + "@EntranceTone" + ", " +
                                      "HoldMusic" + " = " + "@HoldMusic" + ", " +
                                      "HoldOn" + " = " + "@HoldOn" + ", " +
                                      "HoldCourse" + " = " + "@HoldCourse " +
                                      "where Id = " + "@Id" + ";", sqlConnection);

                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                        sqlCommand.Parameters["@Id"].Value = intervalsAndChecksGymnasiumObject.Id;
                        sqlCommand.Parameters.Add("@Start", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Start"].Value = intervalsAndChecksGymnasiumObject.Start;
                        sqlCommand.Parameters.Add("@Stop", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Stop"].Value = intervalsAndChecksGymnasiumObject.Stop;
                        sqlCommand.Parameters.Add("@ExitTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@ExitTone"].Value = intervalsAndChecksGymnasiumObject.ExitTone;
                        sqlCommand.Parameters.Add("@EntranceTone", SqlDbType.Bit);
                        sqlCommand.Parameters["@EntranceTone"].Value = intervalsAndChecksGymnasiumObject.EntranceTone;
                        sqlCommand.Parameters.Add("@HoldMusic", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldMusic"].Value = intervalsAndChecksGymnasiumObject.HoldMusic;
                        sqlCommand.Parameters.Add("@HoldOn", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldOn"].Value = intervalsAndChecksGymnasiumObject.HoldOn;
                        sqlCommand.Parameters.Add("@HoldCourse", SqlDbType.Bit);
                        sqlCommand.Parameters["@HoldCourse"].Value = intervalsAndChecksGymnasiumObject.HoldCourse;

                        sqlCommand.ExecuteNonQuery();
                    }
                    break;
            }
        }

        public List<IntervalsAndChecksGymnasium> ReadIntervalsAndChecksGymnasiumFromDatabase()
        {
            string connectionString = @"Data Source=MIHAIFLORIN\SQLEXPRESS;Initial Catalog=ClassBellProject;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from IntervalsAndChecksGymnasium;", sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<IntervalsAndChecksGymnasium> intervalsAndChecksGymnasium = new List<IntervalsAndChecksGymnasium>();
            while (reader.Read())
            {
                intervalsAndChecksGymnasium.Add(new IntervalsAndChecksGymnasium()
                {
                    Id = (int)reader.GetValue(0),
                    DayGymnasiumId = (int)reader.GetValue(1),
                    Start = reader.GetValue(2).ToString(),
                    Stop = reader.GetValue(3).ToString(),
                    ExitTone = (bool)reader.GetValue(4),
                    EntranceTone = (bool)reader.GetValue(5),
                    HoldMusic = (bool)reader.GetValue(6),
                    HoldOn = (bool)reader.GetValue(7),
                    HoldCourse = (bool)reader.GetValue(8),
                });
            }
            sqlConnection.Close();

            return intervalsAndChecksGymnasium;
        }

        public void PopulateIntervalsAndChecksSelectingDay()
        {
            List<IntervalsAndChecksGymnasium> intervalsAndChecksGymnasium = ReadIntervalsAndChecksGymnasiumFromDatabase();

            string[] startIntervalComponents;
            string[] timeStartIntervalComponents;
            string[] stopIntervalComponents;
            string[] timeStopIntervalComponents;

            string dayChecked = listBoxSelectDayGymnasium.SelectedItem.ToString();
            switch (dayChecked)
            {
                case "Luni":
                    if (intervalsAndChecksGymnasium[0].Start != "" && intervalsAndChecksGymnasium[0].Stop != "" &&
                        intervalsAndChecksGymnasium[0].Id == 1)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[0].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval1.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval1.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval1.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[0].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval1.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval1.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval1.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone1.Checked = intervalsAndChecksGymnasium[0].ExitTone;
                        checkBoxEntranceTone1.Checked = intervalsAndChecksGymnasium[0].EntranceTone;
                        checkBoxHoldMusic1.Checked = intervalsAndChecksGymnasium[0].HoldMusic;
                        checkBoxHoldOn1.Checked = intervalsAndChecksGymnasium[0].HoldOn;
                        checkBoxHoldCourse1.Checked = intervalsAndChecksGymnasium[0].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[1].Start != "" && intervalsAndChecksGymnasium[1].Stop != "" &&
                        intervalsAndChecksGymnasium[1].Id == 2)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[1].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval2.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval2.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval2.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[1].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval2.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval2.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval2.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone2.Checked = intervalsAndChecksGymnasium[1].ExitTone;
                        checkBoxEntranceTone2.Checked = intervalsAndChecksGymnasium[1].EntranceTone;
                        checkBoxHoldMusic2.Checked = intervalsAndChecksGymnasium[1].HoldMusic;
                        checkBoxHoldOn2.Checked = intervalsAndChecksGymnasium[1].HoldOn;
                        checkBoxHoldCourse2.Checked = intervalsAndChecksGymnasium[1].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[2].Start != "" && intervalsAndChecksGymnasium[2].Stop != "" &&
                        intervalsAndChecksGymnasium[2].Id == 3)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[2].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval3.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval3.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval3.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[2].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval3.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval3.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval3.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone3.Checked = intervalsAndChecksGymnasium[2].ExitTone;
                        checkBoxEntranceTone3.Checked = intervalsAndChecksGymnasium[2].EntranceTone;
                        checkBoxHoldMusic3.Checked = intervalsAndChecksGymnasium[2].HoldMusic;
                        checkBoxHoldOn3.Checked = intervalsAndChecksGymnasium[2].HoldOn;
                        checkBoxHoldCourse3.Checked = intervalsAndChecksGymnasium[2].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[3].Start != "" && intervalsAndChecksGymnasium[3].Stop != "" && 
                        intervalsAndChecksGymnasium[3].Id == 4)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[3].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval4.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval4.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval4.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[3].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval4.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval4.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval4.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone4.Checked = intervalsAndChecksGymnasium[3].ExitTone;
                        checkBoxEntranceTone4.Checked = intervalsAndChecksGymnasium[3].EntranceTone;
                        checkBoxHoldMusic4.Checked = intervalsAndChecksGymnasium[3].HoldMusic;
                        checkBoxHoldOn4.Checked = intervalsAndChecksGymnasium[3].HoldOn;
                        checkBoxHoldCourse4.Checked = intervalsAndChecksGymnasium[3].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[4].Start != "" && intervalsAndChecksGymnasium[4].Stop != "" &&
                        intervalsAndChecksGymnasium[4].Id == 5)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[4].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval5.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval5.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval5.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[4].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval5.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval5.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval5.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone5.Checked = intervalsAndChecksGymnasium[4].ExitTone;
                        checkBoxEntranceTone5.Checked = intervalsAndChecksGymnasium[4].EntranceTone;
                        checkBoxHoldMusic5.Checked = intervalsAndChecksGymnasium[4].HoldMusic;
                        checkBoxHoldOn5.Checked = intervalsAndChecksGymnasium[4].HoldOn;
                        checkBoxHoldCourse5.Checked = intervalsAndChecksGymnasium[4].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[5].Start != "" && intervalsAndChecksGymnasium[5].Stop != "" &&
                        intervalsAndChecksGymnasium[5].Id == 6)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[5].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval6.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval6.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval6.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[5].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval6.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval6.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval6.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone6.Checked = intervalsAndChecksGymnasium[5].ExitTone;
                        checkBoxEntranceTone6.Checked = intervalsAndChecksGymnasium[5].EntranceTone;
                        checkBoxHoldMusic6.Checked = intervalsAndChecksGymnasium[5].HoldMusic;
                        checkBoxHoldOn6.Checked = intervalsAndChecksGymnasium[5].HoldOn;
                        checkBoxHoldCourse6.Checked = intervalsAndChecksGymnasium[5].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[6].Start != "" && intervalsAndChecksGymnasium[6].Stop != "" &&
                        intervalsAndChecksGymnasium[6].Id == 7)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[6].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval7.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval7.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval7.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[6].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval7.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval7.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval7.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone7.Checked = intervalsAndChecksGymnasium[6].ExitTone;
                        checkBoxEntranceTone7.Checked = intervalsAndChecksGymnasium[6].EntranceTone;
                        checkBoxHoldMusic7.Checked = intervalsAndChecksGymnasium[6].HoldMusic;
                        checkBoxHoldOn7.Checked = intervalsAndChecksGymnasium[6].HoldOn;
                        checkBoxHoldCourse7.Checked = intervalsAndChecksGymnasium[6].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[7].Start != "" && intervalsAndChecksGymnasium[7].Stop != "" &&
                        intervalsAndChecksGymnasium[7].Id == 8)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[7].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval8.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval8.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval8.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[7].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval8.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval8.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval8.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone8.Checked = intervalsAndChecksGymnasium[7].ExitTone;
                        checkBoxEntranceTone8.Checked = intervalsAndChecksGymnasium[7].EntranceTone;
                        checkBoxHoldMusic8.Checked = intervalsAndChecksGymnasium[7].HoldMusic;
                        checkBoxHoldOn8.Checked = intervalsAndChecksGymnasium[7].HoldOn;
                        checkBoxHoldCourse8.Checked = intervalsAndChecksGymnasium[7].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[8].Start != "" && intervalsAndChecksGymnasium[8].Stop != "" &&
                        intervalsAndChecksGymnasium[8].Id == 9)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[8].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval9.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval9.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval9.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[8].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval9.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval9.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval9.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone9.Checked = intervalsAndChecksGymnasium[8].ExitTone;
                        checkBoxEntranceTone9.Checked = intervalsAndChecksGymnasium[8].EntranceTone;
                        checkBoxHoldMusic9.Checked = intervalsAndChecksGymnasium[8].HoldMusic;
                        checkBoxHoldOn9.Checked = intervalsAndChecksGymnasium[8].HoldOn;
                        checkBoxHoldCourse9.Checked = intervalsAndChecksGymnasium[8].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[9].Start != "" && intervalsAndChecksGymnasium[9].Stop != "" &&
                        intervalsAndChecksGymnasium[9].Id == 10)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[9].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval10.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval10.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval10.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[9].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval10.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval10.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval10.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone10.Checked = intervalsAndChecksGymnasium[9].ExitTone;
                        checkBoxEntranceTone10.Checked = intervalsAndChecksGymnasium[9].EntranceTone;
                        checkBoxHoldMusic10.Checked = intervalsAndChecksGymnasium[9].HoldMusic;
                        checkBoxHoldOn10.Checked = intervalsAndChecksGymnasium[9].HoldOn;
                        checkBoxHoldCourse10.Checked = intervalsAndChecksGymnasium[9].HoldCourse;
                    }

                    break;

                case "Marti":
                    if (intervalsAndChecksGymnasium[10].Start != "" && intervalsAndChecksGymnasium[10].Stop != "" &&
                        intervalsAndChecksGymnasium[10].Id == 11)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[10].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval1.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval1.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval1.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[10].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval1.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval1.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval1.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone1.Checked = intervalsAndChecksGymnasium[10].ExitTone;
                        checkBoxEntranceTone1.Checked = intervalsAndChecksGymnasium[10].EntranceTone;
                        checkBoxHoldMusic1.Checked = intervalsAndChecksGymnasium[10].HoldMusic;
                        checkBoxHoldOn1.Checked = intervalsAndChecksGymnasium[10].HoldOn;
                        checkBoxHoldCourse1.Checked = intervalsAndChecksGymnasium[10].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[11].Start != "" && intervalsAndChecksGymnasium[11].Stop != "" &&
                        intervalsAndChecksGymnasium[11].Id == 12)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[11].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval2.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval2.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval2.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[11].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval2.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval2.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval2.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone2.Checked = intervalsAndChecksGymnasium[11].ExitTone;
                        checkBoxEntranceTone2.Checked = intervalsAndChecksGymnasium[11].EntranceTone;
                        checkBoxHoldMusic2.Checked = intervalsAndChecksGymnasium[11].HoldMusic;
                        checkBoxHoldOn2.Checked = intervalsAndChecksGymnasium[11].HoldOn;
                        checkBoxHoldCourse2.Checked = intervalsAndChecksGymnasium[11].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[12].Start != "" && intervalsAndChecksGymnasium[12].Stop != "" &&
                        intervalsAndChecksGymnasium[12].Id == 13)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[12].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval3.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval3.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval3.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[12].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval3.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval3.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval3.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone3.Checked = intervalsAndChecksGymnasium[12].ExitTone;
                        checkBoxEntranceTone3.Checked = intervalsAndChecksGymnasium[2].EntranceTone;
                        checkBoxHoldMusic3.Checked = intervalsAndChecksGymnasium[12].HoldMusic;
                        checkBoxHoldOn3.Checked = intervalsAndChecksGymnasium[12].HoldOn;
                        checkBoxHoldCourse3.Checked = intervalsAndChecksGymnasium[12].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[13].Start != "" && intervalsAndChecksGymnasium[13].Stop != "" &&
                        intervalsAndChecksGymnasium[13].Id == 14)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[13].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval4.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval4.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval4.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[13].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval4.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval4.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval4.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone4.Checked = intervalsAndChecksGymnasium[13].ExitTone;
                        checkBoxEntranceTone4.Checked = intervalsAndChecksGymnasium[13].EntranceTone;
                        checkBoxHoldMusic4.Checked = intervalsAndChecksGymnasium[13].HoldMusic;
                        checkBoxHoldOn4.Checked = intervalsAndChecksGymnasium[13].HoldOn;
                        checkBoxHoldCourse4.Checked = intervalsAndChecksGymnasium[13].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[14].Start != "" && intervalsAndChecksGymnasium[14].Stop != "" &&
                        intervalsAndChecksGymnasium[14].Id == 15)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[14].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval5.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval5.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval5.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[14].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval5.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval5.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval5.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone5.Checked = intervalsAndChecksGymnasium[14].ExitTone;
                        checkBoxEntranceTone5.Checked = intervalsAndChecksGymnasium[14].EntranceTone;
                        checkBoxHoldMusic5.Checked = intervalsAndChecksGymnasium[14].HoldMusic;
                        checkBoxHoldOn5.Checked = intervalsAndChecksGymnasium[14].HoldOn;
                        checkBoxHoldCourse5.Checked = intervalsAndChecksGymnasium[14].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[15].Start != "" && intervalsAndChecksGymnasium[15].Stop != "" &&
                        intervalsAndChecksGymnasium[15].Id == 16)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[15].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval6.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval6.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval6.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[15].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval6.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval6.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval6.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone6.Checked = intervalsAndChecksGymnasium[15].ExitTone;
                        checkBoxEntranceTone6.Checked = intervalsAndChecksGymnasium[15].EntranceTone;
                        checkBoxHoldMusic6.Checked = intervalsAndChecksGymnasium[15].HoldMusic;
                        checkBoxHoldOn6.Checked = intervalsAndChecksGymnasium[15].HoldOn;
                        checkBoxHoldCourse6.Checked = intervalsAndChecksGymnasium[15].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[16].Start != "" && intervalsAndChecksGymnasium[16].Stop != "" &&
                        intervalsAndChecksGymnasium[16].Id == 17)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[16].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval7.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval7.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval7.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[16].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval7.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval7.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval7.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone7.Checked = intervalsAndChecksGymnasium[16].ExitTone;
                        checkBoxEntranceTone7.Checked = intervalsAndChecksGymnasium[16].EntranceTone;
                        checkBoxHoldMusic7.Checked = intervalsAndChecksGymnasium[16].HoldMusic;
                        checkBoxHoldOn7.Checked = intervalsAndChecksGymnasium[16].HoldOn;
                        checkBoxHoldCourse7.Checked = intervalsAndChecksGymnasium[16].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[17].Start != "" && intervalsAndChecksGymnasium[17].Stop != "" &&
                        intervalsAndChecksGymnasium[17].Id == 18)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[17].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval8.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval8.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval8.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[17].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval8.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval8.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval8.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone8.Checked = intervalsAndChecksGymnasium[17].ExitTone;
                        checkBoxEntranceTone8.Checked = intervalsAndChecksGymnasium[17].EntranceTone;
                        checkBoxHoldMusic8.Checked = intervalsAndChecksGymnasium[17].HoldMusic;
                        checkBoxHoldOn8.Checked = intervalsAndChecksGymnasium[17].HoldOn;
                        checkBoxHoldCourse8.Checked = intervalsAndChecksGymnasium[17].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[18].Start != "" && intervalsAndChecksGymnasium[18].Stop != "" &&
                        intervalsAndChecksGymnasium[18].Id == 19)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[18].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval9.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval9.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval9.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[18].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval9.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval9.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval9.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone9.Checked = intervalsAndChecksGymnasium[18].ExitTone;
                        checkBoxEntranceTone9.Checked = intervalsAndChecksGymnasium[18].EntranceTone;
                        checkBoxHoldMusic9.Checked = intervalsAndChecksGymnasium[18].HoldMusic;
                        checkBoxHoldOn9.Checked = intervalsAndChecksGymnasium[18].HoldOn;
                        checkBoxHoldCourse9.Checked = intervalsAndChecksGymnasium[18].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[19].Start != "" && intervalsAndChecksGymnasium[19].Stop != "" &&
                        intervalsAndChecksGymnasium[19].Id == 20)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[19].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval10.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval10.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval10.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[19].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval10.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval10.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval10.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone10.Checked = intervalsAndChecksGymnasium[19].ExitTone;
                        checkBoxEntranceTone10.Checked = intervalsAndChecksGymnasium[19].EntranceTone;
                        checkBoxHoldMusic10.Checked = intervalsAndChecksGymnasium[19].HoldMusic;
                        checkBoxHoldOn10.Checked = intervalsAndChecksGymnasium[19].HoldOn;
                        checkBoxHoldCourse10.Checked = intervalsAndChecksGymnasium[19].HoldCourse;
                    }

                    break;

                case "Miercuri":
                    if (intervalsAndChecksGymnasium[20].Start != "" && intervalsAndChecksGymnasium[20].Stop != "" &&
                        intervalsAndChecksGymnasium[20].Id == 21)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[20].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval1.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval1.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval1.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[20].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval1.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval1.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval1.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone1.Checked = intervalsAndChecksGymnasium[20].ExitTone;
                        checkBoxEntranceTone1.Checked = intervalsAndChecksGymnasium[20].EntranceTone;
                        checkBoxHoldMusic1.Checked = intervalsAndChecksGymnasium[20].HoldMusic;
                        checkBoxHoldOn1.Checked = intervalsAndChecksGymnasium[20].HoldOn;
                        checkBoxHoldCourse1.Checked = intervalsAndChecksGymnasium[20].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[21].Start != "" && intervalsAndChecksGymnasium[21].Stop != "" &&
                        intervalsAndChecksGymnasium[21].Id == 22)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[21].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval2.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval2.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval2.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[21].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval2.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval2.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval2.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone2.Checked = intervalsAndChecksGymnasium[21].ExitTone;
                        checkBoxEntranceTone2.Checked = intervalsAndChecksGymnasium[21].EntranceTone;
                        checkBoxHoldMusic2.Checked = intervalsAndChecksGymnasium[21].HoldMusic;
                        checkBoxHoldOn2.Checked = intervalsAndChecksGymnasium[21].HoldOn;
                        checkBoxHoldCourse2.Checked = intervalsAndChecksGymnasium[21].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[22].Start != "" && intervalsAndChecksGymnasium[22].Stop != "" &&
                        intervalsAndChecksGymnasium[22].Id == 23)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[22].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval3.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval3.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval3.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[22].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval3.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval3.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval3.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone3.Checked = intervalsAndChecksGymnasium[22].ExitTone;
                        checkBoxEntranceTone3.Checked = intervalsAndChecksGymnasium[22].EntranceTone;
                        checkBoxHoldMusic3.Checked = intervalsAndChecksGymnasium[22].HoldMusic;
                        checkBoxHoldOn3.Checked = intervalsAndChecksGymnasium[22].HoldOn;
                        checkBoxHoldCourse3.Checked = intervalsAndChecksGymnasium[22].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[23].Start != "" && intervalsAndChecksGymnasium[23].Stop != "" &&
                        intervalsAndChecksGymnasium[23].Id == 24)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[23].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval4.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval4.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval4.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[23].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval4.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval4.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval4.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone4.Checked = intervalsAndChecksGymnasium[23].ExitTone;
                        checkBoxEntranceTone4.Checked = intervalsAndChecksGymnasium[23].EntranceTone;
                        checkBoxHoldMusic4.Checked = intervalsAndChecksGymnasium[23].HoldMusic;
                        checkBoxHoldOn4.Checked = intervalsAndChecksGymnasium[23].HoldOn;
                        checkBoxHoldCourse4.Checked = intervalsAndChecksGymnasium[23].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[24].Start != "" && intervalsAndChecksGymnasium[24].Stop != "" &&
                        intervalsAndChecksGymnasium[24].Id == 25)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[24].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval5.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval5.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval5.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[24].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval5.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval5.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval5.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone5.Checked = intervalsAndChecksGymnasium[24].ExitTone;
                        checkBoxEntranceTone5.Checked = intervalsAndChecksGymnasium[24].EntranceTone;
                        checkBoxHoldMusic5.Checked = intervalsAndChecksGymnasium[24].HoldMusic;
                        checkBoxHoldOn5.Checked = intervalsAndChecksGymnasium[24].HoldOn;
                        checkBoxHoldCourse5.Checked = intervalsAndChecksGymnasium[24].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[25].Start != "" && intervalsAndChecksGymnasium[25].Stop != "" &&
                        intervalsAndChecksGymnasium[25].Id == 26)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[25].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval6.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval6.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval6.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[25].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval6.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval6.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval6.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone6.Checked = intervalsAndChecksGymnasium[25].ExitTone;
                        checkBoxEntranceTone6.Checked = intervalsAndChecksGymnasium[25].EntranceTone;
                        checkBoxHoldMusic6.Checked = intervalsAndChecksGymnasium[25].HoldMusic;
                        checkBoxHoldOn6.Checked = intervalsAndChecksGymnasium[25].HoldOn;
                        checkBoxHoldCourse6.Checked = intervalsAndChecksGymnasium[25].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[26].Start != "" && intervalsAndChecksGymnasium[26].Stop != "" &&
                        intervalsAndChecksGymnasium[26].Id == 27)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[26].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval7.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval7.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval7.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[26].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval7.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval7.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval7.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone7.Checked = intervalsAndChecksGymnasium[26].ExitTone;
                        checkBoxEntranceTone7.Checked = intervalsAndChecksGymnasium[26].EntranceTone;
                        checkBoxHoldMusic7.Checked = intervalsAndChecksGymnasium[26].HoldMusic;
                        checkBoxHoldOn7.Checked = intervalsAndChecksGymnasium[26].HoldOn;
                        checkBoxHoldCourse7.Checked = intervalsAndChecksGymnasium[26].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[27].Start != "" && intervalsAndChecksGymnasium[27].Stop != "" &&
                        intervalsAndChecksGymnasium[27].Id == 28)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[27].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval8.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval8.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval8.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[27].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval8.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval8.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval8.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone8.Checked = intervalsAndChecksGymnasium[27].ExitTone;
                        checkBoxEntranceTone8.Checked = intervalsAndChecksGymnasium[27].EntranceTone;
                        checkBoxHoldMusic8.Checked = intervalsAndChecksGymnasium[27].HoldMusic;
                        checkBoxHoldOn8.Checked = intervalsAndChecksGymnasium[27].HoldOn;
                        checkBoxHoldCourse8.Checked = intervalsAndChecksGymnasium[27].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[28].Start != "" && intervalsAndChecksGymnasium[28].Stop != "" &&
                        intervalsAndChecksGymnasium[28].Id == 29)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[28].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval9.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval9.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval9.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[28].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval9.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval9.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval9.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone9.Checked = intervalsAndChecksGymnasium[28].ExitTone;
                        checkBoxEntranceTone9.Checked = intervalsAndChecksGymnasium[28].EntranceTone;
                        checkBoxHoldMusic9.Checked = intervalsAndChecksGymnasium[28].HoldMusic;
                        checkBoxHoldOn9.Checked = intervalsAndChecksGymnasium[28].HoldOn;
                        checkBoxHoldCourse9.Checked = intervalsAndChecksGymnasium[28].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[29].Start != "" && intervalsAndChecksGymnasium[29].Stop != "" &&
                        intervalsAndChecksGymnasium[29].Id == 30)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[29].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval10.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval10.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval10.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[29].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval10.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval10.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval10.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone10.Checked = intervalsAndChecksGymnasium[29].ExitTone;
                        checkBoxEntranceTone10.Checked = intervalsAndChecksGymnasium[29].EntranceTone;
                        checkBoxHoldMusic10.Checked = intervalsAndChecksGymnasium[29].HoldMusic;
                        checkBoxHoldOn10.Checked = intervalsAndChecksGymnasium[29].HoldOn;
                        checkBoxHoldCourse10.Checked = intervalsAndChecksGymnasium[29].HoldCourse;
                    }

                    break;

                case "Joi":
                    if (intervalsAndChecksGymnasium[30].Start != "" && intervalsAndChecksGymnasium[30].Stop != "" &&
                        intervalsAndChecksGymnasium[30].Id == 31)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[30].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval1.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval1.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval1.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[30].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval1.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval1.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval1.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone1.Checked = intervalsAndChecksGymnasium[30].ExitTone;
                        checkBoxEntranceTone1.Checked = intervalsAndChecksGymnasium[30].EntranceTone;
                        checkBoxHoldMusic1.Checked = intervalsAndChecksGymnasium[30].HoldMusic;
                        checkBoxHoldOn1.Checked = intervalsAndChecksGymnasium[30].HoldOn;
                        checkBoxHoldCourse1.Checked = intervalsAndChecksGymnasium[30].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[31].Start != "" && intervalsAndChecksGymnasium[31].Stop != "" &&
                        intervalsAndChecksGymnasium[31].Id == 32)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[31].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval2.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval2.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval2.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[31].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval2.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval2.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval2.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone2.Checked = intervalsAndChecksGymnasium[31].ExitTone;
                        checkBoxEntranceTone2.Checked = intervalsAndChecksGymnasium[31].EntranceTone;
                        checkBoxHoldMusic2.Checked = intervalsAndChecksGymnasium[31].HoldMusic;
                        checkBoxHoldOn2.Checked = intervalsAndChecksGymnasium[31].HoldOn;
                        checkBoxHoldCourse2.Checked = intervalsAndChecksGymnasium[31].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[32].Start != "" && intervalsAndChecksGymnasium[32].Stop != "" &&
                        intervalsAndChecksGymnasium[32].Id == 33)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[32].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval3.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval3.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval3.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[32].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval3.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval3.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval3.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone3.Checked = intervalsAndChecksGymnasium[32].ExitTone;
                        checkBoxEntranceTone3.Checked = intervalsAndChecksGymnasium[32].EntranceTone;
                        checkBoxHoldMusic3.Checked = intervalsAndChecksGymnasium[32].HoldMusic;
                        checkBoxHoldOn3.Checked = intervalsAndChecksGymnasium[32].HoldOn;
                        checkBoxHoldCourse3.Checked = intervalsAndChecksGymnasium[32].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[33].Start != "" && intervalsAndChecksGymnasium[33].Stop != "" &&
                        intervalsAndChecksGymnasium[33].Id == 34)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[33].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval4.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval4.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval4.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[33].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval4.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval4.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval4.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone4.Checked = intervalsAndChecksGymnasium[33].ExitTone;
                        checkBoxEntranceTone4.Checked = intervalsAndChecksGymnasium[33].EntranceTone;
                        checkBoxHoldMusic4.Checked = intervalsAndChecksGymnasium[33].HoldMusic;
                        checkBoxHoldOn4.Checked = intervalsAndChecksGymnasium[33].HoldOn;
                        checkBoxHoldCourse4.Checked = intervalsAndChecksGymnasium[33].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[34].Start != "" && intervalsAndChecksGymnasium[34].Stop != "" &&
                        intervalsAndChecksGymnasium[34].Id == 35)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[34].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval5.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval5.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval5.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[34].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval5.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval5.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval5.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone5.Checked = intervalsAndChecksGymnasium[34].ExitTone;
                        checkBoxEntranceTone5.Checked = intervalsAndChecksGymnasium[34].EntranceTone;
                        checkBoxHoldMusic5.Checked = intervalsAndChecksGymnasium[34].HoldMusic;
                        checkBoxHoldOn5.Checked = intervalsAndChecksGymnasium[34].HoldOn;
                        checkBoxHoldCourse5.Checked = intervalsAndChecksGymnasium[34].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[35].Start != "" && intervalsAndChecksGymnasium[35].Stop != "" &&
                        intervalsAndChecksGymnasium[35].Id == 36)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[35].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval6.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval6.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval6.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[35].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval6.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval6.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval6.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone6.Checked = intervalsAndChecksGymnasium[35].ExitTone;
                        checkBoxEntranceTone6.Checked = intervalsAndChecksGymnasium[35].EntranceTone;
                        checkBoxHoldMusic6.Checked = intervalsAndChecksGymnasium[35].HoldMusic;
                        checkBoxHoldOn6.Checked = intervalsAndChecksGymnasium[35].HoldOn;
                        checkBoxHoldCourse6.Checked = intervalsAndChecksGymnasium[35].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[36].Start != "" && intervalsAndChecksGymnasium[36].Stop != "" &&
                        intervalsAndChecksGymnasium[36].Id == 37)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[36].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval7.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval7.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval7.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[36].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval7.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval7.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval7.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone7.Checked = intervalsAndChecksGymnasium[36].ExitTone;
                        checkBoxEntranceTone7.Checked = intervalsAndChecksGymnasium[36].EntranceTone;
                        checkBoxHoldMusic7.Checked = intervalsAndChecksGymnasium[36].HoldMusic;
                        checkBoxHoldOn7.Checked = intervalsAndChecksGymnasium[36].HoldOn;
                        checkBoxHoldCourse7.Checked = intervalsAndChecksGymnasium[36].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[37].Start != "" && intervalsAndChecksGymnasium[37].Stop != "" &&
                        intervalsAndChecksGymnasium[37].Id == 38)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[37].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval8.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval8.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval8.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[37].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval8.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval8.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval8.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone8.Checked = intervalsAndChecksGymnasium[37].ExitTone;
                        checkBoxEntranceTone8.Checked = intervalsAndChecksGymnasium[37].EntranceTone;
                        checkBoxHoldMusic8.Checked = intervalsAndChecksGymnasium[37].HoldMusic;
                        checkBoxHoldOn8.Checked = intervalsAndChecksGymnasium[37].HoldOn;
                        checkBoxHoldCourse8.Checked = intervalsAndChecksGymnasium[37].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[38].Start != "" && intervalsAndChecksGymnasium[38].Stop != "" &&
                        intervalsAndChecksGymnasium[38].Id == 39)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[38].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval9.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval9.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval9.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[38].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval9.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval9.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval9.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone9.Checked = intervalsAndChecksGymnasium[38].ExitTone;
                        checkBoxEntranceTone9.Checked = intervalsAndChecksGymnasium[38].EntranceTone;
                        checkBoxHoldMusic9.Checked = intervalsAndChecksGymnasium[38].HoldMusic;
                        checkBoxHoldOn9.Checked = intervalsAndChecksGymnasium[38].HoldOn;
                        checkBoxHoldCourse9.Checked = intervalsAndChecksGymnasium[38].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[39].Start != "" && intervalsAndChecksGymnasium[39].Stop != "" &&
                        intervalsAndChecksGymnasium[39].Id == 40)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[39].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval10.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval10.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval10.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[39].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval10.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval10.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval10.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone10.Checked = intervalsAndChecksGymnasium[39].ExitTone;
                        checkBoxEntranceTone10.Checked = intervalsAndChecksGymnasium[39].EntranceTone;
                        checkBoxHoldMusic10.Checked = intervalsAndChecksGymnasium[39].HoldMusic;
                        checkBoxHoldOn10.Checked = intervalsAndChecksGymnasium[39].HoldOn;
                        checkBoxHoldCourse10.Checked = intervalsAndChecksGymnasium[39].HoldCourse;
                    }

                    break;

                case "Vineri":
                    if (intervalsAndChecksGymnasium[40].Start != "" && intervalsAndChecksGymnasium[40].Stop != "" &&
                        intervalsAndChecksGymnasium[40].Id == 41)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[40].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval1.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval1.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval1.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[40].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval1.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval1.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval1.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone1.Checked = intervalsAndChecksGymnasium[40].ExitTone;
                        checkBoxEntranceTone1.Checked = intervalsAndChecksGymnasium[40].EntranceTone;
                        checkBoxHoldMusic1.Checked = intervalsAndChecksGymnasium[40].HoldMusic;
                        checkBoxHoldOn1.Checked = intervalsAndChecksGymnasium[40].HoldOn;
                        checkBoxHoldCourse1.Checked = intervalsAndChecksGymnasium[40].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[41].Start != "" && intervalsAndChecksGymnasium[41].Stop != "" &&
                        intervalsAndChecksGymnasium[41].Id == 42)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[41].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval2.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval2.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval2.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[41].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval2.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval2.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval2.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone2.Checked = intervalsAndChecksGymnasium[41].ExitTone;
                        checkBoxEntranceTone2.Checked = intervalsAndChecksGymnasium[41].EntranceTone;
                        checkBoxHoldMusic2.Checked = intervalsAndChecksGymnasium[41].HoldMusic;
                        checkBoxHoldOn2.Checked = intervalsAndChecksGymnasium[41].HoldOn;
                        checkBoxHoldCourse2.Checked = intervalsAndChecksGymnasium[41].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[42].Start != "" && intervalsAndChecksGymnasium[42].Stop != "" &&
                        intervalsAndChecksGymnasium[42].Id == 43)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[42].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval3.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval3.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval3.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[42].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval3.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval3.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval3.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone3.Checked = intervalsAndChecksGymnasium[42].ExitTone;
                        checkBoxEntranceTone3.Checked = intervalsAndChecksGymnasium[42].EntranceTone;
                        checkBoxHoldMusic3.Checked = intervalsAndChecksGymnasium[42].HoldMusic;
                        checkBoxHoldOn3.Checked = intervalsAndChecksGymnasium[42].HoldOn;
                        checkBoxHoldCourse3.Checked = intervalsAndChecksGymnasium[42].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[43].Start != "" && intervalsAndChecksGymnasium[43].Stop != "" &&
                        intervalsAndChecksGymnasium[43].Id == 44)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[43].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval4.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval4.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval4.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[43].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval4.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval4.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval4.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone4.Checked = intervalsAndChecksGymnasium[43].ExitTone;
                        checkBoxEntranceTone4.Checked = intervalsAndChecksGymnasium[43].EntranceTone;
                        checkBoxHoldMusic4.Checked = intervalsAndChecksGymnasium[43].HoldMusic;
                        checkBoxHoldOn4.Checked = intervalsAndChecksGymnasium[43].HoldOn;
                        checkBoxHoldCourse4.Checked = intervalsAndChecksGymnasium[43].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[44].Start != "" && intervalsAndChecksGymnasium[44].Stop != "" &&
                        intervalsAndChecksGymnasium[44].Id == 45)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[44].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval5.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval5.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval5.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[44].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval5.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval5.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval5.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone5.Checked = intervalsAndChecksGymnasium[44].ExitTone;
                        checkBoxEntranceTone5.Checked = intervalsAndChecksGymnasium[44].EntranceTone;
                        checkBoxHoldMusic5.Checked = intervalsAndChecksGymnasium[44].HoldMusic;
                        checkBoxHoldOn5.Checked = intervalsAndChecksGymnasium[44].HoldOn;
                        checkBoxHoldCourse5.Checked = intervalsAndChecksGymnasium[44].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[45].Start != "" && intervalsAndChecksGymnasium[45].Stop != "" &&
                        intervalsAndChecksGymnasium[45].Id == 46)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[45].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval6.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval6.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval6.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[45].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval6.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval6.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval6.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone6.Checked = intervalsAndChecksGymnasium[45].ExitTone;
                        checkBoxEntranceTone6.Checked = intervalsAndChecksGymnasium[45].EntranceTone;
                        checkBoxHoldMusic6.Checked = intervalsAndChecksGymnasium[45].HoldMusic;
                        checkBoxHoldOn6.Checked = intervalsAndChecksGymnasium[45].HoldOn;
                        checkBoxHoldCourse6.Checked = intervalsAndChecksGymnasium[45].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[46].Start != "" && intervalsAndChecksGymnasium[46].Stop != "" &&
                        intervalsAndChecksGymnasium[46].Id == 47)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[46].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval7.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval7.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval7.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[46].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval7.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval7.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval7.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone7.Checked = intervalsAndChecksGymnasium[46].ExitTone;
                        checkBoxEntranceTone7.Checked = intervalsAndChecksGymnasium[46].EntranceTone;
                        checkBoxHoldMusic7.Checked = intervalsAndChecksGymnasium[46].HoldMusic;
                        checkBoxHoldOn7.Checked = intervalsAndChecksGymnasium[46].HoldOn;
                        checkBoxHoldCourse7.Checked = intervalsAndChecksGymnasium[46].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[47].Start != "" && intervalsAndChecksGymnasium[47].Stop != "" &&
                        intervalsAndChecksGymnasium[47].Id == 48)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[47].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval8.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval8.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval8.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[47].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval8.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval8.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval8.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone8.Checked = intervalsAndChecksGymnasium[47].ExitTone;
                        checkBoxEntranceTone8.Checked = intervalsAndChecksGymnasium[47].EntranceTone;
                        checkBoxHoldMusic8.Checked = intervalsAndChecksGymnasium[47].HoldMusic;
                        checkBoxHoldOn8.Checked = intervalsAndChecksGymnasium[47].HoldOn;
                        checkBoxHoldCourse8.Checked = intervalsAndChecksGymnasium[47].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[48].Start != "" && intervalsAndChecksGymnasium[48].Stop != "" &&
                        intervalsAndChecksGymnasium[48].Id == 49)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[48].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval9.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval9.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval9.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[48].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval9.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval9.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval9.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone9.Checked = intervalsAndChecksGymnasium[48].ExitTone;
                        checkBoxEntranceTone9.Checked = intervalsAndChecksGymnasium[48].EntranceTone;
                        checkBoxHoldMusic9.Checked = intervalsAndChecksGymnasium[48].HoldMusic;
                        checkBoxHoldOn9.Checked = intervalsAndChecksGymnasium[48].HoldOn;
                        checkBoxHoldCourse9.Checked = intervalsAndChecksGymnasium[48].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[49].Start != "" && intervalsAndChecksGymnasium[49].Stop != "" &&
                        intervalsAndChecksGymnasium[49].Id == 50)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[49].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval10.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval10.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval10.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[49].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval10.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval10.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval10.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone10.Checked = intervalsAndChecksGymnasium[49].ExitTone;
                        checkBoxEntranceTone10.Checked = intervalsAndChecksGymnasium[49].EntranceTone;
                        checkBoxHoldMusic10.Checked = intervalsAndChecksGymnasium[49].HoldMusic;
                        checkBoxHoldOn10.Checked = intervalsAndChecksGymnasium[49].HoldOn;
                        checkBoxHoldCourse10.Checked = intervalsAndChecksGymnasium[49].HoldCourse;
                    }

                    break;

                case "Sambata":
                    if (intervalsAndChecksGymnasium[50].Start != "" && intervalsAndChecksGymnasium[50].Stop != "" &&
                        intervalsAndChecksGymnasium[50].Id == 51)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[50].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval1.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval1.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval1.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[50].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval1.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval1.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval1.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone1.Checked = intervalsAndChecksGymnasium[50].ExitTone;
                        checkBoxEntranceTone1.Checked = intervalsAndChecksGymnasium[50].EntranceTone;
                        checkBoxHoldMusic1.Checked = intervalsAndChecksGymnasium[50].HoldMusic;
                        checkBoxHoldOn1.Checked = intervalsAndChecksGymnasium[50].HoldOn;
                        checkBoxHoldCourse1.Checked = intervalsAndChecksGymnasium[50].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[51].Start != "" && intervalsAndChecksGymnasium[51].Stop != "" &&
                        intervalsAndChecksGymnasium[51].Id == 52)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[51].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval2.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval2.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval2.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[51].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval2.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval2.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval2.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone2.Checked = intervalsAndChecksGymnasium[51].ExitTone;
                        checkBoxEntranceTone2.Checked = intervalsAndChecksGymnasium[51].EntranceTone;
                        checkBoxHoldMusic2.Checked = intervalsAndChecksGymnasium[51].HoldMusic;
                        checkBoxHoldOn2.Checked = intervalsAndChecksGymnasium[51].HoldOn;
                        checkBoxHoldCourse2.Checked = intervalsAndChecksGymnasium[51].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[52].Start != "" && intervalsAndChecksGymnasium[52].Stop != "" && 
                        intervalsAndChecksGymnasium[52].Id == 53)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[52].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval3.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval3.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval3.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[52].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval3.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval3.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval3.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone3.Checked = intervalsAndChecksGymnasium[52].ExitTone;
                        checkBoxEntranceTone3.Checked = intervalsAndChecksGymnasium[52].EntranceTone;
                        checkBoxHoldMusic3.Checked = intervalsAndChecksGymnasium[52].HoldMusic;
                        checkBoxHoldOn3.Checked = intervalsAndChecksGymnasium[52].HoldOn;
                        checkBoxHoldCourse3.Checked = intervalsAndChecksGymnasium[52].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[53].Start != "" && intervalsAndChecksGymnasium[53].Stop != "" &&
                        intervalsAndChecksGymnasium[53].Id == 54)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[53].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval4.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval4.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval4.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[53].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval4.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval4.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval4.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone4.Checked = intervalsAndChecksGymnasium[53].ExitTone;
                        checkBoxEntranceTone4.Checked = intervalsAndChecksGymnasium[53].EntranceTone;
                        checkBoxHoldMusic4.Checked = intervalsAndChecksGymnasium[53].HoldMusic;
                        checkBoxHoldOn4.Checked = intervalsAndChecksGymnasium[53].HoldOn;
                        checkBoxHoldCourse4.Checked = intervalsAndChecksGymnasium[53].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[54].Start != "" && intervalsAndChecksGymnasium[54].Stop != "" &&
                        intervalsAndChecksGymnasium[54].Id == 55)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[54].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval5.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval5.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval5.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[54].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval5.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval5.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval5.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone5.Checked = intervalsAndChecksGymnasium[54].ExitTone;
                        checkBoxEntranceTone5.Checked = intervalsAndChecksGymnasium[54].EntranceTone;
                        checkBoxHoldMusic5.Checked = intervalsAndChecksGymnasium[54].HoldMusic;
                        checkBoxHoldOn5.Checked = intervalsAndChecksGymnasium[54].HoldOn;
                        checkBoxHoldCourse5.Checked = intervalsAndChecksGymnasium[54].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[55].Start != "" && intervalsAndChecksGymnasium[55].Stop != "" &&
                        intervalsAndChecksGymnasium[55].Id == 56)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[55].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval6.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval6.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval6.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[55].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval6.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval6.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval6.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone6.Checked = intervalsAndChecksGymnasium[55].ExitTone;
                        checkBoxEntranceTone6.Checked = intervalsAndChecksGymnasium[55].EntranceTone;
                        checkBoxHoldMusic6.Checked = intervalsAndChecksGymnasium[55].HoldMusic;
                        checkBoxHoldOn6.Checked = intervalsAndChecksGymnasium[55].HoldOn;
                        checkBoxHoldCourse6.Checked = intervalsAndChecksGymnasium[55].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[56].Start != "" && intervalsAndChecksGymnasium[56].Stop != "" &&
                        intervalsAndChecksGymnasium[56].Id == 57)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[56].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval7.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval7.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval7.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[56].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval7.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval7.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval7.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone7.Checked = intervalsAndChecksGymnasium[56].ExitTone;
                        checkBoxEntranceTone7.Checked = intervalsAndChecksGymnasium[56].EntranceTone;
                        checkBoxHoldMusic7.Checked = intervalsAndChecksGymnasium[56].HoldMusic;
                        checkBoxHoldOn7.Checked = intervalsAndChecksGymnasium[56].HoldOn;
                        checkBoxHoldCourse7.Checked = intervalsAndChecksGymnasium[56].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[57].Start != "" && intervalsAndChecksGymnasium[57].Stop != "" &&
                        intervalsAndChecksGymnasium[57].Id == 58)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[57].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval8.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval8.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval8.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[57].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval8.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval8.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval8.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone8.Checked = intervalsAndChecksGymnasium[57].ExitTone;
                        checkBoxEntranceTone8.Checked = intervalsAndChecksGymnasium[57].EntranceTone;
                        checkBoxHoldMusic8.Checked = intervalsAndChecksGymnasium[57].HoldMusic;
                        checkBoxHoldOn8.Checked = intervalsAndChecksGymnasium[57].HoldOn;
                        checkBoxHoldCourse8.Checked = intervalsAndChecksGymnasium[57].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[58].Start != "" && intervalsAndChecksGymnasium[58].Stop != "" &&
                        intervalsAndChecksGymnasium[58].Id == 59)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[58].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval9.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval9.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval9.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[58].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval9.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval9.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval9.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone9.Checked = intervalsAndChecksGymnasium[58].ExitTone;
                        checkBoxEntranceTone9.Checked = intervalsAndChecksGymnasium[58].EntranceTone;
                        checkBoxHoldMusic9.Checked = intervalsAndChecksGymnasium[58].HoldMusic;
                        checkBoxHoldOn9.Checked = intervalsAndChecksGymnasium[58].HoldOn;
                        checkBoxHoldCourse9.Checked = intervalsAndChecksGymnasium[58].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[59].Start != "" && intervalsAndChecksGymnasium[59].Stop != "" &&
                        intervalsAndChecksGymnasium[59].Id == 60)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[59].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval10.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval10.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval10.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[59].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval10.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval10.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval10.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone10.Checked = intervalsAndChecksGymnasium[59].ExitTone;
                        checkBoxEntranceTone10.Checked = intervalsAndChecksGymnasium[59].EntranceTone;
                        checkBoxHoldMusic10.Checked = intervalsAndChecksGymnasium[59].HoldMusic;
                        checkBoxHoldOn10.Checked = intervalsAndChecksGymnasium[59].HoldOn;
                        checkBoxHoldCourse10.Checked = intervalsAndChecksGymnasium[59].HoldCourse;
                    }

                    break;

                case "Duminica":
                    if (intervalsAndChecksGymnasium[60].Start != "" && intervalsAndChecksGymnasium[60].Stop != "" &&
                        intervalsAndChecksGymnasium[60].Id == 61)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[60].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval1.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval1.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval1.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[60].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval1.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval1.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval1.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone1.Checked = intervalsAndChecksGymnasium[60].ExitTone;
                        checkBoxEntranceTone1.Checked = intervalsAndChecksGymnasium[60].EntranceTone;
                        checkBoxHoldMusic1.Checked = intervalsAndChecksGymnasium[60].HoldMusic;
                        checkBoxHoldOn1.Checked = intervalsAndChecksGymnasium[60].HoldOn;
                        checkBoxHoldCourse1.Checked = intervalsAndChecksGymnasium[60].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[61].Start != "" && intervalsAndChecksGymnasium[61].Stop != "" &&
                        intervalsAndChecksGymnasium[61].Id == 62)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[61].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval2.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval2.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval2.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[61].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval2.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval2.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval2.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone2.Checked = intervalsAndChecksGymnasium[61].ExitTone;
                        checkBoxEntranceTone2.Checked = intervalsAndChecksGymnasium[61].EntranceTone;
                        checkBoxHoldMusic2.Checked = intervalsAndChecksGymnasium[61].HoldMusic;
                        checkBoxHoldOn2.Checked = intervalsAndChecksGymnasium[61].HoldOn;
                        checkBoxHoldCourse2.Checked = intervalsAndChecksGymnasium[61].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[62].Start != "" && intervalsAndChecksGymnasium[62].Stop != "" &&
                        intervalsAndChecksGymnasium[62].Id == 63)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[62].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval3.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval3.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval3.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[62].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval3.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval3.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval3.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone3.Checked = intervalsAndChecksGymnasium[62].ExitTone;
                        checkBoxEntranceTone3.Checked = intervalsAndChecksGymnasium[62].EntranceTone;
                        checkBoxHoldMusic3.Checked = intervalsAndChecksGymnasium[62].HoldMusic;
                        checkBoxHoldOn3.Checked = intervalsAndChecksGymnasium[62].HoldOn;
                        checkBoxHoldCourse3.Checked = intervalsAndChecksGymnasium[62].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[63].Start != "" && intervalsAndChecksGymnasium[63].Stop != "" &&
                        intervalsAndChecksGymnasium[63].Id == 64)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[63].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval4.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval4.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval4.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[63].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval4.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval4.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval4.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone4.Checked = intervalsAndChecksGymnasium[63].ExitTone;
                        checkBoxEntranceTone4.Checked = intervalsAndChecksGymnasium[63].EntranceTone;
                        checkBoxHoldMusic4.Checked = intervalsAndChecksGymnasium[63].HoldMusic;
                        checkBoxHoldOn4.Checked = intervalsAndChecksGymnasium[63].HoldOn;
                        checkBoxHoldCourse4.Checked = intervalsAndChecksGymnasium[63].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[64].Start != "" && intervalsAndChecksGymnasium[64].Stop != "" &&
                        intervalsAndChecksGymnasium[64].Id == 65)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[64].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval5.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval5.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval5.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[64].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval5.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval5.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval5.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone5.Checked = intervalsAndChecksGymnasium[64].ExitTone;
                        checkBoxEntranceTone5.Checked = intervalsAndChecksGymnasium[64].EntranceTone;
                        checkBoxHoldMusic5.Checked = intervalsAndChecksGymnasium[64].HoldMusic;
                        checkBoxHoldOn5.Checked = intervalsAndChecksGymnasium[64].HoldOn;
                        checkBoxHoldCourse5.Checked = intervalsAndChecksGymnasium[64].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[65].Start != "" && intervalsAndChecksGymnasium[65].Stop != "" &&
                        intervalsAndChecksGymnasium[65].Id == 66)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[65].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval6.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval6.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval6.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[65].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval6.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval6.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval6.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone6.Checked = intervalsAndChecksGymnasium[65].ExitTone;
                        checkBoxEntranceTone6.Checked = intervalsAndChecksGymnasium[65].EntranceTone;
                        checkBoxHoldMusic6.Checked = intervalsAndChecksGymnasium[65].HoldMusic;
                        checkBoxHoldOn6.Checked = intervalsAndChecksGymnasium[65].HoldOn;
                        checkBoxHoldCourse6.Checked = intervalsAndChecksGymnasium[65].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[66].Start != "" && intervalsAndChecksGymnasium[66].Stop != "" &&
                        intervalsAndChecksGymnasium[66].Id == 67)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[66].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval7.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval7.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval7.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[66].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval7.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval7.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval7.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone7.Checked = intervalsAndChecksGymnasium[66].ExitTone;
                        checkBoxEntranceTone7.Checked = intervalsAndChecksGymnasium[66].EntranceTone;
                        checkBoxHoldMusic7.Checked = intervalsAndChecksGymnasium[66].HoldMusic;
                        checkBoxHoldOn7.Checked = intervalsAndChecksGymnasium[66].HoldOn;
                        checkBoxHoldCourse7.Checked = intervalsAndChecksGymnasium[66].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[67].Start != "" && intervalsAndChecksGymnasium[67].Stop != "" &&
                        intervalsAndChecksGymnasium[67].Id == 68)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[67].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval8.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval8.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval8.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[67].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval8.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval8.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval8.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone8.Checked = intervalsAndChecksGymnasium[67].ExitTone;
                        checkBoxEntranceTone8.Checked = intervalsAndChecksGymnasium[67].EntranceTone;
                        checkBoxHoldMusic8.Checked = intervalsAndChecksGymnasium[67].HoldMusic;
                        checkBoxHoldOn8.Checked = intervalsAndChecksGymnasium[67].HoldOn;
                        checkBoxHoldCourse8.Checked = intervalsAndChecksGymnasium[67].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[68].Start != "" && intervalsAndChecksGymnasium[68].Stop != "" &&
                        intervalsAndChecksGymnasium[68].Id == 69)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[68].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval9.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval9.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval9.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[68].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval9.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval9.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval9.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone9.Checked = intervalsAndChecksGymnasium[68].ExitTone;
                        checkBoxEntranceTone9.Checked = intervalsAndChecksGymnasium[68].EntranceTone;
                        checkBoxHoldMusic9.Checked = intervalsAndChecksGymnasium[68].HoldMusic;
                        checkBoxHoldOn9.Checked = intervalsAndChecksGymnasium[68].HoldOn;
                        checkBoxHoldCourse9.Checked = intervalsAndChecksGymnasium[68].HoldCourse;
                    }

                    if (intervalsAndChecksGymnasium[69].Start != "" && intervalsAndChecksGymnasium[69].Stop != "" &&
                        intervalsAndChecksGymnasium[69].Id == 70)
                    {
                        startIntervalComponents = intervalsAndChecksGymnasium[69].Start.Split(' ');
                        timeStartIntervalComponents = startIntervalComponents[0].Split(':');
                        comboBoxStartHourInterval10.SelectedItem = timeStartIntervalComponents[0];
                        comboBoxStartMinuteInterval10.SelectedItem = timeStartIntervalComponents[1];
                        comboBoxStartFormatInterval10.SelectedItem = startIntervalComponents[1];
                        stopIntervalComponents = intervalsAndChecksGymnasium[69].Stop.Split(' ');
                        timeStopIntervalComponents = stopIntervalComponents[0].Split(':');
                        comboBoxStopHourInterval10.SelectedItem = timeStopIntervalComponents[0];
                        comboBoxStopMinuteInterval10.SelectedItem = timeStopIntervalComponents[1];
                        comboBoxStopFormatInterval10.SelectedItem = stopIntervalComponents[1];
                        checkBoxExitTone10.Checked = intervalsAndChecksGymnasium[69].ExitTone;
                        checkBoxEntranceTone10.Checked = intervalsAndChecksGymnasium[69].EntranceTone;
                        checkBoxHoldMusic10.Checked = intervalsAndChecksGymnasium[69].HoldMusic;
                        checkBoxHoldOn10.Checked = intervalsAndChecksGymnasium[69].HoldOn;
                        checkBoxHoldCourse10.Checked = intervalsAndChecksGymnasium[69].HoldCourse;
                    }

                    break;
            }
        }

        public List<IntervalsAndChecksPrimary> ReadIntervalsAndChecksPrimaryFromDatabase()
        {
            string connectionString = @"Data Source=MIHAIFLORIN\SQLEXPRESS;Initial Catalog=ClassBellProject;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from IntervalsAndChecksPrimary;", sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<IntervalsAndChecksPrimary> intervalsAndChecksPrimary = new List<IntervalsAndChecksPrimary>();
            while (reader.Read())
            {
                intervalsAndChecksPrimary.Add(new IntervalsAndChecksPrimary()
                {
                    Id = (int)reader.GetValue(0),
                    DayPrimaryId = (int)reader.GetValue(1),
                    Start = reader.GetValue(2).ToString(),
                    Stop = reader.GetValue(3).ToString(),
                    ExitTone = (bool)reader.GetValue(4),
                    EntranceTone = (bool)reader.GetValue(5),
                    HoldMusic = (bool)reader.GetValue(6),
                    HoldOn = (bool)reader.GetValue(7),
                    HoldCourse = (bool)reader.GetValue(8),
                });
            }
            sqlConnection.Close();

            return intervalsAndChecksPrimary;
        }

        public List<IntervalsAndChecksPrimary> GetAllIntervalsAndChecksPrimaryByDayId(int dayId)
        {
            List<IntervalsAndChecksPrimary> intervalsAndChecksPrimaryToReturn = new List<IntervalsAndChecksPrimary>();
            List<IntervalsAndChecksPrimary> intervalsAndChecksPrimary = ReadIntervalsAndChecksPrimaryFromDatabase();
            for (int iterator = 0; iterator < intervalsAndChecksPrimary.Count; iterator++)
            {
                if (intervalsAndChecksPrimary[iterator].DayPrimaryId == dayId &&
                    intervalsAndChecksPrimary[iterator].Start != "" &&
                    intervalsAndChecksPrimary[iterator].Stop != "")
                {
                    intervalsAndChecksPrimaryToReturn.Add(intervalsAndChecksPrimary[iterator]);
                }
            }

            return intervalsAndChecksPrimaryToReturn;
        }

        CancellationTokenSource cancellationTokenSourceGymnasium;

        private async void buttonStartIntervalsAndDaysGymnasium_Click(object sender, EventArgs e)
        {
            List<string> daysSelected = KeepDaysSelected();
            if (daysSelected.Count > 0)
            {               
                buttonStartIntervalsAndDaysGymnasium.Enabled = false;
                cancellationTokenSourceGymnasium = new CancellationTokenSource();
                await Task.Run(() => StartSongsAndTonesByIntervalsAndDaysGymnasiumAsync(cancellationTokenSourceGymnasium.Token));
            }
            else
            {
                return;
            }
        }

        private void buttonStopIntervalsAndDaysGymnasium_Click(object sender, EventArgs e)
        {
            using SoundPlayer soundPlayerForASongGymnasium = new SoundPlayer();
            using SoundPlayer soundPlayerForAToneGymnasium = new SoundPlayer();
            buttonStartIntervalsAndDaysGymnasium.Enabled = true;
            cancellationTokenSourceGymnasium.Cancel();
            soundPlayerForASongGymnasium.Stop();
            soundPlayerForAToneGymnasium.Stop();
        }
        
        private void listBoxSelectDayGymnasium_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateIntervalsAndChecksSelectingDay();
        }

        private void buttonUpdateIntervalsAndChecksForACertainDay_Click(object sender, EventArgs e)
        {
            UpdateTableIntervalsAndChecksGymnasiumForACertainDayInDatabase();
        }
    }
}
