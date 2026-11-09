# Fact 41cd7b6a

Store id: a8ce5596-6236-4dcf-aca0-caf37fb3d9b8

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
- posted_at: `2026-11-09T23:44:49.6733760+00:00`

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
  "id": "a8ce5596-6236-4dcf-aca0-caf37fb3d9b8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6733760+00:00"
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
  "subject_id": "8decbedd-8aee-4768-909f-482334f38730",
  "subject_name": "django/db/models/expressions::Window.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection)"
}
```
