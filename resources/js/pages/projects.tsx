import { Card, CardContent, CardDescription, CardHeader, CardTitle } from '@/components/ui/card';
import AppLayout from '@/layouts/app-layout';
import { projects } from '@/routes';
import { BreadcrumbItem } from '@/types';
import { Head } from '@inertiajs/react';

const breadcrumbs: BreadcrumbItem[] = [
    {
        title: 'Projects',
        href: projects().url,
    },
];

const projectsList = [
    {
        id: 1,
        name: 'Project 1',
        description: 'Project 1 description',
    },
    {
        id: 2,
        name: 'Project 2',
        description: 'Project 2 description',
    },
];

const Projects = () => {
    return (
        <AppLayout breadcrumbs={breadcrumbs}>
            <Head title="Projects" />
            <div className="flex h-full flex-1 flex-col gap-4 overflow-x-auto rounded-xl p-4">
                <div className="grid h-full gap-4 md:grid-cols-3">
                    {projectsList.map((project) => (
                        <Card key={project.id} className="h-64">
                            <CardHeader>
                                <CardTitle>{project.name}</CardTitle>
                                <CardDescription>{project.description}</CardDescription>
                            </CardHeader>
                            <CardContent>
                                <p>{project.description}</p>
                            </CardContent>
                        </Card>
                    ))}
                </div>
            </div>
        </AppLayout >
    );
};

export default Projects;