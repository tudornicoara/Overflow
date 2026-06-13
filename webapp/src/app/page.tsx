import {Button} from "@heroui/react";
import {AcademicCapIcon} from "@heroicons/react/24/solid";

export default function Home() {
  return (
    <div className='text-4xl text-red-500'>
      <h1>Overflow app</h1>
      <Button variant="primary">
        Click me!
        <AcademicCapIcon className="size-6" />
      </Button>
    </div>
  );
}
