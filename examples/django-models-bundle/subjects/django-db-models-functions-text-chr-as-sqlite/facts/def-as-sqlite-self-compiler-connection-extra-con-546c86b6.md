# Fact 546c86b6

Store id: 82e48741-9cdd-4cf0-9927-a11810cfc324

## Text

```text
def as_sqlite(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:32:02.1568240+00:00`

## Data

```json
{
  "end_line": 65,
  "entity_kind": "method",
  "parent": "Chr",
  "start_line": 64,
  "symbol": "Chr.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":64,"selector":"L64-L65","symbol":"Chr.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Chr.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 65,
    "entity_kind": "method",
    "parent": "Chr",
    "start_line": 64,
    "symbol": "Chr.as_sqlite"
  },
  "id": "82e48741-9cdd-4cf0-9927-a11810cfc324",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.1568240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 64,
        "selector": "L64-L65",
        "symbol": "Chr.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "128f4245-9275-4618-af3e-f248cb2b83e9",
  "subject_name": "django/db/models/functions/text::Chr.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
