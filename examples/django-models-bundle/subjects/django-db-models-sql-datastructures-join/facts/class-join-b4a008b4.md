# Fact b4a008b4

Store id: ada2d31f-7e14-4788-acf5-309ecb5c28e8

## Text

```text
class Join
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:06.4362400+00:00`

## Data

```json
{
  "end_line": 178,
  "entity_kind": "class",
  "parent": "datastructures",
  "start_line": 27,
  "symbol": "Join"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":27,"selector":"L27-L178","symbol":"Join"}`

## Items

```json
[
  {
    "text": "Used by sql.Query and sql.SQLCompiler to generate JOIN clauses into the FROM entry. For example, the SQL generated could be LEFT OUTER JOIN \"sometable\" T1 ON (\"othertable\".\"sometable_id\" = \"sometable\".\"id\")",
    "locator": {
      "line": 28
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::Join](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 178,
    "entity_kind": "class",
    "parent": "datastructures",
    "start_line": 27,
    "symbol": "Join"
  },
  "id": "ada2d31f-7e14-4788-acf5-309ecb5c28e8",
  "items": [
    {
      "locator": {
        "line": 28
      },
      "text": "Used by sql.Query and sql.SQLCompiler to generate JOIN clauses into the FROM entry. For example, the SQL generated could be LEFT OUTER JOIN \"sometable\" T1 ON (\"othertable\".\"sometable_id\" = \"sometable\".\"id\")"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.4362400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 27,
        "selector": "L27-L178",
        "symbol": "Join"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "3d53a54d-87ee-4469-b528-e0e8c2eacc08",
  "subject_name": "django/db/models/sql/datastructures::Join",
  "tags": [
    "entity:class"
  ],
  "text": "class Join"
}
```
