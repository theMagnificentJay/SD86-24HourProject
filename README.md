# SD86-24HourProject

![code size](https://img.shields.io/github/languages/code-size/theMagnificentJay/SD86-24HourProject)
![total lines](https://img.shields.io/tokei/lines/github/theMagnificentJay/SD86-24HourProject)
![# of lang](https://img.shields.io/github/languages/count/theMagnificentJay/SD86-24HourProject)
![top lang](https://img.shields.io/github/languages/top/theMagnificentJay/SD86-24HourProject)
![efa-notes](https://img.shields.io/static/v1?label=&message=EFA-Assignment&color=red)

## About

This assignment is a 24 hour project. Utilizing skills for team git fundamentals and a basic social-media-esque API.

### Note

Post works, comment gives error saying AuthorId and Created (DateTime) is required and does not post comment. Reply, while structured at this stage has the same errors as comment. We apologize for the inconvience.

## Account Register

In order to utilize elements of this API one would have to first create a user account using a program like post man. While using POST (/api/Account/Register) in the body create 3 Keys: Email, Password, and ConfirmPassword. Password values require a capital letter, number, and special character. After that you need to POST (/token) in the body create 3 keys: grant_type, username, and password. For username and password use the values you created when you created the account using the POST method for register. This should return a token, take note of it as we will need it to POST post, comment, and reply.

## Post

In order to utilize elements of this API one would have to first create a user account using a program like post man. While using POST (/api/Post) in the headers add one key named Authorization (case sensitive) and for the value make it "Bearer <your-token>". In the body make 3 keys: PostId, Title, and Text. Values can be set at your discretion as long as the match the proper type (e.g. PostId is an int so make sure its value is an int. Title is a string so make sure its value is a string.). It should return your post as a json object, with the PostId, Title, Text, and Created (DateTime).
  
## Comment

In order to utilize elements of this API one would have to first create a user account using a program like post man. While using POST (/api/Comment/{ID}) in the headers add one key named Authorization (case sensitive) and for the value make it "Bearer <your-token>". In the body make 2 keys: PostId, and Text. Values can be set at your discretion as long as the match the proper type (e.g. PostId is an int so make sure its value is an int. Title is a string so make sure its value is a string.). It should return your post as a json object, with the PostId, Text, and Created (DateTime).
  
### Note

Currently this section is broken, and still a WIP. It is requiring an AuthorId and Created (DateTime) as they are set up incorrectly in the CommentRepository.cs and/or CommentServices.cs
  
## Reply

In order to utilize elements of this API one would have to first create a user account using a program like post man. While using POST (/api/Reply/{ID}) in the headers add one key named Authorization (case sensitive) and for the value make it "Bearer <your-token>". In the body make 2 keys: CommentId, and Text. Values can be set at your discretion as long as the match the proper type (e.g. PostId is an int so make sure its value is an int. Title is a string so make sure its value is a string.). It should return your post as a json object, with the PostId, Text, and Created (DateTime).
  
### Note

Currently this section is broken, and still a WIP. It is requiring an AuthorId and Created (DateTime) as they are set up incorrectly in the ReplyRepository.cs and/or ReplyServices.cs

## Authors

[![theMagnificentJay](https://img.shields.io/static/v1?label=&message=theMagnificentJay&color=black)](https://themagnificentjay.github.io/portfolio/)
[![theMagnificentJay](https://img.shields.io/static/v1?label=&message=RJYocham&color=blue)](https://github.com/RJYocham)
[![theMagnificentJay](https://img.shields.io/static/v1?label=&message=D2-Tech&color=red)](https://github.com/D2-Tech)
