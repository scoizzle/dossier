# Fact fcfe82dc

Store id: ecc2d032-0184-4c17-baad-7de88efc933d

## Text

```text
def as_postgresql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:32:02.1685670+00:00`

## Data

```json
{
  "end_line": 100,
  "entity_kind": "method",
  "parent": "ConcatPair",
  "start_line": 88,
  "symbol": "ConcatPair.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":88,"selector":"L88-L100","symbol":"ConcatPair.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::ConcatPair.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 100,
    "entity_kind": "method",
    "parent": "ConcatPair",
    "start_line": 88,
    "symbol": "ConcatPair.as_postgresql"
  },
  "id": "ecc2d032-0184-4c17-baad-7de88efc933d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.1685670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 88,
        "selector": "L88-L100",
        "symbol": "ConcatPair.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "3cf10167-a764-436a-9eae-5cf8b4fa9b56",
  "subject_name": "django/db/models/functions/text::ConcatPair.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
