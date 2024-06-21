import express from 'express';
import fs from 'fs';
import path from 'path';
import { Request, Response } from 'express';

const router = express.Router();
const dbPath = path.join(__dirname, 'db.json');

// submit endpoint
router.post('/submit', (req: Request, res: Response) => {
    const { name, email, phone, github_link, stopwatch_time } = req.body;

    if (!name || !email || !phone || !github_link || !stopwatch_time) {
        return res.status(400).json({ error: 'Missing fields' });
    }

    const newSubmission = { name, email, phone, github_link, stopwatch_time };

    fs.readFile(dbPath, 'utf8', (err, data) => {
        if (err) {
            return res.status(500).json({ error: 'Failed to read database' });
        }

        const submissions = JSON.parse(data);
        submissions.push(newSubmission);

        fs.writeFile(dbPath, JSON.stringify(submissions, null, 2), (err) => {
            if (err) {
                return res.status(500).json({ error: 'Failed to save submission' });
            }
            res.json({ success: true });
        });
    });
});

//  read endpoint
router.get('/read', (req: Request, res: Response) => {
    const index = parseInt(req.query.index as string, 10);

    if (isNaN(index)) {
        return res.status(400).json({ error: 'Invalid index' });
    }

    fs.readFile(dbPath, 'utf8', (err, data) => {
        if (err) {
            return res.status(500).json({ error: 'Failed to read database' });
        }

        const submissions = JSON.parse(data);

        if (index < 0 || index >= submissions.length) {
            return res.status(404).json({ error: 'Submission not found' });
        }

        res.json(submissions[index]);
    });
});

export default router;
