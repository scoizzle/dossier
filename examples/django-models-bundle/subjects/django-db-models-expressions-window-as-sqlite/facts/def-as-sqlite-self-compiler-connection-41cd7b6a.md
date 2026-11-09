# Fact 41cd7b6a

Store id: e5bb9052-e024-4d11-99c3-dcbf687d43cb

## Text

```text
def as_sqlite(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:41.7640870+00:00`

## Data

```json
{
  "end_line": 2105,
  "entity_kind": "method",
  "parent": "Window",
  "start_line": 2097,
  "symbol": "Window.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2097,"selector":"L2097-L2105","symbol":"Window.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Window.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2105,
    "entity_kind": "method",
    "parent": "Window",
    "start_line": 2097,
    "symbol": "Window.as_sqlite"
  },
  "id": "e5bb9052-e024-4d11-99c3-dcbf687d43cb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7640870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2097,
        "selector": "L2097-L2105",
        "symbol": "Window.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "2f688f2d-b98d-498d-9a58-743c3fe2ece2",
  "subject_name": "django/db/models/expressions::Window.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection)"
}
```
