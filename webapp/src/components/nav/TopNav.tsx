import Link from "next/link";
import {AcademicCapIcon, MagnifyingGlassIcon} from "@heroicons/react/24/solid";
import {Button, Input} from "@heroui/react";

export default function TopNav() {
    return (
        <header className="p-2 w-full fixed top-0 z-50 border-b bg-white">
            <div className="flex px-10 mx-auto">
                <div className="flex items-center gap-6">
                    <Link href='/' className='flex items-center gap-3 max-h-16'>
                        <AcademicCapIcon className="size-10 text-secondary" />
                        <h3 className="text-xl font-semibold uppercase">Overflow</h3>
                    </Link>
                    <nav className="flex gap-3 my-2 text-md text-neutral-500">
                        <Link href='/'>About</Link>
                        <Link href='/'>Products</Link>
                        <Link href='/'>Contact</Link>
                    </nav>
                </div>
                
                <div className="relative ml-6 flex items-center flex-1">
                    <MagnifyingGlassIcon className="absolute left-3 size-5 text-neutral-400 pointer-events-none" />
                    <Input
                        className="pl-9 w-full"
                        type="search"
                        placeholder="Search"
                    />
                </div>
                
                <div className="flex basis-1/4 shrink-0 justify-end gap-3">
                    <Button variant="outline">Login</Button>
                    <Button variant="primary">Register</Button>
                </div>
            </div>
        </header>
    );
}