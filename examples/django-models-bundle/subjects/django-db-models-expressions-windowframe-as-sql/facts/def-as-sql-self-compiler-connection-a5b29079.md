# Fact a5b29079

Store id: f227c5af-2fab-486f-8bfb-3f9e0c737cfb

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:31:56.0240620+00:00`

## Data

```json
{
  "end_line": 2187,
  "entity_kind": "method",
  "parent": "WindowFrame",
  "start_line": 2169,
  "symbol": "WindowFrame.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2169,"selector":"L2169-L2187","symbol":"WindowFrame.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::WindowFrame.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2187,
    "entity_kind": "method",
    "parent": "WindowFrame",
    "start_line": 2169,
    "symbol": "WindowFrame.as_sql"
  },
  "id": "f227c5af-2fab-486f-8bfb-3f9e0c737cfb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.0240620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2169,
        "selector": "L2169-L2187",
        "symbol": "WindowFrame.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "d4a38e83-80f9-4073-aea1-16078c6f0079",
  "subject_name": "django/db/models/expressions::WindowFrame.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
