// Tic-Tac-Toe by Eric Justesen

void main(){
    string player = nextPlayer("");
    List<string> board = createBoard();
    while (!(isWon(board) || isDraw(board))){
        displayBoard(board);
        makeMove(player, board);
        player = nextPlayer(player);
    }

    displayBoard(board);

    if(isWon(board)){
        player = nextPlayer(player);
        Console.WriteLine($"{player} wins!");
    }

    else if(isDraw(board)){
        Console.WriteLine("Cats!");
    }    
    Console.WriteLine("GG stinky") ;
}

List<string> createBoard(){
    List<string> board = new List<string>(9);
    for(int i = 0; i < 9; i++){
        board.Add((i + 1).ToString());
    }
    return board;
}

void displayBoard(List<string> board){
    Console.WriteLine();
    Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
    Console.WriteLine();
}

bool isDraw(List<string> board){
    for(int i=0;i<9;i++){
        if( board[i] != "x" && board[i] != "o"){
            return false;
        }
    }
    return true; 
}
    
bool isWon(List<string> board){
    return (board[0] == board[1] && board[1] == board[2] ||
        board[3] == board[4] && board[4] == board[5] ||
        board[6] == board[7] && board[7] == board[8] ||
        board[0] == board[3] && board[3] == board[6] ||
        board[1] == board[4] && board[4] == board[7] ||
        board[2] == board[5] && board[5] == board[8] ||
        board[0] == board[4] && board[4] == board[8] ||
        board[2] == board[4] && board[4] == board[6]);
}

void makeMove(string player, List<string> board){
    try{
        Console.Write($"{player}'s turn to choose a square (1-9): ");
        string? s = Console.ReadLine();

        int square = 0;
        if(s is not null){
            square = int.Parse(s);
        }

        if(square>9 || square <1 || board[square-1] == "o" || board[square-1] == "x"){
            throw new InvalidOperationException("Illegal Move");
        }
        board[square - 1] = player;
    }
    catch (InvalidOperationException ex){
        Console.WriteLine(ex.Message);
        makeMove(player,board);
    }
    catch (FormatException){
        Console.WriteLine("Invalid Entry");
        makeMove(player,board);        
    }
}      

string nextPlayer(string current){
    if (current == "" || current == "o"){
        return "x";
    }
    else {
        return "o";
    }
}

main();