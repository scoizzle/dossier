# Fact 0fb20ad6

Store id: a0e8e279-d990-4f2e-9058-b90224a00ca1

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
- posted_at: `2026-11-09T23:32:02.1961250+00:00`

## Data

```json
{
  "end_line": 176,
  "entity_kind": "method",
  "parent": "Left",
  "start_line": 175,
  "symbol": "Left.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":175,"selector":"L175-L176","symbol":"Left.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Left.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 176,
    "entity_kind": "method",
    "parent": "Left",
    "start_line": 175,
    "symbol": "Left.as_sqlite"
  },
  "id": "a0e8e279-d990-4f2e-9058-b90224a00ca1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.1961250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 175,
        "selector": "L175-L176",
        "symbol": "Left.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "f1beb7b3-d2bb-40fd-b399-752f8ddf3e14",
  "subject_name": "django/db/models/functions/text::Left.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
