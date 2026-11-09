# Fact b4a008b4

Store id: e217ccd8-afd1-4fa1-9f30-0f1b01963d6a

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
- posted_at: `2026-11-09T23:44:58.1787820+00:00`

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
  "id": "e217ccd8-afd1-4fa1-9f30-0f1b01963d6a",
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
    "posted_at": "2026-11-09T23:44:58.1787820+00:00"
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
  "subject_id": "1c76a977-0cb7-45e4-ab93-5d8b4648ce4d",
  "subject_name": "django/db/models/sql/datastructures::Join",
  "tags": [
    "entity:class"
  ],
  "text": "class Join"
}
```
