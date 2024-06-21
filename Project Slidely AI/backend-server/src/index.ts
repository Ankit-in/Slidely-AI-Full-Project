import express from 'express';
import bodyParser from 'body-parser';
import routes from './routes';
import { Request, Response } from 'express';
import path from 'path';

const app = express();
const PORT = 3000;

// Middleware
app.use(bodyParser.json());
app.use('/',routes);

// ping endpoint
app.get('/ping', (req: Request, res: Response) => {
    res.json({ success: true });
});

app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});
