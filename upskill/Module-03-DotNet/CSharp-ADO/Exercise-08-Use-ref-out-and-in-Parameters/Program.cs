// C# Exercise 8
Console.WriteLine("ref, out, and in Parameter Demonstration\n");

int workshopScore = 70;
Console.WriteLine($"Before ref: workshopScore = {workshopScore}");
ApplyBonus(ref workshopScore, 8);
Console.WriteLine($"After ref:  workshopScore = {workshopScore} (updated in caller)\n");

if (TryParseParticipantId("P1042", out int participantId))
    Console.WriteLine($"out parameter: parsed participantId = {participantId}\n");

var feeDetails = new FeeStructure(baseFee: 500m, gstRate: 0.18m);
PrintFeeBreakdown(in feeDetails);

static void ApplyBonus(ref int score, int bonusPoints) =>
    score += bonusPoints;

static bool TryParseParticipantId(string input, out int id) =>
    int.TryParse(input.Replace("P", "", StringComparison.Ordinal), out id);

static void PrintFeeBreakdown(in FeeStructure fees)
{
    var taxAmount = fees.BaseFee * fees.GstRate;
    var totalAmount = fees.BaseFee + taxAmount;
    Console.WriteLine($"in parameter: base fee = ${fees.BaseFee:F2}, tax = ${taxAmount:F2}, total = ${totalAmount:F2}");
}

readonly struct FeeStructure(decimal baseFee, decimal gstRate)
{
    public decimal BaseFee { get; } = baseFee;
    public decimal GstRate { get; } = gstRate;
}
