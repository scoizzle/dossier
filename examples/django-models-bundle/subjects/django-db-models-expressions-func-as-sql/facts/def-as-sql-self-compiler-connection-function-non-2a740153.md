# Fact 2a740153

Store id: c0a7fef4-2aaa-4840-80a5-f083694d0d2f

## Text

```text
def as_sql( self, compiler, connection, function=None, template=None, arg_joiner=None, **extra_context, )
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.5808600+00:00`

## Data

```json
{
  "end_line": 1134,
  "entity_kind": "method",
  "parent": "Func",
  "start_line": 1097,
  "symbol": "Func.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1097,"selector":"L1097-L1134","symbol":"Func.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Func.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1134,
    "entity_kind": "method",
    "parent": "Func",
    "start_line": 1097,
    "symbol": "Func.as_sql"
  },
  "id": "c0a7fef4-2aaa-4840-80a5-f083694d0d2f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5808600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1097,
        "selector": "L1097-L1134",
        "symbol": "Func.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "48ff6892-c96a-463a-a94f-3c49716275a4",
  "subject_name": "django/db/models/expressions::Func.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql( self, compiler, connection, function=None, template=None, arg_joiner=None, **extra_context, )"
}
```
