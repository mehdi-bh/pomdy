# API Pomdy
## List of endpoints

### Student
##### GET
- `/api/students`
- `/api/students/{id}`
- `/api/students/{id}/friends`
- `/api/rooms/{idRoom}/students`
- `/api/teams/{idTeam}/students`
##### POST
- `/api/students`
- `/api/students/friends`
- `/api/rooms/{idRoom}/students`
- `/api/teams/{idTeam}/students`
##### PUT
- `/api/students/{id}`
##### DELETE
- `/api/students/{id}`
- `/api/students/friends`
- `/api/rooms/{idRoom}/students`
- `/api/teams/{idTeam}/students`

### Session
##### GET
- `/api/sessions`
- `/api/sessions/{id}`
- `/api/students/{idStudent}/sessions`
##### POST
- `/api/sessions`
##### PUT
- `/api/sessions/{id}`
##### DELETE
- `/api/sessions/{id}`

### Teams
##### GET
- `/api/teams`
- `/api/teams/{id}`
- `/api/students/{idStudent}/teams`
##### POST
- `/api/teams`
##### PUT
- `/api/teams/{id}`
##### DELETE
- `/api/teams/{id}`

### Rooms
##### GET
- `/api/rooms`
- `/api/rooms/{id}`
- `/api/students/{idStudent}/rooms`
##### POST
- `/api/rooms`
##### PUT
- `/api/rooms/{id}`
##### DELETE
- `/api/rooms/{id}`

### Extrabreaks
##### GET
- `/api/extrabreaks`
- `/api/extrabreaks/{id}`
- `/api/sessions/{idSession}/extrabreaks`
- `/api/students/{idStudent}/extrabreaks`
##### POST
- `/api/extrabreaks`
##### PUT
- `/api/extrabreaks/{id}`
##### DELETE
- `/api/extrabreaks/{id}`
