#!/bin/bash

# Define paths
REPO_ROOT=$(pwd)
CSHARP_ROOT="$REPO_ROOT/roadmaps/backend/csharp"
STARTER_DIR="$CSHARP_ROOT/_shared/starter-state"

# Colors
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[0;33m'
NC='\033[0m' # No Color

echo -e "${YELLOW}⚠️  WARNING: This will reset all C# labs to their initial state.${NC}"
echo -e "${YELLOW}    Your progress in src/ and tests/ will be lost.${NC}"
echo ""

# Check for --force flag
if [[ "$1" != "--force" ]]; then
    read -p "Are you sure you want to continue? (y/N) " -n 1 -r
    echo
    if [[ ! $REPLY =~ ^[Yy]$ ]]; then
        echo "Aborted."
        exit 1
    fi
fi

echo -e "${GREEN}🔄 Resetting labs...${NC}"

# Loop through the starter directory structure
cd "$STARTER_DIR" || exit
find . -type d -name "src" | while read -r src_path; do
    # src_path is like "./00-orientation/src"
    module_rel_path=$(dirname "$src_path")
    # module_rel_path is like "./00-orientation"
    
    target_module_path="$CSHARP_ROOT/${module_rel_path#./}"
    
    echo "   Restoring $target_module_path..."
    
    # 1. Clean existing src and tests
    rm -rf "$target_module_path/src"
    rm -rf "$target_module_path/tests"
    
    # 2. Copy from starter
    cp -R "$module_rel_path/src" "$target_module_path/"
    cp -R "$module_rel_path/tests" "$target_module_path/"
    
    # 3. Restore csproj if missing
    if [ -f "$module_rel_path/Lab.csproj" ]; then
        cp "$module_rel_path/Lab.csproj" "$target_module_path/"
    fi
    
    # 4. Clean build artifacts
    rm -rf "$target_module_path/bin"
    rm -rf "$target_module_path/obj"
    rm -rf "$target_module_path/TestResults"
done

echo -e "${GREEN}✅ Reset complete. Happy coding!${NC}"