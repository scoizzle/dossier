# Fact ae720aad

Store id: 4f4e9a11-4e27-415d-85b2-4b4e60d6a0e5

## Text

```text
def as_sql(self, compiler, connection, template=None)
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
- posted_at: `2026-11-09T23:44:49.6721730+00:00`

## Data

```json
{
  "end_line": 2095,
  "entity_kind": "method",
  "parent": "Window",
  "start_line": 2064,
  "symbol": "Window.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2064,"selector":"L2064-L2095","symbol":"Window.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Window.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2095,
    "entity_kind": "method",
    "parent": "Window",
    "start_line": 2064,
    "symbol": "Window.as_sql"
  },
  "id": "4f4e9a11-4e27-415d-85b2-4b4e60d6a0e5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6721730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2064,
        "selector": "L2064-L2095",
        "symbol": "Window.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "5015a872-a410-440b-bd09-8f8efc8fb0a3",
  "subject_name": "django/db/models/expressions::Window.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, template=None)"
}
```
