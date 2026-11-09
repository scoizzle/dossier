# Fact ae720aad

Store id: 6e4a09a7-1435-4a7a-bd3c-b0104874b8c7

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
- posted_at: `2026-11-09T22:39:41.7625660+00:00`

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
  "id": "6e4a09a7-1435-4a7a-bd3c-b0104874b8c7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7625660+00:00"
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
  "subject_id": "10495e6c-4a26-4b6d-946a-ef360da95cda",
  "subject_name": "django/db/models/expressions::Window.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, template=None)"
}
```
