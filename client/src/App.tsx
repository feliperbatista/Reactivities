import { ListItem, ListItemText, Typography } from '@mui/material';
import axios from 'axios';
import { useEffect, useState } from 'react';


function App() {
  const [activities, setActivities] = useState<Activity[]>([]);

  useEffect(() => {
    axios.get<Activity[]>('https://localhost:5001/api/activities')
      .then(response => setActivities(response.data));
  }, []);

  return (
    <>
      <Typography variant = 'h3'>Hello World</Typography>
      <ListItem>
        {activities.map((activity) => (
          <ListItemText key={activity.id}>{activity.title}</ListItemText>
          ))}
      </ListItem>
    </>
  );
}

export default App;
