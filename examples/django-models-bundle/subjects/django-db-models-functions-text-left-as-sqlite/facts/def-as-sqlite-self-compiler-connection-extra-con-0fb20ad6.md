# Fact 0fb20ad6

Store id: 07b0c994-4e4b-4a44-9860-cb946cfec726

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
- posted_at: `2026-11-09T22:39:47.1128990+00:00`

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
  "id": "07b0c994-4e4b-4a44-9860-cb946cfec726",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1128990+00:00"
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
  "subject_id": "f5aa02d2-5ae9-4743-94f1-3ceec9bd6376",
  "subject_name": "django/db/models/functions/text::Left.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
