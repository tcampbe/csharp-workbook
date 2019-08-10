using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksDatabase
{

/* Microsoft Windows [Version 10.0.17763.615]
(c) 2018 Microsoft Corporation. All rights reserved.

C:\Users\Troy>sqlite3
SQLite version 3.28.0 2019-04-16 19:49:53
Enter ".help" for usage hints.
Connected to a transient in-memory database.
Use ".open FILENAME" to reopen on a persistent database.
sqlite> CREATE TABLE books (id int, title varchar(20), author varchar(20));
sqlite> INSERT INTO books (id, title, author) VALUES (1, 'The Hobbit', 'Tolkien');
sqlite> INSERT INTO books (id, title, author) VALUES (2, 'The Cat in the Hat', 'Dr. Sues');
sqlite> INSERT INTO books (id, title, author) VALUES (3, 'Tom Sawyer', 'Mark Twain');
sqlite> SELECT * FROM books;
1|The Hobbit|Tolkien
2|The Cat in the Hat|Dr. Sues
3|Tom Sawyer|Mark Twain
sqlite> SELECT * FROM books WHERE id = 2;
2|The Cat in the Hat|Dr. Sues
sqlite> SELECT title FROM books;
The Hobbit
The Cat in the Hat
Tom Sawyer
sqlite> UPDATE books SET author = 'J.R.R. Tolkien' WHERE id = 1;
sqlite> DELETE FROM books WHERE id = 2;
sqlite> SELECT * FROM books;
1|The Hobbit|J.R.R. Tolkien
3|Tom Sawyer|Mark Twain
sqlite>
*/


}
